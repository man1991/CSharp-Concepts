using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st Number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd Number");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.WriteLine("The result is:" + z);
            }
            catch (DivideByZeroException ex1)//SystemEmxception
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)//SystemEmxception
            {
                Console.WriteLine("Input Must Be Numeric");
            }
            catch (Exception ex)//SystemEmxception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("End Of the program.");
        }//End Method
    }//End Class
}
