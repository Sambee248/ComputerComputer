// See https://aka.ms/new-console-template for more information
using System;

namespace PrimeFactors{
    class Program{
        static void Main(string[] str){
            Console.WriteLine("请输入一个整数:");
            //string->int
            int num= Convert.ToInt32(Console.ReadLine());
            //循环输出队列
            Console.WriteLine($"{num}的所有素数因子为：");
            foreach (var factor in GetPrimeFactors(num)){
                Console.Write(factor +" ");
            }
            Console.WriteLine();
        }

        //获得所有因子   返回list便于循环输出
        static System.Collections.Generic.List<int> GetPrimeFactors(int number){
            var factors = new System.Collections.Generic.List<int>();

            for(int divisor = 2;number > 1;divisor++)
            {
                while(number % divisor == 0){  //因子
                    factors.Add(divisor);   //添加进队列
                    number /=divisor;   
                }
            }
            return factors;
        }
    }
}