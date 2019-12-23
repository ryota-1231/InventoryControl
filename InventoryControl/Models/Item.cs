using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Lot { get; set; }
        public virtual ICollection<Inventory> Invetories { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal PurchasePrice { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}

