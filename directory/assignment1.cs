// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleCalculator{
    class Program{
        static void Main(string[] str1){
            Console.WriteLine("Welcome to use the calculator!");
            Console.WriteLine("Please input the first number:");
            //string 转  double
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the operator(+,-,*,/):");

            //处理异常之“将 null 文本或可能的 null 值转换为不可为 null 类型”警告
            string operator1= Console.ReadLine() ?? "Default Value";
            //结果
            double result = 0;

            switch(operator1){
                case "+": 
                    result = num1 + num2 ;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 == 0){
                        Console.WriteLine("Wrong!");
                        break;
                    } else{
                        result = num1 / num2;
                        break;
                    }
                default:
                    Console.WriteLine("Wrong!");
                    return;
            }

            // 给出计算结果
            Console.WriteLine($"{num1}{operator1}{num2}={result}");


        }
    }
}
