using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Книга_рецептов
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                AuthService.EnsureDefaultUsers();

                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Form1 (loginForm.UserRole));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка запуска программы: " + ex.Message
                );
            }
        }
    }
}
