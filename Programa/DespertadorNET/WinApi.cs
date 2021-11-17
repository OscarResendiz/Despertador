using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DespertadorNET
{
    #region Internal Structures and delegates definition Region
    /// <summary>
    /// The KBDLLHOOKSTRUCT structure contains information about a low-level 
    /// keyboard input event. 
    /// See: http://msdn.microsoft.com/en-us/library/ms644967(VS.85).aspx
    /// </summary>
    internal struct KBDLLHOOKSTRUCT
    {
        public int vkCode;      // Specifies a virtual-key code. The code must  
        // be avalue in the range 1 to 254. 
        public int scanCode;    // Specifies a hardware scan code for the key.
        public int flags;
        public int time;
        public int dwExtraInfo;
    }

    /// <summary>
    /// The LowLevelKeyboardProc hook procedure is an application-defined 
    /// or library-defined callback function used with the SetWindowsHookEx 
    /// function. The system calls this function every time a new keyboard 
    /// input event is about to be posted into a thread input queue.
    /// See: http://msdn.microsoft.com/en-us/library/ms644985(VS.85).aspx
    /// </summary>
    internal delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
    #endregion

    #region Internal WinApi class (Win32 api functions)
    /// <summary>
    /// This class define the WinApi signatures.
    /// See: PInvoke web site
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false),
     System.Security.SuppressUnmanagedCodeSecurity()]
    internal class WinApi
    {
        #region Constants
        // Constants
        // Windows NT/2000/XP: Installs a hook procedure that monitors low-level 
        // keyboard input events. For more information, see the 
        // LowLevelKeyboardProc hook procedure.
        internal const int WH_KEYBOARD_LL = 13;
        internal const int WM_KEYDOWN = 0x0100;
        internal const int WM_SYSKEYDOWN = 0x104;
        internal const int WM_KEYUP = 0x101;
        internal const int WM_SYSKEYUP = 0x105;

        //Modifier key constants
        internal const int VK_SHIFT = 0x010;
        internal const int VK_CONTROL = 0x011;
        internal const int VK_MENU = 0x012;
        internal const int VK_CAPITAL = 0x014;
        // Constantes para SetWindowsPos
        //   Valores de wFlags
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOACTIVATE = 0x10;
        const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;
        //   Valores de hwndInsertAfter
        const int HWND_TOPMOST = -1;
        const int HWND_NOTOPMOST = -2;
        #endregion

        #region DLL Imports Region
        /// <summary>
        /// The SetWindowsHookEx function installs an application-defined hook 
        /// procedure into a hook chain. You would install a hook procedure to 
        /// monitor the system for certain types of events. These events are 
        /// associated either with a specific thread or with all threads in the 
        /// same desktop as the calling thread.
        /// See: http://msdn.microsoft.com/en-us/library/ms644990(VS.85).aspx
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        /// <summary>
        /// The UnhookWindowsHookEx function removes a hook procedure installed 
        /// in a hook chain by the SetWindowsHookEx function. 
        /// See: http://msdn.microsoft.com/en-us/library/ms644993(VS.85).aspx
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

        /// <summary>
        /// The CallNextHookEx function passes the hook information to the next 
        /// hook procedure in the current hook chain. A hook procedure can call 
        /// this function either before or after processing the hook information.
        /// See: http://msdn.microsoft.com/en-us/library/ms644974(VS.85).aspx
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

        /// <summary>
        /// Retrieves a module handle for the specified module. The module must
        /// have been loaded by the calling process.
        /// See: http://msdn.microsoft.com/en-us/library/ms683199(VS.85).aspx
        /// </summary>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// The GetKeyboardState function copies the status of the 256 virtual 
        /// keys to the specified buffer. 
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern int GetKeyboardState(byte[] pbKeyState);

        /// <summary>
        /// The ToAscii function translates the specified virtual-key code and 
        /// keyboard state to the corresponding character or characters. The 
        /// function translates the code using the input language and physical 
        /// keyboard layout identified by the keyboard layout handle.
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern int ToAscii(int uVirtKey, int uScanCode,
            byte[] lpbKeyState, byte[] lpwTransKey, int fuState);
        //
        /// <summary>
        /// Para mantener la ventana siempre visible
        /// </summary>
        /// <remarks>No utilizamos el valor devuelto</remarks>
        [System.Runtime.InteropServices.DllImport("user32.DLL")]
        private extern static void SetWindowPos(int hWnd, int hWndInsertAfter,int X, int Y, int cx, int cy, int wFlags);
        #endregion
        public static void SiempreEncima(int handle)
        {
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags);
        }

        public static void NoSiempreEncima(int handle)
        {
            SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags);
        }
    }
    #endregion
}
