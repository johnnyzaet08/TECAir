import { TmplAstBoundAttribute } from '@angular/compiler';
import { Component, ComponentFactoryResolver, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Adminflight } from 'src/app/models/adminflight';
import { AdminflightcrudService } from 'src/app/services/adminflightcrud.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-viewallflights',
  templateUrl: './viewallflights.component.html',
  styleUrls: ['./viewallflights.component.css']
})
export class ViewallflightsComponent implements OnInit {
  
  flights:Adminflight[];
  searchText;
  isLoggedIn: boolean;
  constructor(private service:AdminflightcrudService,private routers:Router) {
    
   }

  ngOnInit() {

    var today = new Date();
    var time = today.getDate() + "-" + (today.getMonth() + 1) + "-" + today.getFullYear() + "  " + today.getHours() + ":" + today.getMinutes();
    document.getElementById("datatime_label").innerHTML = time;

    console.log(this.service.getAll());
    console.log("data es tal:");
    this.service.getAll().subscribe((data: Adminflight[])=>{
        this.flights = data;
        console.log(this.flights);
        //this.flights=this.flights.sort();
    })  
    if (!this.service.refreshcheck) {
      window.location.reload();
      this.service.refreshcheck=true
    } 
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
 
}
