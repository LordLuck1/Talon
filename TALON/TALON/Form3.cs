using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace TALON
{
    public partial class Form3 : Form
    {

        string conn_string = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=TALON;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();

            groupBox1.AllowDrop = true;

            label1.Text = "Талон на питание";
            label1.Size = new System.Drawing.Size(230, 30);
            label1.Location = new Point(50, 40);

            label6.Text = "Подпись";
            label6.Size = new System.Drawing.Size(100, 25);
            label6.Location = new Point(150, 250);

            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;

            Number.Text = "Номер";
            Number.ForeColor = Color.Gray;
            Names.Text = "Название";
            Names.ForeColor = Color.Gray;
            Data.Text = "Дата";
            Data.ForeColor = Color.Gray;
            Signature.Text = "Подпись";
            Signature.ForeColor = Color.Gray;
        }
        bool isDown;
        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();
            Pd.PrintPage += printDocument1_PrintPage;
            ppd.Document = Pd;
            ppd.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cmd_text;
            cmd_text = "INSERT INTO [Talon](Number,Names,Data,Signature) VALUES ('" + Number.Text + "' , '" + Names.Text + "' , '" + Data.Text + "' , '" + Signature.Text + "')";
            // создать соединение с базой данных
            SqlConnection sql_conn = new SqlConnection(conn_string);
            // создать команду на языке SQL
            SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);
            sql_conn.Open(); // открыть соединение
            sql_comm.ExecuteNonQuery(); // выполнить команду на языке SQL
            sql_conn.Close(); // закрыть соединение   
            this.talonTableAdapter1.Fill(this.talonDataSet1.Talon);
            MessageBox.Show("Данные сохранены!","Успешно!");
        }
        private void Number_TextChanged(object sender, EventArgs e)
        {
            
            label2.Text = Number.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Точно удалить?", "Внимание!"))
            {
                
            }
            label2.Location = new Point(30, 75);
            label2.Text = null;
            Number.Clear();
            label3.Location = new Point(30, 150);
            label3.Text = null;
            Names.Clear();
            label4.Location = new Point(30, 200);
            label4.Text = null;
            Data.Clear();
            label5.Location = new Point(30, 250);
            label5.Text = null;
            Signature.Clear();
            pictureBox1.Image = null;
        }

        private void Names_TextChanged(object sender, EventArgs e)
        {
            label3.Text=Names.Text;
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {
            label4.Text=Data.Text;
        }

        private void Signature_TextChanged(object sender, EventArgs e)
        {
            label5.Text=Signature.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.talonTableAdapter1.Fill(this.talonDataSet1.Talon);

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Location = new Point(128, 75);
            label2.Text = "№2999";
            label3.Location = new Point(30, 150);
            label3.Text = "ООО Спутник";
            label4.Location = new Point(30, 200);
            label4.Text = "23.09.2020";
            label5.Location = new Point(230, 250);
            label5.Text = "ПР@";

            pictureBox1.Image = Properties.Resources.img1;
        }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Location = new Point(130, 75);
            label2.Text = "№332";
            label3.Location = new Point(30, 150);
            label3.Text = "АОО Энергия";
            label4.Location = new Point(30, 200);
            label4.Text = "09.06.2023";
            label5.Location = new Point(230, 250);
            label5.Text = "Губ.У@";

            pictureBox1.Image = Properties.Resources.img2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Location = new Point(130, 75);
            label2.Text = "№1";
            label3.Location = new Point(30, 150);
            label3.Text = "ГАПОУ КГПТ";
            label4.Location = new Point(30, 200);
            label4.Text = "20.06.2023";
            label5.Location = new Point(230, 250);
            label5.Text = "Диплом@";

            pictureBox1.Image = Properties.Resources.img3;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Green;
            button2.BringToFront();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Green;
            button3.BringToFront();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void Number_Enter(object sender, EventArgs e)
        {
            if (Number.Text == "Номер")
            {
                Number.Text = "";
                Number.ForeColor = Color.Black;
            }
        }

        private void Number_Leave(object sender, EventArgs e)
        {
            if (Number.Text == "")
                Number.Text = "Номер";
            Number.ForeColor = Color.Gray;
        }

        private void Names_Enter(object sender, EventArgs e)
        {
            if (Names.Text == "Название")
            {
                Names.Text = "";
                Names.ForeColor = Color.Black;
            }
        }

        private void Names_Leave(object sender, EventArgs e)
        {
            if (Names.Text == "")
                Names.Text = "Название";
            Names.ForeColor = Color.Gray;
        }

        private void Data_Enter(object sender, EventArgs e)
        {
            if (Data.Text == "Дата")
            {
                Data.Text = "";
                Data.ForeColor = Color.Black;
            }
        }

        private void Data_Leave(object sender, EventArgs e)
        {
            if (Data.Text == "")
                Data.Text = "Дата";
            Data.ForeColor = Color.Gray;
        }

        private void Signature_Enter(object sender, EventArgs e)
        {
            if (Signature.Text == "Подпись")
            {
                Signature.Text = "";
                Signature.ForeColor = Color.Black;
            }
        }

        private void Signature_Leave(object sender, EventArgs e)
        {
            if (Signature.Text == "")
                Signature.Text = "Подпись";
            Signature.ForeColor = Color.Gray;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }
    }
}

