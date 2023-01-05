namespace WendingMachine.Brokers.VM.Brokers;
public partial interface IVMBrokers
{
    public string RechargeCard(int cardId, long CardCridet);
    public long GetCredit(int cardId);
}
