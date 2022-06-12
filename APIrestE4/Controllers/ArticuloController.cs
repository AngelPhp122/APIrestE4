using APIrestE4.Data;
using APIrestE4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIrestE4.Controllers
{
    public class ArticuloController : ApiController
    {
       
        // GET api/<controller>

        public List<Articulo> GET() {

            ArticuloData objArticuloData = new ArticuloData();

            

            return objArticuloData.listaArticulo();



        }

        

    }
}