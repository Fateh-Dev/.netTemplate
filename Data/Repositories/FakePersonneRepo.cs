// using Template.Models;

// namespace Template.Data
// {
//     public class Fake : IPersonneRepo
//     {

//         public Personne getPersonne(int id)
//         {
//             return new Personne() { Nom = "Djehinet", Prenom = "Fateh", Age = 30 };
//         }

//         public IEnumerable<Personne> GetAllPersonnes()
//         {
//             return new List<Personne>{
//               new Personne() {  Nom = "Djehinet", Prenom = "Djawed", Age = 1 },
//              new Personne() {  Nom = "Djehinet", Prenom = "Fateh", Age = 30 }
//             };
//         }

//         public Personne createPersonne(Personne p)
//         {
//             return new Personne() { Nom = "Djehinet", Prenom = "Fateh", Age = 30 };
//         }

//         public List<Personne> createPersonneRange(List<Personne> p)
//         {
//             return new List<Personne>{
//               new Personne() {   Nom = "Djehinet", Prenom = "Djawed", Age = 1 },
//              new Personne() {   Nom = "Djehinet", Prenom = "Fateh", Age = 30 }
//             };
//         }

//         public Personne getPersonne(Guid id)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }