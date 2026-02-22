namespace LlamadaRemota.Repositories
{
    public class CreditosRealizado
    {
        public int idCreditosRealizado { get; set; }
        public int idCliente { get; set; }
        public int idFondosCredito { get; set; }
        public DateTime fechaCredito { get; set; }
        public decimal valorPrestado { get; set; }
        public int noCuotas { get; set; }
    }
}
