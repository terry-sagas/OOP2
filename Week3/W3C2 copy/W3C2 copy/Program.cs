using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3C2_copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentId = new int[3];
            string[] studentName = new string[3];
            string[] studentEmail = new string[3];

            for (int i = 0; i < studentId.Length; i++)
            {
                string value;
                Console.Write("Please enter id for student " + (i+1).ToString() + ": ");
                value = Console.ReadLine();

                int id;
                if (int.TryParse(value, out id))
                {
                    studentId[i] = id;
                }
                else
                {
                    Console.WriteLine("student id must be a number please try again");
                    i--;
                    continue;
                }
                Console.Write("please enter name for student " + (i+1).ToString() + ": ");
                value = Console.ReadLine();
                studentName[i] = value;

                Console.Write("please enter email for student " + (i+1).ToString() + ": ");
                value = Console.ReadLine();
                studentEmail[i] = value;
            }
            Console.Write("Thank you for the data\n");
            

            for (int i = 0; i < studentId.Length; i++)
            {
                Console.WriteLine("\tStudent " + (i+1).ToString() + " information:");
                Console.WriteLine("\tID: " + studentId[i].ToString());
                Console.WriteLine("\tName: " + studentName[i].ToString());
                Console.WriteLine("\tEmail: " + studentEmail[i].ToString());



            }
            
            Console.ReadLine();
        }
    }
}
