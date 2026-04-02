using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressionEvaluator.Core
{
    public class Evaluator
    {
        public static double Evaluate(string infix)
        {
            var postfix = InfixToPostfix(infix);
            return EvaluatePostfix(postfix);
        }

        private static List<string> InfixToPostfix(string infix)
        {
            var output = new List<string>();
            var stack = new Stack<string>();

            var tokens = Tokenize(infix);

            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    output.Add(token);
                }
                else if (IsOperator(token))
                {
                    while (stack.Count > 0 && Priority(stack.Peek()) >= Priority(token))
                    {
                        output.Add(stack.Pop());
                    }
                    stack.Push(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Peek() != "(")
                    {
                        output.Add(stack.Pop());
                    }
                    stack.Pop();
                }
            }

            while (stack.Count > 0)
            {
                output.Add(stack.Pop());
            }

            return output;
        }

        private static double EvaluatePostfix(List<string> postfix)
        {
            var stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    stack.Push(token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => a / b,
                        "^" => Math.Pow(a, b),
                        _ => throw new Exception("Error")
                    });
                }
            }

            return stack.Pop();
        }

        private static List<string> Tokenize(string input)
        {
            var tokens = new List<string>();
            var number = "";

            foreach (char c in input.Replace(",", "."))
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }

                    if (!char.IsWhiteSpace(c))
                        tokens.Add(c.ToString());
                }
            }

            if (number != "")
                tokens.Add(number);

            return tokens;
        }

        private static bool IsOperator(string op)
        {
            return op == "+" || op == "-" || op == "*" || op == "/" || op == "^";
        }

        private static int Priority(string op)
        {
            return op switch
            {
                "^" => 3,
                "*" => 2,
                "/" => 2,
                "+" => 1,
                "-" => 1,
                _ => 0
            };
        }
    }
}