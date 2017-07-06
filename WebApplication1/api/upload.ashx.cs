using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1.api
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;

            string action = request["action"];
            string hash = request["hash"];

            int fileCount = request.Files.Count;
            string imgurl = "";
            if (string.IsNullOrEmpty(hash))
            {
                //普通上传
                if (fileCount > 0)
                {
                    HttpPostedFile file = request.Files[0];
                    
                    string fileName = request["fileName"];
                    if (string.IsNullOrEmpty(fileName)) fileName = System.IO.Path.GetFileName(file.FileName);

                    FileInfo fileinfo = new FileInfo(file.FileName);

                    string serverfilename = Guid.NewGuid().ToString().Replace("-", "") + fileinfo.Extension;
                    
                    string path = context.Server.MapPath("~/Content/images/" + serverfilename);
                    file.SaveAs(path);
                    imgurl = "~/Content/images/" + serverfilename;
                }
            }

            Finish(GetResponseJSON(request, "", imgurl));
        }

        /// <summary>
        /// 获取返回的json字符串
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private string GetResponseJSON(HttpRequest request, string result, string imgurl)
        {
            string type = request["type"];
            string user = request["user"];
            string name = request["name"];

            //此处返回的JSON字符串为手动拼接,未处理字符串转义等特殊情况,仅作演示
            string json = "\"time\":\"" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\"";
            if (type != null) json += ",\"type\":\"" + type + "\"";
            if (user != null) json += ",\"user\":\"" + user + "\"";
            if (name != null) json += ",\"name\":\"" + name + "\"";
            json += ",\"imgurl\":\"" + imgurl + "\"";

            return "{" + json + result + "}";
        }

        /// <summary>
        /// 完成上传
        /// </summary>
        /// <param name="json">回调函数参数</param>
        private void Finish(string json)
        {
            HttpResponse Response = HttpContext.Current.Response;

            Response.Write(json);
            Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}