namespace My_program
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerLable = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonregister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.registerLable);
            this.panel1.Controls.Add(this.userSurnameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonregister);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // registerLable
            // 
            resources.ApplyResources(this.registerLable, "registerLable");
            this.registerLable.Name = "registerLable";
            this.registerLable.Click += new System.EventHandler(this.registerLable_Click);
            this.registerLable.MouseEnter += new System.EventHandler(this.registerLable_MouseEnter);
            this.registerLable.MouseLeave += new System.EventHandler(this.registerLable_MouseLeave);
            // 
            // userSurnameField
            // 
            resources.ApplyResources(this.userSurnameField, "userSurnameField");
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            resources.ApplyResources(this.userNameField, "userNameField");
            this.userNameField.Name = "userNameField";
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonregister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.buttonregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.buttonregister, "buttonregister");
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // passField
            // 
            resources.ApplyResources(this.passField, "passField");
            this.passField.Name = "passField";
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passField_KeyDown);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::My_program.Properties.Resources.user;
            this.pictureBox2.Image = global::My_program.Properties.Resources._lock;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            resources.ApplyResources(this.loginField, "loginField");
            this.loginField.Name = "loginField";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_program.Properties.Resources.user;
            this.pictureBox1.Image = global::My_program.Properties.Resources.user1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(43)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.Close_button);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Close_button
            // 
            resources.ApplyResources(this.Close_button, "Close_button");
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.ForeColor = System.Drawing.Color.Red;
            this.Close_button.Name = "Close_button";
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseEnter += new System.EventHandler(this.Close_button_MouseEnter);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label registerLable;
    }
}