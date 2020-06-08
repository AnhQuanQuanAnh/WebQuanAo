using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopClothing.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsSvc _svc;

        public ProductsController()
        {
            _svc = new ProductsSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getProductById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);
            return Ok(res);
        }

        [HttpPost("get-all")]
        public IActionResult getAllProducts()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }

        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] ProductReq req)
        {
            var res = _svc.CreateProduct(req);
            return Ok(res);
        }

        [HttpPost("update-product")]
        public IActionResult UpdateProduct([FromBody] ProductReq req)
        {
            var res = _svc.UpdateProduct(req);
            return Ok(res);
        }

        [HttpPost("delete-product/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var res = _svc.Remove(id);
            return Ok(res);
        }
    }
}