namespace WindowsForm1
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
            textBox1_usuario = new TextBox();
            textBox_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_conectar = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1_usuario
            // 
            textBox1_usuario.Location = new Point(148, 205);
            textBox1_usuario.Multiline = true;
            textBox1_usuario.Name = "textBox1_usuario";
            textBox1_usuario.Size = new Size(169, 29);
            textBox1_usuario.TabIndex = 0;
            // 
            // textBox_senha
            // 
            textBox_senha.Location = new Point(148, 257);
            textBox_senha.Multiline = true;
            textBox_senha.Name = "textBox_senha";
            textBox_senha.Size = new Size(169, 29);
            textBox_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 214);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 261);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "senha";
            // 
            // button_conectar
            // 
            button_conectar.BackColor = SystemColors.GradientInactiveCaption;
            button_conectar.Location = new Point(177, 307);
            button_conectar.Name = "button_conectar";
            button_conectar.Size = new Size(109, 35);
            button_conectar.TabIndex = 4;
            button_conectar.Text = "conectar-se";
            button_conectar.UseVisualStyleBackColor = false;
            button_conectar.Click += button_conectar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(177, 389);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 5;
            button2.Text = "criar conta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Location = new Point(177, 348);
            button3.Name = "button3";
            button3.Size = new Size(109, 35);
            button3.TabIndex = 6;
            button3.Text = "esqueci a senha";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 523);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_conectar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_senha);
            Controls.Add(textBox1_usuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_usuario;
        private TextBox textBox_senha;
        private Label label1;
        private Label label2;
        private Button button_conectar;
        private Button button2;
        private Button button3;
    }
}
