using System.Text.Json;

namespace WendingMachine.Models;
public class Drinks
{
    private int Id { get; set; }
    private string Name { get; set; }
    private int Price { get; set; }
    public Drinks(int id, string name, int price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int GetId() => this.Id;
    public string GetName() => this.Name;
    public int GetPrice() => this.Price;
}
