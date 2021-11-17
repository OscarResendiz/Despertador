using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DespertadorNET
{
    class CMonitor
    {
        int WM_SYSCOMMAND = 0x112;
        int SC_MONITORPOWER = 0xF170;
        IntPtr Handle;
        public CMonitor(IntPtr handle)
        {
            Handle = handle;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessageLVFIND(IntPtr hWnd, int msg, int iStart, int plvfi);
        public void ApagaMonitor()
        {
            SendMessageLVFIND(Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
        public void Enciende()
        {
            SendMessageLVFIND(Handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }
    }
}
