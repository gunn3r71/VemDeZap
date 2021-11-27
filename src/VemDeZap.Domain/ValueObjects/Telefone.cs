namespace VemDeZap.Domain.ValueObjects
{
    public class Telefone
    {
        public Telefone(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }
    }
}
