namespace WendingMachine.Brokers.VM.Brokers;
public partial interface IVMBrokers
{
    public string AddBeverage(int id, string drinkName, int drinkPrice);
    public int GetPrice(string drinkName);
}
