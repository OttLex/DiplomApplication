using DataAccessLayer;
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
            InitializeComponent();
            _connectionString = connString;
            _authQuerys = new AuthQuery(connString);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
           var result= _authQuerys.GetUser(UserNameTextBox.Text, PasswordTextBox.Text);
            if (result != null)
            {
                new MainForm(_connectionString, result).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации! Не верный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
