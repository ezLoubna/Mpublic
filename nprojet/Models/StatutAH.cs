//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nprojet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatutAH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatutAH()
        {
            this.CoordonneesProfessionnelles = new HashSet<CoordonneesProfessionnelles>();
        }
    
        public int StatutAHId { get; set; }
        public string libelle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoordonneesProfessionnelles> CoordonneesProfessionnelles { get; set; }
    }
}
