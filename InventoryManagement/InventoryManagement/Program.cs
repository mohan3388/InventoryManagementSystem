namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string INVENTORY_FILE_PATH = @"F:\dotnet\Inventory\InventoryManagementSystem\InventoryManagement\InventoryManagement\Inventory.json";
            Inventory inventory = new Inventory();
            inventory.DisplayInventory(INVENTORY_FILE_PATH);

        }

    }
}