using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;


namespace VoeAirlines.Services;

public class CancelamentoService{
    
    
    //propriedade para injeção de dependência
    private readonly VoeAirlinesContext _context;
     public CancelamentoService(VoeAirlinesContext context)
    {
        _context = context;
    }

     public DetalhesCancelamentoViewModel AdicionarCancelamento(AdicionarCancelamentoViewModel dados)
    {
        

        var cancelamento = new Cancelamento(dados.Motivo,dados.DataHoraNotificacao);

        _context.Add(cancelamento);
        _context.SaveChanges();

        return new DetalhesCancelamentoViewModel
        (
            cancelamento.Motivo,
            cancelamento.DataHoraNotificacao
        );
    } 



public IEnumerable<ListarCancelamentoViewModel> ListarCancelamentoAeronaves(){

        return _context.Cancelamentos.Select(a=>new ListarCancelamentoViewModel(a.Motivo,a.DataHoraNotificacao));

    }


 public DetalhesCancelamentoViewModel? ListarCancelamentoPeloId(int id){

        var cancelamento = _context.Cancelamentos.Find(id);
        if(cancelamento != null){
            return new DetalhesCancelamentoViewModel(
                cancelamento.Motivo,
                cancelamento.DataHoraNotificacao );
        }
        return null;
    }



 public void ExcluirAeronave(int id){
        var cancelamento = _context.Cancelamentos.Find(id);
        if(cancelamento != null){
            _context.Remove(cancelamento);
            _context.SaveChanges();
        }
    }

 

}
