
namespace VendingMachines
{
    public class VendingMachine
    {
        Dictionary<string, (string, decimal)> inventory = new();
        public string SelectProduct(string productCode, decimal productPrice)
        {
            if (productCode == "A01")
            {
                return "Vending Soda";
            }
            if (productCode == "A02")
            {
                return "Vending Chips";
            }
            if(productCode == "A03")
            {
                return "Vending Candy";
            }
            return "Vending Gum";
        }
    }
}
