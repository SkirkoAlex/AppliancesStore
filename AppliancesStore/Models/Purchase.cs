using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliancesStore.Models
{
    public class Purchase
    {
        public Guid PurchaseId { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public Guid ProductId { get; set; }
    }
}