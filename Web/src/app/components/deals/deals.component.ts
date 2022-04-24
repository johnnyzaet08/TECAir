import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Deal } from 'src/app/models/deal';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-deals',
  templateUrl: './deals.component.html',
  styleUrls: ['./deals.component.css']
})
export class DealsComponent implements OnInit {
  dealsCopy: Deal[];
  dealsTemp: Deal[];
  deal: Deal;
  ELEMENT_DATA:Deal[];
  
  flightcheck=false;
  index = 0;
  isLoggedIn: boolean;

  constructor(private routers:Router) {}

  ngOnInit() {
    
    this.deal={
      deal_id:null,
      departure_location:'',
      arrival_location:'',
      deal_cost:null,
      duration:null
    }

    this.ELEMENT_DATA = [
      {deal_id: 1632, deal_cost: 300, departure_location: "New Delhi", arrival_location: "Mumbai", duration: "2022-01-16"},
      {deal_id: 1633, deal_cost: 350, departure_location: "Madurai", arrival_location: "Meerut", duration: "2022-08-10"},
      {deal_id: 1634, deal_cost: 200, departure_location: "Mumbai", arrival_location: "Chennai", duration: "2022-07-30"},
      {deal_id: 1635, deal_cost: 150, departure_location: "Hyderabad", arrival_location: "New Delhi", duration: "2022-05-20"}
    ];

    this.dealsTemp = [];

    this.dealsCopy = this.ELEMENT_DATA;
   
    if(!sessionStorage.getItem('admin'))
    {
      Swal.fire({
        title: 'Oops!',
        text: 'Login to Continue!',
        icon: 'warning',
       
      })
      this.routers.navigate([`${'/AdminLogin'}`]);
    }
    if(sessionStorage.getItem('admin'))
    {
        this.isLoggedIn = true
    }

  }


  deleteDeal(deal_id : number){
    
    Swal.fire('Deleting Deal');    
    Swal.showLoading();

    console.log("deleteDeal")

    for(let i=0;i<this.dealsCopy.length;i++)
    {
      if(this.dealsCopy[i].deal_id!=deal_id)
        {
          this.dealsTemp[this.index] = this.dealsCopy[i];
          this.index++;
        }
    }

    this.dealsCopy = this.dealsTemp;
    console.log(this.dealsCopy);
  
    Swal.close(); 
    this.routers.navigate([`${'/Deals'}`]);
  
  }

}