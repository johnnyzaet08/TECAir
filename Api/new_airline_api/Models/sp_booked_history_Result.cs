//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace new_airline_api.Models
{
    using System;
    
    public partial class sp_booked_history_Result
    {
        public int transaction_id { get; set; }
        public System.DateTime booking_date { get; set; }
        public int number_of_seats { get; set; }
        public System.DateTime travel_date { get; set; }
        public string seat_type { get; set; }
        public bool cancellation_status { get; set; }
        public decimal amount { get; set; }
        public int flight_number { get; set; }
        public string departure_location { get; set; }
        public string arrival_location { get; set; }
        public System.TimeSpan departure_time { get; set; }
        public System.TimeSpan arrival_time { get; set; }
        public System.TimeSpan duration { get; set; }
    }
}
