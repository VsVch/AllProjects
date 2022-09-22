using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string word = Console.ReadLine();
            double maxSum = 0;
            string maxWord = string.Empty;

            while (word != "End of words")
            {

                double sum = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    sum += word[i];
                }

                string word2 = word.ToLower();


                if (word2[0] == 'a' || word2[0] == 'e' || word2[0] == 'i' || word2[0] == 'o' || word2[0] == 'u' || word2[0] == 'y')
                {
                    sum = sum * word.Length;
                }
                else
                {
                    sum = Math.Floor(sum / word.Length);
                }



                if (sum>maxSum)
                {
                    maxSum = sum;
                    maxWord = word;
                }


                word = Console.ReadLine();
            }


            Console.WriteLine($"The most powerful word is {maxWord} - {maxSum}");



        }
    }
}
