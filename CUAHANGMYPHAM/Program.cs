using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CUAHANGMYPHAM;

namespace CUAHANGMYPHAM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            // Mở form đăng nhập trước
            frmDangNhap loginForm = new frmDangNhap();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmHome()); // Nếu đăng nhập thành công, mở form chính
            }
        }
        #region 
        public static class UserSession
        {
            public static string Username { get; set; }
            public static string Role { get; set; }
            public static DateTime LoginTime { get; set; }

            // Hàm kiểm tra xem có ai đã đăng nhập chưa
            public static bool IsLoggedIn()
            {
                return !string.IsNullOrEmpty(Username);
            }

            // Hàm reset khi đăng xuất
            public static void Logout()
            {
                Username = null;
                Role = null;
                LoginTime = DateTime.MinValue;
            }
        }
            #endregion
        }
}
