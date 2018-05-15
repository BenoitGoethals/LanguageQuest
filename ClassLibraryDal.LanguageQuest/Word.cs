namespace ClassLibraryDal.LanguageQuest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Word
    {
        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string NL { get; set; }

        [StringLength(255)]
        public string Transcriptie { get; set; }

        [StringLength(255)]
        public string Arabisch { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [StringLength(255)]
        public string Section { get; set; }

        [StringLength(255)]
        public string AllReadyWriten { get; set; }

        public int id { get; set; }

        public int? TypeWord { get; set; }

        public virtual TypeWord TypeWord1 { get; set; }
    }
}
