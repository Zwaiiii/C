using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace dbtest_acess {
    internal class Program {
        static void Main(string[] args)
        {
            /*
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testdb.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            string query = "insert into sales (salecode,customercode,itemcode,date1,qty,price) " +
            "values (1, \"홍길동\",\"컴퓨터\",\"2019-08-02\",10, 10000)";
            // command를 생성하고, connection 설정
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            */

            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testdb.accdb"; ;
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            /*
            string query = "insert into sales (salecode,customercode,itemcode,date1,qty,price) " +
            "values (1, \"홍길동\",\"컴퓨터\",\"2019-08-02\",10, 10000)";
            string query = "update sales set itemcode=\"노트북\" where itemcode=\"컴퓨터\"";
            */
            string query = "select * from sales";
            // command를 생성하고, connection 설정
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Console.WriteLine(r[0].ToString() + "," + r[1].ToString() + "," +
                r[2].ToString() + "," + r[3].ToString() + "," +
                r[4].ToString() + "," + r[5].ToString());
            }
            r.Close();
            // cmd.ExecuteNonQuery(); 
            conn.Close();
        }
    }
}
