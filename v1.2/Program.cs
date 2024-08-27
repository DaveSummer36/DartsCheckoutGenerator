using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.Title = "Darts Checkout Generator - v1.2 (developed by Dave Summer)";

        List<int> impossibleScores = new List<int> { 169, 168, 166, 165, 163, 162, 159 };
        HashSet<int> alreadyGenerated = new HashSet<int>();
        Random random = new Random();

        int checkoutScore = 0;
        int hit = 0;
        int miss = 0;
        char ifHit;

        for (int rounds = 1; rounds < 101; rounds++)
        {
            // Generate a valid random score
            do
            {
                checkoutScore = random.Next(2, 171);
            } while (impossibleScores.Contains(checkoutScore) || alreadyGenerated.Contains(checkoutScore));

            // Add the generated number to the set of generated checkouts
            alreadyGenerated.Add(checkoutScore);

            // Suggest checkout
            Console.WriteLine($"\n\nCheckout suggestion for {checkoutScore}:");
            SuggestCheckout(checkoutScore);

            if(checkoutScore < 41)
            {
                Console.WriteLine("Did you check out in 3 darts?");
                ifHit = Convert.ToChar(Console.ReadLine());

                if(ifHit == 'y')
                {
                    hit++;
                }

                else if(ifHit == 'n')
                {
                    miss++;
                }

                else
                {
                    Console.WriteLine("This is not a proper option! Try again!");
                    ifHit = Convert.ToChar(Console.ReadLine());

                    if (ifHit == 'y')
                    {
                        hit++;
                    }

                    else if (ifHit == 'n')
                    {
                        miss++;
                    }
                }
            }

            else if(checkoutScore > 40 && checkoutScore < 121)
            {
                Console.WriteLine("Did you checkout in 6 darts?");
                ifHit = Convert.ToChar(Console.ReadLine());

                if (ifHit == 'y')
                {
                    hit++;
                }

                else if (ifHit == 'n')
                {
                    miss++;
                }

                else
                {
                    Console.WriteLine("This is not a proper option! Try again!");
                    ifHit = Convert.ToChar(Console.ReadLine());

                    if (ifHit == 'y')
                    {
                        hit++;
                    }

                    else if (ifHit == 'n')
                    {
                        miss++;
                    }
                }
            }

            else if(checkoutScore > 120 && checkoutScore < 171)
            {
                Console.WriteLine("Did you checkout in 9 darts?");
                ifHit = Convert.ToChar(Console.ReadLine());

                if (ifHit == 'y')
                {
                    hit++;
                }

                else if (ifHit == 'n')
                {
                    miss++;
                }

                else
                {
                    Console.WriteLine("This is not a proper option! Try again!");
                    ifHit = Convert.ToChar(Console.ReadLine());

                    if (ifHit == 'y')
                    {
                        hit++;
                    }

                    else if (ifHit == 'n')
                    {
                        miss++;
                    }
                }
            }
        }

        Console.WriteLine("Rounds: 100 | hit: " + hit + " | missed: " + miss);

        ConsoleKeyInfo cki = new ConsoleKeyInfo();
        do
        {
            cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Escape);
    }

    static void SuggestCheckout(int number)
    {
        if (number > 170)
        {
            Console.WriteLine("No outshot possible!");
            return;
        }

        // Basic checkout suggestions
        if (number == 170)
            Console.WriteLine("T20, T20, Bull");
        else if (number == 167)
            Console.WriteLine("T20, T19, Bull");
        else if (number == 164)
            Console.WriteLine("T20, T18, Bull");
        else if (number == 161)
            Console.WriteLine("T20, T17, Bull");
        else if (number == 160)
            Console.WriteLine("T20, T20, D20");
        else if (number == 158)
            Console.WriteLine("T20, T20, D19");
        else if (number == 157)
            Console.WriteLine("T20, T19, D20");
        else if (number == 156)
            Console.WriteLine("T20, T20, D18");
        else if (number == 155)
            Console.WriteLine("T20, T19, D19");
        else if (number == 154)
            Console.WriteLine("T20, T18, D20");
        else if (number == 153)
            Console.WriteLine("T20, T19, D18");
        else if (number == 152)
            Console.WriteLine("T20, T20, D16");
        else if (number == 151)
            Console.WriteLine("T20, T17, D20");
        else if (number == 150)
            Console.WriteLine("T20, T18, D18");
        else if (number == 149)
            Console.WriteLine("T20, T19, D16");
        else if (number == 148)
            Console.WriteLine("T20, T20, D14");
        else if (number == 147)
            Console.WriteLine("T20, T17, D18");
        else if (number == 146)
            Console.WriteLine("T29, T19, D16");
        else if (number == 145)
            Console.WriteLine("T20, T15, D20");
        else if (number == 144)
            Console.WriteLine("T20, T20, D12");
        else if (number == 143)
            Console.WriteLine("T20, T17, D16");
        else if (number == 142)
            Console.WriteLine("T20, T14, D20");
        else if (number == 141)
            Console.WriteLine("T20, T19, D12");
        else if (number == 140)
            Console.WriteLine("T20, T20, D10");
        else if (number == 139)
            Console.WriteLine("T19, T14, D20");
        else if (number == 138)
            Console.WriteLine("T20, T18, D12");
        else if (number == 137)
            Console.WriteLine("T20, T19, D10");
        else if (number == 136)
            Console.WriteLine("T20, T20, D8");
        else if (number == 135)
            Console.WriteLine("Bull, T15, D20");
        else if (number == 134)
            Console.WriteLine("T20, T14, D16");
        else if (number == 133)
            Console.WriteLine("T20, T19, D8");
        else if (number == 132)
            Console.WriteLine("Bull, Bull, D16");
        else if (number == 131)
            Console.WriteLine("T19, T14, D16");
        else if (number == 130)
            Console.WriteLine("T20, T20, D5");
        else if (number == 129)
            Console.WriteLine("T19, T20, D6");
        else if (number == 128)
            Console.WriteLine("T18, T18, D10");
        else if (number == 127)
            Console.WriteLine("T20, T17, D8");
        else if (number == 126)
            Console.WriteLine("T19, T19, D6");
        else if (number == 125)
            Console.WriteLine("25, T20, D20");
        else if (number == 124)
            Console.WriteLine("T20, T14, D11");
        else if (number == 123)
            Console.WriteLine("T19, T16, D9");
        else if (number == 122)
            Console.WriteLine("T18, T18, D7");
        else if (number == 121)
            Console.WriteLine("T20, T11, D14");
        else if (number == 120)
            Console.WriteLine("T20, 20, D20");
        else if (number == 119)
            Console.WriteLine("T19, T12, D13");
        else if (number == 118)
            Console.WriteLine("T20, 18, D20");
        else if (number == 117)
            Console.WriteLine("T20, 17, D20");
        else if (number == 116)
            Console.WriteLine("T20, 16, D20");
        else if (number == 115)
            Console.WriteLine("T20, 15, D20");
        else if (number == 114)
            Console.WriteLine("T20, 14, D20");
        else if (number == 113)
            Console.WriteLine("T20, 17, D18");
        else if (number == 112)
            Console.WriteLine("T20, 20, D16");
        else if (number == 111)
            Console.WriteLine("T20, 19, D16");
        else if (number == 110)
            Console.WriteLine("T20, 18, D16");
        else if (number == 109)
            Console.WriteLine("T20, 17, D16");
        else if (number == 108)
            Console.WriteLine("T18, 18, D18");
        else if (number == 107)
            Console.WriteLine("T19, 18, D16");
        else if (number == 106)
            Console.WriteLine("T20, 10, D18");
        else if (number == 105)
            Console.WriteLine("T20, 13, D16");
        else if (number == 104)
            Console.WriteLine("T18, 18, D16");
        else if (number == 103)
            Console.WriteLine("T20, 3, D20");
        else if (number == 102)
            Console.WriteLine("T20, 10, D16");
        else if (number == 101)
            Console.WriteLine("T20, 1, D20");
        else if (number == 100)
            Console.WriteLine("T20, D20");
        else if (number == 99)
            Console.WriteLine("T19, 10, D16");
        else if (number == 98)
            Console.WriteLine("T20, D19");
        else if (number == 97)
            Console.WriteLine("T19, D20");
        else if (number == 96)
            Console.WriteLine("T20, D18");
        else if (number == 95)
            Console.WriteLine("T19, D19");
        else if (number == 94)
            Console.WriteLine("T18, D20");
        else if (number == 93)
            Console.WriteLine("T19, D18");
        else if (number == 92)
            Console.WriteLine("T20, D16");
        else if (number == 91)
            Console.WriteLine("T17, D20");
        else if (number == 90)
            Console.WriteLine("T18, D18");
        else if (number == 89)
            Console.WriteLine("T19, D16");
        else if (number == 88)
            Console.WriteLine("T16, D20");
        else if (number == 87)
            Console.WriteLine("T17, D18");
        else if (number == 86)
            Console.WriteLine("T18, D16");
        else if (number == 85)
            Console.WriteLine("T15, D20");
        else if (number == 84)
            Console.WriteLine("T20, D12");
        else if (number == 83)
            Console.WriteLine("T17, D16");
        else if (number == 82)
            Console.WriteLine("Bull, D16");
        else if (number == 81)
            Console.WriteLine("T15, D18");
        else if (number == 80)
            Console.WriteLine("T20, D10");
        else if (number == 79)
            Console.WriteLine("T19, D11");
        else if (number == 78)
            Console.WriteLine("T18, D12");
        else if (number == 77)
            Console.WriteLine("T19, D10");
        else if (number == 76)
            Console.WriteLine("T20, D8");
        else if (number == 75)
            Console.WriteLine("T17, D12");
        else if (number == 74)
            Console.WriteLine("T14, D16");
        else if (number == 73)
            Console.WriteLine("T19, D8");
        else if (number == 72)
            Console.WriteLine("T16, D12");
        else if (number == 71)
            Console.WriteLine("T13, D16");
        else if (number == 70)
            Console.WriteLine("T18, D8");
        else if (number == 69)
            Console.WriteLine("T19, D6");
        else if (number == 68)
            Console.WriteLine("T16, D10");
        else if (number == 67)
            Console.WriteLine("T17, D8");
        else if (number == 66)
            Console.WriteLine("T10, D18");
        else if (number == 65)
            Console.WriteLine("T19, D4");
        else if (number == 64)
            Console.WriteLine("T16, D8");
        else if (number == 63)
            Console.WriteLine("T13, D12");
        else if (number == 62)
            Console.WriteLine("T10, D16");
        else if (number == 61)
            Console.WriteLine("T15, D8");
        else if (number == 60)
            Console.WriteLine("20, D20");
        else if (number == 59)
            Console.WriteLine("19, D20");
        else if (number == 58)
            Console.WriteLine("18, D20");
        else if (number == 57)
            Console.WriteLine("17, D20");
        else if (number == 56)
            Console.WriteLine("16, D20");
        else if (number == 55)
            Console.WriteLine("15, D20");
        else if (number == 54)
            Console.WriteLine("14, D20");
        else if (number == 53)
            Console.WriteLine("13, D20");
        else if (number == 52)
            Console.WriteLine("20, D16");
        else if (number == 51)
            Console.WriteLine("19, D16");
        else if (number == 50)
            Console.WriteLine("18, D16");
        else if (number == 49)
            Console.WriteLine("17, D16");
        else if (number == 48)
            Console.WriteLine("16, D16");
        else if (number == 47)
            Console.WriteLine("15, D16");
        else if (number == 46)
            Console.WriteLine("14, D16");
        else if (number == 45)
            Console.WriteLine("13, D16");
        else if (number == 44)
            Console.WriteLine("12, D16");
        else if (number == 43)
            Console.WriteLine("11, D16");
        else if (number == 42)
            Console.WriteLine("10, D16");
        else if (number == 41)
            Console.WriteLine("9, D16");
        else if (number == 40)
            Console.WriteLine("D20");
        else if (number == 39)
            Console.WriteLine("7, D16");
        else if (number == 38)
            Console.WriteLine("D19");
        else if (number == 37)
            Console.WriteLine("5, D16");
        else if (number == 36)
            Console.WriteLine("D18");
        else if (number == 35)
            Console.WriteLine("3, D16");
        else if (number == 34)
            Console.WriteLine("D17");
        else if (number == 33)
            Console.WriteLine("1, D16");
        else if (number == 32)
            Console.WriteLine("D16");
        else if (number == 31)
            Console.WriteLine("15, D8");
        else if (number == 30)
            Console.WriteLine("D15");
        else if (number == 29)
            Console.WriteLine("13, D8");
        else if (number == 28)
            Console.WriteLine("D14");
        else if (number == 27)
            Console.WriteLine("11, D8");
        else if (number == 26)
            Console.WriteLine("D13");
        else if (number == 25)
            Console.WriteLine("9, D8");
        else if (number == 24)
            Console.WriteLine("D12");
        else if (number == 23)
            Console.WriteLine("7, D8");
        else if (number == 22)
            Console.WriteLine("D11");
        else if (number == 21)
            Console.WriteLine("5, D8");
        else if (number == 20)
            Console.WriteLine("D10");
        else if (number == 19)
            Console.WriteLine("3, D8");
        else if (number == 18)
            Console.WriteLine("D9");
        else if (number == 17)
            Console.WriteLine("1, D8");
        else if (number == 16)
            Console.WriteLine("D8");
        else if (number == 15)
            Console.WriteLine("7, D4");
        else if (number == 14)
            Console.WriteLine("D7");
        else if (number == 13)
            Console.WriteLine("5, D4");
        else if (number == 12)
            Console.WriteLine("D6");
        else if (number == 11)
            Console.WriteLine("3, D4");
        else if (number == 10)
            Console.WriteLine("D5");
        else if (number == 9)
            Console.WriteLine("1, D4");
        else if (number == 8)
            Console.WriteLine("D4");
        else if (number == 7)
            Console.WriteLine("3, D2");
        else if (number == 6)
            Console.WriteLine("D3");
        else if (number == 5)
            Console.WriteLine("1, D2");
        else if (number == 4)
            Console.WriteLine("D2");
        else if (number == 3)
            Console.WriteLine("1, D1");
        else if (number == 2)
            Console.WriteLine("D1");
    }
}
