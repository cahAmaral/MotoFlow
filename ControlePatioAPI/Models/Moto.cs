namespace ControlePatioAPI.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? QrCode { get; set; }
        public string? Status { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
    }
}
