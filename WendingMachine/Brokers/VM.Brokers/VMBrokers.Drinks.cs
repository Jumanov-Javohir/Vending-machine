using WendingMachine.Models;
namespace WendingMachine.Brokers.VM.Brokers;
public partial class VMBrokers
{
    List<Drinks> drinksList = new List<Drinks>();
    /// <summary>
    /// Add Drinks
    /// </summary>
    public string AddBeverage(int id, string drinkName, int drinkPrice)
    {
        for (int i = 0; i < drinksList.Count; i++)
        {
            if (drinksList[i].GetId() == id)
            {
                return "Such a drink already exists :(";
            }
        }
        drinksList.Add(new Drinks(id, drinkName, drinkPrice));

        return "Drink has been succefully added :)";
    }
    /// <summary>
    /// Get Price of Drink
    /// </summary>
    public int GetPrice(string drinkName)
    {
        for (int i = 0; i < drinksList.Count; i++)
        {
            if (drinksList[i].GetName() == drinkName)
                return drinksList[i].GetPrice();
        }

        return -1;
    }
}
