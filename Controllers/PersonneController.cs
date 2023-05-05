using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Template.Data;
using Template.Dtos;
using Template.Models;

namespace Template.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonneController : ControllerBase
{
    private readonly IPersonneRepo _repo;
    private readonly IMapper _mapper;
    private readonly ILogger<PersonneController> _logger;

    public PersonneController(ILogger<PersonneController> logger, IPersonneRepo repo, IMapper mapper)
    {
        _logger = logger;
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet("All")]
    public ActionResult<IEnumerable<PersonneReadDto>> GetAllPersonnes()
    {
        var personnes = _repo.GetAllPersonnes();
        if (personnes != null)
        {
            return Ok(_mapper.Map<IEnumerable<PersonneReadDto>>(personnes));
        }
        return NotFound();
    }

    [HttpGet("GetPersonne")]
    public ActionResult<PersonneReadDto> GetPersonne(Guid id)
    {
        var personne = _repo.getPersonne(id);
        if (personne != null)
        {
            return Ok(_mapper.Map<PersonneReadDto>(personne));
        }
        return NotFound();
    }

    [HttpPost("CreatePersonne")]
    public Personne createPersonne(Personne p)
    {
        return _repo.createPersonne(p);
    }
    [HttpDelete]
    public Personne deletePersonne(Guid id)
    {
        var ev = _repo.deletePersonne(id);
        return ev;
    }

}
