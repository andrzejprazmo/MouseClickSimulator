using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseClickSimulator
{
    public class MouseClickProcessor
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public void SetPointer(FormData formData)
        {
            SetCursorPos(formData.MouseX, formData.MouseY);
        }
        public void LeftMouseClick(FormData formData)
        {
            SetPointer(formData);
            mouse_event(MOUSEEVENTF_LEFTDOWN, formData.MouseX, formData.MouseY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, formData.MouseX, formData.MouseY, 0, 0);
        }
    }
}
