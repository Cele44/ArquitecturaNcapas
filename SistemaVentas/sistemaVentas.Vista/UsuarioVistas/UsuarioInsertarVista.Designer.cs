namespace sistemaVentas.Vista.UsuarioVistas
{
    partial class UsuarioInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 328);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 136);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "NOMBREUSER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 194);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 252);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "FECHAREG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 74);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 4;
            label4.Text = "IDPERSONA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 251);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 27);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(310, 328);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 405);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
    }
}