namespace AgriTrack_FinalProject
{
    partial class CreateAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backButton = new Button();
            label1 = new Label();
            userRole = new ReaLTaiizor.Controls.PoisonComboBox();
            createUser = new TextBox();
            nameTxt = new TextBox();
            label2 = new Label();
            createPass = new TextBox();
            label3 = new Label();
            confirmPass = new TextBox();
            label4 = new Label();
            signUpBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            label5 = new Label();
            phoneNum = new TextBox();
            label6 = new Label();
            showPass = new CheckBox();
            label7 = new Label();
            signInBtn = new Button();
            emailTxt = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.Custom_Icon_Design_Mono_General_1_Back;
            backButton.Location = new Point(335, 16);
            backButton.Name = "backButton";
            backButton.Size = new Size(68, 33);
            backButton.TabIndex = 0;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // userRole
            // 
            userRole.FormattingEnabled = true;
            userRole.ItemHeight = 23;
            userRole.Items.AddRange(new object[] { "Farmer", "Customer" });
            userRole.Location = new Point(41, 425);
            userRole.Name = "userRole";
            userRole.PromptText = "User";
            userRole.Size = new Size(307, 29);
            userRole.TabIndex = 6;
            userRole.Text = "User";
            userRole.UseSelectable = true;
            // 
            // createUser
            // 
            createUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createUser.Location = new Point(41, 64);
            createUser.Name = "createUser";
            createUser.Size = new Size(307, 33);
            createUser.TabIndex = 7;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(41, 120);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(307, 33);
            nameTxt.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 100);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // createPass
            // 
            createPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPass.Location = new Point(41, 288);
            createPass.Name = "createPass";
            createPass.PasswordChar = '•';
            createPass.Size = new Size(307, 33);
            createPass.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 268);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // confirmPass
            // 
            confirmPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPass.Location = new Point(41, 344);
            confirmPass.Name = "confirmPass";
            confirmPass.PasswordChar = '•';
            confirmPass.Size = new Size(307, 33);
            confirmPass.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 324);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 12;
            label4.Text = "Confirm Password";
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(192, 255, 192);
            signUpBtn.BorderColor = Color.FromArgb(220, 223, 230);
            signUpBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            signUpBtn.DangerColor = Color.FromArgb(245, 108, 108);
            signUpBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            signUpBtn.Font = new Font("Segoe UI", 12F);
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.HoverTextColor = Color.Black;
            signUpBtn.InfoColor = Color.FromArgb(64, 64, 64);
            signUpBtn.Location = new Point(41, 472);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.PrimaryColor = Color.FromArgb(0, 192, 0);
            signUpBtn.Size = new Size(307, 40);
            signUpBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            signUpBtn.TabIndex = 14;
            signUpBtn.Text = "Sign Up";
            signUpBtn.TextColor = Color.White;
            signUpBtn.WarningColor = Color.FromArgb(230, 162, 60);
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 405);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 15;
            label5.Text = "User Role";
            // 
            // phoneNum
            // 
            phoneNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNum.Location = new Point(41, 232);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(307, 33);
            phoneNum.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 212);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 16;
            label6.Text = "Phone Number";
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.Location = new Point(41, 383);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 18;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 523);
            label7.Name = "label7";
            label7.Size = new Size(186, 21);
            label7.TabIndex = 20;
            label7.Text = "Already have an account?";
            // 
            // signInBtn
            // 
            signInBtn.FlatAppearance.BorderSize = 0;
            signInBtn.FlatAppearance.MouseDownBackColor = Color.White;
            signInBtn.FlatAppearance.MouseOverBackColor = Color.Lavender;
            signInBtn.FlatStyle = FlatStyle.Flat;
            signInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            signInBtn.ForeColor = Color.Blue;
            signInBtn.Location = new Point(245, 518);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(70, 31);
            signInBtn.TabIndex = 21;
            signInBtn.Text = "Sign in";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(41, 176);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(307, 33);
            emailTxt.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 156);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 22;
            label8.Text = "Email";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(emailTxt);
            Controls.Add(label8);
            Controls.Add(signInBtn);
            Controls.Add(label7);
            Controls.Add(showPass);
            Controls.Add(phoneNum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(signUpBtn);
            Controls.Add(confirmPass);
            Controls.Add(label4);
            Controls.Add(createPass);
            Controls.Add(label3);
            Controls.Add(nameTxt);
            Controls.Add(label2);
            Controls.Add(createUser);
            Controls.Add(userRole);
            Controls.Add(label1);
            Controls.Add(backButton);
            Name = "CreateAccount";
            Size = new Size(403, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonComboBox userRole;
        private TextBox createUser;
        private TextBox nameTxt;
        private Label label2;
        private TextBox createPass;
        private Label label3;
        private TextBox confirmPass;
        private Label label4;
        private ReaLTaiizor.Controls.HopeRoundButton signUpBtn;
        private Label label5;
        private TextBox phoneNum;
        private Label label6;
        private CheckBox showPass;
        private Label label7;
        private Button signInBtn;
        private TextBox emailTxt;
        private Label label8;
    }
}
