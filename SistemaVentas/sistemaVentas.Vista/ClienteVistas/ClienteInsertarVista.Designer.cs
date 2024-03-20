namespace sistemaVentas.Vista.ClienteVistas
{
    partial class ClienteInsertarVista
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(299, 256);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 77);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "PERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 131);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "TIPOCLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 186);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "CODIGOCLIENTE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(479, 74);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 8;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(145, 256);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 11;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClienteInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 315);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "ClienteInsertarVista";
            Text = "ClienteInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private Button button1;
    }
}