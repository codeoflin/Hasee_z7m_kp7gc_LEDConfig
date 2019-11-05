using System;
using System.Drawing;
using Hasee_z7m_kp7gc_LEDConfig.USBHelper;

namespace Hasee_z7m_kp7gc_LEDConfig
{
    class Program
    {
        static void Main(string[] args)
        {
			//修改键盘4个颜色区
            LEDHelper.ModifyColor(1, Color.LightPink);
			LEDHelper.ModifyColor(2, Color.Blue);
			LEDHelper.ModifyColor(3, Color.Green);
			LEDHelper.ModifyColor(4, Color.Red);
            LEDHelper.ModifyBrightness(32);
            Console.WriteLine("Hello World!");
        }
    }
}
