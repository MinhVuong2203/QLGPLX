using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using UI;

namespace DAL
{
    public static class DatabaseSession
    {
        public static QLGPLXContext Context { get; private set; }
        public static void Initialize(string username, string password)
        {
            string connStr = $"Data Source=DESKTOP-39G03JV\\SQLEXPRESS;" +
                             $"Initial Catalog=QLGPLX;" +
                             $"User ID={username};" +
                             $"Password={password};" +
                             $"TrustServerCertificate=True;";
            Context = new QLGPLXContext(connStr);
        }

        public static void Close()
        {
            Context?.Dispose();
            Context = null;
        }
    }
}
