namespace Academia.DotNet.AmigoSecreto.App
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void Timer_Inicio_Tick(object sender, EventArgs e)
        {
            if (progressBar_Inicio.Value < 100)
            {
                progressBar_Inicio.Value = progressBar_Inicio.Value + 2;
            }
            else
            {
                Timer_Inicio.Enabled = false;
                Form_Menu formMenu = new Form_Menu();
                formMenu.Show();
                Visible = false;
            }
        }
    }
}