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
    
    public partial class Audience
    {
        public int AudienceId { get; set; }
        public System.DateTime AnneeAudience { get; set; }
        public int DecisionId { get; set; }
        public long PartieId { get; set; }
    
        public virtual Decision Decision { get; set; }
        public virtual Partie Partie { get; set; }
    }
}