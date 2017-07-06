using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApplication1
{
    public class Test
    {
        
        static int i;
        static Test()
        {
            i = 1;
            Console.WriteLine("I am Test 静态默认构造函数 i={0}", i);
        }
        public Test(int j)
        {
            Console.WriteLine("I am Test 公有有参构造函数 i={0}", j);
        }



    }
    class Program
    {
        

        public Program()
        {
            Console.WriteLine("空构造函数");  
        }
        public Program(int i)
        {
            Console.WriteLine("带参数：");
        }
        public delegate void getIntDelegate(int i);
        public delegate void MakeGreeting(string name);
        public void English(string name)
        {
            Console.WriteLine("Good Morning，"+name);
        }
        public void Chinese(string name)
        {
            Console.WriteLine("早上好！，"+name);
        }
        public void GreetPepole(string name, MakeGreeting mg)
        {
            mg(name);
        }

        static void Main(string[] args)
        {


            Program p = new Program();
            p.ss();


            //string zjh = "06-2811-301-1292";
            //string zjh15 = string.Empty;
            //if (!string.IsNullOrEmpty(zjh) && zjh.Length > 15)
            //{
            //    zjh15 = zjh.Substring(0, 6) + zjh.Substring(8, 9);
            //}

            //Program pm = new Program();
            //pm.GreetPepole("wushuang", pm.English);
            //pm.GreetPepole("无双", pm.Chinese);
            //List<Task> list = new List<Task>();
            //Test t = new Test(2);

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var l = list.FirstOrDefault(p => p > 9);

            //Dictionary<string, int> dt = new Dictionary<string, int>();
           

            //var r = list.FindAll(delegate(int i) { return i > 3; });
            //var t = list.FindAll(p => p > 3);

            //Console.ReadLine();

            //getIntDelegate gt = new getIntDelegate(myint);
            //gt(1);
            
        }
        public static void myint(int i)
        {
            Console.WriteLine(i);
        }

        public async void ss()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("user");

            await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

            //var list = await collection.Find(new BsonDocument("Name", "Jack")).ToListAsync();

            //foreach (var document in list)
            //{
            //    Console.WriteLine(document["Name"]);
            //}

        }

    }
}
