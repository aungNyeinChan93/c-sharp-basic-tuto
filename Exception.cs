using System.Collections.Generic;
using System.Text;
using System;

namespace ConsoleApp2
{
    internal class Exception
    {

        public static void Main()
        {
            Test();
        }

        public static void Test()
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err?.Message);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine(err?.Message);
            }
            catch (OverflowException err)
            {
                Console.WriteLine("Overflow Exception");
                Console.WriteLine(err?.Message);
            }
            catch (System.Exception err)
            {
                Console.WriteLine($"Err -> {err?.Message}");
            }
            finally
            {
                Console.WriteLine("End");
            }
        }


    }


}
