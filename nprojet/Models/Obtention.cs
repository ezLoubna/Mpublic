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
    
    public partial class Obtention
    {
        public long ObtentionId { get; set; }
        public long PartieId { get; set; }
        public long CategorieId { get; set; }
        public long SpecialiteId { get; set; }
        public Nullable<System.DateTime> Annee { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Partie Partie { get; set; }
        public virtual Specialite Specialite { get; set; }
    }
}
