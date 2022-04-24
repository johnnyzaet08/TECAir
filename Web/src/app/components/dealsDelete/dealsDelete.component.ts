import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Deal } from 'src/app/models/deal';
import { DealService } from 'src/app/services/dealService.service';
import { Adminflight } from 'src/app/models/adminflight';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dealsDelete',
  templateUrl: './dealsDelete.component.html',
  styleUrls: ['./dealsDelete.component.css']
})
export class DealsDeleteComponent implements OnInit {
  deal:Deal;
  isLoggedIn: boolean;
  constructor(private service:DealService, private router:ActivatedRoute, private routers: Router) { }
  flight:Adminflight;

  ngOnInit(): void {
    this.service.getByDealNumber(this.router.snapshot.params['dealnumber']).subscribe((data)=>
    this.deal={
      deal_id:data["deal_id"],
      departure_location:data["departure_location"],
      arrival_location:data["arrival_location"],
      deal_cost:data["deal_cost"],
      duration:data["duration"]
    })

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

  delete(dealnumber)
  {
    Swal.fire('Deleting Deal');    Swal.showLoading();
    this.service.deleteDeal(dealnumber).subscribe();
    Swal.close(); 
    this.routers.navigate([`${'/Deals'}`]);
  }
}
