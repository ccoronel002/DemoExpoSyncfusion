using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class Countries
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Countries> CountriesList()
        {
            List<Countries> country = new List<Countries>();
            country.Add(new Countries { Name = "Costa Rica", Code = "CR" });
            country.Add(new Countries { Name = "Panamá", Code = "PA" });
            country.Add(new Countries { Name = "Nicaragua", Code = "NI" });
            country.Add(new Countries { Name = "Estados Unicos", Code = "US" });
            country.Add(new Countries { Name = "Mexico", Code = "MX" });
            country.Add(new Countries { Name = "Colombia", Code = "CO" });
            country.Add(new Countries { Name = "Germany", Code = "DE" });
            country.Add(new Countries { Name = "Hong Kong", Code = "HK" });
            country.Add(new Countries { Name = "India", Code = "IN" });
            country.Add(new Countries { Name = "Italy", Code = "IT" });
            country.Add(new Countries { Name = "Japan", Code = "JP" });
            country.Add(new Countries { Name = "Norway", Code = "NO" });
            country.Add(new Countries { Name = "Poland", Code = "PL" });
            country.Add(new Countries { Name = "Switzerland", Code = "CH" });
            country.Add(new Countries { Name = "United Kingdom", Code = "GB" });
            return country;
        }
    }
}
