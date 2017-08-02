
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var itemList = new List<string>();
            #region MyRegion
            var wxyList = new List<Wxy>(){

                new Wxy(){id=1,wxlb="0101a",wxmc="栏杆"},
                new Wxy(){id=2,wxlb="0101b",wxmc="栏杆"},
                new Wxy(){id=3,wxlb="0102a",wxmc="栏杆"},
                new Wxy(){id=4,wxlb="0102b",wxmc="栏杆"},              
                
                new Wxy(){id=5,wxlb="020101a",wxmc="栏杆 脚手架"},
                new Wxy(){id=6,wxlb="020101b",wxmc="栏杆 脚手架"},
                new Wxy(){id=7,wxlb="0202b",wxmc="栏杆 脚手架"},

                new Wxy(){id=8,wxlb="0301a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=9,wxlb="0301b",wxmc="高支模、脚手架、栏杆"},

                new Wxy(){id=10,wxlb="030201a",wxmc="高支模、脚手架"},
                new Wxy(){id=11,wxlb="030201b",wxmc="高支模、脚手架"},
                new Wxy(){id=12,wxlb="030202a",wxmc="高支模、脚手架"},
                new Wxy(){id=12,wxlb="030202b",wxmc="高支模、脚手架"},
                
                new Wxy(){id=13,wxlb="030203a",wxmc="高支模、脚手架"},
                new Wxy(){id=14,wxlb="030203b",wxmc="高支模、脚手架"},
                new Wxy(){id=15,wxlb="030204a",wxmc="高支模、脚手架"},
                new Wxy(){id=16,wxlb="030204b",wxmc="高支模、脚手架"},

                new Wxy(){id=17,wxlb="030205a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=18,wxlb="0303a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=19,wxlb="0303b",wxmc="高支模、脚手架、栏杆"},
                
                new Wxy(){id=20,wxlb="0401a",wxmc="脚手架、栏杆"},
                new Wxy(){id=21,wxlb="0401b",wxmc="脚手架、栏杆"},
                new Wxy(){id=22,wxlb="0402a",wxmc="脚手架、栏杆"},
                new Wxy(){id=23,wxlb="0403a",wxmc="脚手架、栏杆"},
                new Wxy(){id=24,wxlb="040301b",wxmc="脚手架、栏杆"},
                new Wxy(){id=25,wxlb="040302b",wxmc="脚手架、栏杆"},

                new Wxy(){id=26,wxlb="0501a",wxmc="脚手架、栏杆"},
                new Wxy(){id=27,wxlb="0501b",wxmc="脚手架、栏杆"},
                new Wxy(){id=28,wxlb="0502a",wxmc="脚手架、栏杆"},
                new Wxy(){id=29,wxlb="0502b",wxmc="脚手架、栏杆"},
                new Wxy(){id=30,wxlb="0503a",wxmc="脚手架、栏杆"},
                new Wxy(){id=31,wxlb="0503b",wxmc="脚手架、栏杆"},
                new Wxy(){id=32,wxlb="0504a",wxmc="脚手架、栏杆"},
                new Wxy(){id=33,wxlb="0505a",wxmc="脚手架、栏杆"},
                new Wxy(){id=34,wxlb="0506a",wxmc="脚手架、栏杆"},

                new Wxy(){id=35,wxlb="0601a",wxmc="脚手架、栏杆"},
                new Wxy(){id=36,wxlb="060101b",wxmc="脚手架、栏杆"},
                new Wxy(){id=37,wxlb="060102b",wxmc="脚手架、栏杆"},
                new Wxy(){id=38,wxlb="060103b",wxmc="脚手架、栏杆"},
                new Wxy(){id=39,wxlb="0602a",wxmc="脚手架、栏杆"},
                new Wxy(){id=40,wxlb="0602b",wxmc="脚手架、栏杆"},

                new Wxy(){id=41,wxlb="0701a",wxmc="脚手架、栏杆"},
                new Wxy(){id=42,wxlb="0701b",wxmc="脚手架、栏杆"},
                new Wxy(){id=43,wxlb="0702a",wxmc="脚手架、栏杆"},
                new Wxy(){id=44,wxlb="070201b",wxmc="脚手架、栏杆"},
                new Wxy(){id=45,wxlb="070202b",wxmc="脚手架、栏杆"},

                new Wxy(){id=46,wxlb="0703a",wxmc="栏杆"},
                new Wxy(){id=47,wxlb="0703b",wxmc="栏杆"},            

                new Wxy(){id=50,wxlb="0704a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=51,wxlb="0704b",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=52,wxlb="0705a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=53,wxlb="0706a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=54,wxlb="0706b",wxmc="高支模、脚手架、栏杆"},

                new Wxy(){id=55,wxlb="070701a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=56,wxlb="070702a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=57,wxlb="070703a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=58,wxlb="070704a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=59,wxlb="070705a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=60,wxlb="070801a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=61,wxlb="070802a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=62,wxlb="070803a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=63,wxlb="070804a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=64,wxlb="070805a",wxmc="高支模、脚手架、栏杆"},
                new Wxy(){id=65,wxlb="020102b",wxmc="脚手架、栏杆"},
            };
            #endregion
            

            string item ="0,1,2,";
            if (item.Contains(","))
            {
                item = item.Substring(0, item.LastIndexOf(","));
                string[] arry = item.Split(',');
                foreach (var a in arry)
                {
                    itemList.Add(a);
                }
            }
            if (itemList.Contains("0"))
            {
                wxyList = wxyList.Where(p => p.wxmc.Contains("高支模") && !p.wxlb.StartsWith("07")).ToList();
            }
             if (itemList.Contains("1"))
            {
                wxyList = wxyList.Where(p => p.wxmc.Contains("脚手架") && !p.wxlb.StartsWith("07")).ToList();
            }
             if (itemList.Contains("2"))
            {
                wxyList = wxyList.Where(p => p.wxmc.Contains("栏杆") && !p.wxlb.StartsWith("07")).ToList();
            }
             if (itemList.Contains("3"))
            {
                wxyList = wxyList.Where(p => p.wxlb.StartsWith("07")).ToList();
            }
           // string str = "高支模、脚手架、栏杆";
            
           
         //  Response.Write(result.ToString());
        }
    }
    public class Wxy
    {
        public int id { get; set; }
        public string wxlb { get; set; }
        public string wxmc { get; set; }
        public string gcfw { get; set; }

    }
}