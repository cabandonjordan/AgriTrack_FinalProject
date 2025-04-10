namespace AgriTrack_FinalProject
{
    partial class HarvestLogs
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
            harvestGrid = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)harvestGrid).BeginInit();
            SuspendLayout();
            // 
            // harvestGrid
            // 
            harvestGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            harvestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            harvestGrid.Dock = DockStyle.Right;
            harvestGrid.Location = new Point(329, 0);
            harvestGrid.Name = "harvestGrid";
            harvestGrid.Size = new Size(573, 440);
            harvestGrid.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(15, 373);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // HarvestLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(harvestGrid);
            Name = "HarvestLogs";
            Size = new Size(902, 440);
            ((System.ComponentModel.ISupportInitialize)harvestGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView harvestGrid;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}
