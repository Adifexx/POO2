namespace teste
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
            nome = new Label();
            sobrenome = new Label();
            textnome = new TextBox();
            textsobrenome = new TextBox();
            nomecompleto = new Label();
            textnomecompleto = new TextBox();
            cliqueaqui = new Button();
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(22, 23);
            nome.Name = "nome";
            nome.Size = new Size(96, 15);
            nome.TabIndex = 0;
            nome.Text = "Digite seu nome:";
            // 
            // sobrenome
            // 
            sobrenome.AutoSize = true;
            sobrenome.Location = new Point(22, 64);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(135, 15);
            sobrenome.TabIndex = 1;
            sobrenome.Text = "Digite o seu sobrenome:";
            // 
            // textnome
            // 
            textnome.Location = new Point(173, 20);
            textnome.Name = "textnome";
            textnome.Size = new Size(222, 23);
            textnome.TabIndex = 2;
            // 
            // textsobrenome
            // 
            textsobrenome.Location = new Point(173, 61);
            textsobrenome.Name = "textsobrenome";
            textsobrenome.Size = new Size(222, 23);
            textsobrenome.TabIndex = 3;
            // 
            // nomecompleto
            // 
            nomecompleto.AutoSize = true;
            nomecompleto.Location = new Point(22, 158);
            nomecompleto.Name = "nomecompleto";
            nomecompleto.Size = new Size(126, 15);
            nomecompleto.TabIndex = 4;
            nomecompleto.Text = "Seu nome completo é:";
            // 
            // textnomecompleto
            // 
            textnomecompleto.Location = new Point(173, 150);
            textnomecompleto.Name = "textnomecompleto";
            textnomecompleto.Size = new Size(222, 23);
            textnomecompleto.TabIndex = 5;
            // 
            // cliqueaqui
            // 
            cliqueaqui.Location = new Point(305, 99);
            cliqueaqui.Name = "cliqueaqui";
            cliqueaqui.Size = new Size(90, 26);
            cliqueaqui.TabIndex = 6;
            cliqueaqui.Text = "Clique aqui";
            cliqueaqui.UseVisualStyleBackColor = true;
            cliqueaqui.Click += cliqueaqui_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(429, 217);
            Controls.Add(cliqueaqui);
            Controls.Add(textnomecompleto);
            Controls.Add(nomecompleto);
            Controls.Add(textsobrenome);
            Controls.Add(textnome);
            Controls.Add(sobrenome);
            Controls.Add(nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nome;
        private Label sobrenome;
        private TextBox textnome;
        private TextBox textsobrenome;
        private Label nomecompleto;
        private TextBox textnomecompleto;
        private Button cliqueaqui;
    }
}
