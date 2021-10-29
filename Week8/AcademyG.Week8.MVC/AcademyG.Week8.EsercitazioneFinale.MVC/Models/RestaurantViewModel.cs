using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Models
{
    public class RestaurantViewModel
    {
        public string Name { get; set; }
        public string StreetAddress { get;  set; }
        public string AddressLocality { get;  set; }
        public string AddressRegion { get;  set; }
        public string PostalCode { get;  set; }
    }
}
