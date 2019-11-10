namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "leviobd.candidat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        etat = c.String(maxLength: 255, unicode: false),
                        demande_idDemande = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("leviobd.demande", t => t.demande_idDemande)
                .Index(t => t.demande_idDemande);
            
            CreateTable(
                "leviobd.demande",
                c => new
                    {
                        idDemande = c.Int(nullable: false, identity: true),
                        DateDemande = c.DateTime(precision: 0),
                        EtatDemande = c.String(maxLength: 255, unicode: false),
                        Specialite = c.String(maxLength: 255, unicode: false),
                        age = c.Int(nullable: false),
                        cv = c.String(maxLength: 255, unicode: false),
                        lettreaffercation = c.String(maxLength: 255, unicode: false),
                        mail = c.String(maxLength: 255, unicode: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        pays = c.String(maxLength: 255, unicode: false),
                        prenom = c.String(maxLength: 255, unicode: false),
                        tel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDemande);
            
            CreateTable(
                "leviobd.parrain",
                c => new
                    {
                        idPar = c.Int(nullable: false, identity: true),
                        age = c.Int(nullable: false),
                        mail = c.String(maxLength: 255, unicode: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        parrainIdToBeUpdated = c.Int(),
                        prenom = c.String(maxLength: 255, unicode: false),
                        tel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPar);
            
            CreateTable(
                "leviobd.client",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Latitude = c.Int(nullable: false),
                        Logo = c.String(maxLength: 255, unicode: false),
                        Longitude = c.Int(nullable: false),
                        Typeclient = c.String(maxLength: 255, unicode: false),
                        categories = c.String(maxLength: 255, unicode: false),
                        name = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "leviobd.organigramme",
                c => new
                    {
                        IdOrg = c.Int(nullable: false),
                        NomDir = c.String(maxLength: 255, unicode: false),
                        NomHauteDir = c.String(maxLength: 255, unicode: false),
                        Pvp = c.String(maxLength: 255, unicode: false),
                        Vp = c.String(maxLength: 255, unicode: false),
                        idClient = c.Int(nullable: false),
                        client_id = c.Int(),
                    })
                .PrimaryKey(t => t.IdOrg)
                .ForeignKey("leviobd.client", t => t.client_id)
                .Index(t => t.client_id);
            
            CreateTable(
                "leviobd.projet",
                c => new
                    {
                        idProjet = c.Int(nullable: false),
                        Benefice = c.Single(nullable: false),
                        DateDebut = c.DateTime(precision: 0),
                        DateFin = c.DateTime(precision: 0),
                        NbrRessource = c.Int(nullable: false),
                        NomProjet = c.String(maxLength: 255, unicode: false),
                        Rentabilite = c.Single(nullable: false),
                        organigramme_IdOrg = c.Int(),
                        client_id = c.Int(),
                        Typeprojet = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idProjet)
                .ForeignKey("leviobd.organigramme", t => t.organigramme_IdOrg)
                .ForeignKey("leviobd.client", t => t.client_id)
                .Index(t => t.organigramme_IdOrg)
                .Index(t => t.client_id);
            
            CreateTable(
                "leviobd.mandat",
                c => new
                    {
                        idMandat = c.Int(nullable: false, identity: true),
                        archive = c.Boolean(nullable: false, storeType: "bit"),
                        dateDebut = c.DateTime(precision: 0),
                        dateFin = c.DateTime(precision: 0),
                        frais = c.Single(nullable: false),
                        projet_idProjet = c.Int(nullable: false),
                        ressource_idRessource = c.Int(),
                    })
                .PrimaryKey(t => t.idMandat)
                .ForeignKey("leviobd.ressource", t => t.ressource_idRessource)
                .ForeignKey("leviobd.projet", t => t.projet_idProjet)
                .Index(t => t.projet_idProjet)
                .Index(t => t.ressource_idRessource);
            
            CreateTable(
                "leviobd.ressource",
                c => new
                    {
                        idRessource = c.Int(nullable: false, identity: true),
                        cv = c.String(maxLength: 255, unicode: false),
                        dateDebut = c.DateTime(precision: 0),
                        dateFin = c.DateTime(precision: 0),
                        historique = c.String(maxLength: 255, unicode: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        note = c.String(maxLength: 255, unicode: false),
                        origine = c.String(maxLength: 255, unicode: false),
                        photo = c.String(maxLength: 255, unicode: false),
                        prenom = c.String(maxLength: 255, unicode: false),
                        profil = c.String(maxLength: 255, unicode: false),
                        secteur = c.String(maxLength: 255, unicode: false),
                        seniorite = c.String(maxLength: 255, unicode: false),
                        statut = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idRessource);
            
            CreateTable(
                "leviobd.competence",
                c => new
                    {
                        idCompetence = c.Int(nullable: false, identity: true),
                        Competences = c.String(maxLength: 255, unicode: false),
                        DateMiseAJour = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.idCompetence);
            
            CreateTable(
                "leviobd.projet_competence",
                c => new
                    {
                        Projet_idProjet = c.String(nullable: false, maxLength: 255, unicode: false),
                        competences_idCompetence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Projet_idProjet, t.competences_idCompetence })
                .ForeignKey("leviobd.competence", t => t.competences_idCompetence)
                .Index(t => t.competences_idCompetence);
            
            CreateTable(
                "leviobd.dossier",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cin = c.String(maxLength: 255, unicode: false),
                        diplomes = c.String(maxLength: 255, unicode: false),
                        etatdossier = c.String(maxLength: 255, unicode: false),
                        photo = c.String(maxLength: 255, unicode: false),
                        utilisateur_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("leviobd.utilisateur", t => t.utilisateur_id)
                .Index(t => t.utilisateur_id);
            
            CreateTable(
                "leviobd.utilisateur",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(maxLength: 255, unicode: false),
                        name = c.String(maxLength: 255, unicode: false),
                        password = c.String(maxLength: 255, unicode: false),
                        age = c.Int(nullable: false),
                        lastname = c.String(maxLength: 255, unicode: false),
                        phone = c.Int(nullable: false),
                        role = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "leviobd.test",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(storeType: "date"),
                        etattest = c.String(maxLength: 255, unicode: false),
                        resultat = c.String(maxLength: 255, unicode: false),
                        typetest = c.String(maxLength: 255, unicode: false),
                        utilisateur_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("leviobd.utilisateur", t => t.utilisateur_id)
                .Index(t => t.utilisateur_id);
            
            CreateTable(
                "leviobd.message",
                c => new
                    {
                        idmessage = c.Int(nullable: false, identity: true),
                        contenu = c.String(maxLength: 255, unicode: false),
                        reciever = c.String(maxLength: 255, unicode: false),
                        sender = c.String(maxLength: 255, unicode: false),
                        subject = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idmessage);
            
            CreateTable(
                "leviobd.reclamation",
                c => new
                    {
                        idreclamation = c.Int(nullable: false, identity: true),
                        daterec = c.DateTime(storeType: "date"),
                        deftype = c.String(maxLength: 255, unicode: false),
                        description = c.String(maxLength: 255, unicode: false),
                        email = c.String(maxLength: 255, unicode: false),
                        etatreclamation = c.String(maxLength: 255, unicode: false),
                        typereclamation = c.String(maxLength: 255, unicode: false),
                        reponse_idrep = c.Int(),
                    })
                .PrimaryKey(t => t.idreclamation)
                .ForeignKey("leviobd.reponsereclamation", t => t.reponse_idrep)
                .Index(t => t.reponse_idrep);
            
            CreateTable(
                "leviobd.reponsereclamation",
                c => new
                    {
                        idrep = c.Int(nullable: false, identity: true),
                        reponse = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idrep);
            
            CreateTable(
                "dbo.parraincandidats",
                c => new
                    {
                        parrain_idPar = c.Int(nullable: false),
                        candidat_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.parrain_idPar, t.candidat_id })
                .ForeignKey("leviobd.parrain", t => t.parrain_idPar, cascadeDelete: true)
                .ForeignKey("leviobd.candidat", t => t.candidat_id, cascadeDelete: true)
                .Index(t => t.parrain_idPar)
                .Index(t => t.candidat_id);
            
            CreateTable(
                "dbo.ressourcecomp",
                c => new
                    {
                        idCompetence = c.Int(nullable: false),
                        idRessource = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idCompetence, t.idRessource })
                .ForeignKey("leviobd.competence", t => t.idCompetence, cascadeDelete: true)
                .ForeignKey("leviobd.ressource", t => t.idRessource, cascadeDelete: true)
                .Index(t => t.idCompetence)
                .Index(t => t.idRessource);
            
            CreateTable(
                "dbo.ressource_competence",
                c => new
                    {
                        Ressources_idRessource = c.Int(nullable: false),
                        Competences_idCompetence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ressources_idRessource, t.Competences_idCompetence })
                .ForeignKey("leviobd.ressource", t => t.Ressources_idRessource, cascadeDelete: true)
                .ForeignKey("leviobd.competence", t => t.Competences_idCompetence, cascadeDelete: true)
                .Index(t => t.Ressources_idRessource)
                .Index(t => t.Competences_idCompetence);
            
        }
        
        public override void Down()
        {
            DropForeignKey("leviobd.reclamation", "reponse_idrep", "leviobd.reponsereclamation");
            DropForeignKey("leviobd.test", "utilisateur_id", "leviobd.utilisateur");
            DropForeignKey("leviobd.dossier", "utilisateur_id", "leviobd.utilisateur");
            DropForeignKey("leviobd.projet", "client_id", "leviobd.client");
            DropForeignKey("leviobd.organigramme", "client_id", "leviobd.client");
            DropForeignKey("leviobd.projet", "organigramme_IdOrg", "leviobd.organigramme");
            DropForeignKey("leviobd.mandat", "projet_idProjet", "leviobd.projet");
            DropForeignKey("leviobd.mandat", "ressource_idRessource", "leviobd.ressource");
            DropForeignKey("dbo.ressource_competence", "Competences_idCompetence", "leviobd.competence");
            DropForeignKey("dbo.ressource_competence", "Ressources_idRessource", "leviobd.ressource");
            DropForeignKey("dbo.ressourcecomp", "idRessource", "leviobd.ressource");
            DropForeignKey("dbo.ressourcecomp", "idCompetence", "leviobd.competence");
            DropForeignKey("leviobd.projet_competence", "competences_idCompetence", "leviobd.competence");
            DropForeignKey("dbo.parraincandidats", "candidat_id", "leviobd.candidat");
            DropForeignKey("dbo.parraincandidats", "parrain_idPar", "leviobd.parrain");
            DropForeignKey("leviobd.candidat", "demande_idDemande", "leviobd.demande");
            DropIndex("dbo.ressource_competence", new[] { "Competences_idCompetence" });
            DropIndex("dbo.ressource_competence", new[] { "Ressources_idRessource" });
            DropIndex("dbo.ressourcecomp", new[] { "idRessource" });
            DropIndex("dbo.ressourcecomp", new[] { "idCompetence" });
            DropIndex("dbo.parraincandidats", new[] { "candidat_id" });
            DropIndex("dbo.parraincandidats", new[] { "parrain_idPar" });
            DropIndex("leviobd.reclamation", new[] { "reponse_idrep" });
            DropIndex("leviobd.test", new[] { "utilisateur_id" });
            DropIndex("leviobd.dossier", new[] { "utilisateur_id" });
            DropIndex("leviobd.projet_competence", new[] { "competences_idCompetence" });
            DropIndex("leviobd.mandat", new[] { "ressource_idRessource" });
            DropIndex("leviobd.mandat", new[] { "projet_idProjet" });
            DropIndex("leviobd.projet", new[] { "client_id" });
            DropIndex("leviobd.projet", new[] { "organigramme_IdOrg" });
            DropIndex("leviobd.organigramme", new[] { "client_id" });
            DropIndex("leviobd.candidat", new[] { "demande_idDemande" });
            DropTable("dbo.ressource_competence");
            DropTable("dbo.ressourcecomp");
            DropTable("dbo.parraincandidats");
            DropTable("leviobd.reponsereclamation");
            DropTable("leviobd.reclamation");
            DropTable("leviobd.message");
            DropTable("leviobd.test");
            DropTable("leviobd.utilisateur");
            DropTable("leviobd.dossier");
            DropTable("leviobd.projet_competence");
            DropTable("leviobd.competence");
            DropTable("leviobd.ressource");
            DropTable("leviobd.mandat");
            DropTable("leviobd.projet");
            DropTable("leviobd.organigramme");
            DropTable("leviobd.client");
            DropTable("leviobd.parrain");
            DropTable("leviobd.demande");
            DropTable("leviobd.candidat");
        }
    }
}
