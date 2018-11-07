﻿var app = angular.module("Homeapp", []);



app.controller("HomeController", function ($scope, $http) {

    var t;
    $scope.showme = false;

    function intialize() {
        $http({
            method: "get",
            url: "/My/getgenre"



        }).then(function (response) {

            $scope.Genre = response.data;

            });
        $http({
            method: "get",
            url: "/My/getnationalite"



        }).then(function (response) {

            $scope.Nationalite = response.data;

            });
        $http({
            method: "get",
            url: "/My/getville"



        }).then(function (response) {

            $scope.Ville = response.data;

            });
        $http({
            method: "get",
            url: "/My/getmetier"



        }).then(function (response) {

            $scope.Metier = response.data;

            });
        $http({
            method: "get",
            url: "/My/getcategorie"



        }).then(function (response) {

            $scope.Categorie = response.data;

            });
        $http({
            method: "get",
            url: "/My/getspecialite"



        }).then(function (response) {

            $scope.Specialite = response.data;

            });
        $http({
            method: "get",
            url: "/My/getbarreau"



        }).then(function (response) {

            $scope.Barreau = response.data;

            });
        $http({
            method: "get",
            url: "/My/getorgan"



        }).then(function (response) {

            $scope.Organ = response.data;

            });
        $http({
            method: "get",
            url: "/My/getjuridiction"



        }).then(function (response) {

            $scope.Juridiction = response.data;

        });
        $http({
                method: "get",
                url: "/My/getsituationp"



            }).then(function (response) {

                $scope.SituationP = response.data;

            });
        $http({
                method: "get",
                url: "/My/getcourcassation"



            }).then(function (response) {

                $scope.CourCassation = response.data;

            });
        $http({
                method: "get",
                url: "/My/getstatutah"



            }).then(function (response) {

                $scope.StatutAH = response.data;

            });
        $http({
                method: "get",
                url: "/My/getstatutcap"



            }).then(function (response) {

                $scope.StatutCapitaine = response.data;
                

            });
        $http({
                method: "get",
            url: "/My/getavocatassistant"



            }).then(function (response) {

                $scope.AvocatAssistant = response.data;

            });
        $http({
                method: "get",
                url: "/My/getavocatpar"



            }).then(function (response) {

                $scope.AvocatPar = response.data;

            });
        $http({
                method: "get",
                url: "/My/getavocatcoh"



            }).then(function (response) {

                $scope.AvocatCoh = response.data;

            });
        $http({
            method: "get",
            url: "/My/getassurance"



        }).then(function (response) {

            $scope.Assurance = response.data;

            });
        $http({
            method: "get",
            url: "/My/getavocat"



        }).then(function (response) {

            $scope.Avocat = response.data;
     
            });
        $http({
            method: "get",
            url: "/My/getnomination"



        }).then(function (response) {

            $scope.Nomination = response.data;

            });
        $http({
            method: "get",
            url: "/My/getdecision"



        }).then(function (response) {

            $scope.Decision = response.data;

        });
        $http({
            method: "get",
            url: "/My/getsanction"



        }).then(function (response) {

            $scope.Sanction = response.data;

        });

        $http({
            method: "get",
            url: "/My/Getall"



        }).then(function (response) {

            $scope.g = response.data;
           

        });
    }
    intialize();
    $scope.addperson = function () {

        $scope.PP = {};

        $scope.PP.Nom = $scope.Nom;
        $scope.PP.Prenom = $scope.Prenom;
        $scope.PP.DateNaissance = $scope.DateNaissance;


        $scope.PP.LieuNaissance = $scope.LieuNaissance;

        $scope.PP.GenreId = $scope.Genr.GenreId;

        $scope.PP.Cin = $scope.Cin;

        $scope.PP.NationaliteId = $scope.Nat.NationaliteId;

        $scope.PP.Adresse = $scope.Adresse;

        $scope.PP.VilleId = $scope.Vil.VilleId;
        $scope.PP.MetierId = $scope.Metie.MetierId;
        $scope.PP.CategorieId = $scope.Categori.CategorieId;
        $scope.PP.SpecialiteId = $scope.Specialit.SpecialiteId;
        $scope.PP.Annee = $scope.Annee;
        $scope.PP.BarreauId = $scope.Barreauu.BarreauId;
        $scope.PP.ReferenceNat = $scope.ReferenceNat;
        $scope.PP.OrganId = $scope.Organn.OrganId;
        $scope.PP.SituationPId = $scope.SituationPP.SituationPId;
        $scope.PP.AnneeDA = $scope.AnneeDA;
        $scope.PP.AnneeAY = $scope.AnneeAY;
        $scope.PP.CourCassationId = $scope.CourCass.CourCassationId;
        $scope.PP.AnneeACC = $scope.AnneeACC;
        $scope.PP.StatutAHId = $scope.StatutAHH.StatutAHId;
        $scope.PP.AnneeSt = $scope.AnneeSt;
        $scope.PP.AnneeRSt = $scope.AnneeRSt;
        $scope.PP.StatutCapitaineId = $scope.StatutCap.StatutCapitaineId;
        $scope.PP.AnneeCapitaine = $scope.AnneeCapitaine;
        $scope.PP.AnneeFinSt = $scope.AnneeFinSt;
        $scope.PP.AvocatAssistantId = $scope.AvocatAssistan.AvocatAssistantId;
        $scope.PP.AvocatParId = $scope.AvocatParr.AvocatParId;
        $scope.PP.AvocatCohId = $scope.AvocatCohh.AvocatCohId;
        $scope.PP.AssuranceId = $scope.Assuranc.AssuranceId;
        $scope.PP.NomSociete = $scope.NomSociete;
        $scope.PP.NomAvocatAss = $scope.Avocata;
        $scope.PP.NomAvocatPar = $scope.Avocatp;
        $scope.PP.NomAvocatCoh=$scope.Avocatc;
        $scope.PP.NomAvocatAssurance = $scope.Avocats;
        $scope.PP.AnneeDebut = $scope.AnneeDebut;
        $scope.PP.AnneeArret = $scope.AnneeArret;
        $scope.PP.AnneeReprendre = $scope.AnneeReprendre;
        $scope.PP.AnneeFin = $scope.AnneeFin;
        $scope.PP.AnneeSupp = $scope.AnneeSupp;
        $scope.PP.AvocatStage = $scope.AvocatStagee;
        $scope.PP.NominationId = $scope.Nominationn.NominationId;
        $scope.PP.AnneeMembre = $scope.AnneeMembre;
        $scope.PP.NumeroPole = $scope.NumeroPole;
        $scope.PP.JuridictionId = $scope.Juridictionn.JuridictionId;
        $scope.PP.NumeroDossier = $scope.NumeroDossier;
        $scope.PP.Accusation = $scope.Accusation;
        $scope.PP.ChapitreSuivi = $scope.ChapitreSuivi;
        $scope.PP.AnneeAudience = $scope.AnneeAudience;
        $scope.PP.DecisionId = $scope.Decisionn.DecisionId;
        $scope.PP.Jugement = $scope.Jugement;
        $scope.PP.DateJugement = $scope.DateJugement;
        $scope.PP.SanctionId = $scope.Sanctionn.SanctionId;
        $scope.PP.DateSanction = $scope.DateSanction;
       








       
        





        $http({
            method: 'POST',
            url: '/My/AddP',
            dataType: 'json',
            data: JSON.stringify($scope.PP)
        }).then(function () {

            intialize();
            $scope.Nom = '';
            $scope.Prenom = '';
            $scope.DateNaissance = '';
            $scope.LieuNaissance = '';

            $scope.Cin = '';
          
            $scope.Adresse = '';
            $scope.Annee = '';
            $scope.ReferenceNat = '';
            $scope.AnneeDA = '';
            $scope.AnneeAY = '';
            $scope.AnneeACC = '';
            $scope.AnneeSt = '';
            $scope.AnneeRSt = '';
            $scope.AnneeCapitaine = '';
            $scope.AnneeFinSt = '';
            $scope.NomSociete = '';
            $scope.AnneeDebut = '';
            $scope.AnneeReprendre = '';
            $scope.AnneeArret = '';
            $scope.AnneeFin = '';
            $scope.AnneeSupp = '';
            $scope.AnneeMembre = '';
            $scope.NumeroPole = '';
            $scope.NumeroDossier = '';
            $scope.Accusation = '';
            $scope.ChapitreSuivi = '';
            $scope.AnneeAudience = '';
            $scope.Jugement = '';
            $scope.DateJugement = '';
            $scope.DateSanction ='';
            
            
      

            console.log("success")



        });
    }

    $scope.updd = function () {
        $scope.PPP = {};

        $scope.PPP.Nom = $scope.Nom;
        $scope.PPP.Prenom = $scope.Prenom;
        $scope.PPP.DateNaissance = $scope.DateNaissance;


        $scope.PPP.LieuNaissance = $scope.LieuNaissance;

        $scope.PPP.GenreId = $scope.Genrr.GenreId;

        $scope.PPP.Cin = $scope.Cin;

        $scope.PPP.NationaliteId = $scope.Natt.NationaliteId;

        $scope.PPP.Adresse = $scope.Adresse;

        $scope.PPP.VilleId = $scope.Vill.VilleId;
        $scope.PPP.MetierId = $scope.Metiee.MetierId;
        $scope.PPP.CategorieId = $scope.Categorii.CategorieId;
        $scope.PPP.SpecialiteId = $scope.Specialitt.SpecialiteId;
        $scope.PPP.Annee = $scope.Annee;
        $scope.PPP.BarreauId = $scope.Barre.BarreauId;
        $scope.PPP.ReferenceNat = $scope.ReferenceNat;
        $scope.PPP.OrganId = $scope.Organee.OrganId;

        $scope.PPP.SituationPId = $scope.SituationPPP.SituationPId;

        $scope.PPP.AnneeDA = $scope.AnneeDA;
        $scope.PPP.AnneeAY = $scope.AnneeAY;
        $scope.PPP.CourCassationId = $scope.CourCassationn.CourCassationId;
        $scope.PPP.AnneeACC = $scope.AnneeACC;
        $scope.PPP.StatutAHId = $scope.StatutA.StatutAHId;
        $scope.PPP.AnneeSt = $scope.AnneeSt;
        $scope.PPP.AnneeRSt = $scope.AnneeRSt;
        $scope.PPP.StatutCapitaineId = $scope.StatutCapitainee.StatutCapitaineId;
        $scope.PPP.AnneeCapitaine = $scope.AnneeCapitaine;
        $scope.PPP.AnneeFinSt = $scope.AnneeFinSt;
        $scope.PPP.AvocatAssistantId = $scope.AvocatAssistann.AvocatAssistantId;
        $scope.PPP.AvocatParId = $scope.AvocatPa.AvocatParId;
        $scope.PPP.AvocatCohId = $scope.AvocatCo.AvocatCohId;
        $scope.PPP.AssuranceId = $scope.Assurancee.AssuranceId;
        $scope.PPP.NomSociete = $scope.NomSociete;
        $scope.PPP.NomAvocatAss = $scope.NAvocatAssistann;
        $scope.PPP.NomAvocatPar = $scope.NAvocatPa;
        $scope.PPP.NomAvocatCoh = $scope.NAvocatCo;
        $scope.PPP.NomAvocatAssurance = $scope.NAssurancee;
        $scope.PPP.AnneeDebut = $scope.AnneeDebut;
        $scope.PPP.AnneeArret = $scope.AnneeArret;
        $scope.PPP.AnneeReprendre = $scope.AnneeReprendre;
        $scope.PPP.AnneeFin = $scope.AnneeFin;
        $scope.PPP.AnneeSupp = $scope.AnneeSupp;
        $scope.PPP.AvocatStage = $scope.AvocatStagee;
        $scope.PPP.NominationId = $scope.Nominatione.NominationId;
        $scope.PPP.AnneeMembre = $scope.AnneeMembre;
        $scope.PPP.NumeroPole = $scope.NumeroPole;
        $scope.PPP.JuridictionId = $scope.Juridictionnn.JuridictionId;
        $scope.PPP.NumeroDossier = $scope.NumeroDossier;
        $scope.PPP.Accusation = $scope.Accusation;
        $scope.PPP.ChapitreSuivi = $scope.ChapitreSuivi;
        $scope.PPP.AnneeAudience = $scope.AnneeAudience;
        $scope.PPP.DecisionId = $scope.Decisionnn.DecisionId;
        $scope.PPP.Jugement = $scope.Jugement;
        $scope.PPP.DateJugement = $scope.DateJugement;
        $scope.PPP.SanctionId = $scope.Sanctionnn.SanctionId;
        $scope.PPP.DateSanction = $scope.DateSanction;




        $scope.PPP.Id = t;




        $http({
            method: 'POST',
            url: '/My/update',
            dataType: 'json',
            data: JSON.stringify($scope.PPP)
        }).then(function () {

            intialize();
            $scope.Nom = '';
            $scope.Prenom = '';
            $scope.DateNaissance = '';
            $scope.LieuNaissance = '';

            $scope.Cin = '';
           
            $scope.Adresse = '';
            $scope.Annee = '';
            $scope.ReferenceNat = '';
            $scope.AnneeDA = '';
            $scope.AnneeAY = '';
            $scope.AnneeACC = '';
            $scope.AnneeSt = '';
            $scope.AnneeRSt = '';
            $scope.AnneeCapitaine = '';
            $scope.AnneeFinSt = '';
            $scope.NomSociete = '';
            $scope.AnneeDebut = '';
            $scope.AnneeReprendre = '';
            $scope.AnneeArret = '';
            $scope.AnneeFin = '';
            $scope.AnneeSupp = '';
            $scope.AnneeMembre = '';
            $scope.NumeroPole = '';
            $scope.NumeroDossier = '';
            $scope.Accusation = '';
            $scope.ChapitreSuivi = '';
            $scope.AnneeAudience = '';
            $scope.Jugement = '';
            $scope.DateJugement = '';
            $scope.DateSanction = '';

       
            $scope.showme = false;

            console.log("success")



        });
    }


    $scope.delete = function (per) {
        delete per.Genre;



        $http({
            method: 'POST',
            url: '/My/deletep',
            dataType: 'json',
            data: per



        }).then(function () {

            intialize();
            console.log("success")

        });
        console.log(per);
    }

    $scope.Updatep = function (per) {



        $scope.Nom = per.Nom;
        $scope.Prenom = per.Prenom;
        $scope.DateNaissance = per.DateNaissance;


        $scope.LieuNaissance = per.LieuNaissance;
        $scope.Genrr = { 'libelle': per.Genre, 'GenreId': per.GenreId };


        $scope.Cin = per.Cin;

        $scope.Natt = { 'libelle': per.Nationalite, 'NationaliteId': per.NationaliteId };

        $scope.Adresse = per.Adresse;

        $scope.Vill= { 'libelle': per.Ville, 'VilleId': per.VilleId };
        $scope.Metiee = { 'libelle': per.Metier, 'MetierId': per.MetierId };
        $scope.Categorii = { 'libelle': per.Categorie, 'CategorieId': per.CategorieId };
        $scope.Specialitt = { 'libelle': per.Specialite, 'SpecialiteId': per.SpecialiteId };

        $scope.Annee = per.Annee;
        $scope.Barre = { 'libelle': per.Barreau, 'BarreauId': per.BarreauId };
        $scope.ReferenceNat = per.ReferenceNat;
        $scope.Organee = { 'libelle': per.Organ, 'OrganId': per.OrganId };
        $scope.SituationPPP = { 'libelle': per.SituationP, 'SituationPId': per.SituationPId };
        $scope.AnneeDA = per.AnneeDA;
        $scope.AnneeAY = per.AnneeAY;
        $scope.CourCassationn = { 'libelle': per.CourCassation, 'CourCassationId': per.CourCassationId };
        $scope.AnneeACC = per.AnneeACC;
        $scope.StatutA = { 'libelle': per.StatutAH, 'StatutAHId': per.StatutAHId };
        $scope.AnneeSt = per.AnneeSt;
        $scope.AnneeRSt = per.AnneeRSt;
        $scope.StatutCapitainee = { 'libelle': per.StatutCapitaine, 'StatutCapitaineId': per.StatutCapitaineId };
        $scope.AnneeCapitaine = per.AnneeCapitaine;
        $scope.AnneeFinSt = per.AnneeFinSt;
        $scope.AvocatAssistann = { 'libelle': per.AvocatAssistant, 'AvocatAssistantId': per.AvocatAssistantId };
        $scope.AvocatPa = { 'libelle': per.AvocatPar, 'AvocatParId': per.AvocatParId };
        $scope.AvocatCo = { 'libelle': per.AvocatCoh, 'AvocatCohId': per.AvocatCohId };
        $scope.Assurancee = { 'libelle': per.Assurance, 'AssuranceId': per.AssuranceId };
        $scope.NAvocatAssistann = { 'NAvocatAss': per.NAvocatAss, 'Id': per.NomAvocatAss};
        $scope.NAvocatPa = { 'NAvocatPar': per.NAvocatPar, 'Id': per.NomAvocatPar };
        $scope.NAvocatCo = { 'NAvocatCoh': per.NAvocatCoh, 'Id': per.NomAvocatCoh };
        $scope.NAssurancee = { 'NAvocatAssurance': per.NAvocatAssurance, 'Id': per.NomAvocatAssurance };
        $scope.NomSociete = per.NomSociete;
        $scope.AnneeDebut =per.AnneeDebut;
        $scope.AnneeArret =per.AnneeArret;
        $scope.AnneeReprendre = per.AnneeReprendre;
        $scope.AnneeFin = per.AnneeFin;
        $scope.AnneeSupp = per.AnneeSupp;
        $scope.AvocatStagee = { 'NAvocatStage': per.NAvocatStage, 'Id': per.AvocatStage };
        $scope.Nominatione = { 'libelle': per.Nomination, 'NominationId': per.NominationId };
        $scope.AnneeMembre = per.AnneeMembre;
        $scope.NumeroPole = per.NumeroPole;
        $scope.Juridictionnn = { 'libelle': per.Juridiction, 'JuridictionId': per.JuridictionId };
        $scope.NumeroDossier = per.NumeroDossier;
        $scope.Accusation = per.Accusation;
        $scope.ChapitreSuivi = per.ChapitreSuivi;
        $scope.AnneeAudience = per.AnneeAudience;
        $scope.Decisionnn = { 'libelle': per.Decision, 'DecisionId': per.DecisionId };
        $scope.Jugement = per.Jugement;
        $scope.DateJugement = per.DateJugement;
        $scope.Sanctionnn = { 'libelle': per.AvocatPar, 'SanctionId': per.SanctionId };
        $scope.DateSanction = per.DateSanction;


        $scope.showme = true;

        console.log(per);
        console.log($scope.NAvocatAssistann);


        t = per.Id;












    }














})
