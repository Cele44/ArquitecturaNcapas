namespace sistemaVentas.Vista.MarcaVistas
{
    partial class MarcaEditarVista
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
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(245, 171);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 12;
            label2.Text = "ESTADO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "NOMBRE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(77, 171);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MarcaEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 246);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "MarcaEditarVista";
            Text = "MarcaEditarVista";
            Load += MarcaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}