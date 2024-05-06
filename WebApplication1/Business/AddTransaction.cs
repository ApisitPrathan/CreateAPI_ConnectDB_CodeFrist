using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Business
{
    public class AddTransaction
    {
        private readonly ApplicationDb _db;
        public AddTransaction(ApplicationDb db)
        {
            _db = db;
        }

        public void AddTran(Count transaction)
        {
            
            _db.Add(transaction);
            _db.SaveChanges();
        }
    }
}
