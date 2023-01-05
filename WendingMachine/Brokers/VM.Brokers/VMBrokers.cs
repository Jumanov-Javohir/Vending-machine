using WendingMachine.Models;

namespace WendingMachine.Brokers.VM.Brokers;
public partial class VMBrokers : IVMBrokers
{
    /// <summary>
    /// Singilton for VMBrokers
    /// </summary>
    public VMBrokers() { }
    private static VMBrokers instance = null;
    public static VMBrokers Instance
    {
        get
        {
            if (instance is null)
                instance = new VMBrokers();
            return instance;
        }
    }
    /// <summary>
    /// Sale
    /// </summary>
    public string Sale(string drinkName, int CardId)
    {
        Drinks drink = null;
        Cards card = null;

        for (int i = 0; i < drinksList.Count; i++)
        {
            if (drinksList[i].GetName() == drinkName)
                drink = drinksList[i];
        }

        for (int i = 0; i < cardsList.Count; i++)
        {
            if (cardsList[i].GetCardId() == CardId)
                card = cardsList[i];
        }

        if (drink is null)
            return "Such a drink does not exist....";

        if (card is null)
            return "Such a card does not exist....";

        if (vendingMachine.ContainsKey(drink))
        {
            int drinkPrice = drink.GetPrice();

            if (vendingMachine[drink] == 0)
                return "There is no such drink in the vending machine....";

            if (drinkPrice > (int)card.GetCridet())
                return "There is enough money on the card....";

            card.SetCridet(-drinkPrice);

            vendingMachine[drink] -= 1;
        }

        return "Water was successfully sold....";
    }
}
