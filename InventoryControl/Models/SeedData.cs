using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InventoryControl.Data;
using System;
using System.Linq;

namespace InventoryControl.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InventoryControlContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<InventoryControlContext>>()))
            {

                return;

                //if (context.Clients.Any())
                //{
                //    return;   // DB has been seeded
                //}
                context.Clients.AddRange(
                new Client
                {
                    Name = "橋本百貨店",
                    ClientNum = 100,
                    Address = "横浜1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")
                },

                new Client
                {
                    Name = "山田商事",
                    ClientNum = 101,
                    Address = "浦賀1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")
                },

                new Client
                {
                    Name = "田中デパート",
                    ClientNum = 102,
                    Address = "逗子1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")
                },

                new Client
                {
                    Name = "佐藤商店",
                    ClientNum = 103,
                    Address = "三浦1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")
                }
            );
                context.SaveChanges();

                //    if (context.Store.Any())
                //    {
                //        return;   // DB has been seeded
                //    }
                context.Stores.AddRange(
                new Store
                {
                    Name = "渋谷店",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    StoreNum = 1,
                    Address = "渋谷2-2-2"
                },

                new Store
                {
                    Name = "恵比寿店",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    StoreNum = 2,
                    Address = "恵比寿2-2-2"
                },

                new Store
                {
                    Name = "品川店",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    StoreNum = 3,
                    Address = "品川2-2-2"
                },

                new Store
                {
                    Name = "五反田店",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    StoreNum = 4,
                    Address = "五反田2-2-2"
                }
            );
                context.SaveChanges();

                //    if (context.Supplier.Any())
                //    {
                //        return;   // DB has been seeded
                //    }
                context.Suppliers.AddRange(
                new Supplier
                {
                    Name = "高橋商店",
                    SupplierNum = 200,
                    Address = "国立市1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")

                },

                new Supplier
                {
                    Name = "北島商事",
                    SupplierNum = 201,
                    Address = "立川市1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")
                },

                new Supplier
                {
                    Name = "川田商事",
                    SupplierNum = 202,
                    Address = "国分寺市1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")

                },

                new Supplier
                {
                    Name = "後藤商事",
                    SupplierNum = 203,
                    Address = "武蔵野市1-1-1",
                    ReleaseDate = DateTime.Parse("2019-12-12")

                }
            );
                context.SaveChanges();

                //if (context.Warehouses.Any())
                //{
                //    return;   // DB has been seeded
                //}
                context.Warehouses.AddRange(
                new Warehouse
                {
                    Name = "渋谷倉庫",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    WarehouseNum = 1,
                    Address = "渋谷2-2-2",
                    StoreId = 1
                },

                new Warehouse
                {
                    Name = "恵比寿倉庫",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    WarehouseNum = 2,
                    Address = "恵比寿2-2-2",
                    StoreId = 2
                },

                new Warehouse
                {
                    Name = "品川倉庫",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    WarehouseNum = 3,
                    Address = "品川2-2-2",
                    StoreId = 3
                },

                new Warehouse
                {
                    Name = "五反田倉庫",
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    WarehouseNum = 4,
                    Address = "五反田2-2-2",
                    StoreId = 4
                }
            );
                context.SaveChanges();

                //if (context.Item.Any())
                //{
                //    return;   // DB has been seeded
                //}
                context.Items.AddRange(
                new Item
                {
                    Name = "椅子",
                    Lot = 10001,
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    Genre = "椅子",
                    PurchasePrice = 2000M,
                    SupplierId = 1
                },

                new Item
                {
                    Name = "机",
                    Lot = 10002,
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    Genre = "机",
                    PurchasePrice = 10000,
                    SupplierId = 1

                },

                new Item
                {
                    Name = "キッチン棚",
                    Lot = 10003,
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    Genre = "棚",
                    PurchasePrice = 15000,
                    SupplierId = 1

                },

                new Item
                {
                    Name = "ソファ",
                    Lot = 10004,
                    ReleaseDate = DateTime.Parse("2019-12-12"),
                    Genre = "ソファ",
                    PurchasePrice = 100000,
                    SupplierId = 1

                }
                );
                context.SaveChanges();
            }
        }
    }
}