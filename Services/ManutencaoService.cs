using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels.Manutencao;

namespace VoeAirlines.Services;


public class ManutencaoService{

    private readonly VoeAirlinesContext _context;


     public ManutencaoService(VoeAirlinesContext context)
    {
        _context = context;
    }


 public DetalhesManutencaoViewModel AdicionarManutecao(AdicionarManutencaoAeronaveViewModel dados)
    {
        

        var manutencao = new Manutencao(dados.DataHora, dados.Observacao, dados.AeronaveId);


        _context.Add(manutencao);
        _context.SaveChanges();


        

        return new DetalhesManutencaoViewModel
        (
            manutencao.DataHora,
            manutencao.Observacao,
            manutencao.AeronaveId
       
        );
      
    }


     public IEnumerable<ListarManutencaoAeronaveViewModel> ListarManutencaoAeronaves(){

        return _context.Manutencoes.Select(a=>new ListarManutencaoAeronaveViewModel(a.DataHora, a.Observacao, a.AeronaveId));

    }


        public DetalhesManutencaoViewModel? ListarManutencaoPeloId(int id){

        var manutencao = _context.Manutencao.Find(id);
        if(manutencao != null){
            return new DetalhesManutencaoViewModel(
                manutencao.DataHora,
                manutencao.Observacao,
                manutencao.AeronaveId
            );
        }
        return null;



    }
          public void ExcluirManutencao(int id){
        var manutencao = _context.Manutencoes.Find(id);
        if(manutencao != null){
            _context.Remove(manutencao);
            _context.SaveChanges();
        }
    }
  

        public DetalhesManutencaoViewModel? AtualizarManutencao(AtualizarManutencaoAeronaveViewModel dados){
              
              var manutencao = _context.Manutencoes.Find(dados.Id);
              if(manutencao != null){
                  manutencao.DataHora = dados.DataHora;
                  manutencao.Observacao = dados.Observacao;
                  manutencao.AeronaveId = dados.AeronaveId;
                  _context.Update(manutencao);
                  _context.SaveChanges();
                  return new DetalhesManutencaoViewModel(manutencao.Id,manutencao.DataHora,manutencao.Observacao,manutencao.AeronaveId);

              }
              return null; 
     
    }

    














}