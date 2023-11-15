using Academia.DotNet.AmigoSecreto.App.Communications;
using Academia.DotNet.AmigoSecreto.App.Models;
using Academia.DotNet.AmigoSecreto.App.Utils;

namespace Academia.DotNet.AmigoSecreto.App
{
    public partial class Form_Menu : Form
    {
        private Comunicacao comunicacao;

        public Form_Menu()
        {
            InitializeComponent();

            List<Amigo> listaDeAmigos = new List<Amigo>();
            comunicacao = new Comunicacao(listaDeAmigos, listView_Amigo, listView_AmigosSecretos);
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sobre formSobre = new Form_Sobre();
            formSobre.Show();
        }

        private void Timer_Menu_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Data.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text;
            string email = textBox_Email.Text;

            Amigo novoAmigo = new Amigo(nome, email);

            if (!Utilitario.ValidarNome(nome) || !Utilitario.ValidarFormatoDoEmail(email))
            {
                return;
            }

            comunicacao.AdicionarAmigo(novoAmigo);

            LimparCampos();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Btn_GerarAmigoSecreto_Click(object sender, EventArgs e)
        {
            comunicacao.GerarEExibirAmigoSecreto();
        }

        private void Btn_LimparLista_Click(object sender, EventArgs e)
        {
            comunicacao.LimparListasComValidacao();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparCampos()
        {
            textBox_Nome.Text = string.Empty;
            textBox_Email.Text = string.Empty;
        }
    }
}
