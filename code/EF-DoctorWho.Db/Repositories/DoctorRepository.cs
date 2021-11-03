using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EF_DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public static void AddNewDoctor(string Drname, int DrNumber, DateTime BD, DateTime FEPS, DateTime LEPS)
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
        public static void UpdateExistingDoctor(int DrID, string Drname, int DrNumber, DateTime BD, DateTime FEPS, DateTime LEPS)
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
        public static void DeleteExistingDoctor(int DrID)
        {
            var Dr = _context.tblDoctor.Find(DrID);
            _context.tblDoctor.Remove(Dr);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }

        public static void PrintAllAvailableDoctor()
        {
            var Drs = _context.tblDoctor.FromSqlInterpolated($"select * from tblDoctor").ToList();
            foreach (var item in Drs)
            {
                Console.WriteLine(item.DoctorName);
            }
        }

    }
}