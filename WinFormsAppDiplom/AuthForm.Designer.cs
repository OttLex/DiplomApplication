namespace WinFormsAppDiplom
{
    partial class AuthForm
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
            this.AuthLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuthButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthLabel
            // 
            this.AuthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthLabel.Location = new System.Drawing.Point(97, 43);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(257, 19);
            this.AuthLabel.TabIndex = 0;
            this.AuthLabel.Text = "Введите имя пользователя и пароль.";
            this.AuthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTextBox.Location = new System.Drawing.Point(97, 89);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PlaceholderText = "Имя пользователя";
            this.UserNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.AuthButton);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.AuthLabel);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Location = new System.Drawing.Point(191, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 273);
            this.panel1.TabIndex = 2;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(159, 207);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(135, 39);
            this.AuthButton.TabIndex = 3;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(99, 125);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderText = "Пароль";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthForm_KeyUp);
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthForm_KeyUp);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AuthLabel;
        private TextBox UserNameTextBox;
        private Panel panel1;
        private TextBox PasswordTextBox;
        private Button AuthButton;
    }
}