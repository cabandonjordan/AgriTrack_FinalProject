using System.ComponentModel;
namespace AgriTrack_FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTop = new Panel();
            closeBtn = new Button();
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            panelRight = new Panel();
            aboutUs = new Button();
            label4 = new Label();
            createAcc = new Button();
            loginBtn = new Button();
            showPass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            userName = new TextBox();
            label1 = new Label();
            forgotPass = new LinkLabel();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(closeBtn);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(847, 40);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
            // 
            // closeBtn
            // 
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(784, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(63, 40);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 40);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(444, 565);
            panelLeft.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 565);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(forgotPass);
            panelRight.Controls.Add(aboutUs);
            panelRight.Controls.Add(label4);
            panelRight.Controls.Add(createAcc);
            panelRight.Controls.Add(loginBtn);
            panelRight.Controls.Add(showPass);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(password);
            panelRight.Controls.Add(userName);
            panelRight.Controls.Add(label1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(444, 40);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(403, 565);
            panelRight.TabIndex = 2;
            // 
            // aboutUs
            // 
            aboutUs.FlatAppearance.BorderSize = 0;
            aboutUs.FlatStyle = FlatStyle.Flat;
            aboutUs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutUs.Image = (Image)resources.GetObject("aboutUs.Image");
            aboutUs.ImageAlign = ContentAlignment.MiddleLeft;
            aboutUs.Location = new Point(139, 468);
            aboutUs.Name = "aboutUs";
            aboutUs.Size = new Size(112, 44);
            aboutUs.TabIndex = 13;
            aboutUs.Text = "      about us";
            aboutUs.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 409);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 9;
            label4.Text = "Not Registered?";
            // 
            // createAcc
            // 
            createAcc.FlatAppearance.BorderSize = 0;
            createAcc.FlatAppearance.MouseDownBackColor = Color.White;
            createAcc.FlatAppearance.MouseOverBackColor = Color.Lavender;
            createAcc.FlatStyle = FlatStyle.Flat;
            createAcc.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            createAcc.ForeColor = Color.Blue;
            createAcc.Location = new Point(209, 404);
            createAcc.Name = "createAcc";
            createAcc.Size = new Size(129, 31);
            createAcc.TabIndex = 8;
            createAcc.Text = "Create Account";
            createAcc.UseVisualStyleBackColor = true;
            createAcc.Click += createAcc_Click;
            // 
            // loginBtn
            // 
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.White;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Image = (Image)resources.GetObject("loginBtn.Image");
            loginBtn.Location = new Point(71, 316);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(232, 62);
            loginBtn.TabIndex = 7;
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.Location = new Point(71, 277);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 6;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 212);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(71, 236);
            password.Name = "password";
            password.PasswordChar = '•';
            password.Size = new Size(274, 35);
            password.TabIndex = 2;
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(71, 150);
            userName.Name = "userName";
            userName.Size = new Size(274, 35);
            userName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign in";
            // 
            // forgotPass
            // 
            forgotPass.AutoSize = true;
            forgotPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPass.Location = new Point(245, 278);
            forgotPass.Name = "forgotPass";
            forgotPass.Size = new Size(100, 15);
            forgotPass.TabIndex = 14;
            forgotPass.TabStop = true;
            forgotPass.Text = "Forgot password?";
            forgotPass.LinkClicked += forgotPass_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 605);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button closeBtn;
        private Panel panelLeft;
        private Panel panelRight;
        private Label label1;
        private TextBox password;
        private TextBox userName;
        private CheckBox showPass;
        private Label label3;
        private Label label2;
        private Button loginBtn;
        private Label label4;
        private Button createAcc;
        private PictureBox pictureBox1;
        private Button aboutUs;
        private LinkLabel forgotPass;
    }
}
