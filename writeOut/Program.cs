using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace writeOut
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n***********Write out ********\n");
            //NAME THE .TXT FILE
            Console.Write("\nPlease name the .txt file you're writting out: ");
            string filename = Console.ReadLine(); 


            string firstName, surname, city, answer;

            //CREATE THE FILE PATH
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + filename+".txt";
            
            //LOOP UNTIL NO MORE RECORDS
            do
            {
                Console.Write("\nEnter first name: ");
                firstName = Console.ReadLine();
                Console.Write("\nEnter surname: ");
                surname = Console.ReadLine();
                Console.Write("\nEnter city: ");
                city = Console.ReadLine();
                Console.Write("\n\nWould You like to continue? Y or N:");
                answer = Console.ReadLine().ToLower();
                StreamWriter sw = File.AppendText(filepath);
                sw.Write($"Firstname: {firstName}, ");
                sw.Write($"Surname: {surname}, ");
                sw.Write($"City: {city}.");
                sw.Write("\n");
                sw.Close();

            } while (answer == "y");


            Console.WriteLine("\nFile saved!");
            Console.ReadLine();
        }
    }
}
