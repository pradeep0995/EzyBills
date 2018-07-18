using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ezybills.Models;

namespace EzyBills.Models
{
    public class Bill
    {
        [Required]
        [ForeignKey("VendorID")]
        public int BillVendorID;

        [Required]
        [ForeignKey("CustomerID")]
        public int BillCustomerID;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }

        public List<Item> BillItems = new List<Item>();

        public double Total_Bill;
    }
}