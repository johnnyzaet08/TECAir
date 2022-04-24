import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';
import { Deal } from 'src/app/models/deal';
import { DealService } from 'src/app/services/dealService.service';

@Component({
  selector: 'app-dealsShow',
  templateUrl: './dealsShow.component.html',
  styleUrls: ['./dealsShow.component.css']
})
export class DealsShowComponent implements OnInit {
  dealsCopy: Deal[];
  ELEMENT_DATA:Deal[];

  constructor(private service:DealService) { }

  ngOnInit(): void {

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

    Swal.fire({
      title: 'Current promotions',
      text: 'Here you can find our current promotions',
      icon: 'success',
    })

  }

}
