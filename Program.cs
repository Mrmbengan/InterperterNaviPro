using System;

namespace InterperterNaviPro;

class Program
{
    public static void Main()
    {
        string expression = "1 + (36 / 2) / (3 * 3) - 2";

        double result = EvaluateExpression(expression);

        Console.WriteLine("Expression " + expression);
        Console.WriteLine("result " + result);
        Console.ReadLine();
    }

    public static double EvaluateExpression(string expression){
        return Evaluate(expression);
    }

   private static double Evaluate(string expression)
    {
        while (expression.Contains('('))
        {
            int startIndex = expression.LastIndexOf('(');
            int endIndex = expression.IndexOf(')', startIndex);
            string subExpression = expression.Substring(startIndex + 1, endIndex - startIndex - 1);
            double innerResult = EvaluateSimpleExpression(subExpression);
            expression = expression.Substring(0, startIndex) + innerResult + expression.Substring(endIndex + 1);
        }
        return EvaluateSimpleExpression(expression);
    }
    private static double EvaluateSimpleExpression(string expression){

        double result = 0;
        char currentOperator = '+'; //start av operatorn
        double currentNumber = 0;
        int i = 0;

        while (i < expression.Length){
            char currentChar = expression[i];
            if (char.IsDigit(currentChar) || currentChar == '.'){
                int startIndex = i;
                while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.')){
                    i++;
                }
                currentNumber = double.Parse(expression.Substring(startIndex, i - startIndex));
                i--; //testar

                if (currentOperator == '+'){
                    result += currentNumber;
                }
                else if (currentOperator == '-'){
                    result -= currentNumber;
                }
                else if (currentOperator == '*'){
                    result *= currentNumber;
                }
                else if (currentOperator == '/'){
                    result /= currentNumber;
                }
                
            }
            else if (currentChar == '+' || currentChar == '-' || currentChar == '*' || currentChar == '/'){
                currentOperator = currentChar;
            }
            i++;
            
            //inte snyggaste men jag tror jag har det nu, men resutatet blir fel :-(
            
        }
        
        return result;
        
    }
}
