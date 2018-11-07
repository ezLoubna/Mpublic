using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nprojet.Models
{
    public class PersonModel
    {
        public long Id { get; set; }
        public String Nom { get; set; }

        public String Prenom { get; set; }

        public String DateNaissance { get; set; }

        public String LieuNaissance { get; set; }

        public int GenreId { get; set; }
        public String Genre { get; set; }
        public String Cin { get; set; }

        public long NationaliteId { get; set; }
        public String Nationalite { get; set; }
        public String Adresse { get; set; }
        public long VilleId { get; set; }
        public String Ville { get; set; }

        public int MetierId { get; set; }
        public String Metier { get; set; }
        public long CategorieId { get; set; }
        public String Categorie { get; set; }
        public long SpecialiteId { get; set; }
        public String Specialite { get; set; }
        public String Annee { get; set; }
        public long BarreauId { get; set; }
        public String Barreau { get; set; }
        public long ReferenceNat { get; set; }
        public long OrganId { get; set; }
        
        public String Organ { get; set; }
        public long SituationPId { get; set; }
        public String SituationP{ get; set; }
        public String AnneeDA { get; set; }
        public String AnneeAY { get; set; }
        public long CourCassationId { get; set; }
        public String CourCassation { get; set; }
        public String AnneeACC { get; set; }
        public long StatutAHId { get; set; }
        public String StatutAH { get; set; }
        public String AnneeSt { get; set; }
        public String AnneeRSt { get; set; }
        public long StatutCapitaineId { get; set; }
        public String StatutCapitaine { get; set; }
        public String AnneeCapitaine { get; set; }
        public String AnneeFinSt { get; set; }
        public long AvocatAssistantId { get; set; }
        public String AvocatAssistant { get; set; }
        public long AvocatParId { get; set; }
        public String AvocatPar { get; set; }
        public long AvocatCohId { get; set; }
        public String AvocatCoh { get; set; }
        public long AssuranceId { get; set; }
        public String Assurance { get; set; }
        public String NomSociete { get; set; }
        public long ? NomAvocatAss { get; set; }
        public long ? NomAvocatPar { get; set; }
        public long ? NomAvocatCoh { get; set; }
        public long ? NomAvocatAssurance { get; set; }
        public String NAvocatAss { get; set; }
        public String NAvocatPar { get; set; }
        public String NAvocatCoh { get; set; }
        public String NAvocatAssurance { get; set; }
        public String PAvocatAss { get; set; }
        public String PAvocatPar { get; set; }
        public String PAvocatCoh { get; set; }
        public String PAvocatAssurance { get; set; }
        public String AnneeDebut { get; set; }
        public String AnneeArret { get; set; }
        public String AnneeReprendre { get; set; }
        public String AnneeFin { get; set; }
        public String AnneeSupp { get; set; }
        public long ? AvocatStage { get; set; }
        public String NAvocatStage { get; set; }
        public long NominationId { get; set; }
        public String Nomination { get; set; }
        public String AnneeMembre { get; set; }
        public long NumeroPole { get; set; }
        public long JuridictionId { get; set; }
        public String Juridiction { get; set; }
        public long NumeroDossier { get; set; }
        public String Accusation { get; set; }
        public String ChapitreSuivi { get; set; }
        public String AnneeAudience { get; set; }
        public long DecisionId { get; set; }
        public String Decision { get; set; }
        public String Jugement { get; set; }
        public String DateJugement { get; set; }
        public long SanctionId { get; set; }
        public String Sanction{ get; set; }
        public String DateSanction { get; set; }























    }
}