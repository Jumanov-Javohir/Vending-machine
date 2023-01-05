namespace WendingMachine.Brokers.VM.Brokers;
public partial interface IVMBrokers
{
    public string RefillColumn(string drinkName, int amountDrink);
    public int AvailableCans(string drinkName);
}
