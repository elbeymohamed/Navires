using WebApplication1.Models;

namespace WebApplication1.Service
{
    public static class MockDatabase
    {
        private static List<Navire> navires = new List<Navire>
        {
            new Navire { Numero = 1,  Nom = "Navire A", Annee = 2020, Longueur = 100,
                         Largeur = 20, TonnageBrut = 100, TonnageNet = 80, Note = "Marchendise dangereuse" },
            new Navire { Numero = 2,  Nom = "Navire B", Annee = 2021, Longueur = 200,
                         Largeur = 40, TonnageBrut = 200, TonnageNet = 160, Note = "Marchendise industruelle" },
            new Navire { Numero = 3,  Nom = "Navire c", Annee = 2022, Longueur = 300,
                         Largeur = 30, TonnageBrut = 300, TonnageNet = 240, Note = "Marchendise agricole" },

        };

        public static List<Navire> GetAllNavires()
        {
            return navires;
        }

        public static Navire GetNavireById(int numero)
        {
            Navire navire = navires.Find(p => p.Numero == numero);
            return navire;
        }

        public static void AddNavire(Navire navire)
        {
            navire.Numero = navires.Count + 1; // Generating a new ID
            navires.Add(navire);
        }

        public static void UpdateNavire(Navire updatedNavire)
        {
            int index = navires.FindIndex(navire => navire.Numero == updatedNavire.Numero);
            if (index != -1)
            {
                navires[index] = updatedNavire;
            }
        }

        public static void DeleteNavire(int id)
        {
            Navire navireToRemove = navires.Find(navire => navire.Numero == id);
            if (navireToRemove != null)
            {
                navires.Remove(navireToRemove);
            }
        }
    }
}
