using System;

namespace RefreshIcon
{
    internal partial class Program
    {
        [System.Runtime.InteropServices.LibraryImport("Shell32.dll")]
        private static partial int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

        static void Main()
        {
            SHChangeNotify(0x8000000, 0x0000, IntPtr.Zero, IntPtr.Zero); 
        }
    }
}
