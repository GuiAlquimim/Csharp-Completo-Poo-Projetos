namespace _155_exercicio_proposto_excecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
