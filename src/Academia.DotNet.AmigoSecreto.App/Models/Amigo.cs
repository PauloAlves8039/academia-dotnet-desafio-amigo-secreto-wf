namespace Academia.DotNet.AmigoSecreto.App.Models
{
    public class Amigo
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome} - {Email}";
        }

        public override bool Equals(object obj)
        {
            if (obj is null || ReferenceEquals(this, obj))
            {
                return false;
            }

            if (obj is Amigo amigo)
            {
                return Email.Equals(amigo.Email, StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode(StringComparison.OrdinalIgnoreCase);
        }
    }
}
