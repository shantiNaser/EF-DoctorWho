using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DoctorWho.Db
{
    public class tblEnemy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tblEnemyId { get; set; }

        [MaxLength(20)]
        public string EnemyName { get; set; }
        public string Description { get; set; }

        public tblEpisodeEnemy EpisodeEnemy { get; set; }
    }
}