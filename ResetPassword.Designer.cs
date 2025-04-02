namespace AgriTrack_FinalProject
{
    partial class ResetPassword
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
            label1 = new Label();
            newPass = new TextBox();
            resetPass = new Button();
            label2 = new Label();
            label4 = new Label();
            confirmPass = new TextBox();
            showPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 63);
            label1.Name = "label1";
            label1.Size = new Size(296, 32);
            label1.TabIndex = 0;
            label1.Text = "Reset account password";
            // 
            // newPass
            // 
            newPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            newPass.Location = new Point(48, 226);
            newPass.Name = "newPass";
            newPass.PasswordChar = '•';
            newPass.Size = new Size(296, 35);
            newPass.TabIndex = 1;
            // 
            // resetPass
            // 
            resetPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            resetPass.Location = new Point(85, 398);
            resetPass.Name = "resetPass";
            resetPass.Size = new Size(205, 43);
            resetPass.TabIndex = 2;
            resetPass.Text = "Reset Password";
            resetPass.UseVisualStyleBackColor = true;
            resetPass.Click += resetPass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(48, 193);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 3;
            label2.Text = "New password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(48, 277);
            label4.Name = "label4";
            label4.Size = new Size(191, 30);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // confirmPass
            // 
            confirmPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            confirmPass.Location = new Point(48, 310);
            confirmPass.Name = "confirmPass";
            confirmPass.PasswordChar = '•';
            confirmPass.Size = new Size(296, 35);
            confirmPass.TabIndex = 6;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(48, 351);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 7;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showPass);
            Controls.Add(confirmPass);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(resetPass);
            Controls.Add(newPass);
            Controls.Add(label1);
            Name = "ResetPassword";
            Size = new Size(403, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox newPass;
        private Button resetPass;
        private Label label2;
        private Label label4;
        private TextBox confirmPass;
        private CheckBox showPass;
    }
}
