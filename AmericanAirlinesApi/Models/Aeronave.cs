namespace AmericanAirlinesApi.Models
{
    public class Aeronave
    {
        public int Id {get; set;}
        public required string Modelo {get; set;}
        public required string CodigoCauda {get; set;}
        public int CapacidadePassageiros {get; set;}
        
    }
}