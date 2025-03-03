// See https://aka.ms/new-console-template for more information

using System;

class Program{
    static void Main(){
        Console.WriteLine("请输入数组长度：");
        //arrNum  -> 数组长度
        int arrNum = Convert.ToInt32(Console.ReadLine());
        int[] preArr = new int[arrNum];
        Console.WriteLine("请输入数组元素：");
        for(int i = 0; i < arrNum; i++){
            preArr[i] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(preArr[i] + " ");
        }
        int min = preArr[0];
        int max = preArr[0];
        int sum = 0;
        for(int i = 0; i < arrNum; i++){
            if(max < preArr[i]) max = preArr[i];
            if(min > preArr[i]) min = preArr[i];
            sum += preArr[i]; 
        }
        double averageNum = sum / arrNum;
        Console.WriteLine($"最大值为：{max}  最小值为：{min}  平均值为：{averageNum}  和为：{sum}");

    }
}
