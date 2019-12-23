using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryControl.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Item_ItemId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Store_StoreId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Warehouse_WarehouseId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Supplier_SupplierId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Client_ClientId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Inventory_InventoryId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Store_StoreId",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "Warehouses");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Inventories");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_StoreId",
                table: "Warehouses",
                newName: "IX_Warehouses_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_InventoryId",
                table: "Sales",
                newName: "IX_Sales_InventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_ClientId",
                table: "Sales",
                newName: "IX_Sales_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_SupplierId",
                table: "Items",
                newName: "IX_Items_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_WarehouseId",
                table: "Inventories",
                newName: "IX_Inventories_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_StoreId",
                table: "Inventories",
                newName: "IX_Inventories_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_ItemId",
                table: "Inventories",
                newName: "IX_Inventories_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Items",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Items_ItemId",
                table: "Inventories",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Stores_StoreId",
                table: "Inventories",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Warehouses_WarehouseId",
                table: "Inventories",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Clients_ClientId",
                table: "Sales",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Inventories_InventoryId",
                table: "Sales",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Stores_StoreId",
                table: "Warehouses",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Items_ItemId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Stores_StoreId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Warehouses_WarehouseId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Clients_ClientId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Inventories_InventoryId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Stores_StoreId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "Inventory");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouses_StoreId",
                table: "Warehouse",
                newName: "IX_Warehouse_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_InventoryId",
                table: "Sale",
                newName: "IX_Sale_InventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_ClientId",
                table: "Sale",
                newName: "IX_Sale_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SupplierId",
                table: "Item",
                newName: "IX_Item_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventory",
                newName: "IX_Inventory_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_StoreId",
                table: "Inventory",
                newName: "IX_Inventory_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_ItemId",
                table: "Inventory",
                newName: "IX_Inventory_ItemId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Item",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Item_ItemId",
                table: "Inventory",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Store_StoreId",
                table: "Inventory",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Warehouse_WarehouseId",
                table: "Inventory",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Supplier_SupplierId",
                table: "Item",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Client_ClientId",
                table: "Sale",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Inventory_InventoryId",
                table: "Sale",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Store_StoreId",
                table: "Warehouse",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
