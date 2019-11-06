using System;
using System.Drawing;
using Hasee_z7m_kp7gc_LEDConfig.USBHelper;

namespace Hasee_z7m_kp7gc_LEDConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            //关闭LED
            LEDHelper.CloseLED();
			//修改4个颜色区
            LEDHelper.ModifyColor(1, Color.Blue);
			LEDHelper.ModifyColor(2, Color.Blue);
			LEDHelper.ModifyColor(3, Color.Blue);
			LEDHelper.ModifyColor(4, Color.Aqua);
            //修改亮度(0~32)
            LEDHelper.ModifyBrightness(32);
            Console.WriteLine("Hello World!");
        }
    }
}
