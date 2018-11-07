using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nprojet.Models;
using System.Data;


namespace nprojet.Controllers
{
    public class MyController : Controller
    {
        private Databasee db = new Databasee();

        // GET: Person
        public ActionResult Index()
        {
            return View("My");
        }
        public ActionResult gett()
        {
            return View();
        }

        public ActionResult Postt()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddP(PersonModel PP)
        {
            Partie p = new Partie();
            p.Nom = PP.Nom;
            p.Prenom = PP.Prenom;
            p.DateNaissance = (DateTime)Convert.ToDateTime(PP.DateNaissance);
            p.LieuNaissance = PP.LieuNaissance;
            p.GenreId = PP.GenreId;
            p.Cin = PP.Cin;
            p.NationaliteId = (int)Convert.ToInt64(PP.NationaliteId);
            p.Adresse = PP.Adresse;
            p.VilleId = (int)Convert.ToInt64(PP.VilleId);
            p.MetierId = (int)Convert.ToInt64(PP.MetierId);
            
            db.Partie.Add(p);
            db.SaveChanges();
            long latest = p.Id;
            Obtention pp = new Obtention();
            pp.PartieId =latest;
            pp.CategorieId = PP.CategorieId;
            pp.SpecialiteId = PP.SpecialiteId;
            pp.Annee = (DateTime)Convert.ToDateTime(PP.Annee);
            db.Obtention.Add(pp);
            db.SaveChanges();
            CoordonneesProfessionnelles ppp = new CoordonneesProfessionnelles();
            ppp.PartieId = latest;
            ppp.BarreauId = (int)Convert.ToInt64(PP.BarreauId);
            ppp.ReferenceNational = PP.ReferenceNat;
            ppp.OrganeId = (int)Convert.ToInt64(PP.OrganId);
            ppp.SituationPId = (int)Convert.ToInt64(PP.SituationPId);
            ppp.AnneeDA = (DateTime)Convert.ToDateTime(PP.AnneeDA);
            ppp.AnneeAY = (DateTime)Convert.ToDateTime(PP.AnneeAY);
            ppp.CourCassationId = (int)Convert.ToInt64(PP.CourCassationId);
            ppp.AnneeACC = (DateTime)Convert.ToDateTime(PP.AnneeACC);
            ppp.StatutAHId = (int)Convert.ToInt64(PP.StatutAHId);
            ppp.AnneeSt = (DateTime)Convert.ToDateTime(PP.AnneeSt);
            ppp.AnneeRSt = (DateTime)Convert.ToDateTime(PP.AnneeRSt);
            ppp.StatutCapitaineId = (int)Convert.ToInt64(PP.StatutCapitaineId);
            ppp.AnneeCapitaine = (DateTime)Convert.ToDateTime(PP.AnneeCapitaine);
            ppp.AnneeFinSt = (DateTime)Convert.ToDateTime(PP.AnneeFinSt);
            ppp.AvocatAssistantId = (int)Convert.ToInt64(PP.AvocatAssistantId);
            ppp.AvocatParId = (int)Convert.ToInt64(PP.AvocatParId);
            ppp.AvocatCohId = (int)Convert.ToInt64(PP.AvocatCohId);
            ppp.AssuranceId = (int)Convert.ToInt64(PP.AssuranceId);
            ppp.NomSociete = PP.NomSociete;
            ppp.NomAvocatAss = PP.NomAvocatAss;
            ppp.NomAvocatPar = PP.NomAvocatPar;
            ppp.NomAvocatCoh = PP.NomAvocatCoh;
            ppp.NomAvocatAssurance = PP.NomAvocatAssurance;
            db.CoordonneesProfessionnelles.Add(ppp);
            db.SaveChanges();
            Stage pppp = new Stage();
            pppp.PartieId = latest;
            pppp.AnneeDebut= (DateTime)Convert.ToDateTime(PP.AnneeDebut);
            pppp.AnneeArret = (DateTime)Convert.ToDateTime(PP.AnneeArret);
            pppp.AnneeReprendre = (DateTime)Convert.ToDateTime(PP.AnneeReprendre);
            pppp.AnneFin = (DateTime)Convert.ToDateTime(PP.AnneeFin);
            pppp.AnneeSupp = (DateTime)Convert.ToDateTime(PP.AnneeSupp);
            pppp.AvocatStageId= (int)Convert.ToInt64(PP.AvocatStage);
            db.Stage.Add(pppp);
            db.SaveChanges();

            AvocatMembre ppppppppp = new AvocatMembre();
            ppppppppp.PartieId = latest;
            ppppppppp.NominationId= (int)Convert.ToInt64(PP.NominationId);
            ppppppppp.AnneeMembre= (DateTime)Convert.ToDateTime(PP.AnneeMembre);
            db.AvocatMembre.Add(ppppppppp);
            db.SaveChanges();
            Audience pppppp = new Audience();
            pppppp.PartieId = latest;
            pppppp.AnneeAudience = (DateTime)Convert.ToDateTime(PP.AnneeAudience);
            pppppp.DecisionId = (int)Convert.ToInt64(PP.DecisionId);
            db.Audience.Add(pppppp);
            db.SaveChanges();
            Jugement ppppppp = new Jugement();
            ppppppp.PartieId = latest;
            ppppppp.Jugementt = PP.Jugement;
            ppppppp.DateJugement = (DateTime)Convert.ToDateTime(PP.DateJugement);
            db.Jugement.Add(ppppppp);
            db.SaveChanges();
            Sanction pppppppp = new Sanction();
            pppppppp.PartieId = latest;
            pppppppp.SanctionId = (int)Convert.ToInt64(PP.SanctionId);
            pppppppp.DateSanction = (DateTime)Convert.ToDateTime(PP.DateSanction);
            db.Sanction.Add(pppppppp);
            db.SaveChanges();
            PoursuiteJuridique ppppp = new PoursuiteJuridique();
            ppppp.PartieId = latest;
            ppppp.NumeroPole = PP.NumeroPole;
            ppppp.JuridictionId = (int)Convert.ToInt64(PP.JuridictionId);
            ppppp.NumeroDossier = PP.NumeroDossier;
            ppppp.Accusation = PP.Accusation;
            ppppp.ChaitreSuivi = PP.ChapitreSuivi;
          
            db.PoursuiteJuridique.Add(ppppp);
            db.SaveChanges();
            









            return Json("succes");

        }

        public JsonResult getgenre()
        {
            var gg = db.Genre.Select(t => new GenreModel
            {
                GenreId = t.GenreId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getnationalite()
        {
            var gg = db.Nationalite.Select(t => new NationaliteModel
            {
                NationaliteId = t.NationaliteId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getville()
        {
            var gg = db.Ville.Select(t => new VilleModel
            {
                VilleId = t.VilleId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getmetier()
        {
            var gg = db.Metier.Select(t => new MetierModel
            {
                MetierId = t.MetierId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getcategorie()
        {
            var gg = db.Categorie.Select(t => new CategorieModel
            {
                CategorieId = t.CategorieId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getspecialite()
        {
            var gg = db.Specialite.Select(t => new SpecialiteModel
            {
                SpecialiteId = t.SpecialiteId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getbarreau()
        {
            var gg = db.Barreau.Select(t => new BarreauModel
            {
                BarreauId = t.BarreauId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
     
        public JsonResult getjuridiction()
        {
            var gg = db.Juridiction.Select(t => new JuridictionModel            {
                JuridictionId = t.JuridictionId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getorgan()
        {
            var gg = db.Juridiction.Where(t =>t.OrganeId==2).Select(t=> new OrganModel
            {    
                OrganId = t.JuridictionId,
               
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getsituationp()
        {
            var gg = db.SituationP.Select(t => new SituationModel
            {
                SituationPId = t.SituationPId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getcourcassation()
        {
            var gg = db.CourCassation.Select(t => new CourCassationModel
            {
                CourCassationId= t.CourCassationId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getstatutah()
        {
            var gg = db.StatutAH.Select(t => new StatutAHModel
            {
                StatutAHId = t.StatutAHId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getstatutcap()
        {
            var gg = db.StatutCapitaine.Select(t => new StatutCapitaineModel
            {
                StatutCapitaineId = t.StatutCapitaineId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getavocatassistant()
        {
            var gg = db.AvocatAssistant.Select(t => new AvocatAssistantModel
            {
                AvocatAssistantId = t.AvocatAssistantId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getavocatpar()
        {
            var gg = db.AvocatPar.Select(t => new AvocatParModel
            {
                AvocatParId = t.AvocatParId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getavocatcoh()
        {
            var gg = db.AvocatCoh.Select(t => new AvocatCohModel
            {
                AvocatCohId= t.AvocatCohId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getassurance()
        {
            var gg = db.Assurance.Select(t => new AssuranceModel
            {
                AssuranceId = t.AssuranceId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getavocat()
        {
            var gg = db.Partie.Select(t => new NomModel
            {Id=t.Id,
                Nom=t.Nom,
                Prenom=t.Prenom
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getnomination()
        {
            var gg = db.Nomination.Select(t => new NominationModel
            {
                NominationId = t.NominationId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getdecision()
        {
            var gg = db.Decision.Select(t => new DecisionModel
            {
                DecisionId = t.DecisionId,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getsanction()
        {
            var gg = db.CatSanction.Select(t => new SanctionModel
            {
                SanctionId = t.Id,
                libelle = t.libelle
            }).ToList();
            return Json(gg, JsonRequestBehavior.AllowGet);

        }
        public JsonResult deletep(Partie per)
        {
            var ppp = db.Partie.First(t => t.Id == per.Id);
            db.Partie.Remove(ppp);
            var pp=db.Obtention.First(u => u.PartieId == per.Id);
            db.Obtention.Remove(pp);
           var ava= db.CoordonneesProfessionnelles.Where(a => a.NomAvocatAss == per.Id);
            foreach(var i in ava) { i.NomAvocatAss = null; }
            var avp = db.CoordonneesProfessionnelles.Where(a => a.NomAvocatPar == per.Id);
            foreach (var i in avp) { i.NomAvocatPar = null; }
            var avc = db.CoordonneesProfessionnelles.Where(a => a.NomAvocatCoh == per.Id);
            foreach (var i in avc) { i.NomAvocatCoh= null; }
            var avas = db.CoordonneesProfessionnelles.Where(a => a.NomAvocatAssurance == per.Id);
            foreach (var i in avas) { i.NomAvocatAssurance = null; }
            var avs = db.Stage.Where(a => a.AvocatStageId == per.Id);
            foreach (var i in avs) { i.AvocatStageId = null; }
            



            var p = db.CoordonneesProfessionnelles.First(c => c.PartieId == per.Id);
            db.CoordonneesProfessionnelles.Remove(p);
            
            var ppppppppp=db.AvocatMembre.First(c => c.PartieId == per.Id);
            db.AvocatMembre.Remove(ppppppppp);
            

            var pppp = db.Stage.First(c => c.PartieId == per.Id);
            db.Stage.Remove(pppp);
            
            var ppppp = db.PoursuiteJuridique.First(c => c.PartieId == per.Id);
            db.PoursuiteJuridique.Remove(ppppp);
        
            var pppppp = db.Audience.First(c => c.PartieId == per.Id);
            db.Audience.Remove(pppppp);
            
            var ppppppp = db.Jugement.First(c => c.PartieId == per.Id);
            db.Jugement.Remove(ppppppp);
           
            var pppppppp = db.Sanction.First(c => c.PartieId == per.Id);
            db.Sanction.Remove(pppppppp);
            db.SaveChanges();
            


            return Json("succes");









        }
        public JsonResult update(PersonModel PPP)
        {
            Partie ppp = db.Partie.First(t => t.Id == PPP.Id);
            ppp.Nom = PPP.Nom;
            ppp.Prenom = PPP.Prenom;
            ppp.DateNaissance = (DateTime)Convert.ToDateTime(PPP.DateNaissance);


            ppp.LieuNaissance = PPP.LieuNaissance;

            ppp.GenreId = PPP.GenreId;

            ppp.Cin = PPP.Cin;

            ppp.NationaliteId = (int)Convert.ToInt64(PPP.NationaliteId);

            ppp.Adresse = PPP.Adresse;

            ppp.VilleId = (int)Convert.ToInt64(PPP.VilleId);
            ppp.MetierId = PPP.MetierId;
            db.SaveChanges();
            Obtention pp = db.Obtention.First(u => u.PartieId == PPP.Id);
            pp.SpecialiteId = PPP.SpecialiteId;
            pp.CategorieId = PPP.CategorieId;
            pp.Annee = (DateTime)Convert.ToDateTime(PPP.Annee);
            db.SaveChanges();
            CoordonneesProfessionnelles p=db.CoordonneesProfessionnelles.First(c => c.PartieId == PPP.Id);
            p.BarreauId = (int)Convert.ToInt64(PPP.BarreauId);
            p.ReferenceNational = PPP.ReferenceNat;
            p.OrganeId = (int)Convert.ToInt64(PPP.OrganId);
            p.SituationPId = (int)Convert.ToInt64(PPP.SituationPId);
            p.AnneeDA = (DateTime)Convert.ToDateTime(PPP.AnneeDA);
            p.AnneeAY = (DateTime)Convert.ToDateTime(PPP.AnneeAY);
            p.CourCassationId = (int)Convert.ToInt64(PPP.CourCassationId);
            p.AnneeACC = (DateTime)Convert.ToDateTime(PPP.AnneeACC);
            p.StatutAHId = (int)Convert.ToInt64(PPP.StatutAHId);
            p.AnneeSt = (DateTime)Convert.ToDateTime(PPP.AnneeSt);
            p.AnneeRSt = (DateTime)Convert.ToDateTime(PPP.AnneeRSt);
            p.StatutCapitaineId = (int)Convert.ToInt64(PPP.StatutCapitaineId);
            p.AnneeCapitaine = (DateTime)Convert.ToDateTime(PPP.AnneeCapitaine);
            p.AnneeFinSt = (DateTime)Convert.ToDateTime(PPP.AnneeFinSt);
            p.AvocatAssistantId = (int)Convert.ToInt64(PPP.AvocatAssistantId);
            p.AvocatParId = (int)Convert.ToInt64(PPP.AvocatParId);
            p.AvocatCohId = (int)Convert.ToInt64(PPP.AvocatCohId);
            p.AssuranceId = (int)Convert.ToInt64(PPP.AssuranceId);
            p.NomAvocatAss= (int)Convert.ToInt64(PPP.NomAvocatAss);
            p.NomAvocatPar = (int)Convert.ToInt64(PPP.NomAvocatPar);
            p.NomAvocatCoh = (int)Convert.ToInt64(PPP.NomAvocatCoh);
            p.NomAvocatAssurance = (int)Convert.ToInt64(PPP.NomAvocatAssurance);
            p.NomSociete = PPP.NomSociete;
            db.SaveChanges();
            Stage pppp = db.Stage.First(s => s.PartieId == PPP.Id);
            pppp.AnneeDebut = (DateTime)Convert.ToDateTime(PPP.AnneeDebut);
            pppp.AnneeArret = (DateTime)Convert.ToDateTime(PPP.AnneeArret);
            pppp.AnneeReprendre = (DateTime)Convert.ToDateTime(PPP.AnneeReprendre);
            pppp.AnneFin = (DateTime)Convert.ToDateTime(PPP.AnneeFin);
            pppp.AnneeSupp = (DateTime)Convert.ToDateTime(PPP.AnneeSupp);
            pppp.AvocatStageId = (int)Convert.ToInt64(PPP.AvocatStage);
            db.SaveChanges();
            AvocatMembre ppppp = db.AvocatMembre.First(a => a.PartieId == PPP.Id);
            ppppp.NominationId = (int)Convert.ToInt64(PPP.NominationId);
            ppppp.AnneeMembre = (DateTime)Convert.ToDateTime(PPP.AnneeMembre);
            db.SaveChanges();
            
            Audience ppppppp=db.Audience.First(au => au.PartieId == PPP.Id);
            ppppppp.AnneeAudience = (DateTime)Convert.ToDateTime(PPP.AnneeAudience);
            ppppppp.DecisionId = (int)Convert.ToInt64(PPP.DecisionId);
            db.SaveChanges();
            Jugement pppppppp= db.Jugement.First(j => j.PartieId == PPP.Id);
            pppppppp.Jugementt = PPP.Jugement;
            pppppppp.DateJugement = (DateTime)Convert.ToDateTime(PPP.DateJugement);
            db.SaveChanges();
            Sanction ppppppppp = db.Sanction.First(sa => sa.PartieId == PPP.Id);
            ppppppppp.SanctionId = (int)Convert.ToInt64(PPP.SanctionId);
            ppppppppp.DateSanction = (DateTime)Convert.ToDateTime(PPP.DateSanction);




            db.SaveChanges();
            PoursuiteJuridique pppppp = db.PoursuiteJuridique.First(P => P.PartieId == PPP.Id);
            pppppp.NumeroPole = (int)Convert.ToInt64(PPP.NumeroPole);
            pppppp.JuridictionId = (int)Convert.ToInt64(PPP.JuridictionId);
            pppppp.NumeroDossier = (int)Convert.ToInt64(PPP.NumeroDossier);
            pppppp.Accusation = PPP.Accusation;
            pppppp.ChaitreSuivi = PPP.ChapitreSuivi;
            db.SaveChanges();

            return Json("succes");









        }




        public JsonResult Getall()
        {
            var pp = db.Partie.Join(db.Obtention, t => t.Id, u => u.PartieId, (t, u) => new { t, u }).Join(db.CoordonneesProfessionnelles, t => t.t.Id,
               c => c.PartieId, (t, c) => new { t, c }).Join(db.Stage, t => t.t.t.Id,
               s => s.PartieId, (t, s) => new { t, s }).Join(db.AvocatMembre,t => t.t.t.t.Id,
               av => av.PartieId, (t, av) => new { t, av }).Join(db.PoursuiteJuridique, t => t.t.t.t.t.Id,
               p => p.PartieId, (t, p) => new { t, p }).Join(db.Audience, t => t.t.t.t.t.t.Id,
               a => a.PartieId, (t, a) => new { t, a }).Join(db.Jugement, t => t.t.t.t.t.t.t.Id,
               j => j.PartieId, (t, j) => new { t, j }).Join(db.Sanction, t => t.t.t.t.t.t.t.t.Id,
              s => s.PartieId, (t, s) => new PersonModel
              {
                  Id = t.t.t.t.t.t.t.t.Id,
                  Nom = t.t.t.t.t.t.t.t.Nom,
                  Prenom = t.t.t.t.t.t.t.t.Prenom,
                  DateNaissance = t.t.t.t.t.t.t.t.DateNaissance.ToString(),
                  LieuNaissance = t.t.t.t.t.t.t.t.LieuNaissance,
                  GenreId = t.t.t.t.t.t.t.t.GenreId,
                  Genre = t.t.t.t.t.t.t.t.Genre.libelle,

                  Cin = t.t.t.t.t.t.t.t.Cin,
                  NationaliteId = t.t.t.t.t.t.t.t.NationaliteId,
                  Nationalite = t.t.t.t.t.t.t.t.Nationalite.libelle,
                  Adresse = t.t.t.t.t.t.t.t.Adresse,
                  VilleId = t.t.t.t.t.t.t.t.VilleId,
                  Ville = t.t.t.t.t.t.t.t.Ville.libelle,

                  MetierId = t.t.t.t.t.t.t.t.MetierId,
                  Metier = t.t.t.t.t.t.t.t.Metier.libelle,
                  CategorieId = t.t.t.t.t.t.t.u.CategorieId,
                  Categorie = t.t.t.t.t.t.t.u.Categorie.libelle,
                  SpecialiteId = t.t.t.t.t.t.t.u.SpecialiteId,
                  Specialite = t.t.t.t.t.t.t.u.Specialite.libelle,
                  Annee = t.t.t.t.t.t.t.u.Annee.ToString(),

                  BarreauId = t.t.t.t.t.t.c.BarreauId,
                  Barreau = t.t.t.t.t.t.c.Barreau.libelle,
                  ReferenceNat = (long)t.t.t.t.t.t.c.ReferenceNational,
                  OrganId = t.t.t.t.t.t.c.OrganeId,
                  Organ = t.t.t.t.t.t.c.Juridiction.libelle,
                  SituationPId = t.t.t.t.t.t.c.SituationPId,
                  SituationP = t.t.t.t.t.t.c.SituationP.libelle,
                  AnneeDA = t.t.t.t.t.t.c.AnneeDA.ToString(),
                  AnneeAY = t.t.t.t.t.t.c.AnneeAY.ToString(),
                  AnneeACC = t.t.t.t.t.t.c.AnneeACC.ToString(),
                  AnneeSt = t.t.t.t.t.t.c.AnneeSt.ToString(),
                  AnneeRSt = t.t.t.t.t.t.c.AnneeRSt.ToString(),
                  AnneeCapitaine = t.t.t.t.t.t.c.AnneeCapitaine.ToString(),
                  AnneeFinSt = t.t.t.t.t.t.c.AnneeFinSt.ToString(),
                  CourCassationId = t.t.t.t.t.t.c.CourCassationId,
                  CourCassation = t.t.t.t.t.t.c.CourCassation.libelle,
                  StatutAHId = t.t.t.t.t.t.c.StatutAHId,
                  StatutAH = t.t.t.t.t.t.c.StatutAH.libelle,
                  StatutCapitaineId = t.t.t.t.t.t.c.StatutCapitaineId,
                  StatutCapitaine = t.t.t.t.t.t.c.StatutCapitaine.libelle,
                  AvocatAssistantId = t.t.t.t.t.t.c.AvocatAssistantId,
                  AvocatAssistant = t.t.t.t.t.t.c.AvocatAssistant.libelle,
                  AvocatParId = t.t.t.t.t.t.c.AvocatParId,
                  AvocatPar = t.t.t.t.t.t.c.AvocatPar.libelle,
                  AvocatCohId = t.t.t.t.t.t.c.AvocatCohId,
                  AvocatCoh = t.t.t.t.t.t.c.AvocatCoh.libelle,
                  AssuranceId = t.t.t.t.t.t.c.AssuranceId,
                  Assurance = t.t.t.t.t.t.c.Assurance.libelle,
                  NomSociete = t.t.t.t.t.t.c.NomSociete,
                  NomAvocatAss = (long)t.t.t.t.t.t.c.NomAvocatAss,
                  NomAvocatPar = (long)t.t.t.t.t.t.c.NomAvocatPar,
                  NomAvocatCoh = (long)t.t.t.t.t.t.c.NomAvocatCoh,
                  NomAvocatAssurance = (long)t.t.t.t.t.t.c.NomAvocatAssurance,
                  NAvocatAss= t.t.t.t.t.t.c.Partie1.Nom+" "+ t.t.t.t.t.t.c.Partie1.Prenom,
                  NAvocatPar = t.t.t.t.t.t.c.Partie2.Nom + " " + t.t.t.t.t.t.c.Partie2.Prenom,
                  NAvocatCoh = t.t.t.t.t.t.c.Partie3.Nom + " " + t.t.t.t.t.t.c.Partie3.Prenom,
                  NAvocatAssurance = t.t.t.t.t.t.c.Partie4.Nom + " " + t.t.t.t.t.t.c.Partie4.Prenom,
                
                  AnneeDebut = t.t.t.t.t.s.AnneeDebut.ToString(),
                  AnneeArret = t.t.t.t.t.s.AnneeArret.ToString(),
                  AnneeReprendre = t.t.t.t.t.s.AnneeReprendre.ToString(),
                  AnneeFin = t.t.t.t.t.s.AnneFin.ToString(),
                  AnneeSupp = t.t.t.t.t.s.AnneeSupp.ToString(),
                  AvocatStage= (long)t.t.t.t.t.s.AvocatStageId,
                   NAvocatStage= t.t.t.t.t.s.Partie1.Nom + " " + t.t.t.t.t.s.Partie1.Prenom,
                  NominationId = t.t.t.t.av.NominationId,
                  Nomination =t.t.t.t.av.Nomination.libelle,
                  AnneeMembre= t.t.t.t.av.AnneeMembre.ToString(),


                  NumeroPole = t.t.t.p.NumeroPole,
                  JuridictionId = t.t.t.p.JuridictionId,
                  Juridiction= t.t.t.p.Juridiction.libelle,
                  NumeroDossier = t.t.t.p.NumeroDossier,
                  Accusation = t.t.t.p.Accusation,
                  ChapitreSuivi = t.t.t.p.ChaitreSuivi,
                  AnneeAudience = t.t.a.AnneeAudience.ToString(),
                  DecisionId = t.t.a.DecisionId,
                  Decision = t.t.a.Decision.libelle,
                  Jugement = t.j.Jugementt,
                  DateJugement = t.j.DateJugement.ToString(),
                  SanctionId = s.SanctionId,
                  Sanction = s.CatSanction.libelle,
                  DateSanction = s.DateSanction.ToString()

















                }).ToList<PersonModel>().DefaultIfEmpty();


            return Json(pp, JsonRequestBehavior.AllowGet);

        }
    }
}