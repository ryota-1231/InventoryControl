using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int WarehouseNum { get; set; }
        public List<Inventory> Inventories { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
