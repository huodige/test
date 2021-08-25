using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("{\"work_order_no\":\"" + 1 + "\",\"taskType\":\"" + 2 + "\",\"customerPhone\":\"" + 3 + "\",\"telePhone\":\"" + 4 + "\",\"noShow\":\"" + 5 + "\",\"ifSendMessage\":\"" + 6 + "\"}");
            //string str = sb.ToString();
            //Dictionary<string, object> dict = new Dictionary<string, object>();
            //dict.Add("work_order_no","75879617320201026");
            //dict.Add("taskType", "0");
            //dict.Add("customerPhone", "15136405165");
            //dict.Add("telePhone", "15136402568");
            //dict.Add("noShow", "false");
            //dict.Add("ifSendMessage", "true");

            string url1 = "http://hucai-simoo.oss-cn-hangzhou.aliyuncs.com/temp/20210714/96818788120210707/rough/96818788120210707_0001.jpg";
            string url2 = "http://hucai-simoo.oss-cn-hangzhou.aliyuncs.com/temp/20210714/96818788120210707/rough/07623232220210513_0070.jpg";

            string url11 = url1.Substring(0,url1.LastIndexOf('.'));

            string[] arr1 = url1.Split('/');
            //int aaaaq = file_url.LastIndexOf('.')- file_url.IndexOf(arr1[3]);
            //string dewww = url1.Substring(url1.IndexOf(arr1[3]), aaaaq);

            //oss_path = file_url.Substring(file_url.IndexOf(arr[3]), file_url.LastIndexOf('.') - file_url.IndexOf(arr1[3]));

            int asw=url2.IndexOf('/');

            System.IO.File.Copy(url1, url2, true);
            if (System.IO.File.Exists(url1))
            {
                System.IO.File.Copy(url1, url2, true);
            }

            string file_name = "123_";
            //string file_name1 = "123";
            //file_name= file_name.Substring(0, file_name.LastIndexOf('('));
            List<int> list1 = new List<int>();
            int sll=list1.Max();

            string file_name1 = file_name.Substring(0, file_name.LastIndexOf('_'));
            string file_name2= file_name.Substring(file_name.LastIndexOf('_')+1);

            int index1 = file_name.LastIndexOf('(');

            int index2 = file_name.LastIndexOf(')');

            //int index3 = file_name.IndexOf("(");

            file_name = file_name.Substring(index1+1, index2-index1-1);

            //file_name = file_name1.Substring(file_name1.LastIndexOf('('), file_name.LastIndexOf(')'));


            string file_url = "http://192.172.9.148/Uploads/FJFile/000106210625/HP订单信息查询.docx";
            string Directory = System.AppDomain.CurrentDomain.BaseDirectory;
            string file_url1 = (Directory + file_url.Substring(file_url.IndexOf("Uploads"))).Replace("//","\\");
            //string file_name = file_url.Substring(file_url.LastIndexOf("/") + 1);

            string ssdd = "";
            if(string.IsNullOrEmpty(ssdd))
            {
                ssdd = "1";
            }


            int sss1= Program.GetImageType("60");

            int sss2 = Program.GetImageType("30");

            int sss3 = Program.GetImageType("10");

            int sss4 = Program.GetImageType("80");


            string jsonstr = "[{\"s1\":1},{\"s2\":2 }]";

            JArray sdss = new JArray();
            JObject jobjss = new JObject();
            jobjss.Add("s1",1);
            sdss.Add(jobjss);
            JObject jobjss1 = new JObject();
            jobjss1.Add("s1", 2);
            sdss.Add(jobjss1);

            JArray jadee = JArray.Parse(sdss.ToString());
            foreach(var dd in jadee)
            {
                JObject jkh = JObject.Parse(dd.ToString());
                string dds = jkh["s1"].ToString();
            }
            

            HttpHelper help = new HttpHelper();
            //string url = "http://192.172.9.153:8077/api/FileApiPnxTransfer/UpdatePlateStatusToCloudAlbum";
            //var result=help.HttpPostForm(url, dict);
            string url = "http://192.172.9.153:8077";
            string[] ids = { "X0001226320210203", "X0001226320210204" };

            int[] sss = { 1, 2 };
            List<Object> list = new List<Object>();
            
            for(int i=0;i<ids.Length;i++)
            {
                string sb = "{\"plateTaskNos\":\"" + ids[i] + "\"}";
                //list.Add(new StringBuilder("{\"plateTaskNos\":\"" + ids[i] + "\"}"));
                list.Add(sb);
            }
            string ssl = String.Join(",", list);

            JArray ddddd=JArray.Parse(JsonConvert.SerializeObject(ids));

            JArray res = JArray.FromObject(ids);

            foreach(var jjar in res)
            {
                JObject jkh = JObject.Parse(jjar.ToString());
                string dds = jkh["plateTaskNos"].ToString();
            }
            JObject jobjj = new JObject();
            jobjj.Add("plateTaskNos", "X0001226320210203");
            JArray jarr = new JArray();
            jarr.Add(jobjj); 
            string resss = res.ToString();
            string resu = help.HttpRequest(url+ "/api/FileApiPnxTransfer/PushPlateImgToCloudAlbum", jarr.ToString());

            string imagelist = "[[{\"DefaultThumbURL\":\"http://hucai-a.oss-cn-hangzhou.aliyuncs.com/test/20210308/A0001291320210308/001/thumb/13_320x114.jpg\",\"FileName\":\"13.jpg\"}],[{\"DefaultThumbURL\":\"http://hucai-a.oss-cn-hangzhou.aliyuncs.com/test/20210308/A0001291320210308/001/thumb/00_320x225.jpg\",\"FileName\":\"00.jpg\"},{\"DefaultThumbURL\":\"http://hucai-a.oss-cn-hangzhou.aliyuncs.com/test/20210308/A0001291320210308/001/thumb/01_320x114.jpg\",\"FileName\":\"01.jpg\"}]]";

 
          
            string paramUrl = url + "/api/FileApiPnxTransfer/GetThumbImagesTransfer?plate_task_no=A0001291320210308&imageSize=8&ImageInfo=1&IsPlate=1";
            var result = help.HttpGet(paramUrl, "").TrimEnd('"').TrimStart('"');
            string result1=result.ToString().TrimEnd('"').TrimStart('"');
            string result2 = result.Replace("\\", "");
            string result3 = "[[]]";
            JArray jary = JArray.Parse(result3);
            int count = jary.Count;
            foreach (var jar in jary)
            {
                JArray jbr = JArray.Parse(jar.ToString());
                foreach (var jaa in jbr)
                {
                    JObject jobj = JObject.Parse(jaa.ToString());
                    string DefaultThumbURL = jobj["DefaultThumbURL"].ToString();
                    string FileName = jobj["FileName"].ToString();
                }
            }
        }

        public static int GetImageType(string procedure)
        {
            int imagetype = 1;
            switch (procedure)
            {
                case "10":
                    imagetype = 1;
                    break;
                case "30":
                    imagetype = 2;
                    break;
                case "40":                  
                case "50":
                case "60":
                case "70":                 
                case "80":                   
                case "90":
                    imagetype = 3;
                    break;
                default:
                    imagetype = 1;
                    break;
            }
            return imagetype;
        }
    }


}
