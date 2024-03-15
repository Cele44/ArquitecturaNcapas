namespace sistemaVentas.Vista.ProductoVistas
{
    partial class ProductoInsertarVista
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "IDTIPOPROD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 110);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "IDMARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 165);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 220);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 5;
            label4.Text = "CODIGOBARRA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 275);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "UNIDAD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 330);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 7;
            label6.Text = "DESCRIPCION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(195, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(326, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(195, 323);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(326, 27);
            textBox6.TabIndex = 13;
            // 
            // ProductoInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 460);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProductoInsertarVista";
            Text = "ProductoInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}