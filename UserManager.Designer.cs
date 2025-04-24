namespace AgriTrack_FinalProject
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            userGrid = new DataGridView();
            fullName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            email = new TextBox();
            label4 = new Label();
            phoneNum = new TextBox();
            userType = new Label();
            profilePics = new PictureBox();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePics).BeginInit();
            SuspendLayout();
            // 
            // userGrid
            // 
            userGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Location = new Point(307, 14);
            userGrid.Name = "userGrid";
            userGrid.ReadOnly = true;
            userGrid.Size = new Size(562, 410);
            userGrid.TabIndex = 0;
            userGrid.CellContentClick += userGrid_CellContentClick;
            // 
            // fullName
            // 
            fullName.Font = new Font("Segoe UI", 12F);
            fullName.Location = new Point(34, 189);
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            fullName.Size = new Size(220, 29);
            fullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 165);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 243);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 12F);
            email.Location = new Point(34, 267);
            email.Name = "email";
            email.ReadOnly = true;
            email.Size = new Size(220, 29);
            email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 320);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 8;
            label4.Text = "Phone Number";
            // 
            // phoneNum
            // 
            phoneNum.Font = new Font("Segoe UI", 12F);
            phoneNum.Location = new Point(34, 344);
            phoneNum.Name = "phoneNum";
            phoneNum.ReadOnly = true;
            phoneNum.Size = new Size(220, 29);
            phoneNum.TabIndex = 7;
            // 
            // userType
            // 
            userType.AutoSize = true;
            userType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userType.Location = new Point(34, 14);
            userType.Name = "userType";
            userType.Size = new Size(76, 21);
            userType.TabIndex = 9;
            userType.Text = "UserType";
            // 
            // profilePics
            // 
            profilePics.Image = (Image)resources.GetObject("profilePics.Image");
            profilePics.Location = new Point(73, 51);
            profilePics.Name = "profilePics";
            profilePics.Size = new Size(136, 100);
            profilePics.SizeMode = PictureBoxSizeMode.Zoom;
            profilePics.TabIndex = 10;
            profilePics.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(129, 389);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(125, 35);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(deleteBtn);
            Controls.Add(profilePics);
            Controls.Add(userType);
            Controls.Add(label4);
            Controls.Add(phoneNum);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(fullName);
            Controls.Add(userGrid);
            DoubleBuffered = true;
            Name = "UserManager";
            Size = new Size(902, 438);
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userGrid;
        private TextBox fullName;
        private Label label1;
        private Label label3;
        private TextBox email;
        private Label label4;
        private TextBox phoneNum;
        private Label userType;
        private PictureBox profilePics;
        private Button deleteBtn;
    }
}
