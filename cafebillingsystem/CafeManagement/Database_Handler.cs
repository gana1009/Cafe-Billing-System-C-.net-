using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeManagement
{
    class Database_Handler
    {
        SqlConnection con;
        SqlCommand cmd;

        public Database_Handler()
        {
            con = new SqlConnection("Data Source=Nitro-5;Initial Catalog=Cafe_RIT;Integrated Security=True");
            
        }
       
        public int add_data(string Items, int Price)
        {
            string str = "insert into Prices values ('" + Items + "'," + Price + ")";
            con.Open();
            cmd = new SqlCommand(str, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;
        }

        public DataTable show_data()
        {
            string str = "select * from Prices";
            con.Open();
            SqlDataAdapter adptr = new SqlDataAdapter(str, con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adptr);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            con.Close();
            return dt;
        }

        public int delete_data(string Items)
        {
            string str = "delete from Prices where Items='" + Items + "'";
            con.Open();
            cmd = new SqlCommand(str, con);
            cmd.CommandText = str;
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n;
        }

        public int update_data(string Items, int Price)
        {
            string str = "update Prices set Price =" + Price.ToString() + " where Items='" + Items + "'";
            con.Open();
            cmd = new SqlCommand(str, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;
        }

        public List<int> fetch_data()
        {
            con.Open();
            string selectquery = "select Price from Prices";
            cmd = new SqlCommand(selectquery, con);

            List<int> list = new List<int>();

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Convert.ToInt32(reader.GetValue(0)));
            }
            con.Close();

            return list;
        }
    }
}
