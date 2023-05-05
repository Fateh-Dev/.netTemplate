using Template.Models;

namespace Template.Data
{
    public class SqlPersonneRepo : IPersonneRepo
    {
        private readonly TemplateContext _context;

        public SqlPersonneRepo(TemplateContext context)
        {
            _context = context;
        }

        public Personne createPersonne(Personne p)
        {
            _context.Personnes.Add(p);
            _context.SaveChanges();
            return p;
        }

        public List<Personne> createPersonneRange(List<Personne> p)
        {
            _context.Personnes.AddRange(p);
            _context.SaveChanges();
            return p;
        }

        public Personne deletePersonne(Guid id)
        {
            var ev = getPersonne(id);
            _context.Remove(ev);
            _context.SaveChanges();
            return ev;
        }

        public IEnumerable<Personne> GetAllPersonnes()
        {
            return _context.Personnes.ToList();
        }

        public Personne getPersonne(Guid id)
        {
            return _context.Personnes.FirstOrDefault(e => e.Id == id);
        }

    }
}