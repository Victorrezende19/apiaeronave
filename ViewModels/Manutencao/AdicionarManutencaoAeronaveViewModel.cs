using VoeAirlines.Entities;
using VoeAirlines.Entities.Enums;
using VoeAirlines.ViewModels.Manutencao;
//SEM ID
namespace VoeAirlines.ViewModels.Manutencao;

public class AdicionarManutencaoAeronaveViewModel
{
    public AdicionarManutencaoAeronaveViewModel(DateTime dataHora, string observacao, int aeronaveId)
    {

        DataHora = dataHora;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    //Gera Construtor desses aqui
    
    public DateTime DataHora { get; set; }
    public string Observacao { get; set; }
    public TipoManuntecao Tipo{get;set;}
    public int AeronaveId { get; set; }
    //Não gera construtor
    public Aeronave Aeronave { get; set; } = null!;



}
