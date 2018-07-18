using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ezybills.Models
{
    public class Item
    {
        [Required]
        [ForeignKey("ProductID")]
        public int ItemID;

        public String ItemName;

        public double QuantityPurchased { get; set; }
        public double QuantityCost;
    }
}