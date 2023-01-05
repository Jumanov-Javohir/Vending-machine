using WendingMachine.Models;

namespace WendingMachine.Brokers.VM.Brokers;
public partial class VMBrokers
{
    Dictionary<Drinks, int> vendingMachine = new Dictionary<Drinks, int>();
    /// <summary>
    /// Add Vending Machine
    /// </summary>
    public string RefillColumn(string drinkName, int amountDrink)
    {
        if (vendingMachine.Count > 4)
        {
            return "We have four(4) columns :(";
        }
        for (int i = 0; i < drinksList.Count; i++)
        {
            if (drinksList[i].GetName() == drinkName)
            {
                if (!vendingMachine.ContainsKey(drinksList[i]))
                {
                    vendingMachine.Add(drinksList[i], amountDrink);
                }
                else
                {
                    vendingMachine[drinksList[i]] += amountDrink;
                }

                return "A drink has been added to the vending machine :)";
            }
        }
        return "There is no such drink in the vending machine....";
    }
    /// <summary>
    /// Get Available Cans
    /// </summary>
    public int AvailableCans(string drinkName)
    {
        for (int i = 0; i < drinksList.Count; i++)
        {
            if (drinksList[i].GetName() == drinkName)
            {
                if (vendingMachine.ContainsKey(drinksList[i]))
                    return vendingMachine[drinksList[i]];
            }
        }

        return 0;
    }
}
