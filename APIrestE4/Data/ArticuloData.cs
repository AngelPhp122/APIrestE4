using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIrestE4.Models;
using System.Data;
using System.Data.SqlClient;

namespace APIrestE4.Data
{
    public class ArticuloData
    {
        Data.Conexion objConexion = new Conexion();

        


        
        
           public List<Articulo> listaArticulo() {

            List<Articulo> listaArticulos = new List<Articulo>();
               try
               {
                   objConexion.getConexionDB().Open();
                   string consultaSQL = "Select * from tbArticulos";
                   SqlCommand comando = new SqlCommand(consultaSQL, objConexion.getConexionDB());
                   SqlDataReader lector = comando.ExecuteReader();

                   while (lector.Read())
                   {

                       listaArticulos.Add(new Articulo()
                       {
                           id_producto = Convert.ToInt32(lector["id_producto"]),
                           id_categoria = Convert.ToInt32(lector["id_categoria"]),
                           id_imagen = Convert.ToInt32(lector["id_imagen"]),
                           nombreArticulo = lector["nombreArticulo"].ToString(),
                           descripcionArt = lector["descripcionArt"].ToString(),
                           cantidad = int.Parse(lector["cantidad"].ToString()),
                           precio = double.Parse(lector["precio"].ToString()),
                           fechaCaptura = lector["fechaCaptura"].ToString()

                       });


                   }

                   lector.Close();

                   objConexion.getConexionDB().Close();



                   return listaArticulos;
               }
               catch (Exception ex) { 
               Console.WriteLine(ex.ToString());
                   string msg = ex.Message;    
                   return listaArticulos;    
               }
               }
           }
   

    
}
