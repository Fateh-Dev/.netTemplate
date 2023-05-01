using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Data;
using Template.Models;
using Template.Models.Auth;
using Newtonsoft.Json;
using Template.Dtos;
using AutoMapper;

namespace Template.Controllers;

[ApiController]
[Route("[controller]")]
public class ExternalServersController : ControllerBase
{
    private readonly ILogger<PersonneController> _logger;
    private readonly TemplateContext _context;
    // private readonly IPersonneRepo _repo;
    private readonly IMapper _mapper;

    public ExternalServersController(ILogger<PersonneController> logger, TemplateContext context, IPersonneRepo repo, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("All")]
    public ActionResult<IEnumerable<ExternalEntity>> GetAllServers()
    {
        var servers = _context.ExternalEntities.ToList();
        if (servers != null)
        {
            return Ok(servers);
        }
        return NotFound();
    }

    [HttpGet("GetServerByName")]
    public ActionResult<ExternalEntity> GetServer(string serverName)
    {
        var server = _context.ExternalEntities.FirstOrDefault(o => o.ServerName == serverName);
        if (server != null)
        {
            return Ok(server);
        }
        return NotFound();
    }

    [HttpPost("CreateServerConfig")]
    public ExternalEntity createPersonne(ExternalEntity server)
    {
        ExternalEntity e = new ExternalEntity()
        {
            ServerName = "Server-name",
            ServerUrl = server.ServerUrl,
            Port = server.Port,
            Address = server.Address
        };
        _context.ExternalEntities.Add(e);
        _context.SaveChanges();
        return e;
    }

    [HttpPut("updateServerConfig")]
    public ExternalEntity updateServer(ExternalEntity server)
    {
        ExternalEntity ev = _context.ExternalEntities.AsNoTracking().FirstOrDefault(o => o.ServerName == server.ServerName);
        if (ev != null)
        {
            ev = server;
            _context.Entry(ev).State = EntityState.Modified;
            _context.SaveChanges();
        }
        return ev;
    }


    [HttpDelete]
    public ExternalEntity deletePersonne(string serverName)
    {
        var ev = _context.ExternalEntities.FirstOrDefault(o => o.ServerName == serverName);
        if (ev != null)
            _context.ExternalEntities.Remove(ev);
        _context.SaveChanges();
        return ev;
    }
    [HttpGet("Connect")]
    public async Task<HttpResponseMessage> connect()
    {
        string ServerUrl = "https://localhost:7161/Users/authenticate";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        // Pass the handler to httpclient(from you are calling api)
        HttpClient httpClient = new HttpClient(clientHandler);
        // HttpClient httpClient = new HttpClient();
        // Try To Connect To Server 
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, ServerUrl);
        request.Content = new StringContent("{ \"username\": \"string\", \"password\": \"strikng\" }", Encoding.UTF8, "application/json");
        // request.Content = new FormUrlEncodedContent(new[] {
        //             new KeyValuePair<string, string>("username", "string"),
        //             new KeyValuePair<string, string>("password", "string"),
        //         });
        HttpResponseMessage response = await httpClient.SendAsync(request);
        // if (response.IsSuccessStatusCode)
        // {
        //     string val = await response.Content.ReadAsStringAsync();
        //     AuthenticateResponse credentials = JsonConvert.DeserializeObject<AuthenticateResponse>(await response.Content.ReadAsStringAsync());
        // }

        // Send payload to Server 

        // Get Response   

        /* 
            200 OK 
            204 No Content
            400 Bad Request 
            401 Unauthorized
            403 Forbidden
            404 Not Found
            408 Request Time Out
            500 Internal Error on Server
        */

        return response;
    }

    [HttpGet("AllPersonnes")]
    public async Task<ActionResult<IEnumerable<PersonneReadDto>>> GetAllPersonnes()
    {
        HttpResponseMessage connection = await this.connect();

        if (connection.IsSuccessStatusCode)
        {
            AuthenticateResponse credentials = JsonConvert.DeserializeObject<AuthenticateResponse>(await connection.Content.ReadAsStringAsync());

            var personnes = await _context.Personnes.ToListAsync();
            if (personnes != null)
            {
                return Ok(_mapper.Map<IEnumerable<PersonneReadDto>>(personnes));
            }
            return NotFound();
        }
        else
        {
            switch (connection.StatusCode)
            {
                case HttpStatusCode.Unauthorized: return Unauthorized();
                case HttpStatusCode.Forbidden: return Forbid();
                case HttpStatusCode.BadRequest: return BadRequest();
                case HttpStatusCode.NoContent: return NoContent();
                default: return BadRequest();
            }
        }
    }


}
