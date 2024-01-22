namespace GrantTotinovKA1
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
            elementtxtbox = new TextBox();
            classtxtbox = new TextBox();
            generatebutton = new Button();
            resulttxtbox = new TextBox();
            combobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            countlabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // elementtxtbox
            // 
            elementtxtbox.Location = new Point(12, 172);
            elementtxtbox.Name = "elementtxtbox";
            elementtxtbox.Size = new Size(135, 23);
            elementtxtbox.TabIndex = 0;
            // 
            // classtxtbox
            // 
            classtxtbox.Location = new Point(12, 242);
            classtxtbox.Name = "classtxtbox";
            classtxtbox.Size = new Size(135, 23);
            classtxtbox.TabIndex = 1;
            // 
            // generatebutton
            // 
            generatebutton.BackColor = Color.Green;
            generatebutton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generatebutton.ForeColor = Color.White;
            generatebutton.Location = new Point(12, 294);
            generatebutton.Name = "generatebutton";
            generatebutton.Size = new Size(135, 44);
            generatebutton.TabIndex = 2;
            generatebutton.Text = "Генерирай";
            generatebutton.UseVisualStyleBackColor = false;
            generatebutton.Click += generatebutton_Click;
            // 
            // resulttxtbox
            // 
            resulttxtbox.Location = new Point(291, 70);
            resulttxtbox.Multiline = true;
            resulttxtbox.Name = "resulttxtbox";
            resulttxtbox.ReadOnly = true;
            resulttxtbox.ScrollBars = ScrollBars.Both;
            resulttxtbox.Size = new Size(199, 268);
            resulttxtbox.TabIndex = 3;
            // 
            // combobox
            // 
            combobox.FormattingEnabled = true;
            combobox.Location = new Point(12, 96);
            combobox.Name = "combobox";
            combobox.Size = new Size(135, 23);
            combobox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 5;
            label1.Text = "ИЗБЕРИ ВИД НА ЕЛЕМЕНТИТЕ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 6;
            label2.Text = "БРОЙ ЕЛЕМЕНТИ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 224);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "ОТ КОЙ КЛАС ";
            // 
            // countlabel
            // 
            countlabel.AutoSize = true;
            countlabel.BackColor = Color.Transparent;
            countlabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countlabel.ForeColor = Color.FromArgb(64, 0, 64);
            countlabel.Location = new Point(12, 363);
            countlabel.Name = "countlabel";
            countlabel.Size = new Size(301, 19);
            countlabel.TabIndex = 8;
            countlabel.Text = "Броят на вариациите без повторение са:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(490, 19);
            label4.TabIndex = 9;
            label4.Text = "Генератор на вариации без повторения от k-ти клас на n елемента";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 410);
            Controls.Add(label4);
            Controls.Add(countlabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combobox);
            Controls.Add(resulttxtbox);
            Controls.Add(generatebutton);
            Controls.Add(classtxtbox);
            Controls.Add(elementtxtbox);
            Name = "Form1";
            Text = "Grant Totinov KST 5235";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox elementtxtbox;
        private TextBox classtxtbox;
        private Button generatebutton;
        private TextBox resulttxtbox;
        private ComboBox combobox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label countlabel;
        private Label label4;
    }
}
