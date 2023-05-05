using Template.Models;

namespace Template.Data
{
    public interface IPersonneRepo
    {
        IEnumerable<Personne> GetAllPersonnes();
        Personne getPersonne(Guid id);

        Personne createPersonne(Personne p);
        Personne deletePersonne(Guid id);
        List<Personne> createPersonneRange(List<Personne> p);
    }
}