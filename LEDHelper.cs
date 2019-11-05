using System;
using System.Drawing;
using Hasee_z7m_kp7gc_LEDConfig.USBHelper;

namespace Hasee_z7m_kp7gc_LEDConfig
{
    public static class LEDHelper
    {
        /// <summary>
        /// 修改键盘灯颜色
        /// </summary>
        /// <param name="index">灯位(1~4)</param>
        /// <param name="color">颜色</param>
        public static void ModifyColor(byte index, Color color)
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

        /// <summary>
        /// 修改键盘灯亮度
        /// </summary>
        /// <param name="brightness">颜色 (0~32)</param>
        public static void ModifyBrightness(byte brightness)
        {
            if (brightness < 0 || brightness > 32) throw new Exception("亮度范围为0~32!");
            var te = CUSB._EnumPorts_(0x048D, 0xCE00);
            var data = new byte[] { 0x08, 0x02, 0x01, 0x05, brightness, 0x08, 0x00, 0x00 };
            var m_usb = new CUSB();
            byte b = 0;
            foreach (var t in te)
            {
                m_usb.Open(t);
                m_usb.CmdWrite(data, ref b);
                m_usb.Close();
            }
        }

        /// <summary>
        /// 关闭键盘灯
        /// </summary>
        public static void CloseLED()
        {
            var te = CUSB._EnumPorts_(0x048D, 0xCE00);
            var data = new byte[] { 0x08, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            var m_usb = new CUSB();
            byte b = 0;
            foreach (var t in te)
            {
                m_usb.Open(t);
                m_usb.CmdWrite(data, ref b);
                m_usb.Close();
            }
        }
    }
}