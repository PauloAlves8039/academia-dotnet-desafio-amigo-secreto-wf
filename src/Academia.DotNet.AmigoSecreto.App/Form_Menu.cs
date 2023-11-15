namespace Academia.DotNet.AmigoSecreto.App
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
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

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Btn_GerarAmigoSecreto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LimparLista_Click(object sender, EventArgs e)
        {

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
