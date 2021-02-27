namespace ApiLocadoraVeiculo.Domain.Entitys
{
    public class Veiculo : Base
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagem { get; set; }
        public bool IsDisponivel { get; set; }
    }
}