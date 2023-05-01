using System.ComponentModel.DataAnnotations;
using template.Models;

namespace Template.Dtos
{
    public class NoteReadDto
    {
        // public Guid Id { get; set; } = Guid.NewGuid();
        // public Guid IdPersonne { get; set; } = Guid.Parse("4BA26E97-8DAE-4D31-9995-4418B5F4952C");
        public Desciplines DesciplineCode { get; set; }
        // public string Descipline { get; set; }
        public double Note { get; set; }
        public bool IsTest { get; set; } = false;
        public bool IsRevision { get; set; } = false;
        /*      Vol Normal = 1;     Test Partiel = 2;       Test Final = 3;     Vol de Revision = 0.75;     */
        public double Coefficient { get; set; } = 1;
        public Phase PhaseFormationCode { get; set; } // VOL <OR> SOL
        // public string PhaseFormationDisplay { get; set; }
        // public string Description { get; set; } = "";

    }
    public class NoteReturnDto
    {
        public Desciplines DesciplineCode { get; set; }
        public double Note { get; set; }
        public bool IsTest { get; set; } = false;
        public bool IsRevision { get; set; } = false;
        public double Coefficient { get; set; } = 1;
        public Phase PhaseFormationCode { get; set; }
        public double TotalNote { get; set; }

    }
}