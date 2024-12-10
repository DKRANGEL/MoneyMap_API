namespace MoneyMap.Api.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public Guid? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}