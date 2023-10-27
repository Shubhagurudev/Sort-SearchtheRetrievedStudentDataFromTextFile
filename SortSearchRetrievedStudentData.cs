using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataSortSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            string path = @"C:\Users\shubh\source\repos\StudentsDataToSortandSearch.txt";
                        
            List<string> readText = new List<string>(File.ReadAllLines(path));

            readText.ForEach((line) => Console.WriteLine(line));

            List<string> s = readText.ToList();
            
            s.Sort();

            Console.WriteLine("*******************************");
            Console.WriteLine("Students data After Sorted");

            foreach (var line in s)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n Enter student name to search student by name:");

            for (int i = 0; i < 100; i++)
            {
                string SearchedStudent = Console.ReadLine();

                foreach (var StudentInList in s)
                {

                    if (SearchedStudent == StudentInList)
                    {
                        Console.WriteLine($"\n The Student {SearchedStudent}  you are searching is present in the class 10");
                    }


                }
            }

           


            Console.ReadLine(); 

        }
    }
}
