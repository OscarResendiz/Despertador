using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
namespace DespertadorNET
{
    class KeyboardInterceptor : IDisposable
    {
        #region Public Properties
        public event KeyPressEventHandler KeyPress;
        public event KeyEventHandler KeyUp;
        public event KeyEventHandler KeyDown;
        #endregion

        #region Private Fields
        private LowLevelKeyboardProc proc;
        private IntPtr hookId = IntPtr.Zero;
        #endregion

        #region Public Constructor
        public KeyboardInterceptor()
        {
            proc = new LowLevelKeyboardProc(HookCallback);
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                hookId = WinApi.SetWindowsHookEx(WinApi.WH_KEYBOARD_LL, proc,
                    WinApi.GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        #endregion

        #region The callback method invoked when keys are pressed
        private IntPtr HookCallback(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
        {         
            int command = (int)wParam;
            bool handled = false;

            if (nCode >= 0)
            {
                if (KeyDown != null && (command == WinApi.WM_KEYDOWN || command == WinApi.WM_SYSKEYDOWN))
                {
                    KeyDown(this, new KeyEventArgs((Keys)lParam.vkCode));
                }

                if (KeyPress != null && command == WinApi.WM_KEYDOWN)
                {
                    bool shift = ((Keys.Shift & Control.ModifierKeys) == Keys.Shift);
                    bool caps = ((Keys.Capital & Control.ModifierKeys) == Keys.Capital);

                    byte[] keyState = new byte[256];
                    WinApi.GetKeyboardState(keyState);
                    byte[] inBuffer = new byte[2];
                    if (WinApi.ToAscii(lParam.vkCode, lParam.scanCode, keyState, inBuffer, lParam.flags) == 1)
                    {
                        char key = (char)inBuffer[0];
                        if ((caps ^ shift) && Char.IsLetter(key)) key = Char.ToUpper(key);

                        KeyPressEventArgs e = new KeyPressEventArgs(key);
                        KeyPress(this, e);
                    }
                }

                if (KeyUp != null && (command == WinApi.WM_KEYUP || command == WinApi.WM_SYSKEYUP))
                {
                    KeyUp(this, new KeyEventArgs((Keys)lParam.vkCode));
                }

            }

            return WinApi.CallNextHookEx(hookId, nCode, wParam, ref lParam);
        }
        #endregion


        #region IDisposable Members
        /// <summary>
        /// Releases the keyboard hook.
        /// </summary>
        public void Dispose()
        {
            WinApi.UnhookWindowsHookEx(hookId);
        }
        #endregion
    }
}
