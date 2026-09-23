using System;
using System.Windows.Forms;

namespace DijkstraTest2
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi động ứng dụng WinForms.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // chạy Form1
        }
    }
}



