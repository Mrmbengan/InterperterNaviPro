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
        double currentChar = 0;
        double currentNumber = 0;
        for (int i = 0; i < expression.Length; i++){
            char charexpr = expression[i];
            if (char.IsDigit(charexpr) || currentChar == '.'){
                int startIndex = i;
                while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.')){
                    i++;
                }
                currentNumber = double.Parse(expression.Substring(startIndex, i - startIndex));
                i++;

                if (currentChar == 0){
                    result = currentNumber;
                }
                else if (currentChar == '+'){
                    result += currentNumber;
                }
                else if (currentChar == '-'){
                    result -= currentNumber;
                }
                else if (currentChar == '*'){
                    result *= currentNumber;
                }
                else if (currentChar == '/'){
                    result /= currentNumber;
                }
            }
            
            
            
        }
        result += currentNumber;
        return result;
        //okej jag tror detta funkar!
        //nu ska jag få in parenteser innan läggdags :-(
        
    }
}
