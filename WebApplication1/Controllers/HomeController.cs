using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Filters.CheckUserRole]
        public ActionResult SayHello()
        {

            return Content("我是Lucy，这只能给我访问");
        }
        [HttpPost]
        public void Upload(HttpPostedFileBase img)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            try
            {
                FileInfo fileinfo = new FileInfo(img.FileName);

                string serverfilename = Guid.NewGuid().ToString().Replace("-", "") + fileinfo.Extension;

                img.SaveAs(Server.MapPath("~/Content/images/" + Path.GetFileName(serverfilename)));

                result["path"] = "/Content/images/" + Path.GetFileName(serverfilename);
            }
            catch (Exception ex)
            {
                result["error"] = ex.Message;
            }
            this.HttpContext.Response.Write(new JavaScriptSerializer().Serialize(result));
        }


        //后台代码
        //为了简便这里就不对图片进行压缩等处理了。。。
        [HttpPost]
        public string UploadImage(HttpPostedFileBase image)
        {
            string st = "";
            if (image != null)
            {
                string vPath = TempBasePicUrl + Guid.NewGuid().ToString() + ".png";
                string tempFilePath = Server.MapPath("~" + vPath);
                image.SaveAs(tempFilePath);
                st = vPath;
               
            }
            return st;
        }

        private string TempBasePicUrl
        {
            get
            {
                string temp = "/temp/";
                string dir = Server.MapPath("~" + temp);
                if (!System.IO.Directory.Exists(dir))
                {
                    System.IO.Directory.CreateDirectory(dir);
                }
                return temp;
            }
        }
    }
}