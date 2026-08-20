namespace LoginUpdate
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
            IDtb = new TextBox();
            Nametb = new TextBox();
            Agetb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // IDtb
            // 
            IDtb.Location = new Point(501, 49);
            IDtb.Name = "IDtb";
            IDtb.Size = new Size(202, 27);
            IDtb.TabIndex = 0;
            IDtb.TextChanged += textBox1_TextChanged;
            // 
            // Nametb
            // 
            Nametb.Location = new Point(501, 126);
            Nametb.Name = "Nametb";
            Nametb.Size = new Size(202, 27);
            Nametb.TabIndex = 1;
            // 
            // Agetb
            // 
            Agetb.Location = new Point(501, 202);
            Agetb.Name = "Agetb";
            Agetb.Size = new Size(202, 27);
            Agetb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 31);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 4;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(426, 196);
            label3.Name = "label3";
            label3.Size = new Size(56, 31);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(382, 235);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(482, 235);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(582, 235);
            button3.Name = "button3";
            button3.Size = new Size(93, 37);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Menu;
            button4.Location = new Point(682, 235);
            button4.Name = "button4";
            button4.Size = new Size(93, 37);
            button4.TabIndex = 9;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(100, 179);
            label4.Name = "label4";
            label4.Size = new Size(219, 33);
            label4.TabIndex = 10;
            label4.Text = "Classic System";
            label4.Click += label4_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(379, 143);
            dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(222, 341);
            label5.Name = "label5";
            label5.Size = new Size(154, 33);
            label5.TabIndex = 12;
            label5.Text = "Search result";
            label5.Click += label5_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(59, 393);
            button5.Name = "button5";
            button5.Size = new Size(93, 37);
            button5.TabIndex = 13;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(795, 442);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Agetb);
            Controls.Add(Nametb);
            Controls.Add(IDtb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDtb;
        private TextBox Nametb;
        private TextBox Agetb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button5;
    }
}
