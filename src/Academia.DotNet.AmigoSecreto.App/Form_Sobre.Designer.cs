namespace Academia.DotNet.AmigoSecreto.App
{
    partial class Form_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sobre));
            label_Sobre = new Label();
            label_InfoDetalhes = new Label();
            label_InfoAmigoSecreto = new Label();
            label_InfoDesenvolvedor = new Label();
            label_Desenvolvedor = new Label();
            SuspendLayout();
            // 
            // label_Sobre
            // 
            label_Sobre.AutoSize = true;
            label_Sobre.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Sobre.ForeColor = Color.White;
            label_Sobre.Location = new Point(199, 9);
            label_Sobre.Name = "label_Sobre";
            label_Sobre.Size = new Size(66, 28);
            label_Sobre.TabIndex = 1;
            label_Sobre.Text = "Sobre";
            // 
            // label_InfoDetalhes
            // 
            label_InfoDetalhes.AutoSize = true;
            label_InfoDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoDetalhes.ForeColor = Color.White;
            label_InfoDetalhes.Location = new Point(34, 92);
            label_InfoDetalhes.Name = "label_InfoDetalhes";
            label_InfoDetalhes.Size = new Size(417, 15);
            label_InfoDetalhes.TabIndex = 8;
            label_InfoDetalhes.Text = "Aplicação responsável por gerenciar uma lista de pares de amigos secretos";
            // 
            // label_InfoAmigoSecreto
            // 
            label_InfoAmigoSecreto.AutoSize = true;
            label_InfoAmigoSecreto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoAmigoSecreto.ForeColor = Color.White;
            label_InfoAmigoSecreto.Location = new Point(34, 58);
            label_InfoAmigoSecreto.Name = "label_InfoAmigoSecreto";
            label_InfoAmigoSecreto.Size = new Size(137, 15);
            label_InfoAmigoSecreto.TabIndex = 7;
            label_InfoAmigoSecreto.Text = "Projeto: Amigo Secreto";
            // 
            // label_InfoDesenvolvedor
            // 
            label_InfoDesenvolvedor.AutoSize = true;
            label_InfoDesenvolvedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoDesenvolvedor.ForeColor = Color.White;
            label_InfoDesenvolvedor.Location = new Point(34, 156);
            label_InfoDesenvolvedor.Name = "label_InfoDesenvolvedor";
            label_InfoDesenvolvedor.Size = new Size(227, 15);
            label_InfoDesenvolvedor.TabIndex = 6;
            label_InfoDesenvolvedor.Text = "Aluno da 5° academia .NET da UFN 2023";
            // 
            // label_Desenvolvedor
            // 
            label_Desenvolvedor.AutoSize = true;
            label_Desenvolvedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Desenvolvedor.ForeColor = Color.White;
            label_Desenvolvedor.Location = new Point(34, 124);
            label_Desenvolvedor.Name = "label_Desenvolvedor";
            label_Desenvolvedor.Size = new Size(174, 15);
            label_Desenvolvedor.TabIndex = 5;
            label_Desenvolvedor.Text = "Desenvolvido por: Paulo Alves";
            // 
            // Form_Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(484, 228);
            Controls.Add(label_InfoDetalhes);
            Controls.Add(label_InfoAmigoSecreto);
            Controls.Add(label_InfoDesenvolvedor);
            Controls.Add(label_Desenvolvedor);
            Controls.Add(label_Sobre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Sobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Sobre;
        private Label label_InfoDetalhes;
        private Label label_InfoAmigoSecreto;
        private Label label_InfoDesenvolvedor;
        private Label label_Desenvolvedor;
    }
}