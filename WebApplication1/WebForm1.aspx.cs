
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        private const string conn = "mongodb://127.0.0.1:27017";
        /// <summary>
        /// 指定的数据库
        /// </summary>
        private const string dbName = "test";
        /// <summary>
        /// 指定的表
        /// </summary>
        private const string tbName = "user";

        protected void Page_Load(object sender, EventArgs e)
        {
            ss();
            
            //string s = "2017010001";
            //int i = Convert.ToInt32(s);
            
            //string st = "F2AB01-201704-0001";
            //if (st.IndexOf("F2AB01") > -1)
            //{
            //    s = "";
            //}


           
            //T_CareApply car = new T_CareApply()
            //{
            //    ElderlyId=11
            //};

            //string st = null;
            //string a=st.ToUpper();
           // DateTime dt_Now = DateTime.Now;
           //string st= dt_Now.ToString("yyyyMM");
           // DateTime? dt2 = Convert.ToDateTime("2017-05-01");
           // if (dt2 < dt_Now)
           // {

           // }
            //if (!IsPostBack)
            //{
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("20160025", "上海协恒工程管理有限公司");
            //    dic.Add("20170056", "上海张园建设投资有限公司");
            //    this.DropDownList1.DataSource = dic;
            //    this.DropDownList1.DataValueField = "key";
            //    this.DropDownList1.DataTextField = "value";                
            //    this.DropDownList1.DataBind();
            //}


            //this.DropDownList1.Items.Add("上海协恒工程管理有限公司");
            //this.DropDownList1.Items.Add("协恒工程管理有限公司");
            //string st = DateTime.Now.Month.ToString("D2");          
           

            //Random rd = new Random();
            //string s = rd.Next(1, 999999).ToString();
            //Response.Write(s);
           
            //DataTable oldData = ExcelToDataTable("F:/getdate/old.xls", "sheet1");
            //DataTable newData = ExcelToDataTable("F:/getdate/new2.xls", "sheet1");

            //List<string> list1 = new List<string>();
            //List<string> list2 = new List<string>();

            //for (int i = 1; i < oldData.Rows.Count; i++)
            //{
            //    String mystr = oldData.Rows[i][1].ToString();
            //    list1.Add(mystr);

            //}
            //for (int i = 1; i < newData.Rows.Count; i++)
            //{
            //    String mystr2 = newData.Rows[i][1].ToString();
            //    list2.Add(mystr2);

            //}

            //foreach (var item in list1)
            //{
            //    if (!list2.Contains(item.ToString().Trim()))
            //    {
            //        Response.Write(item + "<br/>");
            //    }
            //}
          
        }

        public async void  ss()
        {
            var client = new MongoClient(conn);
            var database = client.GetDatabase(dbName);
            var collection = database.GetCollection<BsonDocument>("user");

            await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

            var list = await collection.Find(new BsonDocument("Name", "Jack"))
                .ToListAsync();

            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }

        }
        public static DataTable ExcelToDataTable(string strExcelFileName, string strSheetName)
        {
            
            //源的定义
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strExcelFileName + ";" + "Extended Properties='Excel 8.0;HDR=NO;IMEX=1';";

            //Sql语句
            //string strExcel = string.Format("select * from [{0}$]", strSheetName); 这是一种方法
            string strExcel = "select * from   [sheet1$]";

            //定义存放的数据表
            DataSet ds = new DataSet();

            //连接数据源
            OleDbConnection conn = new OleDbConnection(strConn);

            conn.Open();

            //适配到数据源
            OleDbDataAdapter adapter = new OleDbDataAdapter(strExcel, strConn);
            adapter.Fill(ds, strSheetName);

            conn.Close();

            return ds.Tables[strSheetName];
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.TextBox1.Text = this.DropDownList1.SelectedItem.Text;
            this.TextBox2.Text = this.DropDownList1.SelectedValue;
        }
    }

    public class user
    {
        public string name { get; set; }

    }
}