namespace ClassLibraryDal.LanguageQuest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelLanguage : DbContext
    {
        public ModelLanguage()
            : base("name=ModelLanguage")
        {
        }

        public virtual DbSet<TypeWord> TypeWords { get; set; }
        public virtual DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeWord>()
                .HasMany(e => e.Words)
                .WithOptional(e => e.TypeWord1)
                .HasForeignKey(e => e.TypeWord);
        }
    }
}
