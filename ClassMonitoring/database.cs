using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Attendance_Monitoring
{
    class database
    {
        public string GetConnection()
        {
            string connection = "server=localhost;user id=root;password=;database=monitoringsmsdb";
            return connection;
        }
    }
}
