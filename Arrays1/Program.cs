using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100000;
            int index = 0;
            int[] array = new int[length];
            
            while (true)
            {
                //length++;
                Console.WriteLine("write your number or 'stop' if you want to stop");
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
               if(input != "stop")
                {
                    
                    int number = int.Parse(input);
                    array[index] = number;
                   
                    index++;


                }
            }

            for (int i = 0; i < index; i++)
                Console.WriteLine(array[i]);
            {

            }
            

            
            
            
        }
    }
}
