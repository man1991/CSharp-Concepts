using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class clsDispose_safe
    {
        // Take a flag to check if object is already disposed
        bool bDisposed = false;

        // Create a object of SafeHandle class
        SafeHandle objSafeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Dispose method (public)
        public void Dispose1()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Dispose method (protected)
        protected virtual void Dispose(bool bDispose)
        {
            if (bDisposed)
                return;

            if (bDispose)
            {
                objSafeHandle.Dispose();
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            //
            bDisposed = true;
        }
    }
    class clsDispose_Fin
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose1(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose1(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~clsDispose_Fin()
        {
            Dispose1(false);
        }
    }
    class testClass : IDisposable
    {
        public void Dispose()
        {
            // Dispose objects here
            // clean resources
            Console.WriteLine(0);
        }
    }

    //call class
    class Program
    {
        static void Main()
        {
            // Use using statement with class that implements Dispose.
            using (testClass objClass = new testClass())
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(2);
        }
    }
}

//output
//1
//0
//2

//it is same as below TRY...Finally code
//{
//    clsDispose_Fin objClass = new clsDispose_Fin();
//    try
//    {
//        //code goes here 
//    }
//    finally
//    {
//        if (objClass != null)
//        ((IDisposable)objClass).Dispose();
//    }
//}
//}
