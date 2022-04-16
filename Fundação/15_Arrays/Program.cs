using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]{1, 2, 3, 4, 5}; 
            meuArray[0] = 400;  // trocar o array na posição 0( que é 1) por 400

            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
        }
    }
}