using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySqlConnector;

namespace AcceDatos
{
    public class clsConexiones
    {

        //string Serv = ConfigurationManager.AppSettings["Server"];
        public static SqlConnection cnn = new SqlConnection(@"Data Source=" + ConfigurationManager.AppSettings["Server"] + ";Initial Catalog=db_Conta;User ID=JGarcia;Password=JGarcia");

        public static DataTable EjecDtaTable(string Dato)
        {
            DataTable dt = new DataTable();
            DataTable DTable = new DataTable();
            try
            {
                cnn.Open();
                SqlDataAdapter DatAdap = new SqlDataAdapter();
            
                //sql
                string sql = Dato;
                        //da = new MySqlDataAdapter("SELECT * FROM `producto` ", cnx);
                        //sql = "select * from Cuenta where Cuenta.Cuenta_Tipo = 1";
                //SQL
                //SqlCommand cmd = new SqlCommand(sql, cnn);
                //cnn.Open();
                //SqlDataAdapter DatAdap = new SqlDataAdapter(cmd);
                DatAdap.SelectCommand = new SqlCommand(sql, cnn);
                DatAdap.Fill(DTable);
                cnn.Close();
                DatAdap.Dispose();

            }
            catch (Exception e)
            {
                if (DTable.Rows.Count ==0)
                {
                    MessageBox.Show("La tabla esta vacia");
                }
                else
                {
                MessageBox.Show("ERROR: " + e);
                }

                

            }
            
            return DTable;

        }


        public static void EjecutaQuery(string Dato)
        {


            //SQL
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter ();
            String sql = Dato;


            try
            {
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }

        }


        public static string EjecString(string Dato)
        {
            string val = "";

            try
            {
                //sql
                cnn.Open();
                //DataTable DTable = new DataTable();
                string sql = Dato;
                //da = new MySqlDataAdapter("SELECT * FROM `producto` ", cnx);
                //sql = "select * from Cuenta where Cuenta.Cuenta_Tipo = 1";
                //SQL
                SqlCommand cmd = new SqlCommand(sql, cnn);
                //cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetString(0);
                }

                //cnn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }
            cnn.Close();

            return val;

        }



        public static void MysqlEjecutar(string StrQuery)
        {   //console.clever-cloud.com
            MySqlConnection conn = new MySqlConnection("server=b1niq90f5jehrlqokc8p-mysql.services.clever-cloud.com;port=3306;database=b1niq90f5jehrlqokc8p;user id=utdatkhbhzmdks7m;password=7jweV77mAMzyA9F0vLFl;charset=utf8");
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    //tvTips.Text = " Successfully connected";
                    MySqlCommand cmd = new MySqlCommand(StrQuery, conn);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                //tvTips.Text = ex.ToString();
                //Toast.MakeText(context, ex.ToString(), ToastLength.Long).Show(); //Muestra un Toast con el error (Puede ser muy largo)
                //return false;
            }
            finally
            {
                conn.Close();
            }



        }




        public static int MysqlObtener(string StrQuery)
        {
            int id = 0;
            //console.clever-cloud.com
            MySqlConnection conn1 = new MySqlConnection("server=b1niq90f5jehrlqokc8p-mysql.services.clever-cloud.com;port=3306;database=b1niq90f5jehrlqokc8p;user id=utdatkhbhzmdks7m;password=7jweV77mAMzyA9F0vLFl;charset=utf8");


            try
            {
                if (conn1.State == ConnectionState.Closed)
                {
                    conn1.Open();

                    MySqlCommand cmd = new MySqlCommand(StrQuery, conn1);
                    //MySqlDataReader rdr = cmd.ExecuteReader();

                    //if (rdr.HasRows)
                    //{
                    //while (rdr.Read())
                    //{
                    //    for (int i = 0; i < NumCampo; i++)
                    id = (Int32)cmd.ExecuteScalar();

                    //}

                    //rdr.Close();

                    //}

                }

            }
            catch (MySqlException ex)
            {
                //tvTips.Text = ex.ToString();
                //Toast.MakeText(context, ex.ToString(), ToastLength.Long).Show(); //Muestra un Toast con el error (Puede ser muy largo)
                //return false;
            }
            finally
            {
                conn1.Close();
            }


            return id;
        }













    }
}
