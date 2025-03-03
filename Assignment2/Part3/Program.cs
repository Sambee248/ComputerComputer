// See https://aka.ms/new-console-template for more information

using System;

class Program{
    static void Main(){
        //2~100内的素数
        int[] primeNumber = new int[50];
        int order = 0;  //序号
        for(int i = 2; i <= 100 ; i++){
            for(int j = 2;j < i; j++){
                if( i % j == 0) break;   //除得尽直接进入下一轮循环
                if( j == i-1 ){
                    primeNumber[order] = i;
                    order ++;
                }
            }
        };
        Console.WriteLine("2~100之间的素数有:");
        for(int m = 0;m < order; m++){
            Console.Write(primeNumber[m] + " ");
        }
    }
}