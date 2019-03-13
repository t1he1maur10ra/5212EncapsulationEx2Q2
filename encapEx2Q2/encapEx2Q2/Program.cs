using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapEx2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.Write("Please enter the students name: ");
            string name = Console.ReadLine();
            CheckString(name);
            Console.WriteLine("Complete");


        }

        static string CheckString(string input)
        {
            do
            {
                if(input == "" || input == null)
                {
                    Console.Write("You need to enter a name, please enter the students name: ");
                    input = Console.ReadLine();
                }

            } while (input == "");
            return input;
        }
    }

    class Student
    {
        /*Auto Properties*/
        public string Name { get; set; }
        public string Email { private get; set; }
        public string Address { private get; set; }
        public string ID { private get; set; }
        public string password; //{ private get; set; }
        public string Emergency { get; set; }
        public EmergencyContact Contact { get; set; }
        /*array to hold results*/
        int[] results = new int[4];

        public int[] Results
        {
            get { return results; }
            set { results = value; }
        }

        public string StudentInfo()
        {
            double average = 0;
            foreach (int x in Results)
                average += x;
            average = average / Results.Length;
            return $"Name: {Name}\nID: {ID}\nResult 1:{Results[0]}\nResult 2:{Results[1]}\nResult 3:{Results[2]}\nResult 4:{Results[3]}\nAverage: {average}";
        }

    }
    public class EmergencyContact
    {
        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
