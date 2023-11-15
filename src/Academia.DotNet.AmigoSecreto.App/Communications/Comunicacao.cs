using Academia.DotNet.AmigoSecreto.App.Data;
using Academia.DotNet.AmigoSecreto.App.Models;
using Academia.DotNet.AmigoSecreto.App.Utils;

namespace Academia.DotNet.AmigoSecreto.App.Communications
{
    public class Comunicacao
    {
        private List<Amigo> listaDeAmigos;
        private ListView listView_Amigo;
        private ListView listView_AmigosSecretos;
        private Persistencia persistencia;

        public Comunicacao(List<Amigo> amigos, ListView listViewAmigo, ListView listViewAmigosSecretos)
        {
            listaDeAmigos = amigos;
            listView_Amigo = listViewAmigo;
            listView_AmigosSecretos = listViewAmigosSecretos;
            persistencia = new Persistencia();
            CarregarAmigosDoArquivo();
        }

        public void AdicionarAmigo(Amigo amigo)
        {
            Persistencia persistencia = new Persistencia();

            listaDeAmigos.Add(amigo);
            Utilitario.OrdenarAmigosPorNome(listaDeAmigos);
            AtualizarListViewAmigo();
            persistencia.SalvarAmigosNoArquivo(listaDeAmigos);
        }

        public List<Amigo> ListarAmigos()
        {
            return listaDeAmigos;
        }

        public void GerarAmigoSecreto()
        {
            if (listaDeAmigos.Count < 2)
            {
                MessageBox.Show("Não há amigos suficientes para gerar amigos secretos.", "Aviso");
            }
            else
            {
                List<Amigo> amigosEmbaralhados = new List<Amigo>(listaDeAmigos);
                Random random = new Random();

                List<Tuple<Amigo, Amigo>> paresAmigosSecretos = new List<Tuple<Amigo, Amigo>>();

                while (amigosEmbaralhados.Count >= 2)
                {
                    int indiceAmigo = random.Next(0, amigosEmbaralhados.Count);
                    Amigo amigo = amigosEmbaralhados[indiceAmigo];
                    amigosEmbaralhados.RemoveAt(indiceAmigo);

                    int indiceAmigoSecreto = random.Next(0, amigosEmbaralhados.Count);
                    Amigo amigoSecreto = amigosEmbaralhados[indiceAmigoSecreto];
                    amigosEmbaralhados.RemoveAt(indiceAmigoSecreto);

                    paresAmigosSecretos.Add(new Tuple<Amigo, Amigo>(amigo, amigoSecreto));
                }

                if (amigosEmbaralhados.Count == 1)
                {
                    MessageBox.Show("Há um amigo sem par. Adicione mais amigos para resolver.", "Aviso");
                }

                Persistencia persistencia = new Persistencia();
                persistencia.SalvarParesAmigosSecretos(paresAmigosSecretos);

                AtualizarListBoxAmigosSecretos(paresAmigosSecretos);
            }
        }

        public void GerarEExibirAmigoSecreto()
        {
            GerarAmigoSecreto();
            List<Tuple<Amigo, Amigo>> paresAmigosSecretos = persistencia.LerParesAmigosSecretos();
            AtualizarListBoxAmigosSecretos(paresAmigosSecretos);
        }

        public void LimparListasComValidacao()
        {
            if (ListarAmigos().Any() || persistencia.LerParesAmigosSecretos().Any())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja limpar as listas?", "Confirmação",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LimparListas();
                }
            }
            else
            {
                MessageBox.Show("As listas já estão vazias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparListas()
        {
            Persistencia persistencia = new Persistencia();
            persistencia.LimparConteudoArquivos();

            listaDeAmigos.Clear();
            listView_Amigo.Items.Clear();
            listView_AmigosSecretos.Items.Clear();
        }

        private void CarregarAmigosDoArquivo()
        {
            Persistencia persistencia = new Persistencia();
            listaDeAmigos.AddRange(persistencia.LerAmigosDoArquivo());
            AtualizarListViewAmigo();
        }

        private void AtualizarListViewAmigo()
        {
            listView_Amigo.Items.Clear();

            foreach (var amigo in listaDeAmigos)
            {
                AdicionarAmigoAoListView(amigo);
            }
        }

        private void AdicionarAmigoAoListView(Amigo amigo)
        {
            ListViewItem item = new ListViewItem();
            item.Text = amigo.Nome;
            item.SubItems.Add(amigo.Email);

            listView_Amigo.Items.Add(item);
        }

        private void AtualizarListBoxAmigosSecretos(List<Tuple<Amigo, Amigo>> paresAmigosSecretos)
        {

            listView_AmigosSecretos.Items.Clear();

            foreach (var par in paresAmigosSecretos)
            {
                AdicionarParAmigosAoListView(par.Item1, par.Item2);
            }
        }

        private void AdicionarParAmigosAoListView(Amigo amigo1, Amigo amigo2)
        {
            ListViewItem item = new ListViewItem();

            item.Text = amigo1.Nome;
            item.SubItems.Add(amigo1.Email);

            item.SubItems.Add(amigo2.Nome);
            item.SubItems.Add(amigo2.Email);

            listView_AmigosSecretos.Items.Add(item);
        }
    }
}
