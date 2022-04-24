import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Deal } from 'src/app/models/deal';
import { DealService } from 'src/app/services/dealService.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dealsCreate',
  templateUrl: './dealsCreate.component.html',
  styleUrls: ['./dealsCreate.component.css']
})
export class DealsCreateComponent implements OnInit {
  deal2:Deal;
  dealsCopy: Deal[];
  ELEMENT_DATA:Deal[];

  dealcheck=true;
  isLoggedIn: boolean;
  
  constructor(private service:DealService, private router: Router) { }

  ngOnInit(): void {
    
    this.deal2={
      deal_id:null,
      deal_cost:null,
      departure_location:'',
      arrival_location:'',
      duration:null
    }
    
    this.ELEMENT_DATA = [
      {deal_id: 1632, deal_cost: 300, departure_location: "New Delhi", arrival_location: "Mumbai", duration: "2022-01-16"},
      {deal_id: 1633, deal_cost: 350, departure_location: "Madurai", arrival_location: "Meerut", duration: "2022-08-10"},
      {deal_id: 1634, deal_cost: 200, departure_location: "Mumbai", arrival_location: "Chennai", duration: "2022-07-30"},
      {deal_id: 1635, deal_cost: 150, departure_location: "Hyderabad", arrival_location: "New Delhi", duration: "2022-05-20"}
    ];

    //this.dealsCopy = this.ELEMENT_DATA;
    
    this.service.getAll().subscribe((data: Deal[])=>{
      this.dealsCopy = data; 
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
    this.dealcheck=true;
  }
  

  /*
  submitForm(DealForm) {
    
    for(let i=0;i<this.dealsCopy.length;i++)
    {
      if(this.dealsCopy[i].deal_id==DealForm.value.deal_id)
        {
          this.flightcheck=false;
          window.scrollTo(0,1);
        }
    }
    
    if(this.flightcheck)
    {

      Swal.fire('Adding Deal');    
      Swal.showLoading();
      
      this.deal2.deal_id = DealForm.value.deal_id;
      this.deal2.deal_cost = DealForm.value.deal_cost;
      this.deal2.departure_location = DealForm.value.departure_location;
      this.deal2.arrival_location = DealForm.value.arrival_location;
      this.deal2.duration = DealForm.value.duration;

      this.dealsCopy.push(this.deal2);

      console.log(this.dealsCopy.length);
      console.log(this.dealsCopy);
      
      Swal.close();
      this.router.navigate([`${'/Deals'}`]);
    
    }
  }
  */

  submitForm(DealForm) {
    
    for(let i=0;i<this.dealsCopy.length;i++)
    {
      if(this.dealsCopy[i].deal_id==DealForm.value.deal_id)
        {
          this.dealcheck=false;
          window.scrollTo(0,1);
        }
    }
  
    if(this.dealcheck==true)
    {
      Swal.fire('Adding Deal');    Swal.showLoading();
      this.service.addDeal(DealForm.value).subscribe((data)=>
      console.log(data,"Deal Added")
      )
      Swal.close();
    this.router.navigate([`${'/Deals'}`]);
    }
    
  }

}
