using System.Dynamic;
using System.Text.Json;

namespace WendingMachine.Models;
public class Cards
{
    private int CardId { get; set; }
    private long Cridet{ get; set; }
    public Cards(int cardId, long cridet)
    {
        CardId = cardId;
        Cridet = cridet;
    }
    public int GetCardId() => this.CardId;
    public long GetCridet() => this.Cridet;
    public void SetCridet(long cridet)
    {
        if(cridet != 0)
        {
            this.Cridet += cridet;
        }
    }
}
