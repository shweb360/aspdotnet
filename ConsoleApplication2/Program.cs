using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        public static int mm(ref int i){

            return i+1;
        }
       


        static void Main(string[] args)
        {

            string st = "0,10,11,12,13,14,16";
            string max = st.Remove(0, st.LastIndexOf(",")+1);
            int i = int.Parse(max);

            //var bjfxThree = new List<string>()
            //{
            //    "P0101",
            //    "P0101",
            //};
            //var strStart = "P0101001".Substring(0, 5);// P0101001
            //if (bjfxThree.Contains(strStart))
            //{
            //  string  strFxkf = "-1";
            //}

            //string st = "-1";
            //int m = int.Parse(st);
            //int j=0;
            //int s = mm(ref j );

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
