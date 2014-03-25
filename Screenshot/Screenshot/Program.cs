using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Screenshot
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Chup_" + DateTime.Now.ToString("ddMMyyyyhhmmtt");
            try
            {
                Console.WriteLine("Chup man hinh, nhan OK");
                Console.Read();
                ScreenCapturer.CaptureAndSave(fileName);
                Console.WriteLine("Da chup: C:\\temp\\" + fileName + ".png");
                
                logErr("Da chup: C:\\temp\\" + fileName + ".png");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }            
        }
        static void logErr(string str)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string logPath = path + "\\Info-TC7.txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter(logPath, true);
            file.WriteLine(str);
            file.Close();
            file.Dispose();
        }
    }
}
