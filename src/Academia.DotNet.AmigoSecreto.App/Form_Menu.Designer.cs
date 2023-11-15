namespace Academia.DotNet.AmigoSecreto.App
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            amigoToolStripMenuItem = new MenuStrip();
            MenuToolStripMenuItem = new ToolStripMenuItem();
            SobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip_Menu = new StatusStrip();
            toolStripStatusLabel_Msg = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgData = new ToolStripStatusLabel();
            toolStripStatusLabel_Data = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgHora = new ToolStripStatusLabel();
            toolStripStatusLabel_Hora = new ToolStripStatusLabel();
            panel1 = new Panel();
            label_ListaAmigosSecreto = new Label();
            label_ListaDeAmigos = new Label();
            listView_AmigosSecretos = new ListView();
            nome_amigo1 = new ColumnHeader();
            email_amigo1 = new ColumnHeader();
            nome_amigo2 = new ColumnHeader();
            email_amigo2 = new ColumnHeader();
            listView_Amigo = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            panel_AdicionarAmigo = new Panel();
            label_AdicionarAmigo = new Label();
            textBox_Email = new TextBox();
            label_Email = new Label();
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            toolStripCadastrarAmigo = new ToolStrip();
            Btn_Adicionar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Btn_Cancelar = new ToolStripButton();
            toolStrip_GerarAmigosSecretos = new ToolStrip();
            Btn_GerarAmigoSecreto = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_LimparLista = new ToolStripButton();
            Btn_Sair = new ToolStripButton();
            Timer_Menu = new System.Windows.Forms.Timer(components);
            label_Menu = new Label();
            pictureBox_AmigosSecretos = new PictureBox();
            amigoToolStripMenuItem.SuspendLayout();
            statusStrip_Menu.SuspendLayout();
            panel1.SuspendLayout();
            panel_AdicionarAmigo.SuspendLayout();
            toolStripCadastrarAmigo.SuspendLayout();
            toolStrip_GerarAmigosSecretos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AmigosSecretos).BeginInit();
            SuspendLayout();
            // 
            // amigoToolStripMenuItem
            // 
            amigoToolStripMenuItem.BackColor = Color.DeepSkyBlue;
            amigoToolStripMenuItem.Items.AddRange(new ToolStripItem[] { MenuToolStripMenuItem });
            amigoToolStripMenuItem.Location = new Point(0, 0);
            amigoToolStripMenuItem.Name = "amigoToolStripMenuItem";
            amigoToolStripMenuItem.Size = new Size(1084, 25);
            amigoToolStripMenuItem.TabIndex = 0;
            amigoToolStripMenuItem.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            MenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SobreToolStripMenuItem });
            MenuToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            MenuToolStripMenuItem.Size = new Size(55, 21);
            MenuToolStripMenuItem.Text = "Menu";
            // 
            // SobreToolStripMenuItem
            // 
            SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            SobreToolStripMenuItem.Size = new Size(111, 22);
            SobreToolStripMenuItem.Text = "Sobre";
            SobreToolStripMenuItem.Click += SobreToolStripMenuItem_Click;
            // 
            // statusStrip_Menu
            // 
            statusStrip_Menu.BackColor = Color.DeepSkyBlue;
            statusStrip_Menu.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Msg, toolStripStatusLabel_MsgData, toolStripStatusLabel_Data, toolStripStatusLabel_MsgHora, toolStripStatusLabel_Hora });
            statusStrip_Menu.Location = new Point(0, 679);
            statusStrip_Menu.Name = "statusStrip_Menu";
            statusStrip_Menu.Size = new Size(1084, 22);
            statusStrip_Menu.TabIndex = 1;
            statusStrip_Menu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Msg
            // 
            toolStripStatusLabel_Msg.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Msg.Name = "toolStripStatusLabel_Msg";
            toolStripStatusLabel_Msg.Size = new Size(83, 17);
            toolStripStatusLabel_Msg.Text = "Bem-vindo(a)";
            // 
            // toolStripStatusLabel_MsgData
            // 
            toolStripStatusLabel_MsgData.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_MsgData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgData.Name = "toolStripStatusLabel_MsgData";
            toolStripStatusLabel_MsgData.Size = new Size(33, 17);
            toolStripStatusLabel_MsgData.Text = "Data";
            // 
            // toolStripStatusLabel_Data
            // 
            toolStripStatusLabel_Data.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Data.Name = "toolStripStatusLabel_Data";
            toolStripStatusLabel_Data.Size = new Size(127, 17);
            toolStripStatusLabel_Data.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel_MsgHora
            // 
            toolStripStatusLabel_MsgHora.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_MsgHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgHora.Name = "toolStripStatusLabel_MsgHora";
            toolStripStatusLabel_MsgHora.Size = new Size(34, 17);
            toolStripStatusLabel_MsgHora.Text = "Hora";
            // 
            // toolStripStatusLabel_Hora
            // 
            toolStripStatusLabel_Hora.BackColor = Color.DeepSkyBlue;
            toolStripStatusLabel_Hora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Hora.Name = "toolStripStatusLabel_Hora";
            toolStripStatusLabel_Hora.Size = new Size(127, 17);
            toolStripStatusLabel_Hora.Text = "toolStripStatusLabel5";
            // 
            // panel1
            // 
            panel1.Controls.Add(label_ListaAmigosSecreto);
            panel1.Controls.Add(label_ListaDeAmigos);
            panel1.Controls.Add(listView_AmigosSecretos);
            panel1.Controls.Add(listView_Amigo);
            panel1.Controls.Add(panel_AdicionarAmigo);
            panel1.Controls.Add(toolStrip_GerarAmigosSecretos);
            panel1.Location = new Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 585);
            panel1.TabIndex = 2;
            // 
            // label_ListaAmigosSecreto
            // 
            label_ListaAmigosSecreto.AutoSize = true;
            label_ListaAmigosSecreto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaAmigosSecreto.ForeColor = Color.White;
            label_ListaAmigosSecreto.Location = new Point(705, 13);
            label_ListaAmigosSecreto.Name = "label_ListaAmigosSecreto";
            label_ListaAmigosSecreto.Size = new Size(140, 21);
            label_ListaAmigosSecreto.TabIndex = 14;
            label_ListaAmigosSecreto.Text = "Pares  de Amigos";
            // 
            // label_ListaDeAmigos
            // 
            label_ListaDeAmigos.AutoSize = true;
            label_ListaDeAmigos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ListaDeAmigos.ForeColor = Color.White;
            label_ListaDeAmigos.Location = new Point(126, 178);
            label_ListaDeAmigos.Name = "label_ListaDeAmigos";
            label_ListaDeAmigos.Size = new Size(165, 21);
            label_ListaDeAmigos.TabIndex = 13;
            label_ListaDeAmigos.Text = "Amigos Cadastrados";
            // 
            // listView_AmigosSecretos
            // 
            listView_AmigosSecretos.Columns.AddRange(new ColumnHeader[] { nome_amigo1, email_amigo1, nome_amigo2, email_amigo2 });
            listView_AmigosSecretos.Location = new Point(460, 48);
            listView_AmigosSecretos.Name = "listView_AmigosSecretos";
            listView_AmigosSecretos.Size = new Size(600, 465);
            listView_AmigosSecretos.TabIndex = 12;
            listView_AmigosSecretos.UseCompatibleStateImageBehavior = false;
            listView_AmigosSecretos.View = View.Details;
            // 
            // nome_amigo1
            // 
            nome_amigo1.Text = "Nome";
            nome_amigo1.Width = 128;
            // 
            // email_amigo1
            // 
            email_amigo1.Text = "Email";
            email_amigo1.Width = 170;
            // 
            // nome_amigo2
            // 
            nome_amigo2.Text = "Nome";
            nome_amigo2.Width = 128;
            // 
            // email_amigo2
            // 
            email_amigo2.Text = "Email";
            email_amigo2.Width = 170;
            // 
            // listView_Amigo
            // 
            listView_Amigo.Alignment = ListViewAlignment.Default;
            listView_Amigo.Columns.AddRange(new ColumnHeader[] { nome, email });
            listView_Amigo.Location = new Point(3, 213);
            listView_Amigo.Name = "listView_Amigo";
            listView_Amigo.Size = new Size(420, 300);
            listView_Amigo.TabIndex = 11;
            listView_Amigo.UseCompatibleStateImageBehavior = false;
            listView_Amigo.View = View.Details;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 207;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 209;
            // 
            // panel_AdicionarAmigo
            // 
            panel_AdicionarAmigo.Controls.Add(label_AdicionarAmigo);
            panel_AdicionarAmigo.Controls.Add(textBox_Email);
            panel_AdicionarAmigo.Controls.Add(label_Email);
            panel_AdicionarAmigo.Controls.Add(label_Nome);
            panel_AdicionarAmigo.Controls.Add(textBox_Nome);
            panel_AdicionarAmigo.Controls.Add(toolStripCadastrarAmigo);
            panel_AdicionarAmigo.Location = new Point(3, 3);
            panel_AdicionarAmigo.Name = "panel_AdicionarAmigo";
            panel_AdicionarAmigo.Size = new Size(420, 160);
            panel_AdicionarAmigo.TabIndex = 1;
            // 
            // label_AdicionarAmigo
            // 
            label_AdicionarAmigo.AutoSize = true;
            label_AdicionarAmigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_AdicionarAmigo.ForeColor = Color.White;
            label_AdicionarAmigo.Location = new Point(135, 10);
            label_AdicionarAmigo.Name = "label_AdicionarAmigo";
            label_AdicionarAmigo.Size = new Size(139, 21);
            label_AdicionarAmigo.TabIndex = 11;
            label_AdicionarAmigo.Text = "Adicionar Amigo";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(62, 82);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(355, 23);
            textBox_Email.TabIndex = 10;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Email.ForeColor = Color.White;
            label_Email.Location = new Point(0, 82);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(51, 20);
            label_Email.TabIndex = 9;
            label_Email.Text = "Email:";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nome.ForeColor = Color.White;
            label_Nome.Location = new Point(0, 48);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(56, 20);
            label_Nome.TabIndex = 8;
            label_Nome.Text = "Nome:";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(62, 45);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(355, 23);
            textBox_Nome.TabIndex = 7;
            // 
            // toolStripCadastrarAmigo
            // 
            toolStripCadastrarAmigo.BackColor = Color.DeepSkyBlue;
            toolStripCadastrarAmigo.Dock = DockStyle.Bottom;
            toolStripCadastrarAmigo.ImageScalingSize = new Size(40, 40);
            toolStripCadastrarAmigo.Items.AddRange(new ToolStripItem[] { Btn_Adicionar, toolStripSeparator2, Btn_Cancelar });
            toolStripCadastrarAmigo.Location = new Point(0, 117);
            toolStripCadastrarAmigo.Name = "toolStripCadastrarAmigo";
            toolStripCadastrarAmigo.Size = new Size(420, 43);
            toolStripCadastrarAmigo.TabIndex = 0;
            toolStripCadastrarAmigo.Text = "toolStrip1";
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.AutoSize = false;
            Btn_Adicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Adicionar.Image = Properties.Resources.amiga;
            Btn_Adicionar.ImageTransparentColor = Color.Magenta;
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(40, 40);
            Btn_Adicionar.Text = "Adicionar Amigo";
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.AutoSize = false;
            Btn_Cancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Cancelar.Image = Properties.Resources.brush3;
            Btn_Cancelar.ImageTransparentColor = Color.Magenta;
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(40, 40);
            Btn_Cancelar.Text = "Limpar Campos";
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // toolStrip_GerarAmigosSecretos
            // 
            toolStrip_GerarAmigosSecretos.BackColor = Color.DeepSkyBlue;
            toolStrip_GerarAmigosSecretos.Dock = DockStyle.Bottom;
            toolStrip_GerarAmigosSecretos.ImageScalingSize = new Size(40, 40);
            toolStrip_GerarAmigosSecretos.Items.AddRange(new ToolStripItem[] { Btn_GerarAmigoSecreto, toolStripSeparator1, Btn_LimparLista, Btn_Sair });
            toolStrip_GerarAmigosSecretos.Location = new Point(0, 542);
            toolStrip_GerarAmigosSecretos.Name = "toolStrip_GerarAmigosSecretos";
            toolStrip_GerarAmigosSecretos.Size = new Size(1060, 43);
            toolStrip_GerarAmigosSecretos.TabIndex = 0;
            toolStrip_GerarAmigosSecretos.Text = "toolStrip1";
            // 
            // Btn_GerarAmigoSecreto
            // 
            Btn_GerarAmigoSecreto.AutoSize = false;
            Btn_GerarAmigoSecreto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_GerarAmigoSecreto.Image = Properties.Resources.amigos;
            Btn_GerarAmigoSecreto.ImageTransparentColor = Color.Magenta;
            Btn_GerarAmigoSecreto.Name = "Btn_GerarAmigoSecreto";
            Btn_GerarAmigoSecreto.Size = new Size(40, 40);
            Btn_GerarAmigoSecreto.Text = "Gerar Amigo Secreto";
            Btn_GerarAmigoSecreto.Click += Btn_GerarAmigoSecreto_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // Btn_LimparLista
            // 
            Btn_LimparLista.AutoSize = false;
            Btn_LimparLista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_LimparLista.Image = Properties.Resources.lixo;
            Btn_LimparLista.ImageTransparentColor = Color.Magenta;
            Btn_LimparLista.Name = "Btn_LimparLista";
            Btn_LimparLista.Size = new Size(40, 40);
            Btn_LimparLista.Text = "Limpar Listas";
            Btn_LimparLista.Click += Btn_LimparLista_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Alignment = ToolStripItemAlignment.Right;
            Btn_Sair.AutoSize = false;
            Btn_Sair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Sair.Image = Properties.Resources.exit;
            Btn_Sair.ImageTransparentColor = Color.Magenta;
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(40, 40);
            Btn_Sair.Text = "Sair";
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Timer_Menu
            // 
            Timer_Menu.Enabled = true;
            Timer_Menu.Tick += Timer_Menu_Tick;
            // 
            // label_Menu
            // 
            label_Menu.AutoSize = true;
            label_Menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_Menu.ForeColor = Color.White;
            label_Menu.Location = new Point(419, 36);
            label_Menu.Name = "label_Menu";
            label_Menu.Size = new Size(182, 32);
            label_Menu.TabIndex = 8;
            label_Menu.Text = "Amigo Secreto";
            // 
            // pictureBox_AmigosSecretos
            // 
            pictureBox_AmigosSecretos.Image = Properties.Resources.amigos_secretos;
            pictureBox_AmigosSecretos.Location = new Point(597, 26);
            pictureBox_AmigosSecretos.Name = "pictureBox_AmigosSecretos";
            pictureBox_AmigosSecretos.Size = new Size(50, 50);
            pictureBox_AmigosSecretos.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_AmigosSecretos.TabIndex = 9;
            pictureBox_AmigosSecretos.TabStop = false;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1084, 701);
            Controls.Add(pictureBox_AmigosSecretos);
            Controls.Add(label_Menu);
            Controls.Add(panel1);
            Controls.Add(statusStrip_Menu);
            Controls.Add(amigoToolStripMenuItem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = amigoToolStripMenuItem;
            MaximizeBox = false;
            Name = "Form_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            FormClosed += Form_Menu_FormClosed;
            amigoToolStripMenuItem.ResumeLayout(false);
            amigoToolStripMenuItem.PerformLayout();
            statusStrip_Menu.ResumeLayout(false);
            statusStrip_Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_AdicionarAmigo.ResumeLayout(false);
            panel_AdicionarAmigo.PerformLayout();
            toolStripCadastrarAmigo.ResumeLayout(false);
            toolStripCadastrarAmigo.PerformLayout();
            toolStrip_GerarAmigosSecretos.ResumeLayout(false);
            toolStrip_GerarAmigosSecretos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AmigosSecretos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip amigoToolStripMenuItem;
        private StatusStrip statusStrip_Menu;
        private ToolStripStatusLabel toolStripStatusLabel_Msg;
        private ToolStripStatusLabel toolStripStatusLabel_MsgData;
        private ToolStripStatusLabel toolStripStatusLabel_Data;
        private ToolStripStatusLabel toolStripStatusLabel_MsgHora;
        private ToolStripStatusLabel toolStripStatusLabel_Hora;
        private Panel panel1;
        private ToolStrip toolStrip_GerarAmigosSecretos;
        private System.Windows.Forms.Timer Timer_Menu;
        private ToolStripButton Btn_GerarAmigoSecreto;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_LimparLista;
        private ToolStripButton Btn_Sair;
        private Panel panel_AdicionarAmigo;
        private ToolStrip toolStripCadastrarAmigo;
        private ToolStripButton Btn_Adicionar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Btn_Cancelar;
        private ToolStripMenuItem MenuToolStripMenuItem;
        private ToolStripMenuItem SobreToolStripMenuItem;
        private ListView listView_AmigosSecretos;
        private ColumnHeader nome_amigo1;
        private ColumnHeader email_amigo1;
        private ColumnHeader nome_amigo2;
        private ColumnHeader email_amigo2;
        private ListView listView_Amigo;
        private ColumnHeader nome;
        private ColumnHeader email;
        private TextBox textBox_Email;
        private Label label_Email;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Label label_AdicionarAmigo;
        private Label label_ListaDeAmigos;
        private Label label_ListaAmigosSecreto;
        private Label label_Menu;
        private PictureBox pictureBox_AmigosSecretos;
    }
}