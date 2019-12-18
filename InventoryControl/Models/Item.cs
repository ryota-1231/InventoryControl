using System;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Lot { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public Client Client { get; set; }
        public Supplier Supplier { get; set; }
    }
}
