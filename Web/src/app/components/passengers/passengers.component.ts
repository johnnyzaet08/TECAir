import { Component, OnInit } from '@angular/core';
import {Passenger} from '../../models/passengers'
import {SelectedFlightService} from '../../services/selectedflight.service'
import {FetchSeatService} from '../../services/fetchseat.service'
import { Router } from '@angular/router';
import {TransactionService} from '../../services/transaction.service'
import Swal from 'sweetalert2';

@Component({
  selector: 'app-passengers',
  templateUrl: './passengers.component.html',
  styleUrls: ['./passengers.component.css']
})
export class PassengersComponent implements OnInit {

  constructor(public flightselected:SelectedFlightService, public fetchseats:FetchSeatService,public router : Router,public TransactionService:TransactionService ) { }

  public count :number;
  public flightselectobj:any
  public seatprice
  public totalprice:number
  passenger = new Passenger()
  public isLoggedIn: boolean = false
  public mobile:string
  public email:string
  public dataarray = []
 
    ngOnInit(): void {
      if(!sessionStorage.getItem('user'))
      {
        Swal.fire({
          title: 'Oops!',
          text: 'Login to Continue!',
          icon: 'warning',
         
        })
        this.router.navigate([`${'/login'}`]);
      }
        else 
        {
        this.isLoggedIn = true
        }
      
        this.flightselectobj = this.flightselected.flightobj
        this.dataarray.push(this.passenger)
        this.count =1;
        this.fetchprice()
    }
      
      onAdd()
      {
        
        if(this.count<this.flightselected.number_of_seats)
        {
          this.passenger = new Passenger()
          this.dataarray.push(this.passenger)
          this.count++;
        }
        
      }
 
    async onSubmit()
      {
        if(!this.email || !this.mobile)
        {
            Swal.fire('oops', 'Enter contact details', 'error')    
            return
        }
        var emailregex =  new RegExp ("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$")
        var phoneregex = new RegExp("^[0-9]{8}$")

        if(!emailregex.test(this.email) || !phoneregex.test(this.mobile))
        {
          Swal.fire('oops', 'Check your contact details', 'error')    
          return
        }
        this.fetchseats.number_of_seats = this.flightselected.number_of_seats
        this.fetchseats.seatclass = this.flightselected.travel_status == true?"business":"economy"
        //let response = await this.fetchseats.fetchseats(this.flightselected.flight_number)
        if(this.fetchseats.number_of_seats > 0)
        {
          this.router.navigate([`${'flight/seats'}`]);
          this.TransactionService.passengers = this.dataarray
          this.TransactionService.final_amount = this.totalprice
          this.TransactionService.contact_no = this.mobile
          this.TransactionService.contact_email = this.email
        }
        else 
        {
          Swal.fire('Oops' , 'An unexpected error occured, try again later', 'error')
          this.router.navigate([`${''}`]);
        }
        
      
      }

      async fetchprice() 
      {
        let response = await this.flightselected.getFlightPrice(this.flightselected.flight_number,this.flightselected.travel_status)
        if(response != 'false'){
          let price: number = +response;
          this.seatprice = price;
          this.totalprice = this.seatprice * this.flightselected.number_of_seats + 10000 + 15000;
          return price
        }
        else 
          {
            Swal.fire('Oops' , 'Error fetching price', 'error')
            return 'false'
          }
      } 
}
