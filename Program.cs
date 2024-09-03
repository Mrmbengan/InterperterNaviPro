using System;

namespace InterperterNaviPro;

class Program
{
    public static void Main()
    {
        string expression = "1+ (36 / 2) / (3 * 3) - 2";

        string result = EvaluateExpression(expression);

        Console.WriteLine("Expression " + expression);
        Console.WriteLine("result " + result);
        Console.ReadLine();
    }

   public static string EvaluateExpression(string expression)
    {
        //får jag använda DataTable ?
        var DataTable = new DataTable();
        var result = DataTable.Compute(expression,null);
        return result.ToString();
    }
}
