using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALON
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Users.Text = "Введите Имя";
            Users.ForeColor = Color.Gray;
            Login.Text = "Введите Логин";
            Login.ForeColor = Color.Gray;
            Password.Text = "Введите Пароль";
            Password.ForeColor = Color.Gray;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Users.Text == "" || Users.Text == "Введите Имя" || Login.Text == "" | Login.Text == "Введите Логин" || Password.Text == "" || Password.Text == "Введите Пароль")
            {
                MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=TALON;Integrated Security=True");
                con.Open();
                String str = ("insert into [Avtorize](Users,Login,Password) values ('"+ Users.Text + "' ,'" + Login.Text + "' , '" + Password.Text + "')");
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Зарегистрирован!", "Успешно!");
                Form2.ActiveForm.Hide();
                Form1 MyForm1 = new Form1();
                MyForm1.ShowDialog();
                Close();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Bitmap b;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b = new Bitmap(pictureBox1.Image);
                string colorcontrol = b.GetPixel(0, 0).ToString();
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        if (b.GetPixel(i, j).ToString() != colorcontrol)
                            b.SetPixel(i, j, colorDialog1.Color);

                    }
                }
                pictureBox1.Image = b;
            }
        }

        private void Users_Enter(object sender, EventArgs e)
        {
            if (Users.Text == "Введите Имя")
            {
                Users.Text = "";
                Users.ForeColor = Color.Black;
            }
        }

        private void Users_Leave(object sender, EventArgs e)
        {
            if (Users.Text == "")
                Users.Text = "Введите Имя";
            Users.ForeColor = Color.Gray;
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

        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
                Password.Text = "Введите Пароль";
            Password.ForeColor = Color.Gray;
        }

        
    }
}
