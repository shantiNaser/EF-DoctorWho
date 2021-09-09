using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DoctorWho.Db
{
    public class tblCompanion
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tblCompanionID { get; set; }
        [MaxLength(20)]
        public string companionName { get; set; }

        [MaxLength(20)]
        public string WhoPlayed { get; set; }

        public tblEpisodeCompanion EpisodeCompanion { get; set; }
    }
}