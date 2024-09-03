using System.Data;

namespace InterperterNaviPro;

class Program
{
    public static void Main(string[] args)
    {
        //hatar matte även om man som utvecklare inte får säga det
        string expression = "1+ (36 / 2) / (3 * 3) - 2";

        string result = EvaluateExpression(expression);

        Console.WriteLine("Expression " + expression);
        Console.WriteLine("result " + result);
        Console.ReadLine();
    }

}
