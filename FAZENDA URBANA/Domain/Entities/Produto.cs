namespace Domain.Entities
   
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco {  get; set; }
        public bool Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}