namespace MoneyMap.Api.Models
{
    public class Transacao
    {
        public Guid TransacaoId { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Tipo { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
    }
}