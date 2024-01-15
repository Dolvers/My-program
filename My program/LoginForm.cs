using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_program
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new System.Drawing.Size(this.loginField.Size.Width, this.loginField.Size.Height);
            loginField.Text = "Введіть логін";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введіть пароль";
            passField.ForeColor = Color.Gray;
            passField.UseSystemPasswordChar = false;
        }
       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += passField_KeyDown;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.ForeColor = Color.Yellow;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            if (!db.CheckConnection())
            {
                MessageBox.Show("Немає зв'язку з базою даних");
                return;
            }

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string query = "SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP";

            using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
            {
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForms mainForm = new MainForms();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Ви не Увійшли");
                }
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == string.Empty)
            {
                loginField.Text = "Введіть логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введіть пароль")
            {
                passField.UseSystemPasswordChar = true;
                passField.Text = string.Empty;
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == string.Empty)
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введіть пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void registerLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLable_MouseEnter(object sender, EventArgs e)
        {
            registerLable.ForeColor = Color.Gray;
        }

        private void registerLable_MouseLeave(object sender, EventArgs e)
        {
            registerLable.ForeColor = Color.Black;
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonlogin.PerformClick();
            }
        }
    }
}
