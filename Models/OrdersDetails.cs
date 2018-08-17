using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2MVCSampleBrowser.Models
{
    public class OrdersDetails
    {
            public OrdersDetails()
            {

            }
            public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.ShipCity = ShipCity;
                this.Verified = Verified;
                this.OrderDate = OrderDate;
                this.ShipName = ShipName;
                this.ShipCountry = ShipCountry;
                this.ShippedDate = ShippedDate;
                this.ShipAddress = ShipAddress;
            }
        public static List<OrdersDetails> GetAllRecords()
        {
            List<OrdersDetails> order = new List<OrdersDetails>();
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                order.Add(new OrdersDetails(code + 1, "CCM", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Cartago", "Simons bistro", "Costa Rica", new DateTime(1996, 7, 16), "Centro"));
                order.Add(new OrdersDetails(code + 2, "JV", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Alajuela", "Queen Cozinha", "Costa Rica", new DateTime(1996, 9, 11), "Avda. 34"));
                order.Add(new OrdersDetails(code + 3, "RG", i + 1, 4.3 * i, true, new DateTime(1957, 11, 30), "Coronado", "Frankenversand", "Costa Rica", new DateTime(1996, 10, 7), "Ruta 52 calle 23"));
                order.Add(new OrdersDetails(code + 4, "DR", i + 3, 5.3 * i, false, new DateTime(1930, 10, 22), "Santa Ana", "Ernst Handel", "Costa Rica", new DateTime(1996, 12, 30), "Oriental "));
                order.Add(new OrdersDetails(code + 5, "HF", i + 4, 6.3 * i, true, new DateTime(1953, 02, 18), "Guadalupe", "Hanari Carnes", "Costa Rica", new DateTime(1997, 12, 3), "Ave. S. 23"));
                code += 5;
            }
            return order;
        }

            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public string ShipCity { get; set; }
            public bool Verified { get; set; }
            public DateTime OrderDate { get; set; }

            public string ShipName { get; set; }

            public string ShipCountry { get; set; }

            public DateTime ShippedDate { get; set; }
            public string ShipAddress { get; set; }
     }

    public class Orders
    {
        public Orders()
        {

        }
        public Orders(int OrderID, string CustomerId, int EmployeeId, decimal Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<Orders> GetAllRecords()
        {
            List<Orders> orders = new List<Orders>();
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                orders.Add(new Orders(code + 1, "CCM", i + 0, 2.32m * i, false, new DateTime(1991, 05, 15), "Cartago", "Simons bistro", "Costa Rica", new DateTime(1996, 7, 16), "Centro"));
                orders.Add(new Orders(code + 2, "JV", i + 2, 3.32m * i, true, new DateTime(1990, 04, 04), "Alajuela", "Queen Cozinha", "Costa Rica", new DateTime(1996, 9, 11), "Avda. 34"));
                orders.Add(new Orders(code + 3, "RG", i + 1, 4.35m * i, true, new DateTime(1957, 11, 30), "Coronado", "Frankenversand", "Costa Rica", new DateTime(1996, 10, 7), "Ruta 52 calle 23"));
                orders.Add(new Orders(code + 4, "DR", i + 3, 5.38m * i, false, new DateTime(1930, 10, 22), "Santa Ana", "Ernst Handel", "Costa Rica", new DateTime(1996, 12, 30), "Oriental"));
                orders.Add(new Orders(code + 5, "HF", i + 4, 6.35m * i, true, new DateTime(1953, 02, 18), "Guadalupe", "Hanari Carnes", "Costa Rica", new DateTime(1997, 12, 3), "Ave. S. 23"));
                code += 5;
            }
            return orders;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public decimal? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}