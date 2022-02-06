using System.Data.SqlClient;

namespace PPSklad
{
    class Links
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FCATBGV\PCC;Initial Catalog=Sklad;Integrated Security=True");
    }
}