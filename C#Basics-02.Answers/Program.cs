using System.Runtime.InteropServices;

namespace C_Basics_02.Answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object book = new Book();
            Console.WriteLine(book);

            string toString = book.ToString();

            Console.WriteLine(toString);

            bool compare = book.Equals(book);

            Console.WriteLine(compare);

            int hashCode = book.GetHashCode();

            Console.WriteLine(hashCode);

            Type type = book.GetType();

            Console.WriteLine(type);



            



        }

    }


    class Book
    {
        string Title;
        int Pages;
    }


}
