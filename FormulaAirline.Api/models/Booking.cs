using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaAirline.Api.models
{
    public class Booking
    {
        public int Id { get; set; }
        public string PassengerName { get; set; } = "";
        public string PassportNo { get; set; } = "";
        public string From { get; set; }
        public string To { get; set; }
        public int Status { get; set; }

    }
}