import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AirportsService {

  airports: any = [
    {
      "IATA_code": "GUP",
      "ICAO_code": "SJO",
      "airport_name": "Carlos Rodriguez Airport",
      "city_name": "Guapiles"
    },
    {
      "IATA_code": "CAR",
      "ICAO_code": "LIB",
      "airport_name": "Vive Vive Airport",
      "city_name": "Cartago"
    },
    {
      "IATA_code": "DSP",
      "ICAO_code": "PUN",
      "airport_name": "Papaya Airport",
      "city_name": "Desamparados"
    },
    {
      "IATA_code": "SCL",
      "ICAO_code": "LIM",
      "airport_name": "Primos Felices Airport",
      "city_name": "San Carlos"
    },
    {
      "IATA_code": "PZL",
      "ICAO_code": "CNA",
      "airport_name": "Galleta Airport",
      "city_name": "Perez Zeledon"
    }
  ]
  constructor() { }

  getData()
  {
    return this.airports;
  }
}
