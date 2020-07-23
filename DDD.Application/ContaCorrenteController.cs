using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDD.Domain.Entities;
using DDD.Service.Services;
using DDD.Service.Validators;

namespace DDD.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
         private ContaCorrenteService<ContaCorrente> service = new ContaCorrenteService<ContaCorrente>();

    [HttpPost]
    public IActionResult CriaConta([FromBody] ContaCorrente item)
    {
        try
        {
            service.Post<ContaCorrenteValidator>(item);

            return new ObjectResult(item.Id);
        }
        catch(ArgumentNullException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPut]
    public IActionResult Altera([FromBody] ContaCorrente item)
    {
        try
        {
            service.Put<ContaCorrenteValidator>(item);

            return new ObjectResult(item);
        }
        catch(ArgumentNullException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
    [HttpDelete("{Conta}")]
     public IActionResult DeletaConta(int Conta)
    {
        try
        {
            service.Delete(Conta);

            return new NoContentResult();
        }
        catch(ArgumentException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet]
    public IActionResult BuscaConta()
    {
        try
        {
            return new ObjectResult(service.Get());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("{id}", Name = "Busca")]
    public IActionResult Get(int id)
    {
        try
        {
            return new ObjectResult(service.Get(id));
        }
        catch(ArgumentException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
    [HttpPut("{Conta}", Name = "Credito")]
    public IActionResult Credito([FromBody] ContaCorrente item, decimal valor)
    {
        try
        {
           
           service.Credito(item,valor);
           return new ObjectResult(item);
        }
        catch(ArgumentException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPut("{Conta}", Name = "Saque")]
    public IActionResult Saque([FromBody] ContaCorrente item, decimal valor)
    {
        try
        {
           
           service.Saque(item,valor);
           return new ObjectResult(item);
        }
        catch(ArgumentException ex)
        {
            return NotFound(ex);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
    }
    
}