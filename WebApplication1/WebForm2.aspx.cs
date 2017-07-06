using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string account = "cce2cd5b-19ff-413e-9450-19a6ab64d23f";
            string key = "r6e355";
            string strDwmc = "上海华";
            string postString = "account=" + account + "&key=" + key + "&dwmc=" + strDwmc;
           
            byte[] postData = System.Text.Encoding.UTF8.GetBytes(postString); //编码，尤其是汉字，事先要看下抓取网页的编码方式  
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");

            string newUrl = "http://172.16.110.229/JGBQyDataService/v1/GetQymcListByQymc";
            byte[] responseData = client.UploadData(newUrl, "POST", postData); //得到返回字符流  
            string value1 = Encoding.UTF8.GetString(responseData);//得到返回JSON字符串
            var list=Newtonsoft.Json.JsonConvert.DeserializeObject<GetQymcListByQymcResponse>(value1);

            Response.Write(value1);

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
    }

    public class GetQymcListByQymcResponse
    {
        public bool Result { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }

        public List<QyInfo> Data { get; set; }

    }
    public class QyInfo
    {
        public string Qymc { get; set; }
        public float Dwid { get; set; }
        public string Dwdm { get; set; }
        public string Jgdmz { get; set; }

    }
}