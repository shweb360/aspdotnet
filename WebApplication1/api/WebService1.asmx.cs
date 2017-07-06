using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1.api
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
           
            //1.返回字符串类型 
          //  return "Hello World";
            return Server.UrlDecode("上海国烨建筑建材有限公司");
        }
        [WebMethod]
        public User GetUser()
        {
            User user = new User() { Id = 1, UserName = "zhang san", Password = "123qwe" };
            return user;
        }

        [WebMethod]
        public List<User> GetUserList()
        {
            List<User> list = new List<User>() 
                { 
                new User{Id=1,UserName="zhang san",Password="asfasdf"}, 
                new User{Id=2,UserName="li si",Password="3rwer"}, 
                new User{Id=3,UserName="wang wu",Password="rqwe"} 
                };
            return list;
        }
        [WebMethod]
        public string SayHello(string name)
        {
            return "Hello " + name;
        } 
    }
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
