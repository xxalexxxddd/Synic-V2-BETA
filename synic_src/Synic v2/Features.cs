using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Synic_v2.Properties;

namespace Synic_v2
{
    public class Features
    {
        #region DllImports

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString,
            int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.Cdecl)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        static extern long GetClassName(IntPtr hwnd, StringBuilder lpClassName, long nMaxCount);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);


        #endregion

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public class Macro
        {
            public static void SetCursorPosition(int x, int y)
            {
                SetCursorPos(x, y);
            }

            public static void SetCursorPosition(MousePoint point)
            {
                SetCursorPos(point.X, point.Y);
            }

            public static MousePoint GetCursorPosition()
            {
                MousePoint currentMousePoint;
                var gotPoint = GetCursorPos(out currentMousePoint);
                if (!gotPoint)
                {
                    currentMousePoint = new MousePoint(0, 0);
                }

                return currentMousePoint;
            }

            public static void MouseEvent(MouseEventFlags value)
            {
                MousePoint position = GetCursorPosition();

                mouse_event
                ((int) value,
                    position.X,
                    position.Y,
                    0,
                    0);
            }

            private static bool enabled = false;
            private static int interval = 1000 / 13;
            private static bool rmb = false;

            public static void enableClicking()
            {
                enabled = true;
            }

            public static void disableClicking()
            {
                enabled = false;
            }

            public static bool isEnabled()
            {
                return enabled;
            }

            public static void setInterval(int i)
            {
                interval = i;
            }

            public static int getInterval()
            {
                return interval;
            }

            public static void enableRMB()
            {
                rmb = true;
            }

            public static void disableRMB()
            {
                rmb = false;
            }

            public static bool isRMB()
            {
                return rmb;
            }


            public static async void AutoClick()
            {
                while (true)
                {
                    if (enabled)
                    {
                        if (!rmb)
                        {
                            MouseEvent(MouseEventFlags.LeftDown);
                            await Task.Delay(1);
                            MouseEvent(MouseEventFlags.LeftUp);
                            await Task.Delay(interval - 49);
                        }
                        else
                        {
                            MouseEvent(MouseEventFlags.RightDown);
                            await Task.Delay(1);
                            MouseEvent(MouseEventFlags.RightUp);
                            await Task.Delay(interval - 49);
                        }

                        await Task.Delay(1);
                    }
                }
            }
        }

        public class Binds
        {
            public static void FishingRod()
            {
                Macro.MouseEvent(MouseEventFlags.RightDown);
                Thread.Sleep(1);
                Macro.MouseEvent(MouseEventFlags.RightUp);
                Thread.Sleep(20);
                Macro.MouseEvent(MouseEventFlags.RightDown);
                Thread.Sleep(1);
                Macro.MouseEvent(MouseEventFlags.RightUp);

            }

            public static void Punch()
            {
                Macro.MouseEvent(MouseEventFlags.RightDown);
                Thread.Sleep(150);
                Macro.MouseEvent(MouseEventFlags.RightUp);
            }

            private static bool bindingArmor = false;
            public static void startbindingArmor() { bindingArmor = true; }
            public static void stopbindingArmor() { bindingArmor = false; }
            public static bool isbindingArmor() { return bindingArmor; }

            public static async void bindingArmorAsync()
            {
                while (true)
                {
                    if (bindingArmor)
                    {
                        
                    }
                }
            }

            public static void ChangeArmor()
            {
                Macro.MouseEvent(MouseEventFlags.LeftDown);
                Thread.Sleep(2);
                Macro.MouseEvent(MouseEventFlags.LeftUp);
            }
        }

        public class Mining
        {
            private static bool mining = false;
            public static void startMining() { mining = true; }
            public static void stopMining() { mining = false; }
            public static bool isMining() { return mining; }

            public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
            public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
            public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

            public static async void SendKey(byte VK_KEYCODE, int interval = 20)
            {
                keybd_event(VK_KEYCODE, 0, KEYEVENTF_KEYDOWN, 0);
                await Task.Delay(interval);
                keybd_event(VK_KEYCODE, 0, KEYEVENTF_KEYUP, 0);
            }

            public static async void Mine()
            {
                while (true)
                {
                    if (mining)
                    {
                        for (int i = 10; i < 1 ; i--) {
                            Macro.MouseEvent(MouseEventFlags.LeftDown);
                            await Task.Delay(50);
                            SendKey(0x44, 5 * 250);
                            await Task.Delay(50);
                            SendKey(0x53, 250);
                            await Task.Delay(50);
                            SendKey(0x41, 5 * 250);
                            await Task.Delay(50);
                            SendKey(0x57, 250);
                            await Task.Delay(50);
                            Macro.MouseEvent(MouseEventFlags.LeftUp);
                        }
                    }
                }
            }
        }
    }
}