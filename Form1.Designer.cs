namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("High Tower Text", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 1;
            label1.Text = "Notas de L'alumne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 95);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 2;
            label2.Text = "Introdueix el nom de l'alumne";
            // 
            // button1
            // 
            button1.Location = new Point(18, 159);
            button1.Name = "button1";
            button1.Size = new Size(100, 46);
            button1.TabIndex = 3;
            button1.Text = "Calcular Mitjana";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 211);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 4;
            button2.Text = "Natejar Paràmetres";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 281);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Mitjana de notes: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 315);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "Nota més alta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 346);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 7;
            label5.Text = "Nota més baixa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 95);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 8;
            label6.Text = "Introdueix les notes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 138);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 9;
            label7.Text = "Nota 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 138);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 10;
            label8.Text = "Nota 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 138);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 11;
            label9.Text = "Nota 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(443, 138);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 12;
            label10.Text = "Nota 4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 159);
            textBox2.MaxLength = 3;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(351, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(395, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(443, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(42, 23);
            textBox5.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(395, 334);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 17;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(402, 297);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Epilepsia";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(494, 374);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ControlText;
            Location = new Point(200, 200);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox textBox1;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private CheckBox checkBox1;
    }
}
