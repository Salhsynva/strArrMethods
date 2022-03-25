using System;

namespace strArrMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //NoSpace(word);
            //HasDigit(word);
            // FirstWord(word);
            //TwoAndUpperWord(word);

            //int[] numbers = { 13, 533, 1455, 3, 57, 5, 2, 1 };
            //int number = Convert.ToInt32(Console.ReadLine());
            //AddNumber(numbers, number);


        }

        static void NoSpace(string word)
        {
            string newWord = "";
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i-1] != ' ')
                {
                    newWord += word[i];
                }
            }
        Console.WriteLine(newWord);
        }

        static void HasDigit(string word) 
        {
            int digit = 0;
            int upper = 0;
            int lower = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    digit++;
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    upper++;
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    lower++;
                }
            }
            if (digit!=0 && upper!=0 && lower != 0)
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
        }

        static void FirstWord(string word)
        {
            string[] wordArray = word.Split(" ");
            int index = 0;
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] != "")
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(wordArray[index]);
        }

        static void TwoAndUpperWord(string word)
        {
            string[] newArr = word.Split(" ");
            int count = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] != "")
                {
                    count++;
                }
            }
            string[] newArr2 = new string[count];
            int j = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] != "")
                {
                    newArr2[j] = newArr[i];
                    j++;
                }
            }
            if (count != 2)
            {
                Console.WriteLine(false);
            }
            else if (count == 2)
            {
                if (char.IsUpper(newArr2[0][0]) && char.IsUpper(newArr2[1][0]))
                {
                    Console.WriteLine(true);
                }else
                    Console.WriteLine(false);
            }
        }

        static void AddNumber(int[] numbers, int number)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            numbers.CopyTo(newNumbers, 0);
            newNumbers[newNumbers.Length - 1] = number;
            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
