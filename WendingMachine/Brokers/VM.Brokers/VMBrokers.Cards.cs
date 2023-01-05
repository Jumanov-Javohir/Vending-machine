using WendingMachine.Models;

namespace WendingMachine.Brokers.VM.Brokers;
public partial class VMBrokers
{
    List<Cards> cardsList = new List<Cards>();

    /// <summary>
    /// Add Cridet Card
    /// </summary>
    public string RechargeCard(int cardId, long CardCridet)
    {
        for (int i = 0; i < cardsList.Count; i++)
        {
            if (cardsList[i].GetCardId() == cardId)
            {
                cardsList[i].SetCridet(CardCridet);

                return "Cridet Card has been succefully added :)";
            }
        }
        cardsList.Add(new Cards(cardId, CardCridet));

        return "The card is now added to the list....";

    }
    /// <summary>
    /// Get Cridet Card
    /// </summary>
    public long GetCredit(int cardId)
    {
        for (int i = 0; i < cardsList.Count; i++)
        {
            if (cardsList[i].GetCardId() == cardId)
                return cardsList[i].GetCridet();
        }

        return -1;
    }
}
