namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            


            string filepath = @"F:\dotnet\Inventory\InventoryManagementSystem\InventoryManagement\InventoryManagement\Inventory.json";

         
            StockPortfolio port = new StockPortfolio();
            port.DisplayStockDetails(filepath);
           


        }

    }
}