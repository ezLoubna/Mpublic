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
    
    public partial class PoursuiteJuridique
    {
        public int PoursuiteJuridiqueId { get; set; }
        public long NumeroPole { get; set; }
        public int JuridictionId { get; set; }
        public long NumeroDossier { get; set; }
        public string Accusation { get; set; }
        public string ChaitreSuivi { get; set; }
        public long PartieId { get; set; }
    
        public virtual Juridiction Juridiction { get; set; }
        public virtual Partie Partie { get; set; }
    }
}