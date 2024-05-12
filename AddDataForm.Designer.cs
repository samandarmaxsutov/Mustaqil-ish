namespace Elektronika
{
    partial class AddDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFirmaNomi = new TextBox();
            textBoxBatareyaQuvvati = new TextBox();
            textBoxIshlabChiqSana = new TextBox();
            textBoxXotiraXajmi = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button3 = new Button();
            label8 = new Label();
            textBoxNomi = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(221, 21);
            label1.Name = "label1";
            label1.Size = new Size(258, 31);
            label1.TabIndex = 0;
            label1.Text = "Elektronika qo'shish";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.Location = new Point(33, 149);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 1;
            label2.Text = "Firma nomi";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.Location = new Point(33, 197);
            label3.Name = "label3";
            label3.Size = new Size(187, 26);
            label3.TabIndex = 2;
            label3.Text = "Batareya quvvati";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label4.Location = new Point(33, 258);
            label4.Name = "label4";
            label4.Size = new Size(205, 52);
            label4.TabIndex = 3;
            label4.Text = "Ishlab chiqarilgan \r\nsana";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label5.Location = new Point(33, 344);
            label5.Name = "label5";
            label5.Size = new Size(142, 26);
            label5.TabIndex = 4;
            label5.Text = "Xotira xajmi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label6.Location = new Point(33, 403);
            label6.Name = "label6";
            label6.Size = new Size(180, 26);
            label6.TabIndex = 5;
            label6.Text = "Elektronika turi";
            // 
            // textBoxFirmaNomi
            // 
            textBoxFirmaNomi.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            textBoxFirmaNomi.Location = new Point(268, 146);
            textBoxFirmaNomi.Name = "textBoxFirmaNomi";
            textBoxFirmaNomi.Size = new Size(223, 35);
            textBoxFirmaNomi.TabIndex = 6;
            // 
            // textBoxBatareyaQuvvati
            // 
            textBoxBatareyaQuvvati.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            textBoxBatareyaQuvvati.Location = new Point(268, 208);
            textBoxBatareyaQuvvati.Name = "textBoxBatareyaQuvvati";
            textBoxBatareyaQuvvati.Size = new Size(223, 35);
            textBoxBatareyaQuvvati.TabIndex = 7;
            // 
            // textBoxIshlabChiqSana
            // 
            textBoxIshlabChiqSana.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            textBoxIshlabChiqSana.Location = new Point(268, 275);
            textBoxIshlabChiqSana.Name = "textBoxIshlabChiqSana";
            textBoxIshlabChiqSana.Size = new Size(223, 35);
            textBoxIshlabChiqSana.TabIndex = 8;
            // 
            // textBoxXotiraXajmi
            // 
            textBoxXotiraXajmi.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            textBoxXotiraXajmi.Location = new Point(268, 341);
            textBoxXotiraXajmi.Name = "textBoxXotiraXajmi";
            textBoxXotiraXajmi.Size = new Size(223, 35);
            textBoxXotiraXajmi.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kompyuter", "Mobil Telefon" });
            comboBox1.Location = new Point(271, 403);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 34);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(525, 403);
            button1.Name = "button1";
            button1.Size = new Size(118, 49);
            button1.TabIndex = 12;
            button1.Text = "Qo'shish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(525, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 202);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label7.Location = new Point(525, 91);
            label7.Name = "label7";
            label7.Size = new Size(149, 26);
            label7.TabIndex = 11;
            label7.Text = "Rasm tanlash";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(696, 83);
            button3.Name = "button3";
            button3.Size = new Size(92, 43);
            button3.TabIndex = 2;
            button3.Text = "Tanlash";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label8.Location = new Point(33, 94);
            label8.Name = "label8";
            label8.Size = new Size(67, 26);
            label8.TabIndex = 17;
            label8.Text = "Nomi";
            // 
            // textBoxNomi
            // 
            textBoxNomi.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            textBoxNomi.Location = new Point(271, 91);
            textBoxNomi.Name = "textBoxNomi";
            textBoxNomi.Size = new Size(223, 35);
            textBoxNomi.TabIndex = 1;
            textBoxNomi.TextChanged += textBoxNomi_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(661, 403);
            button2.Name = "button2";
            button2.Size = new Size(118, 49);
            button2.TabIndex = 18;
            button2.Text = "Orqaga";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(button2);
            Controls.Add(textBoxNomi);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBoxXotiraXajmi);
            Controls.Add(textBoxIshlabChiqSana);
            Controls.Add(textBoxBatareyaQuvvati);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFirmaNomi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddDataForm";
            Text = "AddDataForm";
            Load += AddDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox textBoxNomi;
        private TextBox textBoxFirmaNomi;
        private TextBox textBoxBatareyaQuvvati;
        private TextBox textBoxIshlabChiqSana;
        private TextBox textBoxXotiraXajmi;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}