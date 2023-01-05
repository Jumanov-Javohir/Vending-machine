using WendingMachine.View;

namespace WendingMachine;
public class Program
{
    public static Views views = Views.Instance;
    public static void Main(string[] args)
    {
        views.MainView();
    }
}