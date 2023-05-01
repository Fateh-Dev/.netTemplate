using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using template.Models;
using Template.Data;
using Template.Dtos;
using Template.Models;

namespace Template.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    private readonly IPersonneRepo _repo;
    private readonly IMapper _mapper;
    private readonly TemplateContext _context;
    private readonly ILogger<PersonneController> _logger;

    public NotesController(ILogger<PersonneController> logger, TemplateContext context, IPersonneRepo repo, IMapper mapper)
    {
        _logger = logger;
        _repo = repo;
        _mapper = mapper;
        _context = context;
    }

    [HttpGet("allByPersonne")]
    public ActionResult<Dictionary<string, IDictionary<Desciplines, NotesGroup>>> GetAllNotes()
    {
        IDictionary<Desciplines, NotesGroup> ResultNotes = new Dictionary<Desciplines, NotesGroup>();
        IDictionary<string, NotesGroupGlobale> ResultNotesGlobal = new Dictionary<string, NotesGroupGlobale>();
        var notes = _context.Notations.ToList();

        if (notes != null)
        {
            var Keys = notes.Select(o => o.DesciplineCode).Distinct().ToList();
            foreach (var item in Keys)
            {
                var _notes = _mapper.Map<List<NoteReturnDto>>(notes.Where(o => o.DesciplineCode == item).ToList());
                ResultNotes.Add(item, new NotesGroup(_notes));
            }

            var KeysGlobale = notes.Select(o => o.PhaseFormationDisplay).Distinct().ToList();
            foreach (var item in KeysGlobale)
            {
                var _notes = ResultNotes.Where(o => o.Value.PhaseFormation == item);
                var newDictionary = _notes.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                ResultNotesGlobal.Add(item, new NotesGroupGlobale(newDictionary));
            }

            return Ok(ResultNotesGlobal);
        }

        return NotFound();
    }

    [HttpGet("getNotesByPersonne")]
    public ActionResult<Notation> GetNotes(Guid id)
    {
        var notes = _context.Notations.Where(o => o.IdPersonne == id).ToList();
        if (notes != null)
        {
            return Ok(notes);
        }
        return NotFound();
    }

    [HttpPost("createNotes")]
    public Notation createNote(NotationCreatePayLoad n)
    {
        // TODO LATER WRAP
        Notation Note = new Notation(n.Note, n.DesciplineCode);
        if (n.DesciplineCode == Desciplines.Descipline_1
             || n.DesciplineCode == Desciplines.Descipline_2
             || n.DesciplineCode == Desciplines.Descipline_3
             || n.DesciplineCode == Desciplines.Descipline_4
             || n.DesciplineCode == Desciplines.Descipline_5)
            Note.SetAsSolDescipline(n.DesciplineCode);
        else Note.SetPhase(Phase.Vol);
        switch (n.Type)
        {
            case (TypeNote.Final):
                { Note.SetAsTestFinal(); break; }
            case (TypeNote.Partiel):
                { Note.SetAsTestPartiel(); break; }
            case (TypeNote.Revision):
                { Note.SetAsNoteRevision(); break; }
            default: { break; }
        }

        _context.Notations.Add(Note);
        _context.SaveChanges();
        return Note;
    }

    [HttpGet("TestNotation")]
    public ActionResult<Notation> TestNotation(Guid id)
    {
        Notation Note = new Notation(15, Desciplines.Preselection);
        // Note.SetAsNoteRevision();
        // Note.SetAsTestFinal();
        Note.SetAsTestPartiel();
        return Ok(Note);
    }

}
