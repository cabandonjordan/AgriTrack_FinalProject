namespace AgriTrack_FinalProject
{
    partial class ForgotPassword
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
            components = new System.ComponentModel.Container();
            backButton = new Button();
            label1 = new Label();
            emailPass = new TextBox();
            confirmOTP = new Button();
            otp1 = new TextBox();
            sendEmail = new Button();
            label2 = new Label();
            label3 = new Label();
            resendOTP = new LinkLabel();
            timerOTP = new System.Windows.Forms.Timer(components);
            otp2 = new TextBox();
            otp3 = new TextBox();
            otp4 = new TextBox();
            otp5 = new TextBox();
            otp6 = new TextBox();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.Custom_Icon_Design_Mono_General_1_Back;
            backButton.Location = new Point(335, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(68, 33);
            backButton.TabIndex = 1;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 58);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 2;
            label1.Text = "Forget Password";
            // 
            // emailPass
            // 
            emailPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailPass.Location = new Point(28, 152);
            emailPass.Name = "emailPass";
            emailPass.Size = new Size(330, 39);
            emailPass.TabIndex = 3;
            // 
            // confirmOTP
            // 
            confirmOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmOTP.Location = new Point(141, 427);
            confirmOTP.Name = "confirmOTP";
            confirmOTP.Size = new Size(82, 39);
            confirmOTP.TabIndex = 4;
            confirmOTP.Text = "Confirm";
            confirmOTP.UseVisualStyleBackColor = true;
            confirmOTP.Click += confirmOTP_Click;
            // 
            // otp1
            // 
            otp1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp1.Location = new Point(28, 365);
            otp1.Name = "otp1";
            otp1.Size = new Size(50, 43);
            otp1.TabIndex = 5;
            otp1.TextAlign = HorizontalAlignment.Center;
            // 
            // sendEmail
            // 
            sendEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendEmail.Location = new Point(141, 197);
            sendEmail.Name = "sendEmail";
            sendEmail.Size = new Size(82, 39);
            sendEmail.TabIndex = 6;
            sendEmail.Text = "Send";
            sendEmail.UseVisualStyleBackColor = true;
            sendEmail.Click += sendEmail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 110);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 7;
            label2.Text = "Enter your email address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 326);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 8;
            label3.Text = "Enter OTP number";
            // 
            // resendOTP
            // 
            resendOTP.AutoSize = true;
            resendOTP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resendOTP.Location = new Point(116, 239);
            resendOTP.Name = "resendOTP";
            resendOTP.Size = new Size(130, 21);
            resendOTP.TabIndex = 10;
            resendOTP.TabStop = true;
            resendOTP.Text = "Resend OTP code";
            resendOTP.LinkClicked += resendOTP_LinkClicked;
            // 
            // timerOTP
            // 
            timerOTP.Tick += timerOTP_Tick;
            // 
            // otp2
            // 
            otp2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp2.Location = new Point(84, 365);
            otp2.Name = "otp2";
            otp2.Size = new Size(50, 43);
            otp2.TabIndex = 11;
            otp2.TextAlign = HorizontalAlignment.Center;
            // 
            // otp3
            // 
            otp3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp3.Location = new Point(140, 365);
            otp3.Name = "otp3";
            otp3.Size = new Size(50, 43);
            otp3.TabIndex = 12;
            otp3.TextAlign = HorizontalAlignment.Center;
            // 
            // otp4
            // 
            otp4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp4.Location = new Point(196, 365);
            otp4.Name = "otp4";
            otp4.Size = new Size(50, 43);
            otp4.TabIndex = 13;
            otp4.TextAlign = HorizontalAlignment.Center;
            // 
            // otp5
            // 
            otp5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp5.Location = new Point(252, 365);
            otp5.Name = "otp5";
            otp5.Size = new Size(50, 43);
            otp5.TabIndex = 14;
            otp5.TextAlign = HorizontalAlignment.Center;
            // 
            // otp6
            // 
            otp6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otp6.Location = new Point(308, 365);
            otp6.Name = "otp6";
            otp6.Size = new Size(50, 43);
            otp6.TabIndex = 15;
            otp6.TextAlign = HorizontalAlignment.Center;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(otp6);
            Controls.Add(otp5);
            Controls.Add(otp4);
            Controls.Add(otp3);
            Controls.Add(otp2);
            Controls.Add(resendOTP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sendEmail);
            Controls.Add(otp1);
            Controls.Add(confirmOTP);
            Controls.Add(emailPass);
            Controls.Add(label1);
            Controls.Add(backButton);
            Name = "ForgotPassword";
            Size = new Size(403, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label1;
        private TextBox emailPass;
        private Button confirmOTP;
        private TextBox otp1;
        private Button sendEmail;
        private Label label2;
        private Label label3;
        private LinkLabel resendOTP;
        private System.Windows.Forms.Timer timerOTP;
        private TextBox otp2;
        private TextBox otp3;
        private TextBox otp4;
        private TextBox otp5;
        private TextBox otp6;
    }
}
