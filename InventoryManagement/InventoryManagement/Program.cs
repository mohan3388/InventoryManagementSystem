namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();


            string filepath = @"F:\dotnet\Inventory\InventoryManagementSystem\InventoryManagement\InventoryManagement\Inventory.json";

            Rice data = fetchInventoryDetails.Read(filepath);

            for (int i = 0; i < data.typesofRice.Count; i++)
            {

                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine(data.typesofRice[i].weight);

                Console.WriteLine("--------------");
            }


        }

    }
}