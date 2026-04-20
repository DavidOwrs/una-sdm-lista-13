namespace AmericanAirlinesApi.Models
{
    public class Tripulante
    {
        public int Id {get; set;}
        public required string Nome {get; set;}
        public required string Função {get; set;}
        public decimal NumeroLicenca {get; set;}

    }
}