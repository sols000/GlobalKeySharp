using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GlobalKeySharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void pfnKeyBoardEvent(uint KeyCode, bool bPressed);
    public class GlobalKeySharpApi
    {
        [DllImport("GlobalKeyboard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetGlobalKeyListner(IntPtr KeyCallBack);
    }
}
