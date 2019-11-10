namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;

    public partial  class Contexte2 : DbContext
    {
        public   Contexte2()
            : base("name=leviobd")
        {
        }

        public virtual DbSet<candidat> candidat { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<competence> competence { get; set; }
        public virtual DbSet<demande> demande { get; set; }
        public virtual DbSet<dossier> dossier { get; set; }
        public virtual DbSet<mandat> mandat { get; set; }
        public virtual DbSet<message> message { get; set; }
        public virtual DbSet<organigramme> organigramme { get; set; }
        public virtual DbSet<parrain> parrain { get; set; }
        public virtual DbSet<projet> projet { get; set; }
        public virtual DbSet<reclamation> reclamation { get; set; }
        public virtual DbSet<reponsereclamation> reponsereclamation { get; set; }
        public virtual DbSet<ressource> ressource { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
        public virtual DbSet<projet_competence> projet_competence { get; set; }

        protected override   void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<candidat>()
                .Property(e => e.etat)
                .IsUnicode(false);

            //modelBuilder.Entity<candidat>()
            //    .Property(e => e.mail)
            //    .IsUnicode(false);

            //modelBuilder.Entity<candidat>()
            //    .Property(e => e.nom)
            //    .IsUnicode(false);

            //modelBuilder.Entity<candidat>()
            //    .Property(e => e.pays)
            //    .IsUnicode(false);

            //modelBuilder.Entity<candidat>()
            //    .Property(e => e.prenom)
            //    .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Typeclient)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.categories)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.projet)
                .WithOptional(e => e.client)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<client>()
                .HasMany(e => e.organigramme)
                .WithOptional(e => e.client)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<competence>()
                .Property(e => e.Competences)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .HasMany(e => e.projet_competence)
                .WithRequired(e => e.competence)
                .HasForeignKey(e => e.competences_idCompetence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<competence>()
                .HasMany(e => e.ressource1)
                .WithMany(e => e.competence1)
                .Map(m => m.ToTable("ressourcecomp").MapLeftKey("idCompetence").MapRightKey("idRessource"));

            modelBuilder.Entity<demande>()
                .Property(e => e.EtatDemande)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.Specialite)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.lettreaffercation)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.pays)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .HasMany(e => e.candidat)
                .WithOptional(e => e.demande)
                .HasForeignKey(e => e.demande_idDemande);

            modelBuilder.Entity<dossier>()
                .Property(e => e.cin)
                .IsUnicode(false);

            modelBuilder.Entity<dossier>()
                .Property(e => e.diplomes)
                .IsUnicode(false);

            modelBuilder.Entity<dossier>()
                .Property(e => e.etatdossier)
                .IsUnicode(false);

            modelBuilder.Entity<dossier>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.reciever)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.sender)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<organigramme>()
                .Property(e => e.NomDir)
                .IsUnicode(false);

            modelBuilder.Entity<organigramme>()
                .Property(e => e.NomHauteDir)
                .IsUnicode(false);

            modelBuilder.Entity<organigramme>()
                .Property(e => e.Pvp)
                .IsUnicode(false);

            modelBuilder.Entity<organigramme>()
                .Property(e => e.Vp)
                .IsUnicode(false);

            modelBuilder.Entity<organigramme>()
                .HasMany(e => e.projet)
                .WithOptional(e => e.organigramme)
                .HasForeignKey(e => e.organigramme_IdOrg);

            modelBuilder.Entity<parrain>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<parrain>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<parrain>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            //modelBuilder.Entity<parrain>()
            //    .HasMany(e => e.candidat)
            //    .WithOptional(e => e.parrain)
            //    .HasForeignKey(e => e.parrain_idPar);

            modelBuilder.Entity<projet>()
                .Property(e => e.NomProjet)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.Typeprojet)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.mandat)
                .WithRequired(e => e.projet)
                .HasForeignKey(e => e.projet_idProjet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.deftype)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.etatreclamation)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.typereclamation)
                .IsUnicode(false);

            modelBuilder.Entity<reponsereclamation>()
                .Property(e => e.reponse)
                .IsUnicode(false);

            modelBuilder.Entity<reponsereclamation>()
                .HasMany(e => e.reclamation)
                .WithOptional(e => e.reponsereclamation)
                .HasForeignKey(e => e.reponse_idrep);

            modelBuilder.Entity<ressource>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.historique)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.origine)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.profil)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.secteur)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.seniorite)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .Property(e => e.statut)
                .IsUnicode(false);

            modelBuilder.Entity<ressource>()
                .HasMany(e => e.mandat)
                .WithOptional(e => e.ressource)
                .HasForeignKey(e => e.ressource_idRessource);

            modelBuilder.Entity<ressource>()
                .HasMany(e => e.competence)
                .WithMany(e => e.ressource)
                .Map(m => m.ToTable("ressource_competence").MapLeftKey("Ressources_idRessource").MapRightKey("Competences_idCompetence"));

            modelBuilder.Entity<test>()
                .Property(e => e.etattest)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.resultat)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.typetest)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.dossier)
                .WithOptional(e => e.utilisateur)
                .HasForeignKey(e => e.utilisateur_id);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.test)
                .WithOptional(e => e.utilisateur)
                .HasForeignKey(e => e.utilisateur_id);

            modelBuilder.Entity<projet_competence>()
                .Property(e => e.Projet_idProjet)
                .IsUnicode(false);
        }
    }
}
