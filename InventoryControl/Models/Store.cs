using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreNum { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public static implicit operator Store(int v)
        {
            throw new NotImplementedException();
        }
    }
}
