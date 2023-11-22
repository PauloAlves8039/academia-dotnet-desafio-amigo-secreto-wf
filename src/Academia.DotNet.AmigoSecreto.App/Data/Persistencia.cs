using Academia.DotNet.AmigoSecreto.App.Models;
using System.Reflection;

namespace Academia.DotNet.AmigoSecreto.App.Data
{
    public class Persistencia
    {
        private string caminhoDoArquivoAmigos => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "amigos.csv");
        private string caminhoDoArquivoSecretos => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "secretos.csv");

        public List<Amigo> LerAmigosDoArquivo()
        {
            List<Amigo> listaDeAmigos = new List<Amigo>();

            if (File.Exists(caminhoDoArquivoAmigos))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoAmigos))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string linha = streamReader.ReadLine();
                        string[] dados = linha.Split(';');
                        listaDeAmigos.Add(new Amigo(dados[0], dados[1]));
                    }
                }
            }

            return listaDeAmigos;
        }

        public void SalvarAmigosNoArquivo(List<Amigo> listaDeAmigos)
        {
            if (!Directory.Exists(Path.GetDirectoryName(caminhoDoArquivoAmigos)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoDoArquivoAmigos));
            }

            using (StreamWriter writer = new StreamWriter(caminhoDoArquivoAmigos))
            {
                foreach (var amigo in listaDeAmigos)
                {
                    writer.WriteLine($"{amigo.Nome};{amigo.Email}");
                }
            }
        }

        public List<Tuple<Amigo, Amigo>> LerParesDosAmigosSecretos()
        {
            List<Tuple<Amigo, Amigo>> paresAmigosSecretos = new List<Tuple<Amigo, Amigo>>();

            if (File.Exists(caminhoDoArquivoSecretos))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoSecretos))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string linha = streamReader.ReadLine();
                        string[] dados = linha.Split(';');

                        if (dados.Length >= 4)
                        {
                            Amigo amigoEsquerdo = new Amigo(dados[0], dados[1]);
                            Amigo amigoDireito = new Amigo(dados[2], dados[3]);

                            paresAmigosSecretos.Add(new Tuple<Amigo, Amigo>(amigoEsquerdo, amigoDireito));
                        }
                        else
                        {
                            MessageBox.Show("Arquivo com dados insuficientes.");
                        }
                    }
                }
            }

            return paresAmigosSecretos;
        }

        public void SalvarParesDosAmigosSecretos(List<Tuple<Amigo, Amigo>> paresAmigosSecretos)
        {
            if (!Directory.Exists(Path.GetDirectoryName(caminhoDoArquivoSecretos)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoDoArquivoSecretos));
            }

            using (StreamWriter streamWriter = new StreamWriter(caminhoDoArquivoSecretos))
            {
                foreach (var par in paresAmigosSecretos)
                {
                    string linha = $"{par.Item1.Nome};{par.Item1.Email};{par.Item2.Nome};{par.Item2.Email}";
                    streamWriter.WriteLine(linha);
                }
            }
        }
        public void LimparConteudoDosArquivos()
        {
            LimparConteudoDoArquivo(caminhoDoArquivoAmigos);
            LimparConteudoDoArquivo(caminhoDoArquivoSecretos);
        }

        private void LimparConteudoDoArquivo(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.Write(string.Empty);
                }
            }
        }
    }
}
