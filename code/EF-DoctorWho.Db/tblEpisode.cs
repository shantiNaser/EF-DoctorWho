using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DoctorWho.Db
{
    public class tblEpisode
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tblEpisodeID { get; set; }

        public int SeriesNumber { get; set; }

        public int EpisodeNumber { get; set; }

        [MaxLength(20)]
        public string EpisodeType { get; set; }


        [MaxLength(20)]
        public string Title { get; set; }

        public DateTime EpisodeDate { get; set; }

        // Fk for tblAutor
        public int tblAuthorID { get; set; }

        // Fk for tblDoctor
        public int tblDoctorID { get; set; }

        [MaxLength(50)]
        public string Notes { get; set; }


        public tblEpisodeEnemy EpisodeEnemy { get; set; }

        public tblEpisodeCompanion EpisodeCompanion { get; set; }


    }
}