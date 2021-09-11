using System;
using System.Collections.Generic;

namespace Order.API.Models
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public DateTime CreationDate {get; set;}
        public string ClientName {get;set;}
        public string Address {get;set;}
        public decimal Total {get; set;}
        public List<OrderDetailDto> Details {get;set;}
    }
}
