using System;
using System.Collections.Generic;
using System.Text;
using ShopClothing.Common;
using ShopClothing.DAL;
using System.Linq;

namespace ShopClothing.DAL
{
    using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
    using Models;
    using ShopClothing.Common.DAL;
    using ShopClothing.Common.Rsp;
    using System.Reflection.Metadata.Ecma335;
    using System.Transactions;
    using System.Xml;

    public class ProductsRep : GenericRep<WebQuanAoContext, Products>
    {
        #region
        public override Products Read(int id)
        {
            var res = All.FirstOrDefault(p => p.ProductId == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(i => i.ProductId == id);
            m = base.Delete(m);
            return m.ProductId;
        }

        public SingleRsp CreateProduct(Products pro)
        {
            var res = new SingleRsp();
            using(var context = new WebQuanAoContext())
            {
                using(var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Products.Add(pro);
                        context.SaveChanges();
                        tran.Commit();

                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        res.SetError(e.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp UpdateProduct(Products pro)
        {
            var res = new SingleRsp();
            using (var context = new WebQuanAoContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Products.Update(pro);
                        context.SaveChanges();
                        tran.Commit();

                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        res.SetError(e.StackTrace);
                    }
                }
            }
            return res;
        }

        #endregion
    }
}
