using System;

namespace InterperterNaviPro;

class Program
{
    public static void Main()
    {
        string expression = "1+ 36 / 2 / 3 * 3 - 2";

        double result = EvaluateExpression(expression);

        Console.WriteLine("Expression " + expression);
        Console.WriteLine("result " + result);
        Console.ReadLine();
    }

   public static double EvaluateExpression(string expression)
    {
        double result = 0;
        int i = 0;
        while (i < expression.Length){
            char charexpr = expression[i];
            if (charexpr.IsDigits(charexpr)){
                int startIndex = i;
                while (i < expression.Length && expression[i].IsDigits(expression[i])){
                    i++;
                }
                double number = double.Parse(expression.Substring(startIndex, i - startIndex));

                if (i < expression.Length && expression[i] == '+'){
                    i++;
                    number += double.Parse(expression.Substring(i, expression.Length - i));
                }
                else if (i < expression.Length && expression[i] == '-'){
                    i++;
                    number -= double.Parse(expression.Substring(i, expression.Length - i));
                }
                else if (i < expression.Length && expression[i] == '*'){
                    i++;
                    number *= double.Parse(expression.Substring(i, expression.Length - i));
                }
                else if (i < expression.Length && expression[i] == '/'){
                    i++;
                    number /= double.Parse(expression.Substring(i, expression.Length - i));
                }
                result += number;
            }
            else{
                i++;
            }
            
            //commitar detta så ni ser min struggle, ska testa göra om med for loop
        }
        return result;
        
    }
}
