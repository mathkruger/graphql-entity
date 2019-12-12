namespace APIProdutos.Models
{
    public class Categoria
    {
        private string _codigo;
        public string Codigo
        {
            get => _codigo;
            set => _codigo = value?.Trim().ToUpper();
        }

        private string _descricao;
        public string Descricao
        {
            get => _descricao;
            set => _descricao = value?.Trim();
        }

        // public IEnumerable<Produto> Produtos { get; set; }
    }
}