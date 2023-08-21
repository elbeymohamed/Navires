using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    
    public class Navire
    {
        [Required(ErrorMessage = "Numero est obligatoire")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Nom est obligatoire")]
        public string Nom { get; set; }
        public int Annee { get; set; }

        [Required(ErrorMessage = "Longueur est obligatoire")]
        public float Longueur { get; set; }

        [Required(ErrorMessage = "Largeur est obligatoire")]
        public float Largeur { get; set; }

        public int TonnageBrut { get; set; }
        public int TonnageNet { get; set; }

        [Required(ErrorMessage = "Note est obligatoire")]
        public string Note { get; set; }
    }
}
