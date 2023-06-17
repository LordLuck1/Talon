using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALON
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
            Login.Text = "Введите Логин";
            Login.ForeColor = Color.Gray;
            Password.Text = "Введите Пароль";
            Password.ForeColor = Color.Gray;

            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
            button1.BringToFront();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите Логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
                Login.Text = "Введите Логин";
            Login.ForeColor = Color.Gray;
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Введите Пароль")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                
            }
            Password.PasswordChar = '*';

        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
                Password.Text = "Введите Пароль";
            Password.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text == "" | Login.Text == "Введите Логин" || Password.Text == "" || Password.Text == "Введите Пароль")
            {
                MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=TALON;Integrated Security=True");
                try
                {
                    string comand = string.Format("SELECT * FROM Avtorize WHERE Login = '" + Login.Text + "' AND Password = '" + Password.Text + "';");
                    SqlCommand cheak = new SqlCommand(comand, con);
                    con.Open();

                    if (cheak.ExecuteScalar() != null)
                    {
                        Form1.ActiveForm.Hide();
                        Form3 MyForm3 = new Form3();
                        MyForm3.ShowDialog();
                        Close();
                    }

                    else
                    {
                        MessageBox.Show("Неправильный Логин или Пароль!", "Попробуйте ещё раз!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally { }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
