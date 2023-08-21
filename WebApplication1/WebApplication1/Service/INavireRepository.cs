using WebApplication1.Models;

namespace WebApplication1.Service
{
    public interface INavireRepository
    {
        IEnumerable<Navire> GetAllNavires();
        Navire GetNavireByNumero(int numero);
        void AddNavire(Navire navire);
        void UpdateNavire(Navire navire);
        void DeleteNavire(int numero);
    }
}
