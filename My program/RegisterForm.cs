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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введіть ім'я";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введіть прізвище";
            userSurnameField.ForeColor = Color.Gray;
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

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.ForeColor = Color.Yellow;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.ForeColor = Color.Red;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я")
            {
                userNameField.Text = string.Empty;
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == string.Empty)
            {
                userNameField.Text = "Введіть ім'я";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введіть прізвище")
            {
                userSurnameField.Text = string.Empty;
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == string.Empty)
            {
                userSurnameField.Text = "Введіть прізвище";
                userSurnameField.ForeColor = Color.Gray;
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

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я"
                || passField.Text == "Введіть пароль"
                || userSurnameField.Text == "Введіть прізвище"
                || loginField.Text == "Введіть логін")
            {
                MessageBox.Show("Не всі поля заповнені!!!");
                return;
            }
            
            DB db = new DB();
            if (!db.CheckConnection())
            {
                MessageBox.Show("Немає зв'язку з базою даних");
                return;
            }

            if (isUserExists())
                return;
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)",  db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт був створений");
            else
                MessageBox.Show("Аккаунт не був створений");

            db.closeConnection();
        }


        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий логін вже використовується");
                return true;
            }
            else
                return false;
        }

        private void registerLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
                buttonregister.PerformClick();
            }
        }
    }
}
