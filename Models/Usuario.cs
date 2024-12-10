namespace MoneyMap.Api.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}