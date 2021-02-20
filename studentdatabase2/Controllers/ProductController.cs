using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentdatabase2.DAL;
using studentdatabase2.Model;

namespace studentdatabase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        productDAL pobj = new productDAL();
        //[HttpGet]
        //public string Getproducts()
        //{
        //    return "this will be list of products";
        //}



        [HttpGet]
        public ActionResult<List<Product>> Getproducts()
        {
            var produ=pobj.Getproducts();
            return Ok(produ);
            //return "this will be list of products";
        }
        //[HttpGet("{id}")]
        //public  string Getproduts(int id)
        //{
        //    return "this is one product";
        //}

            //checked using post man 
        [HttpGet("{id}")]
        public ActionResult<List<Product>> Getproduts(int id)
        {
            var pro = pobj.GetOneproducts(id);
            return Ok(pro);
            //return "this is one product";
        }

    }
}