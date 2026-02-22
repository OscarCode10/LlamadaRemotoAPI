using LlamadaRemota.Repositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CreditosController : ControllerBase
{
    private readonly ICreditosRepository _creditosRepository;

    public CreditosController(ICreditosRepository creditosRepository)
    {
        _creditosRepository = creditosRepository;
    }

    [HttpPost]
    public IActionResult CreateCredito([FromBody] CreditosRealizado creditosRealizado)
    {
        if (creditosRealizado == null)
            return BadRequest();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _creditosRepository.CreateCredito(creditosRealizado);

        return NoContent();
    }
}