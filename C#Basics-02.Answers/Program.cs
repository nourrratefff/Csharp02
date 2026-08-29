using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace C_Basics_02.Answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            object book = new Book();
            Console.WriteLine(book);


            //Question 2:

            string toString = book.ToString();

            Console.WriteLine(toString);

            bool compare = book.Equals(book);

            Console.WriteLine(compare);

            int hashCode = book.GetHashCode();

            Console.WriteLine(hashCode);

            Type type = book.GetType();

            Console.WriteLine(type);


            //Question 3:

            //Compile-time error. 


            //Question 4(Topic Hasnt been covered yet):
            try
            {
                int divisor = 0;
                int result = 10 / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot Divide By Zero.");
            }
            finally
            {
                Console.WriteLine("Done");
            }




        }

    }

    // Question 1: 

    class Book
    {
        string Title;
        int Pages;
    }


 










}



