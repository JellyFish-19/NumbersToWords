using System;
using System.Security.Cryptography.X509Certificates;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            bool program = true;
            while (program == true)
            {
                Console.Write("\n\nWrite a number between 0 and 99999: ");
                string num = Console.ReadLine();
                Console.WriteLine();

                if (num.StartsWith("0") && num.Length > 1)
                {
                    Console.WriteLine("\nInvalid number");
                    Environment.Exit(1);
                }

                IsNumeric(num);

                if (IsNumeric(num) == true)
                {
                    Console.WriteLine();
                    int numberWord = Convert.ToInt32(num);

                    if (numberWord.ToString().Length == 1)
                    {
                        Console.WriteLine(NumToWords(numberWord));
                    }
                    else if (numberWord.ToString().Length == 2)
                    {
                        Console.WriteLine(NumToWords(numberWord));
                    }
                    else if (numberWord.ToString().Length == 3)
                    {
                        Console.WriteLine(NumToWordsThree(numberWord));
                    }
                    else if (numberWord.ToString().Length == 4)
                    {
                        Console.WriteLine(NumToWordsFour(numberWord));
                    }
                    else if (numberWord.ToString().Length == 5)
                    {
                        Console.WriteLine(NumToWordsFive(numberWord));
                    }
                    else
                    {
                        Console.WriteLine("\nNumber too big, please try again");
                    }
                }
                else
                {
                    Console.WriteLine("\nNot a number, ending program");
                }

                static bool IsNumeric(string num)
                {
                    int x;
                    bool isNum = int.TryParse(num, out x);
                    return isNum;
                }

                static string NumToWords(int numberWord)
                {
                    string textOne = "";

                    switch (numberWord)
                    {
                        case 0: textOne = "Zero"; break;
                        case 1: textOne = "One"; break;
                        case 2: textOne = "Two"; break;
                        case 3: textOne = "Three"; break;
                        case 4: textOne = "Four"; break;
                        case 5: textOne = "Five"; break;
                        case 6: textOne = "Six"; break;
                        case 7: textOne = "Seven"; break;
                        case 8: textOne = "Eight"; break;
                        case 9: textOne = "Nine"; break;
                        case 10: textOne = "Ten"; break;
                        case 11: textOne = "Eleven"; break;
                        case 12: textOne = "Twelve"; break;
                        case 13: textOne = "Thirteen"; break;
                        case 14: textOne = "Fourteen"; break;
                        case 15: textOne = "Fifthteen"; break;
                        case 16: textOne = "Sixteen"; break;
                        case 17: textOne = "Seventeen"; break;
                        case 18: textOne = "Eighteen"; break;
                        case 19: textOne = "Nineteen"; break;
                        case 20: textOne = "Twelve"; break;
                        case 30: textOne = "Thirty"; break;
                        case 40: textOne = "Fourty"; break;
                        case 50: textOne = "Fifty"; break;
                        case 60: textOne = "Sixty"; break;
                        case 70: textOne = "Seventy"; break;
                        case 80: textOne = "Eighty"; break;
                        case 90: textOne = "Ninety"; break;
                        default: textOne = NumToWordsTwo(numberWord); break;
                    }
                    return textOne;
                }

                static string NumToWordsTwo(int numberWord)
                {
                    string textOne = "";
                    string textTwo = "";

                    if (numberWord.ToString().Length == 2)
                    {
                        char[] numbers = numberWord.ToString().ToCharArray();

                        switch (numbers[0] - '0')
                        {
                            case 2: textOne = "Twenty"; break;
                            case 3: textOne = "Thirty"; break;
                            case 4: textOne = "Fourty"; break;
                            case 5: textOne = "Fifty"; break;
                            case 6: textOne = "Sixty"; break;
                            case 7: textOne = "Seventy"; break;
                            case 8: textOne = "Eighty"; break;
                            case 9: textOne = "Ninety"; break;
                        }

                        switch (numbers[1] - '0')
                        {
                            case 1: textTwo = "One"; break;
                            case 2: textTwo = "Two"; break;
                            case 3: textTwo = "Three"; break;
                            case 4: textTwo = "Four"; break;
                            case 5: textTwo = "Five"; break;
                            case 6: textTwo = "Six"; break;
                            case 7: textTwo = "Seve"; break;
                            case 8: textTwo = "Eight"; break;
                            case 9: textTwo = "Nine"; break;
                            default: textTwo = NumToWordsThree(numberWord); break;
                        }
                    }
                    return $"{textOne} {textTwo}";
                }

                static string NumToWordsThree(int numberWord)
                {
                    string textOne = "";
                    string textTwo = "";
                    string textThree = "";

                    if (numberWord.ToString().Length == 3)
                    {
                        char[] numbers = numberWord.ToString().ToCharArray();

                        switch (numbers[0] - '0')
                        {
                            case 1: textOne = "One Hundred"; break;
                            case 2: textOne = "Two Hundred"; break;
                            case 3: textOne = "Three Hundred"; break;
                            case 4: textOne = "Four Hundred"; break;
                            case 5: textOne = "Five Hundred"; break;
                            case 6: textOne = "Six Hundred"; break;
                            case 7: textOne = "Seven Hundred"; break;
                            case 8: textOne = "Eight Hundred"; break;
                            case 9: textOne = "Nine Hundred"; break;
                        }

                        switch (numbers[1] - '0')
                        {
                            case 1: textTwo = "Ten"; break;
                            case 2: textTwo = "Twenty"; break;
                            case 3: textTwo = "Thirty"; break;
                            case 4: textTwo = "Fourty"; break;
                            case 5: textTwo = "Fifty"; break;
                            case 6: textTwo = "Sixty"; break;
                            case 7: textTwo = "Seventy"; break;
                            case 8: textTwo = "Eighty"; break;
                            case 9: textTwo = "Ninety"; break;
                        }

                        if (textTwo == "Ten")
                        {
                            switch (numbers[2] - '0')
                            {
                                case 1: textTwo = ""; textThree = "Eleven"; break;
                                case 2: textTwo = ""; textThree = "Twelve"; break;
                                case 3: textTwo = ""; textThree = "Thirteen"; break;
                                case 4: textTwo = ""; textThree = "Fourteen"; break;
                                case 5: textTwo = ""; textThree = "Fifteen"; break;
                                case 6: textTwo = ""; textThree = "Sixteen"; break;
                                case 7: textTwo = ""; textThree = "Seventeen"; break;
                                case 8: textTwo = ""; textThree = "Eighteen"; break;
                                case 9: textTwo = ""; textThree = "Nineteen"; break;
                                default: textThree = NumToWordsFour(numberWord); break;
                            }
                        }
                        else
                        {
                            switch (numbers[2] - '0')
                            {
                                case 1: textThree = "One"; break;
                                case 2: textThree = "Two"; break;
                                case 3: textThree = "Three"; break;
                                case 4: textThree = "Four"; break;
                                case 5: textThree = "Five"; break;
                                case 6: textThree = "Six"; break;
                                case 7: textThree = "Seven"; break;
                                case 8: textThree = "Eight"; break;
                                case 9: textThree = "Nine"; break;
                                default: textThree = NumToWordsFour(numberWord); break;
                            }
                        }
                    }
                    return $"{textOne} {textTwo} {textThree}";
                }

                static string NumToWordsFour(int numberWord)
                {
                    string textOne = "";
                    string textTwo = "";
                    string textThree = "";
                    string textFour = "";

                    if (numberWord.ToString().Length == 4)
                    {
                        char[] numbers = numberWord.ToString().ToCharArray();

                        switch (numbers[0] - '0')
                        {
                            case 1: textOne = "One Thousand"; break;
                            case 2: textOne = "Two Thousand"; break;
                            case 3: textOne = "Three Thousand"; break;
                            case 4: textOne = "Four Thousand"; break;
                            case 5: textOne = "Five Thousand"; break;
                            case 6: textOne = "Six Thousand"; break;
                            case 7: textOne = "Seven Thousand"; break;
                            case 8: textOne = "Eight Thousand"; break;
                            case 9: textOne = "Nine Thousand"; break;
                        }

                        if (textOne == "One Thousand" && numbers[1] == '0')
                        {
                            switch (numbers[1] - '0')
                            {
                                case 1: textOne = "One Thousand"; break;
                                case 2: textOne = "Two Thousand"; break;
                                case 3: textOne = "Three Thousand"; break;
                                case 4: textOne = "Four Thousand"; break;
                                case 5: textOne = "Five Thousand"; break;
                                case 6: textOne = "Six Thousand"; break;
                                case 7: textOne = "Seven Thousand"; break;
                                case 8: textOne = "Eight Thousand"; break;
                                case 9: textOne = "Nine Thousand"; break;
                            }
                        }
                        else
                        {
                            switch (numbers[1] - '0')
                            {
                                case 0: textTwo = ""; break;
                                case 1: textTwo = "One Hundred"; break;
                                case 2: textTwo = "Two Hundred"; break;
                                case 3: textTwo = "Three Hundred"; break;
                                case 4: textTwo = "Four Hundred"; break;
                                case 5: textTwo = "Five Hundred"; break;
                                case 6: textTwo = "Six Hundred"; break;
                                case 7: textTwo = "Seven Hundred"; break;
                                case 8: textTwo = "Eight Hundred"; break;
                                case 9: textTwo = "Nine Hundred"; break;
                            }
                        }
                        switch (numbers[2] - '0')
                        {
                            case 0: textThree = ""; break;
                            case 1: textThree = "Ten"; break;
                            case 2: textThree = "Twenty"; break;
                            case 3: textThree = "Thirty"; break;
                            case 4: textThree = "Fourty"; break;
                            case 5: textThree = "Fifty"; break;
                            case 6: textThree = "Sixty"; break;
                            case 7: textThree = "Seventy"; break;
                            case 8: textThree = "Eighty"; break;
                            case 9: textThree = "Ninety"; break;
                        }

                        if (textThree == "Ten")
                        {
                            switch (numbers[3] - '0')
                            {
                                case 0: textFour = ""; break;
                                case 1: textThree = ""; textFour = "Eleven"; break;
                                case 2: textThree = ""; textFour = "Twelve"; break;
                                case 3: textThree = ""; textFour = "Thirteen"; break;
                                case 4: textThree = ""; textFour = "Fourteen"; break;
                                case 5: textThree = ""; textFour = "Fifteen"; break;
                                case 6: textThree = ""; textFour = "Sixteen"; break;
                                case 7: textThree = ""; textFour = "Seventeen"; break;
                                case 8: textThree = ""; textFour = "Eighteen"; break;
                                case 9: textThree = ""; textFour = "Nineteen"; break;
                            }
                        }
                        else
                        {
                            switch (numbers[3] - '0')
                            {
                                case 0: textFour = ""; break;
                                case 1: textFour = "One"; break;
                                case 2: textFour = "Two"; break;
                                case 3: textFour = "Three"; break;
                                case 4: textFour = "Four"; break;
                                case 5: textFour = "Five"; break;
                                case 6: textFour = "Six"; break;
                                case 7: textFour = "Seven"; break;
                                case 8: textFour = "Eight"; break;
                                case 9: textFour = "Nine"; break;
                            }
                        }
                    }
                    return $"{textOne} {textTwo} {textThree} {textFour}";
                }

                static string NumToWordsFive(int numberWord)
                {
                    string textOne = "";
                    string textTwo = "";
                    string textThree = "";
                    string textFour = "";
                    string textFive = "";

                    if (numberWord.ToString().Length == 5)
                    {
                        char[] numbers = numberWord.ToString().ToCharArray();

                        switch (numbers[0] - '0')
                        {
                            case 1: textOne = "Ten Thousand"; break;
                            case 2: textOne = "Twenty"; break;
                            case 3: textOne = "Thirty"; break;
                            case 4: textOne = "Fourty"; break;
                            case 5: textOne = "Fifty"; break;
                            case 6: textOne = "Sixty"; break;
                            case 7: textOne = "Seventy"; break;
                            case 8: textOne = "Eighty"; break;
                            case 9: textOne = "Ninety"; break;
                        }

                        if (textOne == "Ten Thousand")
                        {
                            switch (numbers[1] - '0')
                            {
                                case 0: textTwo = ""; break;
                                case 1: textOne = ""; textTwo = "Eleven Thousand"; break;
                                case 2: textOne = ""; textTwo = "Twelve Thousand"; break;
                                case 3: textOne = ""; textTwo = "Thirteen Thousand"; break;
                                case 4: textOne = ""; textTwo = "Fourteen Thousand"; break;
                                case 5: textOne = ""; textTwo = "Fifteen Thousand"; break;
                                case 6: textOne = ""; textTwo = "Sixteen Thousand"; break;
                                case 7: textOne = ""; textTwo = "Seventeen Thousand"; break;
                                case 8: textOne = ""; textTwo = "Eighteen Thousand"; break;
                                case 9: textOne = ""; textTwo = "Nineteen Thousand"; break;
                            }
                        }
                        else
                        {
                            switch (numbers[1] - '0')
                            {
                                case 0: textTwo = ""; break;
                                case 1: textTwo = "-One Thousand"; break;
                                case 2: textTwo = "-Two Thousand"; break;
                                case 3: textTwo = "-Three Thousand"; break;
                                case 4: textTwo = "-Four Thousand"; break;
                                case 5: textTwo = "-Five Thousand"; break;
                                case 6: textTwo = "-Six Thousand"; break;
                                case 7: textTwo = "-Seven Thousand"; break;
                                case 8: textTwo = "Eight Thousand"; break;
                                case 9: textTwo = "Nine Thousand"; break;
                            }
                        }

                        switch (numbers[2] - '0')
                        {
                            case 0: textThree = ""; break;
                            case 1: textThree = "One Hundred"; break;
                            case 2: textThree = "Two Hundred"; break;
                            case 3: textThree = "Three Hundred"; break;
                            case 4: textThree = "Four Hundred"; break;
                            case 5: textThree = "Five Hundred"; break;
                            case 6: textThree = "Six Hundred"; break;
                            case 7: textThree = "Seven Hundred"; break;
                            case 8: textThree = "Eight Hundred"; break;
                            case 9: textThree = "Nine Hundred"; break;
                        }

                        switch (numbers[3] - '0')
                        {
                            case 0: textFour = ""; break;
                            case 1: textFour = "Ten"; break;
                            case 2: textFour = "Twenty"; break;
                            case 3: textFour = "Thirty"; break;
                            case 4: textFour = "Fourty"; break;
                            case 5: textFour = "Fifty"; break;
                            case 6: textFour = "Sixty"; break;
                            case 7: textFour = "Seventy"; break;
                            case 8: textFour = "Eighty"; break;
                            case 9: textFour = "Ninety"; break;
                        }

                        if (textFour == "Ten")
                        {

                            switch (numbers[4] - '0')
                            {
                                case 1: textFour = ""; textFive = "Eleven"; break;
                                case 2: textFour = ""; textFive = "Twelve"; break;
                                case 3: textFour = ""; textFive = "Thirteen"; break;
                                case 4: textFour = ""; textFive = "Fourteen"; break;
                                case 5: textFour = ""; textFive = "Fifteen"; break;
                                case 6: textFour = ""; textFive = "Sixteen"; break;
                                case 7: textFour = ""; textFive = "Seventeen"; break;
                                case 8: textFour = ""; textFive = "Eighteen"; break;
                                case 9: textFour = ""; textFive = "Nineteen"; break;
                            }
                        }
                        else
                        {
                            switch (numbers[4] - '0')
                            {
                                case 0: textFive = ""; break;
                                case 1: textFive = "One"; break;
                                case 2: textFive = "Two"; break;
                                case 3: textFive = "Three"; break;
                                case 4: textFive = "Four"; break;
                                case 5: textFive = "Five"; break;
                                case 6: textFive = "Six"; break;
                                case 7: textFive = "Seven"; break;
                                case 8: textFive = "Eight"; break;
                                case 9: textFive = "Nine"; break;
                            }
                        }
                    }
                    return $"{textOne}{textTwo} {textThree} {textFour} {textFive}";
                }
            }
        }
    }
}
