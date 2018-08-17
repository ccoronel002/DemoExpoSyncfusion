using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class Cities
    {
        public string CityName { get; set; }
        public string StateId { get; set; }
        public int CityId { get; set; }

        public List<Cities> CitiesList()
        {
            List<Cities> cities = new List<Cities>();
            cities.Add(new Cities() { CityName = "Seattle", StateId = "103", CityId = 207 });
            cities.Add(new Cities() { CityName = "Richmond", StateId = "102", CityId = 204 });
            cities.Add(new Cities() { CityName = "New Jersey", StateId = "101", CityId = 201 });
            cities.Add(new Cities() { CityName = "Manhattan", StateId = "101", CityId = 202 });
            cities.Add(new Cities() { CityName = "Centro", StateId = "104", CityId = 211 });
            cities.Add(new Cities() { CityName = "San Pedro", StateId = "104", CityId = 212 });
            cities.Add(new Cities() { CityName = "Tacoma", StateId = "103", CityId = 208 });
            cities.Add(new Cities() { CityName = "Tres Ríos", StateId = "105", CityId = 213 });
            cities.Add(new Cities() { CityName = "Belén", StateId = "106", CityId = 214 });
            return cities;
        }
    }
}
