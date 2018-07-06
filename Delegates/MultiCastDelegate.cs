using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void RectDelegate(double Width, double Height);

    class MultiCastDelegate
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area Of Rectangle:" + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter Of Rectangle:" + 2 * (Width + Height));
        }
        static void Main()
        {

            MultiCastDelegate rect = new MultiCastDelegate();
            //RectDelegate obj = new RectDelegate(rect.GetArea);
            RectDelegate obj = rect.GetArea;//optional way to declare delegate without Constructor.
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);
            Console.WriteLine();
            obj.Invoke(47.87, 34.89);
            //rect.GetArea(12.34, 56.78);
            //rect.GetPerimeter(12.34, 56.78);
            Console.ReadLine();
        }
    }
}
