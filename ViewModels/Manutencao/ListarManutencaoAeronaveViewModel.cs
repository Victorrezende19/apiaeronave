//ID, CODIGO, MODELO
//não precisa do fabricante.

using VoeAirlines.Entities;
using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;
public class ListarManutencaoAeronaveViewModel
{
    public ListarManutencaoAeronaveViewModel(DateTime dataHora, string observacao, int aeronaveId)
    {

        DataHora = dataHora;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    //Gera Construtor desses aqui
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public string Observacao { get; set; }
    public TipoManuntecao Tipo{get;set;}
    public int AeronaveId { get; set; }
    //Não gera construtor
    public Aeronave Aeronave { get; set; } = null!;

}
