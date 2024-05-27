using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_CustomMainWindow
{
    internal class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern bool GetMonitorInfo(nint hMonitor, MONITORINFO lpmi);

        [DllImport("user32.dll")]
        internal static extern nint MonitorFromWindow(nint hWnd, int flags);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    { public int x; public int y; }

    [StructLayout(LayoutKind.Sequential)]
    public struct MINMAXINFO
    {
        public POINT ptReserved;
        public POINT ptMaxSize;
        public POINT ptMaxPosition;
        public POINT ptMinTrackSize;
        public POINT ptMinTrackPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class MONITORINFO
    {
        public int cbSize = Marshal.SizeOf(typeof(MINMAXINFO));
        public RECT rcMonitor = new RECT();
        public RECT rcWork = new RECT();
        public int dwFlags = 0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
}
