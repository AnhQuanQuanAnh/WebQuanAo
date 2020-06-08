using System;
using System.Collections.Generic;
using System.Text;

using ShopClothing.Common.Rsp;
using ShopClothing.Common.BLL;

namespace ShopClothing.BLL
{
    using DAL;
    using DAL.Models;
    using ShopClothing.Common.Req;

    public class ProductsSvc : GenericSvc<ProductsRep, Products>
    {
        #region -- Overrides --

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="m">The model</param>
        /// <returns>Return the result</returns>
        public override SingleRsp Update(Products m)
        {
            var res = new SingleRsp();

            var m1 = m.ProductId > 0 ? _rep.Read(m.ProductId) : _rep.Read(m.Name);
            if (m1 == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }

        public SingleRsp CreateProduct(ProductReq pro)
        {
            var res = new SingleRsp();
            Products prod = new Products();
            prod.ProductId = pro.ProductId;
            prod.Name = pro.Name;
            prod.Detail = pro.Detail;
            prod.Price = pro.Price;
            prod.Image = pro.Image;
            prod.PriceNew = pro.PriceNew;
            prod.Date = pro.Date;
            prod.Status = pro.Status;
            prod.GroupProductId = pro.GroupProductId;
            res = _rep.CreateProduct(prod);

            return res;
        }

        public SingleRsp UpdateProduct(ProductReq pro)
        {
            var res = new SingleRsp();
            Products prod = new Products();
            prod.ProductId = pro.ProductId;
            prod.Name = pro.Name;
            prod.Detail = pro.Detail;
            prod.Price = pro.Price;
            prod.Image = pro.Image;
            prod.PriceNew = pro.PriceNew;
            prod.Date = pro.Date;
            prod.Status = pro.Status;
            prod.GroupProductId = pro.GroupProductId;
            res = _rep.UpdateProduct(prod);

            return res;
        }

        #endregion -- Overrides --

    }
}
