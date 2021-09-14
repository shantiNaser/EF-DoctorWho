using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EF_DoctorWho.Db
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        static void Main(string[] args)
        {
            // PrepraeTable();
            // PrintEpsiodeViewData();
            // CompanionsFunctionResult(2);
            // EnemyFunctionResult(2);
        }

        private static void PrepraeTable()
        {
            InsertDataInAuthorTable();
            InsertDataInEnemyTable();
            InsertDataInCompanionTable();
            InsertDataInDoctorTable();
            InsertDataInEpisodeTable();
            InsertDataInEpisodeCompanionTable();
            InsertDataInEpisodeEnemyTable();

        }
        private static void InsertDataInAuthorTable()
        {
            var Author1 = new tblAuthor { AuthorName = "Naser" };
            var Author2 = new tblAuthor { AuthorName = "sudqi" };
            var Author3 = new tblAuthor { AuthorName = "Ahmad" };
            var Author4 = new tblAuthor { AuthorName = "Ali" };
            var Author5 = new tblAuthor { AuthorName = "Amjad" };
            _context.tblAuthor.AddRange(Author1, Author2, Author3, Author4, Author5);
            _context.SaveChanges();
        }
        private static void InsertDataInEnemyTable()
        {
            var Enemy1 = new tblEnemy { EnemyName = "sudqi", Description = "original programmer" };
            var Enemy2 = new tblEnemy { EnemyName = "Naser", Description = "Derivative programmer" };
            var Enemy3 = new tblEnemy { EnemyName = "Mohammad", Description = "evil Programmer" };
            var Enemy4 = new tblEnemy { EnemyName = "Hala", Description = "fast Programmer" };
            var Enemy5 = new tblEnemy { EnemyName = "Roaa", Description = "dangrous Programmer" };
            _context.tblEnemy.AddRange(Enemy1, Enemy2, Enemy3, Enemy4, Enemy5);
            _context.SaveChanges();
        }
        private static void InsertDataInCompanionTable()
        {
            var Comp1 = new tblCompanion { companionName = "Naser", WhoPlayed = "Sudqi" };
            var Comp2 = new tblCompanion { companionName = "Hala", WhoPlayed = "Raneem" };
            var Comp3 = new tblCompanion { companionName = "suha", WhoPlayed = "alaa" };
            var Comp4 = new tblCompanion { companionName = "mohammad", WhoPlayed = "ahmad" };
            var Comp5 = new tblCompanion { companionName = "jamal", WhoPlayed = "jehad" };
            _context.tblCompanion.AddRange(Comp1, Comp2, Comp3, Comp4, Comp5);
            _context.SaveChanges();
        }
        private static void InsertDataInDoctorTable()
        {
            var Dr1 = new tblDoctor
            {
                DoctorNumber = 12345
                                    ,
                DoctorName = "Alaa",
                BirthDate = new DateTime(1980, 08, 23),
                FirstEpisodeDate = new DateTime(1990, 02, 16),
                LastEpisodeDate = new DateTime(2000, 03, 05)
            };
            var Dr2 = new tblDoctor
            {
                DoctorNumber = 54321
                                    ,
                DoctorName = "Hala",
                BirthDate = new DateTime(1988, 09, 01),
                FirstEpisodeDate = new DateTime(1998, 02, 16),
                LastEpisodeDate = new DateTime(2010, 03, 05)
            };
            var Dr3 = new tblDoctor
            {
                DoctorNumber = 13579
                                    ,
                DoctorName = "ahmad",
                BirthDate = new DateTime(1985, 05, 08),
                FirstEpisodeDate = new DateTime(1995, 06, 04),
                LastEpisodeDate = new DateTime(2014, 05, 02)
            };
            var Dr4 = new tblDoctor
            {
                DoctorNumber = 97531
                                    ,
                DoctorName = "jood",
                BirthDate = new DateTime(1988, 06, 01),
                FirstEpisodeDate = new DateTime(1990, 12, 02),
                LastEpisodeDate = new DateTime(2013, 02, 02)
            };
            var Dr5 = new tblDoctor
            {
                DoctorNumber = 19087
                                    ,
                DoctorName = "sudgi",
                BirthDate = new DateTime(1995, 09, 01),
                FirstEpisodeDate = new DateTime(2000, 09, 08),
                LastEpisodeDate = new DateTime(2015, 03, 04)
            };
            _context.tblDoctor.AddRange(Dr1, Dr2, Dr3, Dr4, Dr5);
            _context.SaveChanges();
        }
        private static void InsertDataInEpisodeTable()
        {
            var Eps1 = new tblEpisode
            {
                SeriesNumber = 165,
                EpisodeNumber = 134,
                EpisodeType = "mobilApplication",
                Title = null,
                EpisodeDate = new DateTime(2012, 05, 09),
                tblAuthorID = 2,
                tblDoctorID = 1,
                Notes = "Flutter Cross Platform"
            };
            var Eps2 = new tblEpisode
            {
                SeriesNumber = 194,
                EpisodeNumber = 142,
                EpisodeType = "Machine Learining",
                Title = "DataScience",
                EpisodeDate = new DateTime(2018, 03, 09),
                tblAuthorID = 2,
                tblDoctorID = 3,
                Notes = null
            };
            var Eps3 = new tblEpisode
            {
                SeriesNumber = 144,
                EpisodeNumber = 198,
                EpisodeType = "backend",
                Title = "web",
                EpisodeDate = new DateTime(2014, 01, 03),
                tblAuthorID = 1,
                tblDoctorID = 5,
                Notes = "Microsoft"
            };
            var Eps4 = new tblEpisode
            {
                SeriesNumber = 100,
                EpisodeNumber = 120,
                EpisodeType = "React",
                Title = "web",
                EpisodeDate = new DateTime(2012, 03, 24),
                tblAuthorID = 3,
                tblDoctorID = 4,
                Notes = null
            };
            var Eps5 = new tblEpisode
            {
                SeriesNumber = 204,
                EpisodeNumber = 155,
                EpisodeType = "nlp",
                Title = "DataScience",
                EpisodeDate = new DateTime(2019, 02, 27),
                tblAuthorID = 5,
                tblDoctorID = 2,
                Notes = null
            };
            _context.tblEpisode.AddRange(Eps1, Eps2, Eps3, Eps4, Eps5);
            _context.SaveChanges();
        }
        private static void InsertDataInEpisodeCompanionTable()
        {
            var EpsCom1 = new tblEpisodeCompanion { tblCompanionID = 1, tblEpisodeID = 2 };
            var EpsCom2 = new tblEpisodeCompanion { tblCompanionID = 2, tblEpisodeID = 3 };
            var EpsCom3 = new tblEpisodeCompanion { tblCompanionID = 3, tblEpisodeID = 4 };
            var EpsCom4 = new tblEpisodeCompanion { tblCompanionID = 4, tblEpisodeID = 5 };
            _context.tblEpisodeCompanion.AddRange(EpsCom1, EpsCom2, EpsCom3, EpsCom4);
            _context.SaveChanges();
        }
        private static void InsertDataInEpisodeEnemyTable()
        {
            var EpsEnm1 = new tblEpisodeEnemy { tblEpisodeID = 2, tblEnemyID = 1 };
            var EpsEnm2 = new tblEpisodeEnemy { tblEpisodeID = 3, tblEnemyID = 2 };
            var EpsEnm3 = new tblEpisodeEnemy { tblEpisodeID = 4, tblEnemyID = 3 };
            var EpsEnm4 = new tblEpisodeEnemy { tblEpisodeID = 5, tblEnemyID = 4 };
            _context.tblEpisodeEnemy.AddRange(EpsEnm1, EpsEnm2, EpsEnm3, EpsEnm4);
            _context.SaveChanges();
        }
        private static void PrintEpsiodeViewData()
        {
            var Data = _context.viewEpisodes.ToList();
            foreach (var item in Data)
            {
                Console.WriteLine(item.AuthorName + " " + item.DoctorName + " " + item.viewEpisodes + " " + item.Enemies);
            }
        }
        private static void AddNewAuthor(string name)
        {
            var Author = new tblAuthor { AuthorName = name };
            _context.tblAuthor.Add(Author);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void UpdateExistingAuthor(int AuthorID, string newName)
        {
            var Author = _context.tblAuthor.Find(AuthorID);
            Author.AuthorName = newName;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void UpdateExistingAuthor(int AuthorID)
        {
            var Author = _context.tblAuthor.Find(AuthorID);
            _context.tblAuthor.Remove(Author);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void AddNewDoctor(string Drname, int DrNumber, DateTime BD, DateTime FEPS, DateTime LEPS)
        {
            var Dr = new tblDoctor
            {
                DoctorName = Drname,
                DoctorNumber = DrNumber,
                BirthDate = BD,
                FirstEpisodeDate = FEPS,
                LastEpisodeDate = LEPS

            };
            _context.tblDoctor.Add(Dr);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void UpdateExistingDoctor(int DrID, string Drname, int DrNumber, DateTime BD, DateTime FEPS, DateTime LEPS)
        {
            var Dr = _context.tblDoctor.Find(DrID);
            Dr.DoctorName = Drname;
            Dr.DoctorNumber = DrNumber;
            Dr.BirthDate = BD;
            Dr.FirstEpisodeDate = FEPS;
            Dr.LastEpisodeDate = LEPS;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void DeleteExistingDoctor(int DrID)
        {
            var Dr = _context.tblDoctor.Find(DrID);
            _context.tblDoctor.Remove(Dr);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void AddNewEnemys(string Name, string Desc)
        {
            var Enm = new tblEnemy { EnemyName = Name, Description = Desc };
            _context.tblEnemy.Add(Enm);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void updateExistingEnemys(int Id, string Name, string Desc)
        {
            var Enm = _context.tblEnemy.Find(Id);
            Enm.EnemyName = Name;
            Enm.Description = Desc;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void DeleteExistingEnemys(int ID)
        {
            var Enm = _context.tblEnemy.Find(ID);
            _context.tblEnemy.Remove(Enm);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void AddNewCompanion(string Name, string WhoPlay)
        {
            var Com = new tblCompanion { companionName = Name, WhoPlayed = WhoPlay };
            _context.tblCompanion.Add(Com);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void UpdateExistingCompanion(int id, string Name, string WhoPlay)
        {
            var Com = _context.tblCompanion.Find(id);
            Com.companionName = Name;
            Com.WhoPlayed = WhoPlay;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void DeleteExistingCompanion(int id)
        {
            var Com = _context.tblCompanion.Find(id);
            _context.tblCompanion.Remove(Com);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void AddNewEpsoide(int SNumber, int ENumber, string EType, string Title, DateTime EDate, int AuotherID, int DrID, string Note)
        {
            var Eps = new tblEpisode
            {
                SeriesNumber = SNumber,
                EpisodeNumber = ENumber,
                EpisodeType = EType,
                Title = Title,
                EpisodeDate = EDate,
                tblAuthorID = AuotherID,
                tblDoctorID = DrID,
                Notes = Note
            };
            _context.tblEpisode.Add(Eps);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");

        }
        private static void UpdateEpsoide(int EpsoideID, int SNumber, int ENumber, string EType, string Title, DateTime EDate, int AuotherID, int DrID, string Note)
        {
            var Eps = _context.tblEpisode.Find(EpsoideID);
            Eps.SeriesNumber = SNumber;
            Eps.EpisodeNumber = ENumber;
            Eps.EpisodeType = EType;
            Eps.Title = Title;
            Eps.EpisodeDate = EDate;
            Eps.tblAuthorID = AuotherID;
            Eps.tblDoctorID = DrID;
            Eps.Notes = Note;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void DeleteEPisode(int id)
        {
            var EPs = _context.tblEpisode.Find(id);
            _context.tblEpisode.Remove(EPs);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        private static void CompanionsFunctionResult(int EpsoideId)
        {
            var Name = from C in _context.tblCompanion
                       join EC in _context.tblEpisodeCompanion on C.tblCompanionID equals EC.tblCompanionID
                       select _context.CompanionsFunctionResult(EpsoideId);
            System.Console.WriteLine(Name.Take(1).ToList().First());
        }

        private static void EnemyFunctionResult(int EpsoideId)
        {
            var Name = from E in _context.tblEnemy
                       join EE in _context.tblEpisodeEnemy on E.tblEnemyId equals EE.tblEnemyID
                       select _context.EnemiesFunctionResult(EpsoideId);
            System.Console.WriteLine(Name.Take(1).ToList().First());
        }


    }
}
