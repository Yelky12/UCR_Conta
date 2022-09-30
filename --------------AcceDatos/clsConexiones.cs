using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AcceDatos
{
   public class clsConexiones
    {

        //public static MySqlConnection cnx = new MySqlConnection("server=127.0.0.1; database=DB_Ventas; Uid=root; pwd=;");
        public static SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-MMQ6BMP;Initial Catalog=db_ventas;User ID=JGarcia;Password=JGarcia");


        public static void EjecutaQuery(string Opcion)
        {
            MySqlCommand cmd = new MySqlCommand();
            //SQL
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            switch (Opcion)
            {

                case "RP": 

                    cmd = new MySqlCommand($"INSERT INTO `producto`(`NombreProducto`, `Precio`) VALUES ('{ClassBT.clsProducto.NombreProducto}',{ClassBT.clsProducto.Precio})", cnx);
                    sql = $"INSERT INTO producto(NombreProducto, Precio) VALUES (' {ClassBT.clsProducto.NombreProducto}',{ClassBT.clsProducto.Precio})";
                    break;

                case "RV":
                    cmd = new MySqlCommand($"INSERT INTO `ventas`( `Fecha`, `Costo`) VALUES ('{ClassBT.clsVenta.Fecha}',{ClassBT.clsVenta.Costo})", cnx);
                    sql = $"INSERT INTO ventas( Fecha, Costo) VALUES ('{ClassBT.clsVenta.Fecha}',{ClassBT.clsVenta.Costo})";
                    break;

                case "RDV":
                    cmd = new MySqlCommand($"INSERT INTO `detallaventa`( `idProductofk`, `Cantidad`, `Costo`, `idVentas`) VALUES ({ClassBT.clsDetallesVenta.idProdcutofk},{ClassBT.clsDetallesVenta.Cantidad},{ClassBT.clsDetallesVenta.CostoDetalle},{ClassBT.clsDetallesVenta.IdVentafk})", cnx);
                    sql = $"INSERT INTO detallaventa( idProductofk, Cantidad, Costo, idVentas) VALUES ({ClassBT.clsDetallesVenta.idProdcutofk},{ClassBT.clsDetallesVenta.Cantidad},{ClassBT.clsDetallesVenta.CostoDetalle},{ClassBT.clsDetallesVenta.IdVentafk})";
                    break;

            }

            try
            {
                //cnx.Open();
                //cmd.ExecuteNonQuery();
                //cnx.Close();
                //sql
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


        public static DataTable EjecutaQueryConsulta(string Dato, string Opcion)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            //sql
            cnn.Open();
            DataTable DTable = new DataTable();
            string sql = "";

            switch (Opcion)
            {

                case "C":
                    da = new MySqlDataAdapter("SELECT * FROM `producto` ", cnx);
                    sql = "SELECT * FROM producto";
                    break;

            }
            switch (Opcion)
            {

                case "IDV":
                    da = new MySqlDataAdapter("SELECT MAX( `idVenta`) FROM `ventas`", cnx);
                    sql = "SELECT MAX( idVenta) FROM ventas";
                    break;

            }

            switch (Opcion)
            {

                case "CDV":
                    da = new MySqlDataAdapter("SELECT `idVenta`, `Fecha`, V.Costo,`idProducto`, `NombreProducto`, `Precio`,`idDetalleventa`, `idProductofk`, `Cantidad`,dv.Costo FROM ventas as V , producto as p,detallaventa as dv WHERE idVenta=dv.idVentas and idProducto=idProductofk", cnx);
                    sql = "SELECT idVenta, Fecha, V.Costo,idProducto, NombreProducto, Precio,idDetalleventa, idProductofk, Cantidad,dv.Costo FROM ventas as V , producto as p,detallaventa as dv WHERE idVenta=dv.idVentas and idProducto=idProductofk";
                    break;

            }
            try
            {
                //cnx.Open();
                //da.Fill(dt);
                //cnx.Close();
                //SQL
                SqlCommand cmd = new SqlCommand(sql, cnn);
                //cnn.Open();
                SqlDataAdapter DatAdap = new SqlDataAdapter(cmd);
                DatAdap.Fill(DTable);
                cnn.Close();
                DatAdap.Dispose();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }

            return DTable;

        }




        public static DataTable EjecDtaTable(string Dato)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            //sql
            cnn.Open();
            DataTable DTable = new DataTable();
            string sql = "";

 
                    //da = new MySqlDataAdapter("SELECT * FROM `producto` ", cnx);
                    sql = "select * from Cuenta where Cuenta.Cuenta_Tipo = 1";
                    break;

           
            try
            {
                //cnx.Open();
                //da.Fill(dt);
                //cnx.Close();
                //SQL
                SqlCommand cmd = new SqlCommand(sql, cnn);
                //cnn.Open();
                SqlDataAdapter DatAdap = new SqlDataAdapter(cmd);
                DatAdap.Fill(DTable);
                cnn.Close();
                DatAdap.Dispose();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }

            return DTable;

        }







    }
}
