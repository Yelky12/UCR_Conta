using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcceDatos;
using System.Data;
using System.Net.NetworkInformation;


namespace ClaseFunciones
{
   public class ClassFunciones
    {

        public static DataTable EjecutaQueryDataTable(string Opcion)
        {
            String sql = "";

            switch (Opcion)
            {

                case "CM"://Cuenta Madre
                    sql = $"select Cuenta_ID, Cuenta_Descripcion from Cuenta where Cuenta.Cuenta_Tipo < 3";
                    break;

                case "AC"://Cuenta Asociada--Cuenta de ultimo Nivel
                    sql = $"select Cuenta_ID, Cuenta_Descripcion from Cuenta where Cuenta.Cuenta_Tipo =3";
                    break;

                case "RDV":
                    sql = $"select Cuenta_ID, Cuenta_Descripcion from Cuenta where Cuenta.Cuenta_Tipo = 1";
                    break;

                case "BTP"://Buscar Todos los Provedores
                    sql = $"select Tercero_ID, Tercero_Identificador as Identificador, Tercero_Nombre as Nombre from Tercero where Tercero_Tipo = 'P'";
                    break;

                case "BTC"://Buscar Todos los Clientes
                    sql = $"select Tercero_ID, Tercero_Identificador as Identificador, Tercero_Nombre as Nombre from Tercero where Tercero_Tipo = 'C'";
                    break;

                case "TT"://Todos los Terceros
                    sql = $"Select Tercero_ID, Tercero_Identificador as Indentificador, Tercero_Nombre as Nombre, Tercero_Tipo as Tipo from Tercero";
                    break;

                case "TC"://Todas las cuentas
                    sql = $"select Cuenta_Codigo as 'Codigo Cuenta', Cuenta_Descripcion as 'Descripcion', Cuenta_Madre as 'Cuenta Madre', Cuenta_Tipo as 'Tipo', Cuenta_ID, CentroDeCostos_Descripcion as 'Centro de Costos' from Cuenta inner join CentroDeCostos " +
                            "on Cuenta_CentroCostoFK = CentroDeCostos_ID   Order by Cuenta_Codigo asc";

                    break;

                case "TA"://Todos los articulos
                    sql = $"select Articulos_Descripcion as 'Descripcion Articulo', Articulos_Medida 'Unidad de medida', Cuenta.Cuenta_Descripcion as 'Cuenta',Articulos_ID, Articulos_Impuesto as 'Impuesto' " +
                         $"from Articulos inner join Cuenta on (Articulos.Articulos_IDCuentaFK = Cuenta.Cuenta_ID) Where Articulos_Estado = 1 order by Articulos_ID asc";
                    break;

                case "BA"://Buscar Todos los Articulos
                    sql = $"select Articulos_ID, Articulos_Descripcion , Articulos_Medida  from Articulos where Articulos_Estado = 1 order by Articulos_Descripcion asc";
                    break;

                case "BAD"://Buscar Todos Asientos Diarios
                    sql = $"select AsientoEncabezado_ID,	AsientoEncabezado_Documento,	AsientoEncabezado_Fecha, Tercero_Nombre,	AsientoEncabezado_Detalle from AsientoEncabezado inner join Tercero on Tercero_ID = AsientoEncabezado.AsientoEncabezado_IdTerceroFK order by AsientoEncabezado_Fecha asc";
                    break;

                case "OEA"://Obtener Encabezado Asiento
                    sql = $"select AsientoEncabezado_Fecha,	Tercero_Identificador, Tercero_Nombre, AsientoEncabezado_Detalle from AsientoEncabezado " +
                            "inner join Tercero on Tercero_ID = AsientoEncabezado.AsientoEncabezado_IdTerceroFK where " +
                            $"AsientoEncabezado_Documento = { ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento}";
                    break;

                case "ODA"://Buscar Todos Detalles de Asientos
                    sql = $"select Cuenta_Codigo, Cuenta_Descripcion, " +
                           "Case " +
                           "     when AsientoDetalle_Tipo = 'Debito' then AsientoDetalle_Valor " +
                           "     else 0 " +
                           " end as Debito, " +
                           " Case " +
                           "     when AsientoDetalle_Tipo = 'Credito' then AsientoDetalle_Valor " +
                           "     else 0 " +
                           " end as Credito " +
                           " from AsientoDetalle inner join Cuenta on (AsientoDetalle_CodigoCuentaFK = Cuenta.Cuenta_ID)" +
                           $"  where AsientoDetalle_NumeroAsientoFK = { ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento} order by AsientoDetalle_ID ";
                    break;


                case "BCT"://Buscar Compras Todas
                    sql = $"select CompraEncabezado_Documento, CompraEncabezado_Fecha,Moneda_Nombre," +
                        "CompraEncabezado_Condicion,Tercero_Identificador,Tercero_Nombre from CompraEncabezado inner join  Tercero " +
                        " on (CompraEncabezado_IDClienteFK = tercero.Tercero_ID) inner join Moneda on (CompraEncabezado_IDMonedaFK = Moneda.Moneda_ID)";
                    break;

                case "BVT"://Buscar Ventas Todas
                    sql = $"select VentaEncabezado_Documento, VentaEncabezado_Fecha,Moneda_Nombre," +
                        "VentaEncabezado_Condicion,Tercero_Identificador,Tercero_Nombre from VentaEncabezado inner join  Tercero " +
                        " on (VentaEncabezado_IDClienteFK = tercero.Tercero_ID) inner join Moneda on (VentaEncabezado_IDMonedaFK = Moneda.Moneda_ID)";
                    break;

                case "OVE": //Obetener Venta encabezado
                    sql = $"select VentaEncabezado_ID, VentaEncabezado_Documento,VentaEncabezado_Vencimiento,VentaEncabezado_IDClienteFK, " +
                        "VentaEncabezado_Fecha,VentaEncabezado_IDMonedaFK,VentaEncabezado_Condicion,VentaEncabezado_Gravado," +
                        $"VentaEncabezado_Descuento,VentaEncabezado_Impuesto,VentaEncabezado_Total from VentaEncabezado where VentaEncabezado_Documento ={ClaseEntidades.clsVentaEncabezado.VentaEncabezado_ID}";
                    break;

                case "OCE": //Obetener Compra encabezado
                    sql = $"select CompraEncabezado_ID, CompraEncabezado_Documento,CompraEncabezado_Vencimiento,CompraEncabezado_IDClienteFK, " +
                        "CompraEncabezado_Fecha,CompraEncabezado_IDMonedaFK,CompraEncabezado_Condicion,CompraEncabezado_Gravado," +
                        $"CompraEncabezado_Descuento,CompraEncabezado_Impuesto,CompraEncabezado_Total from CompraEncabezado where CompraEncabezado_Documento = {ClaseEntidades.clsCompraEncabezado.CompraEncabezado_ID}";
                    break;

                case "OVD": //Obtener Venta detalle
                    sql = $"select VentaDetalle_ID,	VentaDetalle_IdEncabezadoFK,	VentaDetalle_ArticuloFK,	VentaDetalle_Cant,	VentaDetalle_Precio,"+
                           $"VentaDetalle_Gravado, VentaDetalle_Impuesto, VentaDetalle_Total from VentaDetalle where VentaDetalle_IdEncabezadoFK = {ClaseEntidades.clsVentaEncabezado.VentaEncabezado_ID}";
                    break;

                case "OCD": //Obtener Compra detalle
                    sql = $"select CompraDetalle_ID, CompraDetalle_IdEncabezadoFK, CompraDetalle_ArticuloFK, CompraDetalle_Cant,	CompraDetalle_Precio,"+
                            $"CompraDetalle_Gravado, CompraDetalle_Impuesto, CompraDetalle_Total from CompraDetalle where CompraDetalle_IdEncabezadoFK  = {ClaseEntidades.clsCompraEncabezado.CompraEncabezado_ID}";
                    break;

                case "OTC": //Obtener todos Centro de Costos
                    sql = $"select CentroDeCostos_ID, CentroDeCostos_CentroDeCostos, CentroDeCostos_Descripcion, CentroDeCostos_EsUltimoNivel, CentroDeCostos_Comentarios from CentroDeCostos";
                    break;

                case "CC"://Centro Costo
                    sql = $"select CentroDeCostos_ID, CentroDeCostos_Descripcion from CentroDeCostos";
                    break;

                case "CER"://Mostar la configuracion de estado resultado
                    sql = $"select ConfgEstadoResultado_ID, ConfgEstadoResultado_NombreTitulo,ConfgEstadoResultado_Orden,C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa " +
                           $" from ConfgEstadoResultado CER inner " +
                           $"join Cuenta C on CER.ConfgEstadoResultado_CuentasFK = C.Cuenta_ID";
                    break;

            }



            return clsConexiones.EjecDtaTable(sql);

        }


        public static void EjecutaQueryInsert(string Opcion)
        {
            String sql = "";

            switch (Opcion)
            {

                case "CM": //Insertar Cuenta
                    sql = $"insert into Cuenta (Cuenta_Descripcion, Cuenta_Madre, Cuenta_Tipo, Cuenta_Codigo, Cuenta_CentroCostoFK) values('{ClaseEntidades.clsCuenta.Cuenta_Descripcion}',{ClaseEntidades.clsCuenta.Cuenta_Madre},{ClaseEntidades.clsCuenta.Cuenta_Tipo},'{ClaseEntidades.clsCuenta.Cuenta_Codigo}', {ClaseEntidades.clsCuenta.Cuenta_CentroCostoFK})";
                    break;

                case "AR"://Insertar Articulo
                    sql = $"INSERT INTO Articulos (Articulos_Descripcion,Articulos_Medida,Articulos_IDCuentaFK, Articulos_Impuesto, Articulos_Estado) " + 
                            $"VALUES('{ClaseEntidades.clsArticulos.Articulos_Descripcion}', '{ClaseEntidades.clsArticulos.Articulos_Medida}'," +
                            $"{ClaseEntidades.clsArticulos.Articulos_IDCuentaFK}, {ClaseEntidades.clsArticulos.Articulos_Impuesto}, {ClaseEntidades.clsArticulos.Articulos_Estado})";
                    break;

                case "CE"://Insertar Compra Encabezado
                    sql = $"INSERT INTO CompraEncabezado (CompraEncabezado_Documento,CompraEncabezado_Vencimiento,CompraEncabezado_IDClienteFK, " +
                        "CompraEncabezado_Fecha,CompraEncabezado_IDMonedaFK,CompraEncabezado_Condicion,CompraEncabezado_Gravado," +
                        "CompraEncabezado_Descuento,CompraEncabezado_Impuesto,CompraEncabezado_Total) VALUES" +
                        $"('{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Documento}',convert(datetime, '{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Vencimiento}',101)," + 
                        $"{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDClienteFK}, convert(datetime, '{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Fecha}',101)," +
                        $"{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDMonedaFK}, '{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Condicion}', " +
                        $"{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Gravado}, {ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Descuento}, " +
                        $"{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Impuesto},{ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Total})";
                    break;

                case "VE"://Insertar Venta Encabezado
                    sql = $"INSERT INTO VentaEncabezado (VentaEncabezado_Documento,VentaEncabezado_Vencimiento,VentaEncabezado_IDClienteFK, " +
                        "VentaEncabezado_Fecha,VentaEncabezado_IDMonedaFK,VentaEncabezado_Condicion,VentaEncabezado_Gravado," +
                        "VentaEncabezado_Descuento,VentaEncabezado_Impuesto,VentaEncabezado_Total) VALUES" +
                        $"('{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Documento}',convert(datetime, '{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Vencimiento}',101)," +
                        $"{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDClienteFK}, convert(datetime, '{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Fecha}',101)," +
                        $"{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDMonedaFK}, '{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Condicion}', " +
                        $"{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Gravado}, {ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Descuento}, " +
                        $"{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Impuesto},{ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Total})";
                    break;


                case "CD"://Insertar Compra Detalle
                    sql = $"INSERT INTO CompraDetalle ( CompraDetalle_IdEncabezadoFK,CompraDetalle_ArticuloFK,CompraDetalle_Cant,CompraDetalle_Precio,CompraDetalle_Gravado, CompraDetalle_Impuesto, CompraDetalle_Total) VALUES" +
                          $"({ClaseEntidades.clsCompraDetalle.CompraDetalle_IdEncabezadoFK},{ClaseEntidades.clsCompraDetalle.CompraDetalle_ArticuloFK},{ClaseEntidades.clsCompraDetalle.CompraDetalle_Cant},"+ 
                          $"{ClaseEntidades.clsCompraDetalle.CompraDetalle_Precio},'{ClaseEntidades.clsCompraDetalle.CompraDetalle_Gravado}',{ClaseEntidades.clsCompraDetalle.CompraDetalle_Impuesto}, {ClaseEntidades.clsCompraDetalle.CompraDetalle_Total})";
                    break;

                case "VD"://Insertar Venta Detalle
                    sql = $"INSERT INTO VentaDetalle ( VentaDetalle_IdEncabezadoFK,VentaDetalle_ArticuloFK,VentaDetalle_Cant,VentaDetalle_Precio,VentaDetalle_Gravado,VentaDetalle_Impuesto,VentaDetalle_Total) VALUES" +
                          $"({ClaseEntidades.clsVentaDetalle.VentaDetalle_IdEncabezadoFK},{ClaseEntidades.clsVentaDetalle.VentaDetalle_ArticuloFK},{ClaseEntidades.clsVentaDetalle.VentaDetalle_Cant}," +
                          $"{ClaseEntidades.clsVentaDetalle.VentaDetalle_Precio},'{ClaseEntidades.clsVentaDetalle.VentaDetalle_Gravado}',{ClaseEntidades.clsVentaDetalle.VentaDetalle_Impuesto}, {ClaseEntidades.clsVentaDetalle.VentaDetalle_Total})";
                    break;



                case "TE"://Insertar Tercero
                    sql = $"INSERT INTO Tercero ( Tercero_Identificador, Tercero_Nombre, Tercero_Tipo) VALUES ('" + 
                          $"{ClaseEntidades.clsTercero.Tercero_Identificador}','{ClaseEntidades.clsTercero.Tercero_Nombre}','{ClaseEntidades.clsTercero.Tercero_Tipo}')";
                    break;

                case "IE"://Insertar Nombre Empresa
                    sql = $"INSERT INTO Empresa ( Empresa_Nombre) VALUES('" +
                          $"{ClaseEntidades.clsEmpresa.Empresa_Nombre}')";
                    break;

                case "AE"://Insertar Asiento Encabezado
                    sql = $"INSERT INTO AsientoEncabezado ( AsientoEncabezado_Documento,AsientoEncabezado_Fecha,AsientoEncabezado_IdTerceroFK,AsientoEncabezado_Detalle) VALUES" +
                          $"({ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento},'{ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Fecha}',{ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_IdTerceroFK}," +
                          $"'{ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Detalle}')";
                    break;

                case "AD"://Insertar Asiento Detalle
                    sql = $"INSERT INTO AsientoDetalle (AsientoDetalle_NumeroAsientoFK,AsientoDetalle_Linea,AsientoDetalle_CodigoCuentaFK,AsientoDetalle_Tipo,AsientoDetalle_Valor) VALUES" +
                          $"({ClaseEntidades.clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK},{ClaseEntidades.clsAsientoDetalle.AsientoDetalle_Linea},{ClaseEntidades.clsAsientoDetalle.AsientoDetalle_CodigoCuentaFK}," +
                          $"'{ClaseEntidades.clsAsientoDetalle.AsientoDetalle_Tipo}', {ClaseEntidades.clsAsientoDetalle.AsientoDetalle_Valor})";
                    break;

                case "ICC"://Insertar Centro Costos
                    sql = $"INSERT INTO CentroDeCostos (CentroDeCostos_CentroDeCostos,CentroDeCostos_Descripcion,CentroDeCostos_EsUltimoNivel,CentroDeCostos_Comentarios) VALUES" +
                          $"('{ClaseEntidades.clsCentroCostos.CentroDeCostos_CentroDeCostos}','{ClaseEntidades.clsCentroCostos.CentroDeCostos_Descripcion}','{ClaseEntidades.clsCentroCostos.CentroDeCostos_EsUltimoNivel}'," +
                          $"'{ClaseEntidades.clsCentroCostos.CentroDeCostos_Comentarios}')";
                    break;

                case "ICCER"://Insertar Cuenta a ConfgEstadoResultado
                    sql = $"INSERT INTO ConfgEstadoResultado (ConfgEstadoResultado_NombreTitulo,ConfgEstadoResultado_Orden,ConfgEstadoResultado_CuentasFK,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa) VALUES" +
                          $"('{ClaseEntidades.clsConfgEstResul.clsConfgEstResul_NombreTitulo}',{ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Orden},{ClaseEntidades.clsConfgEstResul.clsConfgEstResul_CuentasFK}," +
                          $"'{ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Naturaleza}', '{ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Empresa}')";
                    break;

                case "IUS"://Insertar Usuarios
                    sql = $"INSERT INTO Usuarios ( Usuarios_Usuario, Usuarios_Clave, Usuarios_TipoUsuario,Usuarios_Estado) VALUES ('" +
                          $"{ClaseEntidades.clsUsuarios.Usuarios_Usuario}','{ClaseEntidades.clsUsuarios.Usuarios_Clave}','{ClaseEntidades.clsUsuarios.Usuarios_TipoUsuario}','{ClaseEntidades.clsUsuarios.Usuarios_Estado}')";
                    break;


            }
            clsConexiones.EjecutaQuery(sql);
        }

        public static string EjecutaQueryString(string Opcion)
        {
            String sql = "";

            switch (Opcion)
            {

                case "OCM": //Obtener Cuenta Madre
                    sql = $"select Cuenta_Codigo from Cuenta where Cuenta_ID ={ClaseEntidades.clsCuenta.Cuenta_Madre}";
                    break;

                case "MO":
                    sql = $"select CONVERT(varchar(10),Moneda_ID) from Moneda where Moneda_Nombre = '{ClaseEntidades.clsMoneda.Moneda_Nombre}'";
                    break;

                case "CEDM":// Obtener el documento mayor
                    //sql = $"SELECT CompraEncabezado_Documento FROM CompraEncabezado WHERE CompraEncabezado_Documento = (SELECT MAX(CompraEncabezado_Documento) FROM CompraEncabezado) ORDER BY CompraEncabezado_Documento";
                    sql = $"SELECT Isnull( cast((SELECT MAX(CompraEncabezado_Documento) FROM CompraEncabezado ) as varchar (10)), cast(0 as varchar(10)))";
                    break;

                case "VEDM":// Obtener el documento mayor
                    sql = $"SELECT Isnull( cast((SELECT MAX(VentaEncabezado_Documento) FROM VentaEncabezado ) as varchar (10)), cast(0 as varchar(10)))";
                    break;

                case "CEID":// Obtener el ID del Encabezado Compras
                    sql = $"select cast(CompraEncabezado_ID as varchar(10)) from CompraEncabezado where CompraEncabezado_Documento = {ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Documento}";
                    break;

                case "VEID":// Obtener el ID del Encabezado Ventas
                    sql = $"select cast(VentaEncabezado_ID as varchar(10)) from VentaEncabezado where VentaEncabezado_Documento = {ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Documento}";
                    break;

                case "ME":// Obtener Nombre de la empresa
                    sql = $"Select Empresa_Nombre from Empresa";
                    break;

                case "DA":// Obtener Nombre del articulo
                    sql = $"select Articulos_Descripcion from Articulos where Articulos_ID = {ClaseEntidades.clsArticulos.Articulos_ID}";
                    break;


                case "NCM":// Obtener Nombre Cuenta Madre
                    //sql = $"select C1.Cuenta_Descripcion from Cuenta inner join Cuenta C1 on(Cuenta.Cuenta_Madre = c1.Cuenta_ID) where " + 
                    //      $"Cuenta.Cuenta_Tipo<> Cuenta.Cuenta_Madre and Cuenta.Cuenta_Madre = {ClaseEntidades.clsCuenta.Cuenta_Madre}";
                    sql = $"select Cuenta_Descripcion from Cuenta where Cuenta_ID = {ClaseEntidades.clsCuenta.Cuenta_Madre}";
                    break;

                case "NC":// Obtener Nombre Cuenta
                    //sql = $"select C1.Cuenta_Descripcion from Cuenta inner join Cuenta C1 on(Cuenta.Cuenta_Madre = c1.Cuenta_ID) where " + 
                    //      $"Cuenta.Cuenta_Tipo<> Cuenta.Cuenta_Madre and Cuenta.Cuenta_Madre = {ClaseEntidades.clsCuenta.Cuenta_Madre}";
                    sql = $"select Cuenta_Descripcion from Cuenta where Cuenta_ID = {ClaseEntidades.clsCuenta.Cuenta_ID}";
                    break;

                case "CC":// Obtener Codigo Cuenta
                    sql = $"select Cuenta_Codigo from Cuenta where Cuenta_ID = {ClaseEntidades.clsCuenta.Cuenta_ID}";
                    break;

                case "IDC":// Obtener ID Cuenta
                    sql = $"select CONVERT(varchar(10), Cuenta_ID) from Cuenta where Cuenta_Codigo = '{ClaseEntidades.clsCuenta.Cuenta_Codigo}'";
                    break;

                case "CAM":// Obtener el numero de asiento mayor
                    sql = $"SELECT Isnull( cast((SELECT MAX(AsientoEncabezado_Documento) FROM AsientoEncabezado ) as varchar (10)), cast(0 as varchar(10)))";
                    break;

                case "ONT"://Obtener Nombre del tercero
                    sql = $"select Tercero_Nombre from Tercero where Tercero_ID ={ ClaseEntidades.clsTercero.Tercero_ID}";
                    break;

                case "OIT"://Obtener Identificador del tercero
                    sql = $"select Tercero_Identificador from Tercero where Tercero_ID ={ ClaseEntidades.clsTercero.Tercero_ID}";
                    break;

                case "OIA"://Obtener Impuesto Articulo
                    sql = $"select STR(Articulos_Impuesto, 25, 2)  from Articulos where Articulos_ID ={ ClaseEntidades.clsArticulos.Articulos_ID}";
                    break;

                case "OUT": //Obtener Usuario y Tipo
                    sql = $"select Usuarios_Usuario + '-' + Usuarios_TipoUsuario from Usuarios where Usuarios_Usuario = '{ClaseEntidades.clsUsuarios.Usuarios_Usuario}' and Usuarios_Clave = '{ClaseEntidades.clsUsuarios.Usuarios_Clave}'";
                    break;

            }



            return clsConexiones.EjecString(sql);

        }


        public static void EjecutaQueryDelete(string Opcion)
        {
            String sql = "";

            switch (Opcion)
            {

                case "DC"://Borrar Cuenta
                    sql = $"delete from Cuenta where Cuenta_Codigo ='{ClaseEntidades.clsCuenta.Cuenta_Codigo}'";
                    break;

                case "DT"://Borrar Tercero
                    sql = $"delete from Tercero where Tercero_Identificador = '{ClaseEntidades.clsTercero.Tercero_Identificador}'";
                    break;

                case "RDV":
                    sql = $"select Cuenta_ID, Cuenta_Descripcion from Cuenta where Cuenta.Cuenta_Tipo = 1";
                    break;

                case "RAE": //Borrar Asiento Diario Encabezado
                    sql = $"delete AsientoEncabezado where AsientoEncabezado_Documento = {ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento}";
                    break;

                case "RAD": //Borrar Asiento Diario Detalle
                    sql = $"delete AsientoDetalle where AsientoDetalle_NumeroAsientoFK = {ClaseEntidades.clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK}";
                    break;

                case "Elimina": //Borrar Asiento Diario Detalle
                    sql = $"delete AsientoDetalle where AsientoDetalle_NumeroAsientoFK = {ClaseEntidades.clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK}";
                    break;

               


            }
            clsConexiones.EjecutaQuery(sql);
        }

        public static void EjecutaQueryUpdate(string Opcion)
        {
            String sql = "";

            switch (Opcion)
            {

                case "AE": //Actualizar Cuenta
                    sql = $"UPDATE Empresa SET Empresa_Nombre = '{ClaseEntidades.clsEmpresa.Empresa_Nombre}'";
                    break;

                case "AR"://Insertar Articulo
                    sql = $"INSERT INTO Articulos (Articulos_Descripcion,Articulos_Medida,Articulos_IDCuentaFK) VALUES('{ClaseEntidades.clsArticulos.Articulos_Descripcion}', '{ClaseEntidades.clsArticulos.Articulos_Medida}', {ClaseEntidades.clsArticulos.Articulos_IDCuentaFK})";
                    break;

                case "ACC"://Actualizar Catalogo de Cuentas
                    sql = $"UPDATE Cuenta SET Cuenta_Descripcion = '{ClaseEntidades.clsCuenta.Cuenta_Descripcion}', Cuenta_Madre = {ClaseEntidades.clsCuenta.Cuenta_Madre}," +
                        $"Cuenta_Tipo = {ClaseEntidades.clsCuenta.Cuenta_Tipo}, Cuenta_Codigo = '{ClaseEntidades.clsCuenta.Cuenta_Codigo}', Cuenta_CentroCostoFK = {ClaseEntidades.clsCuenta.Cuenta_CentroCostoFK}" +
                        $" Where Cuenta_ID = {ClaseEntidades.clsCuenta.Cuenta_ID}";
                    break;

                case "CEA"://Cambiar estado de Articulo a eliminado
                    sql = $"UPDATE Articulos set Articulos_Estado = {ClaseEntidades.clsArticulos.Articulos_Estado} where Articulos_ID = {ClaseEntidades.clsArticulos.Articulos_ID}";
                    break;

                case "AA"://Actualizar Articulo
                    sql = $"Update Articulos set Articulos_Descripcion='{ClaseEntidades.clsArticulos.Articulos_Descripcion}', Articulos_Medida= '{ClaseEntidades.clsArticulos.Articulos_Medida}'," +
                           $"Articulos_IDCuentaFK={ClaseEntidades.clsArticulos.Articulos_IDCuentaFK}, Articulos_Impuesto={ClaseEntidades.clsArticulos.Articulos_Impuesto}" + 
                           $" where Articulos_ID = {ClaseEntidades.clsArticulos.Articulos_ID}";
                    break;


            }
            clsConexiones.EjecutaQuery(sql);
        }


        public static string MantenimientoMac(string Opcion)
        {
            String sql = "";
            String firstMacAddress = "";
            String Dato="";

            switch (Opcion)
            {

                case "OM": //Obtener Mac
                    firstMacAddress = NetworkInterface
                    .GetAllNetworkInterfaces()
                    .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    .Select(nic => nic.GetPhysicalAddress().ToString())
                    .FirstOrDefault();
                    Dato = firstMacAddress;
                    break;

                case "EM"://Enviar Mac
                    sql = $"INSERT INTO `VerificarMac` (Mac,Estado) VALUES('{ClaseEntidades.clsMac.MacNum}', 0)";
                    clsConexiones.MysqlEjecutar(sql);
                    break;

                case "VM"://Validar Mac
                    sql = $"SELECT ESTADO FROM `VerificarMac` WHERE Mac = '{ClaseEntidades.clsMac.MacNum}'";
                    Dato =  clsConexiones.MysqlObtener(sql).ToString();
                    break;


            }

            return Dato;
        }

        public static string ObtenerLista(string Opcion)
        {
            String sql = "";
            String Dato = "";


            switch (Opcion)
            {

                case "OVE": //Obetener Venta encabezado
                    sql = $"select VentaEncabezado_Documento,VentaEncabezado_Vencimiento,VentaEncabezado_IDClienteFK, " +
                        "VentaEncabezado_Fecha,VentaEncabezado_IDMonedaFK,VentaEncabezado_Condicion,VentaEncabezado_Gravado," +
                        $"VentaEncabezado_Descuento,VentaEncabezado_Impuesto,VentaEncabezado_Total from VentaEncabezado where VentaEncabezado_Documento ={ClaseEntidades.clsVentaEncabezado.VentaEncabezado_ID}";
                    break;

                case "OCE": //Obetener Compra encabezado
                    sql = $"select CompraEncabezado_Documento,CompraEncabezado_Vencimiento,CompraEncabezado_IDClienteFK, " +
                        "CompraEncabezado_Fecha,CompraEncabezado_IDMonedaFK,CompraEncabezado_Condicion,CompraEncabezado_Gravado," +
                        $"CompraEncabezado_Descuento,CompraEncabezado_Impuesto,CompraEncabezado_Total from CompraEncabezado where CompraEncabezado_Documento = {ClaseEntidades.clsCompraEncabezado.CompraEncabezado_ID}";
                    break;
            }
            clsConexiones.EjecutaQuery(sql);

            return Dato;
        }




    }
}
