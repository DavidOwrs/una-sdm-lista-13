namespace AmericanAirlinesApi.Models
{
    public class Reserva
    {
        public int Id {get; set;}
        public required int VooId {get; set;}
        public required string NomePassageiro {get; set;}
        public required string Assento {get; set;}

    }
}