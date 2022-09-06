using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Services;
using VoeAirlines.ViewModels;

[Route("api/aeronaves")]
[ApiController]
public class CancelamentoController: ControllerBase{
    
    private readonly CancelamentoService _cancelamentoService;

    public CancelamentoController(CancelamentoService cancelamentoService)
    {
        _cancelamentoService = cancelamentoService;
    }
    [HttpPost]
    public IActionResult AdicionarCancelamento(AdicionarCancelamentoViewModel dados){
       
       var cancelamento = _cancelamentoService.AdicionarCancelamento(dados);
       return Ok(cancelamento);

    }
[HttpGet]
    public IActionResult ListarCancelamentoAeronaves(){
        return Ok(_cancelamentoService.ListarCancelamentoAeronaves());
    }
    
public IActionResult ListarCancelamentoPeloId(int id){
        
        var cancelamento = _cancelamentoService.ListarCancelamentoPeloId(id);
        if(cancelamento!=null){
            return Ok(cancelamento);
        }
        return NotFound();
    }







}

