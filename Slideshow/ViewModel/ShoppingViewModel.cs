using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ES_BLACKWINGS.ViewModel
{
    public class ShoppingViewModel
    {
        public Guid ItemId { get; set; }
        public String ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ItemCode { get; set; }
        public int IsActive { get; set; }

        public string Size { get; set; }

    }
}