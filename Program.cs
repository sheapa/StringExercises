using System;
using System.ComponentModel;

namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****************************************************************************************************//
            //* EXERCISE 1/5                                                                                     *//
            //****************************************************************************************************//
            Console.WriteLine("Please enter a series of numbers seperated by hyphens. Example '1-2-3-...'");
            string hypenString = Console.ReadLine();
            string saveHypenString = hypenString;
            string[] stringsArray = hypenString.Split('-');
            int[] numbersArray = Array.ConvertAll(stringsArray, int.Parse);
            Array.Sort(numbersArray);
            string sortedHyphenString = String.Join("-", numbersArray);

            if (saveHypenString == sortedHyphenString)
            {
                Console.WriteLine("Your numbers are consecutive!");
            }
            else
            {
                Console.WriteLine("Your numbers are not consecutive :( ");
            }

            //****************************************************************************************************//
            //* EXERCISE 2/5                                                                                     *//
            //****************************************************************************************************//

            Console.WriteLine("Please enter a few numbers seperated by hyphens. Example '1-2-3, ...' ");
            var numberSequence = Console.ReadLine();
            if (String.IsNullOrEmpty(numberSequence))
            {
                Console.WriteLine("Exit Program");
            }
            else
            {
                string[] stringsSequenceArray = numberSequence.Split('-');
                int[] numbersSequenceArray = Array.ConvertAll(stringsSequenceArray, int.Parse);
                var numberDict = new Dictionary<int, int>();
                foreach (var number in numbersSequenceArray)
                {
                    numberDict.TryGetValue(number, out int count);
                    numberDict[number] = count + 1;
                }

                foreach (var pair in numberDict)
                {
                    Console.WriteLine("Value {0} occured {1} times.", pair.Key, pair.Value);
                }
            }
            //****************************************************************************************************//
            //* EXERCISE 3/5                                                                                     *//
            //****************************************************************************************************//
            bool formatPass = false;
            DateTime dt;
            try
            {
                Console.WriteLine("Please enter the time in in 24 hour format. Example: '19:00'.");
                string userTime = Console.ReadLine();

                dt = Convert.ToDateTime(userTime);
                string convertedBack = dt.ToString("HH:mm");
                if (userTime == convertedBack)
                {
                    Console.WriteLine("Time is Valid.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Time");
                throw;
            }
            //****************************************************************************************************//
            //* EXERCISE 4/5                                                                                     *//
            //****************************************************************************************************//
            Console.WriteLine("Please enter a few words seperated by spaces.");
            string stringInput = Console.ReadLine();

            string lcStringInput = stringInput.ToLower();
            string[] wordArray = lcStringInput.Split(" ");
            var results = new List<string>();

            foreach (var word in wordArray)
            {
                var result = word[0].ToString().ToUpper() + word.Substring(1);
                var resultString = result.ToString();
                results.Add(resultString);
            }

            Console.WriteLine("Your words in Pascal Case are..." + String.Join("", results));

            //****************************************************************************************************//
            //* EXERCISE 5/5                                                                                     *//
            //****************************************************************************************************//
            int vowelCount = 0;
         Console.WriteLine("Please enter a word.");
         string englishWord = Console.ReadLine();
         char[] englishArray = englishWord.ToArray();
        
        foreach (char eng in englishArray)
        {
            switch (eng)
            {
                    case 'a':
                        vowelCount++;
                        break;
                    case 'e':
                        vowelCount++;
                        break;
                    case 'i':
                        vowelCount++;
                        break;
                    case 'o':
                        vowelCount++;
                        break;
                    case 'u':
                        vowelCount++;
                        break;
                    default:
                        continue;

                }
        }
        Console.WriteLine("Your word contains " + vowelCount + " vowels");
        }
    }
}