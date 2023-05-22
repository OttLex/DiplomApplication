using DataAccessLayer;
using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDiplom
{
    public partial class AuthForm : Form
    {
        private string _connectionString;
        private AuthQuery _authQuerys;
        public AuthForm(string connString)
        {
            _connectionString = connString;
            _authQuerys = new AuthQuery(connString);

            using (var context = new AppDBContext(_connectionString))
            {
                context.Database.EnsureCreated();
            }

            InitializeComponent();

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void Auth()
        {
            var result = _authQuerys.GetUser(UserNameTextBox.Text, PasswordTextBox.Text);
            if (result != null)
            {
                this.Hide();
                new MainForm(_connectionString, result).Show();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации! Не верный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AuthForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Auth();
            }
        }
    }
}
