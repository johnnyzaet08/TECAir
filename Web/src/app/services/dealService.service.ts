import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Deal } from '../models/deal';

@Injectable({
  providedIn: 'root'
})
export class DealService {
  private apiServer = environment.url+"adminoperations/";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
  public refreshcheck=true;
  constructor(private httpClient: HttpClient) { }
  
  getAll(): Observable<Deal[]> {
    return this.httpClient.get<Deal[]>(this.apiServer)
  }

  getByDealNumber(dealnumber): Observable<Deal> {
    return this.httpClient.get<Deal>(this.apiServer+ dealnumber)
  } 

  addDeal(deal): Observable<Deal> {
    this.refreshcheck=false;
    return this.httpClient.post<Deal>(this.apiServer, JSON.stringify(deal), this.httpOptions)
  }

  updateDeal(deal): Observable<Deal> {
    this.refreshcheck=false;
    return this.httpClient.put<Deal>(this.apiServer, JSON.stringify(deal), this.httpOptions)
  }  

  deleteDeal(dealnumber){
    this.refreshcheck=false;
    return this.httpClient.delete<Deal>(this.apiServer + dealnumber, this.httpOptions)  
  }
  
}