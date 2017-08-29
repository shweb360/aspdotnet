using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //调用示例：
            Hashtable ht = new Hashtable();  //Hashtable 为webservice所需要的参数集
            ht.Add("zjh", "122");
            ht.Add("zjlx", "22");
           // XmlDocument xx = WebServiceCaller.QuerySoapWebService("http://localhost:8821/WebService/DataBridge.asmx", "GetQySlry", ht);
            XmlDocument xx = WebServiceCaller.QuerySoapWebService("http://localhost:8821/WebService/DataBridge.asmx", "GetQySlry", ht);
            Console.WriteLine(xx.OuterXml);

            #region 屏蔽测试代码

            //string a = Console.ReadLine();

            //int b = Int32.Parse(a);
            //string st1 = "0";
            //string st2 = "0,2,4,6,8,10";
            //string r1 = st1.Remove(0, st1.LastIndexOf(",") + 1);
            //string r2 = st2.Remove(0, st2.LastIndexOf(",") + 1);
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //List<string> lit = new List<string>();
            //lit.Add("F2AB01-201701-1001");
            //lit.Add("F2AB01-201701-0101");
            //lit.Add("F2AB01-201701-0009");
            ////lit.Add("F2AB01-201701-2012");

            //List<int> lisInt = new List<int>();

            //foreach (var item in lit)
            //{
            //    int i = Convert.ToInt32(item.Remove(0, 14));
            //    lisInt.Add(i);
            //}

            //int max = lisInt.Max(p => p);

            //string str = "0011";
            //int i = Convert.ToInt32(str);
            //List<string> lit = new List<string>();
            //lit.Add("0017");
            //lit.Add("0006");
            //lit.Add("0108");
            //lit.Add("1005");

            //var max = Convert.ToInt32(lit.Max(p => p));

            //test();

            #endregion
        }
        public static async void test()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

            await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

            var list = await collection.Find(new BsonDocument("Name", "Jack"))
                           .ToListAsync();

            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }



        }
    }

}
