using System.Data;

namespace InterperterNaviPro;

class Program
{
    public static void Main(string[] args)
    {
  
        string expression = "1+ (36 / 2) / (3 * 3) - 2";

        string result = EvaluateExpression(expression);

        Console.WriteLine("Epression " + expression);
        Console.WriteLine("result " + result);
        Console.ReadLine();
    }

}
