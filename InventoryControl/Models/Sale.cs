using System;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

    }
}
