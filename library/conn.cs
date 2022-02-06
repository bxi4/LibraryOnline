using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class conn
    {
        public static MySqlConnection mysqlconn = new MySqlConnection(@"server=localhost;database=exam_library;UID=root;password=;");// من تجل الاتصال بقاعدة البيات mysql
        public static DataTable selectdata(string cmd)
        {
            mysqlconn.Open();
            MySqlDataAdapter mysqldataad = new MySqlDataAdapter(cmd, mysqlconn);
            DataTable dt = new DataTable();
            mysqldataad.Fill(dt);
            mysqlconn.Close();
            return dt;

        }
        public static DataTable selectdata_from_sp(string cmd)
        {
            mysqlconn.Open();
            MySqlCommand command = new MySqlCommand(mysqlconn + "");
            command.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter mysqldataad = new MySqlDataAdapter(cmd, mysqlconn);
            DataTable dt = new DataTable();
            mysqldataad.Fill(dt);
            mysqlconn.Close();
            return dt;



        }
        public static int exesql(string cmd_string)// هذه الدالة تستعمل  لضافة اوامل sql مثل الاضافة والحخذف والتعديل
        {
            mysqlconn.Open();
            MySqlCommand command = new MySqlCommand(cmd_string, mysqlconn);
            int result = command.ExecuteNonQuery();
            mysqlconn.Close();
            return result;

        }
    }
}


