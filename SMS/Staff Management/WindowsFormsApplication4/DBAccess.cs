using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication4
{

    public class DBAccess
    {
        public static SqlConnection connect;

        public static SqlConnection GetConnection()
        {
            connect = new SqlConnection("Data Source=LENOVO;Initial Catalog=School;Integrated Security=True");
            return connect;
        }
       

    }
}
