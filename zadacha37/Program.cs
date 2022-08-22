using System;

class Program
{
    static void Main (string[] args)    
    {
        int count = 0;
        int[] array = new int [123];
        for(int i = 0; i < array.Length; i++)
        {
            //array[i] = Convert.ToInt32(new Random().Next(123));
            array[i] = new Random().Next(0,1000);
            Console.Write(array[i]+ " ");
            int min = 10;
            int max = 99;
            if(array[i]> min && array[i]< max)
            {
                count++;

            }
            
        }
        System.Console.WriteLine("колличество " + count);
        
    }
}         
