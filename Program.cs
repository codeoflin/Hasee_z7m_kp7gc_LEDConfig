using System;
using System.Drawing;
using Hasee_z7m_kp7gc_LEDConfig.USBHelper;

namespace Hasee_z7m_kp7gc_LEDConfig
{
    class Program
    {
		/// <summary>
		/// 修改键盘灯颜色
		/// </summary>
		/// <param name="index">灯位(1~4)</param>
		/// <param name="color">颜色</param>
        static void ModifyColor(byte index, Color color)
        {
            if (index <= 0 || index > 4) throw new Exception("这款键盘只有4个颜色区!");
            var te = CUSB._EnumPorts_(0x048D, 0xCE00);
            var data = new byte[] { 0x14, 0x00, index, color.R, color.G, color.B, 0x00, 0x00 };
            var m_usb = new CUSB();
            byte b = 0;
            foreach (var t in te)
            {
                m_usb.Open(t);
                m_usb.CmdWrite(data, ref b);
                m_usb.Close();
            }
        }

        static void Main(string[] args)
        {
			//修改键盘4个颜色区
            ModifyColor(1, Color.LightPink);
			ModifyColor(2, Color.Blue);
			ModifyColor(3, Color.Green);
			ModifyColor(4, Color.Red);
            Console.WriteLine("Hello World!");
        }
    }
}
