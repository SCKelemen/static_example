using System;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    // We can call hello here, because it's static
           // We dont need an instance to invoke the method
	    Console.WriteLine(Example.Hello()); 

	    // here we need an instance because the method is not static
            Example example = new Example();
	    Console.WriteLine(example.Goodbye());
        }
    }

    class Example {
      public static string Hello() {
	return "Hello";
      }

      public string Goodbye() {
	return "Goodbye";
      }
    }


}



