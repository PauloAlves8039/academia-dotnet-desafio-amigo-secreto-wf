using Academia.DotNet.AmigoSecreto.App.Models;
using System.Text.RegularExpressions;

namespace Academia.DotNet.AmigoSecreto.App.Utils
{
    public static class Utilitario
    {
        public static bool ValidarNome(string nomeInformado)
        {
            if (string.IsNullOrWhiteSpace(nomeInformado))
            {
                MessageBox.Show("Nome não pode estar em branco. Por favor, insira um nome válido.", "Aviso");
                return false;
            }

            if (!nomeInformado.Contains(" "))
            {
                MessageBox.Show("O nome deve conter pelo menos um espaço para o sobrenome. Por favor, insira um nome completo.", "Aviso");
                return false;
            }

            return true;
        }

        public static bool ValidarFormatoDoEmail(string emailInformado)
        {
            if (string.IsNullOrWhiteSpace(emailInformado))
            {
                MessageBox.Show("O email não pode estar em branco. Por favor, insira um email válido.", "Aviso");
                return false;
            }

            var formatoDoEmail = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            if (!Regex.IsMatch(emailInformado, formatoDoEmail))
            {
                MessageBox.Show("O formato do email não é válido. Por favor, insira um email válido.", "Aviso");
                return false;
            }

            return true;
        }

        public static void OrdenarAmigosPorNome(List<Amigo> amigos)
        {
            amigos.Sort((amigo1, amigo2) => amigo1.Nome.CompareTo(amigo2.Nome));
        }
    }
}
