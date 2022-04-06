using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class Appconexicion
    {
       // Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\SISTEMA DE VENTAS\CapaDatos\Dbvents_y_compra.mdf";Integrated Security = True
        public static string miconexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SISTEMA DE VENTAS\CapaDatos\Dbvents_y_compra.mdf;Integrated Security = True ";
        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}
namespace CapaDatos
{
    class Class1
    {
    }
}
