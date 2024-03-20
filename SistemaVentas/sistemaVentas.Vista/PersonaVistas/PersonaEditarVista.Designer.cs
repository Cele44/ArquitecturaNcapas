namespace sistemaVentas.Vista.PersonaVistas
{
    partial class PersonaEditarVista
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(311, 353);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 27);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(316, 27);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 27);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 145);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 18;
            label6.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 194);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 17;
            label5.Text = "CI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 243);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 16;
            label4.Text = "CORREO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 362);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 14;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 13;
            label1.Text = "NOMBRE";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(119, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // PersonaEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 409);
            Controls.Add(button1);
            Controls.Add(button2);
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
            Name = "PersonaEditarVista";
            Text = "PersonaEditarVista";
            Load += PersonaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}