using WendingMachine.Brokers.VM.Brokers;
namespace WendingMachine.View;
public class Views
{
    public static VMBrokers vm = VMBrokers.Instance;
    /// <summary>
    /// Singilton for Views
    /// </summary>
    private Views() { }
    private static Views instance = null;
    public static Views Instance
    {
        get
        {
            if (instance is null)
                instance = new Views();
            return instance;
        }
    }
    /// <summary>
    /// Main View
    /// </summary>
    string[] menus = { "", " Drinks ", " Credit Card ", " Vending Machine ", " Sale "};
    public void MainView()
    {
        Menu();
        string choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                Drinks(int.Parse(choose));
                break;
            case "2":
                CridetCard(int.Parse(choose));
                break;
            case "3":
                VendingMachine(int.Parse(choose));
                break;
            case "4":
                Console.Clear();
                Sales(4);
                break;
        }
        void Menu()
        {
            Show(3);

            Console.WriteLine("1. Drinks");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Vending Machine");
            Console.WriteLine("4. Sale");
            Console.Write("\n>>>> ");
        }
        void Drinks(int index)
        {
            Console.Clear();
            Show(index);

            Console.WriteLine("1. Add drinks");
            Console.WriteLine("2. Get price of drink");
            Console.Write("\n>>>> ");

            choose = Console.ReadLine();

            if (choose == "1")
                AddDriks();
            else if (choose == "2")
                GetPrice();
        }
        void CridetCard(int index)
        {
            Console.Clear();
            Show(index);

            Console.WriteLine("1. Add Cridet Card");
            Console.WriteLine("2. Get Card Cridetini");
            Console.Write("\n>>>> ");

            choose = Console.ReadLine();

            if (choose == "1")
                AddCards();
            else if (choose == "2")
                GetCard();
        }
        void VendingMachine(int index)
        {
            Console.Clear();
            Show(index);

            Console.WriteLine("1. Add Vending Machine");
            Console.WriteLine("2. Amount Of Drink From Vending Machine");
            Console.Write("\n>>>> ");

            choose = Console.ReadLine();

            if (choose == "1")
                AddVendingMachine();
            else if (choose == "2")
                GetAmountOfDrinkFromVendingMachine();
        }
    }
    /// <summary>
    /// Show
    /// </summary>
    /// <param name="index"></param>
    private void Show(int index)
    {
        Console.Write(":".PadRight(15, ':'));
        Console.Write($"{menus[index]}");
        Console.WriteLine(":".PadRight(15, ':'));
    }
    /// <summary>
    /// Drinks
    /// </summary>
    private void AddDriks()
    {
        Console.Write("Id : ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Drink Name : ");
        string drinkName = Console.ReadLine();

        Console.Write("Drink Price : ");
        int drinkPrice = int.Parse(Console.ReadLine());

        Console.WriteLine(vm.AddBeverage(id, drinkName, drinkPrice));

        Exit();
    }
    private void GetPrice()
    {
        Console.Write("Drink Name : ");
        string drinkName = Console.ReadLine();

        int priceOfDrink = vm.GetPrice(drinkName);

        if (priceOfDrink == -1)
        {
            Console.WriteLine("Bunday ichimlik mavjud emas...");
        }
        else
        {
            Console.WriteLine($"{drinkName} ning narxi {priceOfDrink} ga teng...");
        }

        Exit();
    }
    /// <summary>
    /// Cridet Card
    /// </summary>
    private void AddCards()
    {
        Console.Write("Card Id : ");
        int cardId = int.Parse(Console.ReadLine());

        Console.Write("Card Price : ");
        long cardPrice = long.Parse(Console.ReadLine());

        Console.WriteLine(vm.RechargeCard(cardId, cardPrice));

        Exit();
    }
    private void GetCard()
    {
        Console.Write("Card Id : ");
        int cardId = int.Parse(Console.ReadLine());

        Console.WriteLine($"{cardId} id lik kartaning krideti {vm.GetCredit(cardId)} ga teng....");

        Exit();
    }
    /// <summary>
    /// Vending Machine
    /// </summary>
    private void AddVendingMachine()
    {
        Console.Write("Drink Name : ");
        string drinkName = Console.ReadLine();

        Console.Write("Amount : ");
        int amount = int.Parse(Console.ReadLine());

        string result = vm.RefillColumn(drinkName, amount);

        Console.WriteLine(result);

        Exit();
    }
    private void GetAmountOfDrinkFromVendingMachine()
    {
        Console.Write("Drink Name : ");
        string drinkName = Console.ReadLine();

        int result = vm.AvailableCans(drinkName);

        if (result == 0)
            Console.WriteLine($"{drinkName} dan sotuv mashinamizda hozircha yuq :(");
        else
            Console.WriteLine($"{drinkName} dan sotuv mashinamizda {result} ta bor....");

        Exit();
    }
    /// <summary>
    /// Sales
    /// </summary>
    /// <param name="index"></param>
    private void Sales(int index)
    {
        Show(index);

        Console.Write("Drink Name : ");
        string drinkName = Console.ReadLine();

        Console.Write("Card Id : ");
        int cardId = int.Parse(Console.ReadLine());

        string result = vm.Sale(drinkName, cardId);

        Console.WriteLine(result);

        Exit();
    }
    /// <summary>
    /// For Exit
    /// </summary>
    private void Exit()
    {
        Console.Write("\nExit [0] : ");

        int exit = int.Parse(Console.ReadLine());
        if (exit == 0)
        {
            Console.Clear();
            MainView();
        }
    }
}