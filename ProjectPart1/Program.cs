using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //part2
            //int max = int.MinValue;
            //int number;
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Write a number");
            //    number = Int32.Parse(Console.ReadLine());
            // //here the ternary also could have been used
            //    max = Math.Max(max, number);
            //}

            //Console.WriteLine(string.Format("The max number is {0}", max));

            //if (number>0 && number<11)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");

            //part 3
            //Console.WriteLine("Write a number");
            //int number31 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Write a number");
            //int number32 = Int32.Parse(Console.ReadLine());

            //if (number31==number32)
            //    Console.WriteLine("portrat");
            //else
            //{
            //    Console.WriteLine("Landscape");
            //}

            //part 4
            //Console.WriteLine("Insert the speed limit");
            //int speedLimit = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Insert the car limit");
            //int carLimit = Int32.Parse(Console.ReadLine());
            //if (carLimit<= speedLimit)
            //    Console.WriteLine("Ok");
            //else
            //{
            //    //here don't use magic numbers define the number 5 as a constant
            //    int fine = (carLimit-speedLimit) / 5;
            //    if (fine>12)
            //        Console.WriteLine("License Suspended");
            //    else
            //        Console.WriteLine(string.Format("taken points {0}", fine));
            //}

            //part 2-1
            //int count = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}
            //Console.WriteLine(count);

            //part 2-2
            //string stop = "";
            //int number;
            //int sum = 0;
            //while (stop != "ok")
            //{
            //    Console.WriteLine("Enter a number:");
            //    string line = Console.ReadLine();

            //    if (line == "ok")
            //        break;
            //    else
            //    {
            //        number = Convert.ToInt32(line);
            //        sum += number;
            //    }

            //}
            //Console.WriteLine(sum);

            //part 2-3
            //too easy no need to do it

            //part 2-4
            //Random randNumber = new Random();
            //int rand = randNumber.Next(1,10);
            //Console.WriteLine(rand);
            //int number;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("write a number:");
            //    number = Int32.Parse(Console.ReadLine());
            //    if (number == rand)
            //        Console.WriteLine("You Won");
            //        break;
            //    else
            //    {
            //        Console.WriteLine("you lost");
            //    }
            //}

            //part 2-5
            //Console.WriteLine("Insert several numbers splitted by comma");
            //string line = Console.ReadLine();
            //string[] lineSplitted=line.Split(',');
            //int max = Int32.MinValue;

            //foreach(var number in lineSplitted) {
            //    max = Math.Max(max, Int32.Parse(number));
            //}
            //Console.WriteLine(max); 

            //Arrays and lists -----------------------
            //part 1
            //var namesList = new List<string>();
            //var line = "value";
            //while (line != "")
            //{
            //    Console.WriteLine("Inser a name:");
            //    line = Console.ReadLine();
            //    if (line != "")
            //        namesList.Add(line);
            //}

            //switch (namesList.Count)
            //{
            //    case 0:
            //        Console.WriteLine("No names were inserted");
            //        break;
            //    case 1:
            //        Console.WriteLine(namesList[0] + " liked your post");
            //        break;
            //    case 2:
            //        Console.WriteLine(namesList[0]+","+namesList[1] + " liked your post");
            //        break;
            //    default:
            //        Console.WriteLine(namesList[0]+", "+namesList[1]+"and other "+(namesList.Count-2).ToString()+" like your post");
            //        break;
            //}

            //part 2

            //Console.WriteLine("Inser a name");
            //string name = Console.ReadLine();

            //var charName = new char[name.Length];
            //for (int i = 0; i < name.Length; i++)
            //{
            //    charName[i] = name[name.Length-i-1];
            //}

            //Console.WriteLine(charName);

            //part3
            //too common doesnt make sense to do it

            //part 4
            //var numbersList = new List<int>() { 1,1,2,3,4,5,5,7,8};
            //foreach(var unique in numbersList.Distinct())
            //{
            //    Console.WriteLine(unique);
            //}

            //part 5
            Console.WriteLine("write a list: ");
            string listNumber = Console.ReadLine();
            
            if(listNumber.Length==0 || listNumber.Length < 6)
                Console.WriteLine("Invalid list try again");
            else
            {
                var stringList = listNumber.Split(',').Select(Int32.Parse).ToList();
                stringList.Sort();
                foreach (var number in stringList)
                {
                    Console.WriteLine(number);
                }
                
            }
            

            
        }
    }
}
