using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        public double Sum(double first, double second)
        {
            return first + second;
        }

        public double Minus(double first, double second)
        {
            return first - second;
        }

        public double Mult(double first, double second)
        {
            return first * second;
        }

        public double Div(double first, double second)
        {
            if (second == 0)
            {
                Console.WriteLine("Avoid division by 0");
                return first;
            }

            else
            {
                return first / second;
            }
                
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool minus, plus, div, mult,loop;
            minus = plus = div = mult = loop = false;
            double firstVal=0, secondVal=0, result = 0;
            Calculator calc = new Calculator();
		
            for(;;)
            {
                try
                {
                    Console.WriteLine("\nInput first value");

                    firstVal = Convert.ToDouble(Console.ReadLine());
                    result = firstVal;
                    loop = true;
                    do
                    {
                        Console.WriteLine("\nDefine operation (+,-,*,/)");
                        Console.WriteLine("Type \"c\" to cancel the result");
                        String operation = Console.ReadLine();
                        if (operation == "+")
                        {
                            plus = true;
                        }
                        else if (operation == "-")
                        {
                            minus = true;
                        }
                        else if (operation == "*")
                        {
                            mult = true;
                        }
                        else if (operation == "/")
                        {
                            div = true;
                        }
                        else if(operation =="c")
                        {
                            loop = false;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("\nUse predefined operation only (+,-.*./)\n");
                            continue;
                        }
                        Console.WriteLine("\nInput next value");
                        secondVal = Convert.ToDouble(Console.ReadLine());

                        if (plus)
                        {
                            result = calc.Sum(result, secondVal);
                            Console.WriteLine("Result = " + result + '\n');
                        }

                        if (minus)
                        {
                            result = calc.Minus(result, secondVal);
                            Console.WriteLine("Result = " + result + '\n');
                        }
                        if (mult)
                        {
                            result = calc.Mult(result, secondVal);
                            Console.WriteLine("Result = " + result + '\n');
                        }
                        if (div)
                        {
                            result = calc.Div(result, secondVal);
                            Console.WriteLine("Result = " + result + '\n');
                        }

                        plus = minus = div = mult = false;
                    }
                    while (loop);
                }
                catch
                {
                    Console.WriteLine("Use numbers only\n");
                }
            }
            
        }
    }
}
