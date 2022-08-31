namespace VoeAirlines.ViewModels;
public class DetalhesCancelamentoViewModel
{
    public DetalhesCancelamentoViewModel(string motivo, DateTime dataHoraNotificacao)
    {
        Motivo = motivo;
        DataHoraNotificacao = dataHoraNotificacao;
    }

    public int Id { get; set; }
    public string Motivo { get; set; }
     
    public DateTime DataHoraNotificacao { get; set; }
    
    public int VooId { get; set; }

    public Voo Voo { get; set; } =null!;
    


    

}


