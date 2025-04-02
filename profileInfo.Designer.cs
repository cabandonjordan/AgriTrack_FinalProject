namespace AgriTrack_FinalProject
{
    partial class profileInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileInfo));
            profilePic = new PictureBox();
            label1 = new Label();
            uploadPhoto = new Button();
            label2 = new Label();
            profUsername = new TextBox();
            profEmail = new TextBox();
            label3 = new Label();
            profNum = new TextBox();
            profNumber = new Label();
            profName = new TextBox();
            label5 = new Label();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
            // 
            // profilePic
            // 
            profilePic.BackColor = Color.LightGray;
            profilePic.Image = (Image)resources.GetObject("profilePic.Image");
            profilePic.Location = new Point(28, 40);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(208, 196);
            profilePic.SizeMode = PictureBoxSizeMode.Zoom;
            profilePic.TabIndex = 0;
            profilePic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // uploadPhoto
            // 
            uploadPhoto.BackColor = Color.LightGray;
            uploadPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadPhoto.Location = new Point(65, 242);
            uploadPhoto.Name = "uploadPhoto";
            uploadPhoto.Size = new Size(128, 39);
            uploadPhoto.TabIndex = 2;
            uploadPhoto.Text = "Upload Photo";
            uploadPhoto.UseVisualStyleBackColor = false;
            uploadPhoto.Click += uploadPhoto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 124);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // profUsername
            // 
            profUsername.BackColor = Color.LightGray;
            profUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profUsername.Location = new Point(280, 152);
            profUsername.Name = "profUsername";
            profUsername.Size = new Size(456, 33);
            profUsername.TabIndex = 4;
            // 
            // profEmail
            // 
            profEmail.BackColor = Color.LightGray;
            profEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profEmail.Location = new Point(280, 242);
            profEmail.Name = "profEmail";
            profEmail.Size = new Size(456, 33);
            profEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 214);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // profNum
            // 
            profNum.BackColor = Color.LightGray;
            profNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profNum.Location = new Point(280, 323);
            profNum.Name = "profNum";
            profNum.Size = new Size(456, 33);
            profNum.TabIndex = 8;
            // 
            // profNumber
            // 
            profNumber.AutoSize = true;
            profNumber.BackColor = Color.LightGray;
            profNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profNumber.Location = new Point(280, 295);
            profNumber.Name = "profNumber";
            profNumber.Size = new Size(86, 25);
            profNumber.TabIndex = 7;
            profNumber.Text = "Number";
            // 
            // profName
            // 
            profName.BackColor = Color.LightGray;
            profName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profName.Location = new Point(280, 68);
            profName.Name = "profName";
            profName.Size = new Size(456, 33);
            profName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(280, 40);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // save
            // 
            save.BackColor = Color.LightGray;
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(65, 323);
            save.Name = "save";
            save.Size = new Size(128, 39);
            save.TabIndex = 12;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // profileInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(save);
            Controls.Add(profName);
            Controls.Add(label5);
            Controls.Add(profNum);
            Controls.Add(profNumber);
            Controls.Add(profEmail);
            Controls.Add(label3);
            Controls.Add(profUsername);
            Controls.Add(label2);
            Controls.Add(uploadPhoto);
            Controls.Add(label1);
            Controls.Add(profilePic);
            Name = "profileInfo";
            Size = new Size(902, 440);
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profilePic;
        private Label label1;
        private Button uploadPhoto;
        private Label label2;
        private TextBox profUsername;
        private TextBox profEmail;
        private Label label3;
        private TextBox profNum;
        private Label profNumber;
        private TextBox profName;
        private Label label5;
        private Button save;
    }
}
