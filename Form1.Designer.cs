namespace EncriptarV1
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
            encriptarBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            mat9 = new TextBox();
            mat8 = new TextBox();
            mat5 = new TextBox();
            mat7 = new TextBox();
            mat6 = new TextBox();
            mat4 = new TextBox();
            mat3 = new TextBox();
            mat2 = new TextBox();
            mat1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // encriptarBtn
            // 
            encriptarBtn.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encriptarBtn.Location = new Point(22, 127);
            encriptarBtn.Name = "encriptarBtn";
            encriptarBtn.Size = new Size(136, 42);
            encriptarBtn.TabIndex = 0;
            encriptarBtn.Text = "Encriptar";
            encriptarBtn.UseVisualStyleBackColor = true;
            encriptarBtn.Click += EncriptarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hack Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 264);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 1;
            label1.Text = "Respuesta";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 25);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 67);
            label2.Name = "label2";
            label2.Size = new Size(170, 18);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el mensaje";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mat9);
            groupBox1.Controls.Add(mat8);
            groupBox1.Controls.Add(mat5);
            groupBox1.Controls.Add(mat7);
            groupBox1.Controls.Add(mat6);
            groupBox1.Controls.Add(mat4);
            groupBox1.Controls.Add(mat3);
            groupBox1.Controls.Add(mat2);
            groupBox1.Controls.Add(mat1);
            groupBox1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(419, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 219);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Matriz de encriptación";
            // 
            // mat9
            // 
            mat9.Location = new Point(154, 161);
            mat9.Name = "mat9";
            mat9.Size = new Size(28, 25);
            mat9.TabIndex = 8;
            mat9.TextAlign = HorizontalAlignment.Center;
            // 
            // mat8
            // 
            mat8.Location = new Point(95, 161);
            mat8.Name = "mat8";
            mat8.Size = new Size(28, 25);
            mat8.TabIndex = 7;
            mat8.TextAlign = HorizontalAlignment.Center;
            // 
            // mat5
            // 
            mat5.Location = new Point(95, 107);
            mat5.Name = "mat5";
            mat5.Size = new Size(28, 25);
            mat5.TabIndex = 5;
            mat5.TextAlign = HorizontalAlignment.Center;
            // 
            // mat7
            // 
            mat7.Location = new Point(35, 161);
            mat7.Name = "mat7";
            mat7.Size = new Size(28, 25);
            mat7.TabIndex = 6;
            mat7.TextAlign = HorizontalAlignment.Center;
            // 
            // mat6
            // 
            mat6.Location = new Point(154, 107);
            mat6.Name = "mat6";
            mat6.Size = new Size(28, 25);
            mat6.TabIndex = 5;
            mat6.TextAlign = HorizontalAlignment.Center;
            // 
            // mat4
            // 
            mat4.Location = new Point(35, 107);
            mat4.Name = "mat4";
            mat4.Size = new Size(28, 25);
            mat4.TabIndex = 3;
            mat4.TextAlign = HorizontalAlignment.Center;
            // 
            // mat3
            // 
            mat3.Location = new Point(154, 54);
            mat3.Name = "mat3";
            mat3.Size = new Size(28, 25);
            mat3.TabIndex = 2;
            mat3.TextAlign = HorizontalAlignment.Center;
            // 
            // mat2
            // 
            mat2.Location = new Point(95, 54);
            mat2.Name = "mat2";
            mat2.Size = new Size(28, 25);
            mat2.TabIndex = 1;
            mat2.TextAlign = HorizontalAlignment.Center;
            // 
            // mat1
            // 
            mat1.Location = new Point(35, 54);
            mat1.Name = "mat1";
            mat1.Size = new Size(28, 25);
            mat1.TabIndex = 0;
            mat1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(164, 127);
            button1.Name = "button1";
            button1.Size = new Size(154, 42);
            button1.TabIndex = 5;
            button1.Text = "Desencriptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(encriptarBtn);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(49, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 219);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Principal";
            // 
            // button2
            // 
            button2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(539, 258);
            button2.Name = "button2";
            button2.Size = new Size(91, 33);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encriptarBtn;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox mat9;
        private TextBox mat8;
        private TextBox mat5;
        private TextBox mat7;
        private TextBox mat6;
        private TextBox mat4;
        private TextBox mat3;
        private TextBox mat2;
        private TextBox mat1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
    }
}
