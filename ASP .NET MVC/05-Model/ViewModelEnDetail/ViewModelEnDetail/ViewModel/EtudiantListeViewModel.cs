using ViewModelEnDetail.Models;

namespace ViewModelEnDetail.ViewModel
{
    public class EtudiantListeViewModel
    {
        public int Id { get; set; }
        public string NomComplet {  get; set; } // Prénom + nom combinés 
        public string Email { get; set; }
        public int Age { get; set; } // age calculé 
        public int ClasseId { get; set; }
        public string NomDeLaClasse { get; set; } // relation résolue 
    }
}
