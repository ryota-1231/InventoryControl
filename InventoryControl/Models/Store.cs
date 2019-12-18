using System;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreNum { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
