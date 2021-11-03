namespace EF_DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public static void AddNewAuthor(string name)
        {
            var Author = new tblAuthor { AuthorName = name };
            _context.tblAuthor.Add(Author);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        public static void UpdateExistingAuthor(int AuthorID, string newName)
        {
            var Author = _context.tblAuthor.Find(AuthorID);
            Author.AuthorName = newName;
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
        public static void DeleteAuthor(int AuthorID)
        {
            var Author = _context.tblAuthor.Find(AuthorID);
            _context.tblAuthor.Remove(Author);
            _context.SaveChanges();
            System.Console.WriteLine("Process was Done Successfully");
        }
    }
}