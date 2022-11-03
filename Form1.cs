using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{   
    public partial class Form1 : Form
    {
        Point p;
        string[] Login;
        string[] Pass;
        bool logged = false;
        public Form1()
        {
            InitializeComponent();
            Login = new string[0];
            Pass = new string[0];
            button_VXOD.Visible = false;
            button_back.Visible = false;
            Prof.Visible = false;
            comboBox1.Visible = false;
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Name_TextBox.Text = "";
            Pass_TextBox.Text = "";
            button_Registr.Visible = false;
            button_VXOD.Visible = true;
            label3.Visible = true;
            button_back.Visible = false;
            button_back.Visible = true;
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = false;
            int id = Array.IndexOf(Login, Name_TextBox.Text);
            if (Login.Length > 0)
            {
                if (id == -1)
                {
                    Array.Resize(ref Login, Login.Length + 1);
                    Array.Resize(ref Pass, Pass.Length + 1);
                    Login[Login.Length - 1] = Name_TextBox.Text;
                    Pass[Pass.Length - 1] = Pass_TextBox.Text;
                    f = true;
                }
                else
                {
                    MessageBox.Show("Кривой логин");
                }
            }
            else
            {
                Array.Resize(ref Login, Login.Length + 1);
                Array.Resize(ref Pass, Pass.Length + 1);
                Login[Login.Length - 1] = Name_TextBox.Text;
                Pass[Pass.Length - 1] = Pass_TextBox.Text;
                f = true;
            }
            if(f)
            {
                button_Registr.Visible = false;
                button_VXOD.Visible = true;
                label3.Visible = false;
                button_back.Visible = true;
                Name_TextBox.Text = "";
                Pass_TextBox.Text = "";
            }
        }

        private void button_VXOD_Click(object sender, EventArgs e)
        {           
            int id = Array.IndexOf(Login, Name_TextBox.Text);
            if (id != -1)
            {
                if (Pass[id] == Pass_TextBox.Text)
                {
                    MessageBox.Show("Вы вошли как " + Name_TextBox.Text);
                    logged = true;
                    button_back.Visible = true;
                    button_Registr.Visible = false;
                    button_VXOD.Visible = false;
                    label3.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label4.Visible = false;
                    Pass_TextBox.Visible = false;
                    Name_TextBox.Visible = false;
                    Prof.Visible = true;
                    comboBox1.Visible = true;
                }
                else
                    MessageBox.Show("Кривой логин или пароль.");
            }
            else
                MessageBox.Show("Кривой логин.");

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            button_back.Visible = false;
            button_Registr.Visible = true;
            button_VXOD.Visible = false;
            label3.Visible=true;
            label3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            Pass_TextBox.Visible = true;
            Name_TextBox.Visible = true;
            Name_TextBox.Text = "";
            Pass_TextBox.Text = "";
            Prof.Visible = false;
            comboBox1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Pass_TextBox.UseSystemPasswordChar)
                Pass_TextBox.UseSystemPasswordChar = false;
            else
                Pass_TextBox.UseSystemPasswordChar = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
