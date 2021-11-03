using System.Linq;
using Xunit;
using EF_DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace Test.Tests
{
    public class EF_DoctorWho_Test
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        [Fact]
        public void CanInsertDataInAuthorTable()
        {
            _context.Database.EnsureCreated();
            // To make sure that database is existed 
            var Author = new tblAuthor();
            _context.tblAuthor.Add(Author);
            _context.SaveChanges();
            var ID = Author.tblAutorID;
            Assert.Equal(ID, Author.tblAutorID);
            // we do not need This Row ... Just for Test
            _context.tblAuthor.Remove(Author);
            _context.SaveChanges();

        }

        [Fact]
        public void CanInsertDataInEnemyTable()
        {
            _context.Database.EnsureCreated();
            // To make sure that database is existed 
            var Enemy = new tblEnemy();
            _context.tblEnemy.Add(Enemy);
            _context.SaveChanges();
            var ID = Enemy.tblEnemyId;
            Assert.Equal(ID, Enemy.tblEnemyId);
            // we do not need This Row ... Just for Test
            _context.tblEnemy.Remove(Enemy);
            _context.SaveChanges();
        }

        [Fact]
        public void CanInsertDataInCompanionTable()
        {
            _context.Database.EnsureCreated();
            // To make sure that database is existed 
            var Comp = new tblCompanion();
            _context.tblCompanion.Add(Comp);
            _context.SaveChanges();
            var ID = Comp.tblCompanionID;
            Assert.Equal(ID, Comp.tblCompanionID);
            // we do not need This Row ... Just for Test
            _context.tblCompanion.Remove(Comp);
            _context.SaveChanges();
        }

        [Fact]
        public void CanInsertDataInDoctorTable()
        {
            _context.Database.EnsureCreated();
            // To make sure that database is existed 
            var Dr = new tblDoctor();
            _context.tblDoctor.Add(Dr);
            _context.SaveChanges();
            var ID = Dr.tblDoctorID;
            Assert.Equal(ID, Dr.tblDoctorID);
            // we do not need This Row ... Just for Test
            _context.tblDoctor.Remove(Dr);
            _context.SaveChanges();
        }

        [Fact]
        public void CanInsertDataInEpsiodeTable()
        {
            int number = _context.tblEpisode.OrderBy(s => s.tblEpisodeID).Last().tblEpisodeID;
            var Eps = new tblEpisode
            {
                tblEpisodeID = number + 1,
                tblAuthorID = 2,
                tblDoctorID = 1
            };

            _context.Database.OpenConnection();
            try
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisode ON");
                _context.tblEpisode.Add(Eps);
                _context.SaveChanges();
                Assert.Equal(number + 1, Eps.tblEpisodeID);
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisode OFF");
            }
            finally
            {
                // we do not need This Row ... Just for Test
                _context.tblEpisode.Remove(Eps);
                _context.SaveChanges();
                _context.Database.CloseConnection();
            }
        }


        [Fact]
        public void CanInsertDataInEpisodeCompanionTable()
        {
            int number = _context.tblEpisodeCompanion.OrderBy(s => s.tblEpisodeCompanionID).Last().tblEpisodeCompanionID;
            var EpsCom = new tblEpisodeCompanion
            {
                tblEpisodeCompanionID = number + 1,
                tblEpisodeID = 1,
                tblCompanionID = 1

            };

            _context.Database.OpenConnection();
            try
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisodeCompanion ON");
                _context.tblEpisodeCompanion.Add(EpsCom);
                _context.SaveChanges();
                Assert.Equal(number + 1, EpsCom.tblEpisodeCompanionID);
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisodeCompanion OFF");
            }
            finally
            {
                // we do not need This Row ... Just for Test
                _context.tblEpisodeCompanion.Remove(EpsCom);
                _context.SaveChanges();
                _context.Database.CloseConnection();
            }
        }


        [Fact]
        public void CanInsertDataInEpisodeEnemyTable()
        {
            int number = _context.tblEpisodeEnemy.OrderBy(s => s.tblEpisodeEnemyID).Last().tblEpisodeEnemyID;
            var EpsEnm = new tblEpisodeEnemy
            {
                tblEpisodeEnemyID = number + 1,
                tblEpisodeID = 2,
                tblEnemyID = 2

            };

            _context.Database.OpenConnection();
            try
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisodeEnemy ON");
                _context.tblEpisodeEnemy.Add(EpsEnm);
                _context.SaveChanges();
                Assert.Equal(number + 1, EpsEnm.tblEpisodeEnemyID);
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.tblEpisodeEnemy OFF");
            }
            finally
            {
                // we do not need This Row ... Just for Test
                _context.tblEpisodeEnemy.Remove(EpsEnm);
                _context.SaveChanges();
                _context.Database.CloseConnection();
            }
        }

    }
}

