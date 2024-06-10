using NMHBaiThiGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMHBaiThiGiuaKy.Controllers
{
    public class NMHController : Controller
    {
        private static List<NmhProduct> nmhProducts = new List<NmhProduct>()
        {
            new NmhProduct(){Id=106,NMHName="Lê Vinh Huy",NMHImage="1234",NMHQuantity=10,NMHPrice=1000000,NMHIsActive=true},
            new NmhProduct(){Id=1,NMHName="Đỗ Trọng Thạo",NMHImage="1235",NMHQuantity=11,NMHPrice=2000000,NMHIsActive=true},
        };

        public ActionResult NMHIndex()
        {
            return View(nmhProducts);
        }

        public ActionResult NMHCreate()
        {
            var nmhModel = new NmhProduct();
            return View(nmhModel);
        }

        [HttpPost]
        public ActionResult NMHCreate(NmhProduct nmhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(nmhProduct);
            }
            nmhProducts.Add(nmhProduct);
            return RedirectToAction("NMHIndex");
        }

        public ActionResult NMHEdit(int id)
        {
            var product = nmhProducts.Find(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult NMHDetails(int id)
        {
            var product = nmhProducts.Find(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NMHEdit(NmhProduct nmhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(nmhProduct);
            }

            var product = nmhProducts.Find(p => p.Id == nmhProduct.Id);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.NMHName = nmhProduct.NMHName;
            product.NMHImage = nmhProduct.NMHImage;
            product.NMHQuantity = nmhProduct.NMHQuantity;
            product.NMHPrice = nmhProduct.NMHPrice;
            product.NMHIsActive = nmhProduct.NMHIsActive;

            return RedirectToAction("NMHIndex");
        }
    }
}
