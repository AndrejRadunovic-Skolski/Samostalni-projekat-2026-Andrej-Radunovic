using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samostalni_projekat_2026_Andrej_Radunovic
{
    internal class Konekcija
    {
        public static SqlConnection NapraviVezu()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Forum;Integrated Security=True;");
        }
    }
}
