import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Deal } from 'src/app/models/deal';
import { DealService } from 'src/app/services/dealService.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dealsUpdate',
  templateUrl: './dealsUpdate.component.html',
  styleUrls: ['./dealsUpdate.component.css']
})
export class DealsUpdateComponent implements OnInit {
  deal:Deal;
  dealsCopy: Deal[];
  ELEMENT_DATA:Deal[];

  flightcheck=false;
  isLoggedIn: boolean;
  
  constructor(private service:DealService, private routers:ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    
    this.deal={
      deal_id:null,
      deal_cost:null,
      departure_location:'',
      arrival_location:'',
      duration:null
    }
    
    this.service.getByDealNumber(this.routers.snapshot.params['dealnumber']).subscribe((data)=>
    this.deal={
      deal_id:null,
      deal_cost:null,
      departure_location:'',
      arrival_location:'',
      duration:null
    })

    this.ELEMENT_DATA = [
      {deal_id: 1632, deal_cost: 300, departure_location: "New Delhi", arrival_location: "Mumbai", duration: "2022-01-16"},
      {deal_id: 1633, deal_cost: 350, departure_location: "Madurai", arrival_location: "Meerut", duration: "2022-08-10"},
      {deal_id: 1634, deal_cost: 200, departure_location: "Mumbai", arrival_location: "Chennai", duration: "2022-07-30"},
      {deal_id: 1635, deal_cost: 150, departure_location: "Hyderabad", arrival_location: "New Delhi", duration: "2022-05-20"}
    ];

    //this.dealsCopy = this.ELEMENT_DATA;
    
    this.service.getAll().subscribe((data: Deal[])=>{
      this.dealsCopy = data;
      console.log(this.dealsCopy);
      //this.flights=this.flights.sort();
    }) 

    if(!sessionStorage.getItem('admin'))
    {
      Swal.fire({
        title: 'Oops!',
        text: 'Login to Continue!',
        icon: 'warning',
       
      })
      this.router.navigate([`${'/AdminLogin'}`]);
    }
    if(sessionStorage.getItem('admin'))
    {
        this.isLoggedIn = true
    }
  }
 

  onclickfn()
  {
    this.flightcheck=true;
  }
  
  /*
  submitForm(DealForm) {
    
    for(let i=0;i<this.dealsCopy.length;i++)
    {
      if(this.dealsCopy[i].deal_id==DealForm.value.deal_id)
        {
 
          Swal.fire('Adding Deal');    
          Swal.showLoading();
          
          this.dealsCopy[i].departure_location = DealForm.value.departure_location;
          this.dealsCopy[i].arrival_location = DealForm.value.arrival_location;
          this.dealsCopy[i].deal_cost = DealForm.value.deal_cost;
          this.dealsCopy[i].duration = DealForm.value.duration;
    
          console.log(this.dealsCopy.length);
          console.log(this.dealsCopy);
          
          Swal.close();
          
          break;
        }
    }
    
    this.router.navigate([`${'/Deals'}`]);
    
  }
  */
  
  submitForm(DealForm) {
    
    DealForm.value.deal_id = this.deal.deal_id;
    DealForm.value.departure_location = this.deal.departure_location;
    DealForm.value.arrival_location = this.deal.arrival_location;
    DealForm.value.deal_cost = this.deal.deal_cost;
    DealForm.value.duration = this.deal.duration;

    Swal.fire('Updating Deal');    Swal.showLoading();
    this.service.updateDeal(DealForm.value).subscribe((data)=>
     console.log(data,"Deal Added")
   )
   Swal.close();
   this.router.navigate([`${'/Deals'}`]);
  
  }

}