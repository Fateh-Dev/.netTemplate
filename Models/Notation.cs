using System.ComponentModel.DataAnnotations;
using Template.Dtos;

namespace template.Models
{
    public class Notation
    {
        public Notation()
        {
        }
        public Notation(double note, Desciplines desciplineCode)
        {
            this.Note = note;
            this.SetDescipline(desciplineCode);
        }
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid IdPersonne { get; set; } = Guid.Parse("4BA26E97-8DAE-4D31-9995-4418B5F4952C");
        public Desciplines DesciplineCode { get; set; }
        public string Descipline { get; set; }
        public double Note { get; set; }
        public bool IsTest { get; set; } = false;
        public bool IsRevision { get; set; } = false;
        /*      Vol Normal = 1;     Test Partiel = 2;       Test Final = 3;     Vol de Revision = 0.75;     */
        public double Coefficient { get; set; } = 1;
        public Phase PhaseFormationCode { get; set; } // VOL <OR> SOL
        public string PhaseFormationDisplay { get; set; }
        public string Description { get; set; } = "";



        public void SetAsTestPartiel()
        {
            this.Coefficient = 2;
            this.IsTest = true;
            this.SetPhase(Phase.Vol);
            this.Description = "Note du test Partiel : " + this.Note;
        }
        public void SetAsTestFinal()
        {
            this.Coefficient = 3;
            this.IsTest = true;
            this.SetPhase(Phase.Vol);
            this.Description = "Note du test Final : " + this.Note;
        }
        public void SetAsNoteRevision()
        {
            //TODO TO BE CONTINUED
            this.Coefficient = 0.75;
            this.IsRevision = true;
            this.SetPhase(Phase.Vol);
            this.Description = "Note de Revision : " + this.Note;
        }
        public void SetAsSolDescipline(Desciplines desciplineCode)
        {
            //TODO TO BE CONTINUED
            switch (desciplineCode)
            {
                case Desciplines.Descipline_1: { this.Coefficient = 5; break; }
                case Desciplines.Descipline_2: { this.Coefficient = 5; break; }
                case Desciplines.Descipline_3: { this.Coefficient = 6; break; }
                case Desciplines.Descipline_4: { this.Coefficient = 7; break; }
                default: { this.Coefficient = 6; break; }
            }
            this.SetPhase(Phase.Sol);
            this.SetDescipline(desciplineCode);
            this.Description = "Note de " + this.Descipline + " : " + this.Note;
        }
        public void SetDescipline(Desciplines Code)
        {
            this.DesciplineCode = Code;
            this.Descipline = Code.ToString();
        }
        public void SetPhase(Phase Code)
        {
            this.PhaseFormationCode = Code;
            this.PhaseFormationDisplay = Code.ToString();
        }

    }
    public class NotationCreatePayLoad
    {
        public Guid IdPersonne { get; set; }
        public Desciplines DesciplineCode { get; set; } // Phase 
        public double Note { get; set; }
        public TypeNote Type { get; set; }

        // la personne - descipline - note - typeNote(test p|f|revision|non) 
    }
    public enum TypeNote
    {
        Undefind,
        Partiel,
        Final,
        Revision
    }
    public enum Phase
    {
        Undefind,
        Sol,
        Vol
    }
    public enum Desciplines
    {
        Undefind,
        Preselection,
        Perfectionnement,
        Navigation,
        Formation,
        Descipline_1, // Sol
        Descipline_2, // Sol
        Descipline_3, // Sol
        Descipline_4, // Sol
        Descipline_5, // Sol
    }
    public class NotesGroup
    {
        public List<NoteReturnDto> Notes { get; set; }
        public double SommeCoefficient { get; set; }
        public double SommeNotes { get; set; }
        public string PhaseFormation { get; set; }
        public double Moyenne { get; set; }
        public NotesGroup(List<NoteReturnDto> _notes)
        {
            Notes = _notes;
            SommeCoefficient = _notes.Sum(o => Math.Ceiling(o.Coefficient));
            SommeNotes = _notes.Sum(o => o.TotalNote);
            PhaseFormation = _notes.First().PhaseFormationCode.ToString();
            Moyenne = SommeNotes / SommeCoefficient;
        }

    }
    public class NotesGroupGlobale
    {
        public IDictionary<Desciplines, NotesGroup> DetailsNotes { get; set; }
        public double SommeCoefficient { get; set; }
        public double SommeNotes { get; set; }
        // public string PhaseFormation { get; set; }
        public double Moyenne { get; set; }
        public NotesGroupGlobale(IDictionary<Desciplines, NotesGroup> dict)
        {
            DetailsNotes = dict;
            SommeCoefficient = dict.Sum(o => Math.Ceiling(o.Value.SommeCoefficient));
            SommeNotes = dict.Sum(o => Math.Ceiling(o.Value.SommeNotes));
            // PhaseFormation = "";
            Moyenne = SommeNotes / SommeCoefficient;
        }



    }
}