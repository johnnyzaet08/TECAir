﻿using new_airline_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace new_airline_api.Controllers
{
    public class SearchFlightController : ApiController
    {
        private new_airlineEntities entity = new new_airlineEntities();

        /*[HttpGet]
        public string searchflight()
        {
            return "hola";
        }*/
        
        [HttpGet]
        public IHttpActionResult searchflight(string departure, string arrival, int seats)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                var flights = entity.Flight_Master.Where(x => x.departure_location == departure && x.arrival_location == arrival);

                return Ok(flights);

                List<new_airline_api.Models.sp_searchflight_Result> list_of_flights = new List<new_airline_api.Models.sp_searchflight_Result>();
                var searched_flights = entity.sp_searchflight(departure, arrival, seats);
                foreach (var flight in searched_flights)
                {
                    if (flight.sum == null || Convert.ToInt32(flight.sum) < Convert.ToInt32(120 - seats))
                    {
                        list_of_flights.Add(flight);
                    }
                }
                return Ok(list_of_flights);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
