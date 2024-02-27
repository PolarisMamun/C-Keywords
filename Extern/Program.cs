using System;
using System.Runtime.InteropServices;

namespace Extern
{
    public class Program
    {
        /*the extern keyword is used to declare a method that is implemented externally. This is typically used when interfacing with unmanaged code, such as a C or C++ library. The extern keyword is used to specify the calling convention used by the method.
         */

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hwd, String text, String caption, int opitons);
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello, World!", "Hello",2);
        }

        /*
         * In this example, the MessageBox function is declared as extern and is imported from the user32.dll library. The DllImport attribute is used to specify the name of the DLL and the name of the function to import. The extern keyword is used to indicate that the method is implemented externally.
         */
    }
}
