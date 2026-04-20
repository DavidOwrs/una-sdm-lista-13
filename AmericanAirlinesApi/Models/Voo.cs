namespace AmericanAirlinesApi.Models
{
    public class Voo
    {
        public int Id {get; set;}
        public required string CodigoVoo {get; set;}
        public required string Origem {get; set;}
        public required string Destino {get; set;}
        public required int AeronaveId {get; set;}
        public required Aeronave Aeronave { get; set; }
        public required string Status {get; set;}

    }
}