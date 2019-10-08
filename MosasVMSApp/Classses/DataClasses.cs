using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MosasVMSApp.Classses
{
    class DataClasses
    {
    }
    [XmlRoot(ElementName = "Kemo")]
    public class Kemo
    {
        [XmlElement(ElementName = "Tarih")]
        public string Tarih { get; set; }
        [XmlElement(ElementName = "YayinNo")]
        public string YayinNo { get; set; }
        [XmlElement(ElementName = "PeryotBaslama")]
        public string PeryotBaslama { get; set; }
        [XmlElement(ElementName = "PeryotBitis")]
        public string PeryotBitis { get; set; }
        [XmlElement(ElementName = "GenelDurum")]
        public string GenelDurum { get; set; }
        [XmlElement(ElementName = "HavaSicakligi")]
        public string HavaSicakligi { get; set; }
        [XmlElement(ElementName = "RuzgarDurum")]
        public string RuzgarDurum { get; set; }
        [XmlElement(ElementName = "DenizDurum")]
        public string DenizDurum { get; set; }
        [XmlElement(ElementName = "IgneadaSinop")]
        public string IgneadaSinop { get; set; }
        [XmlElement(ElementName = "Marmara")]
        public string Marmara { get; set; }
        [XmlElement(ElementName = "Uyari1")]
        public string Uyari1 { get; set; }
        [XmlElement(ElementName = "Uyari2")]
        public string Uyari2 { get; set; }
        [XmlElement(ElementName = "Uyari3")]
        public string Uyari3 { get; set; }
        [XmlElement(ElementName = "Uyari4")]
        public string Uyari4 { get; set; }
        [XmlElement(ElementName = "Uyari5")]
        public string Uyari5 { get; set; }
        [XmlElement(ElementName = "Uyari6")]
        public string Uyari6 { get; set; }
        [XmlElement(ElementName = "Uyari7")]
        public string Uyari7 { get; set; }
        [XmlElement(ElementName = "Uyari8")]
        public string Uyari8 { get; set; }
        [XmlElement(ElementName = "SehirAdi0")]
        public string SehirAdi0 { get; set; }
        [XmlElement(ElementName = "SehirDurum0")]
        public string SehirDurum0 { get; set; }
        [XmlElement(ElementName = "SehirAdi1")]
        public string SehirAdi1 { get; set; }
        [XmlElement(ElementName = "SehirDurum1")]
        public string SehirDurum1 { get; set; }
        [XmlElement(ElementName = "SehirAdi2")]
        public string SehirAdi2 { get; set; }
        [XmlElement(ElementName = "SehirDurum2")]
        public string SehirDurum2 { get; set; }
        [XmlElement(ElementName = "SehirAdi3")]
        public string SehirAdi3 { get; set; }
        [XmlElement(ElementName = "SehirDurum3")]
        public string SehirDurum3 { get; set; }
        [XmlElement(ElementName = "SehirAdi4")]
        public string SehirAdi4 { get; set; }
        [XmlElement(ElementName = "SehirDurum4")]
        public string SehirDurum4 { get; set; }
        [XmlElement(ElementName = "SehirAdi5")]
        public string SehirAdi5 { get; set; }
        [XmlElement(ElementName = "SehirDurum5")]
        public string SehirDurum5 { get; set; }
        [XmlElement(ElementName = "SehirAdi6")]
        public string SehirAdi6 { get; set; }
        [XmlElement(ElementName = "SehirDurum6")]
        public string SehirDurum6 { get; set; }
        [XmlElement(ElementName = "HazirlayanEkip")]
        public string HazirlayanEkip { get; set; }
        [XmlElement(ElementName = "Resim")]
        public string Resim { get; set; }
        [XmlElement(ElementName = "ResimTur")]
        public string ResimTur { get; set; }
    }

    [XmlRoot(ElementName = "ilceler")]
    public class Ilceler
    {
        [XmlElement(ElementName = "Sehir")]
        public string Sehir { get; set; }
        [XmlElement(ElementName = "Peryot")]
        public string Peryot { get; set; }
        [XmlElement(ElementName = "Merkez")]
        public string Merkez { get; set; }
        [XmlElement(ElementName = "ilce")]
        public string Ilce { get; set; }
        [XmlElement(ElementName = "Durum")]
        public string Durum { get; set; }
        [XmlElement(ElementName = "Mak")]
        public string Mak { get; set; }
        [XmlElement(ElementName = "Min")]
        public string Min { get; set; }
        [XmlElement(ElementName = "SehirIkon")]
        public string SehirIkon { get; set; }
    }

    [XmlRoot(ElementName = "SOA")]
    public class SOA
    {
        [XmlElement(ElementName = "Kemo")]
        public Kemo Kemo { get; set; }
        [XmlElement(ElementName = "ilceler")]
        public List<Ilceler> Ilceler { get; set; }
    }

    public class MyToken
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public int Expires_in { get; set; }
    }
    public static class WebApiConnection
    {
        static string ServerIp { get; set; }
        public static void ReadSablon()
        {
            WebRequest request = WebRequest.Create("http://www.contoso.com/PostAccepter.aspx");
            // Set the Method property of the request to POST.  
            request.Method = "POST";

            // Create POST data and convert it to a byte array.  
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.  
            // The using block ensures the stream is automatically closed.
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }

            // Close the response.  
            response.Close();
        }
        public static string Token()
        {
            ServerIp = Globals.ServerIpAddress;
            try
            {


                var client = new RestClient("http://" + ServerIp + "/Token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "3f11916d-99a4-42dc-a094-b638b3d2179b");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("undefined", "username=bestprogramming%40hotmail.com&password=1&grant_type=password", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                MyToken val = JsonConvert.DeserializeObject<MyToken>(response.Content);
                return val.Access_token;
            }
            catch { }
            return null;
        }
        public static List< TravelTimeModel> ReadSureler( VmsModel vmsModel)
        {
            string access_token = Token();
            ServerIp = Globals.ServerIpAddress;
            Stopwatch sw = new Stopwatch();
            try
            {

                sw.Start();
                var client = new RestClient("http://" + ServerIp + "/Vms/TravelTime");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "e766fda2-765f-4d97-848d-606962087980");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Authorization", "Bearer " + access_token);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", JsonConvert.SerializeObject(vmsModel), ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                return JsonConvert.DeserializeObject<List< TravelTimeModel>>(response.Content);

                //if (ServerIp == null || ServerIp.Length == 0)
                //    ServerIp = "88.255.170.112:8082";
                //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + ServerIp + "/Vms/TravelTime");
                //httpWebRequest.ContentType = "application/json";
                //httpWebRequest.Method = "POST";
                //httpWebRequest.Timeout = 30000;
                //
                //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                //{
                //    string json = JsonConvert.SerializeObject(vmsModel);
                //
                //    streamWriter.Write(json);
                //}
                //
                //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                //{
                //    var result = streamReader.ReadToEnd();
                //    sw.Stop();
                //    TimeSpan ts = sw.Elapsed;
                //    Console.WriteLine(vmsModel.ToIds[0] + " SAĞLAM:" + ts.ToString("mm\\:ss\\.ff"));
                //    return JsonConvert.DeserializeObject<List< TravelTimeModel>>(result);
                //}

            }
            catch (WebException webex)
            {
                sw.Stop(); TimeSpan ts = sw.Elapsed;
                Console.WriteLine(vmsModel.ToIds[0] + " HATALI:" + ts.ToString("mm\\:ss\\.ff"));
                WebResponse errResp = webex.Response;
                if (errResp != null)
                    using (Stream respStream = errResp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(respStream);
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                    }


                return null;
            }
        }
        public static T Deserialize<T>(string input) where T : class
        {

            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(GetWebPage(new Uri(input))))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public static string Serialize<T>(T ObjectToSerialize)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
        public static string GetWebPage(Uri uri)
        {
            if ((uri == null))
            {
                throw new ArgumentNullException("uri");
            }

            using (var request = new WebClient())
            {
                //Download the data
                var requestData = request.DownloadData(uri);

                //Return the data by encoding it back to text!
                return Encoding.UTF8.GetString(requestData).Split('?')[2].Remove(0, 1);
            }
        }
    }

    public static class Text_operations
    {
        public static string[] reading_data = new string[100];
        public static Sablon Sablon { get; set; } = new Sablon();
        public static string[] Read_text(string fileName)
        {
            int charCount = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                {
                    while (sr.Peek() >= 0)
                    {
                        string readLine = sr.ReadLine();
                        reading_data[charCount] = readLine;
                        charCount++;
                    }

                }
            }
            catch
            {
            }
            return reading_data;
        }
        public static void Read_text_sablon(string fileName)
        {

            try
            {
                using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                {
                    Sablon.Assets.Clear();
                    int index = 0;
                    while (sr.Peek() >= 0)
                    {
                        string readLine = sr.ReadLine();
                        switch (index)
                        {
                            case 0:
                                Sablon.IsRead = Convert.ToInt32(readLine);
                                break;
                            case 1:
                                Sablon.Width = Convert.ToInt32(readLine);
                                break;
                            case 2:
                                Sablon.Height = Convert.ToInt32(readLine);
                                break;
                            default:
                                {
                                    int v = (index - 3) % 4;
                                    switch (v)
                                    {
                                        case 0:
                                            Asset a = new Asset() { Filename = readLine };
                                            Sablon.Assets.Add(a);
                                            break;
                                        case 1:
                                            Sablon.Assets[Sablon.Assets.Count - 1].Time = Convert.ToInt32(readLine);
                                            break;
                                        case 2:
                                            Sablon.Assets[Sablon.Assets.Count - 1].Startx = Convert.ToInt32(readLine);
                                            break;
                                        case 3:
                                            Sablon.Assets[Sablon.Assets.Count - 1].Starty = Convert.ToInt32(readLine);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                        }
                        index++;
                    }
                    Jsonreader.WriteJsonObject(Sablon, "Sablon.json");
                    using (StreamWriter objWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\set.ini"))
                    {
                        objWriter.WriteLine("1");
                        objWriter.WriteLine(Sablon.Assets[0].Filename);
                        objWriter.WriteLine(Sablon.Assets[0].Startx);
                        objWriter.WriteLine(Sablon.Assets[0].Starty);
                        objWriter.WriteLine(Sablon.Width);
                        objWriter.WriteLine(Sablon.Height);
                    }
                }
            }
            catch
            {
            }

        }
    }

    public static class Jsonreader
    {
        public static void WriteJsonObject(object deger, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(deger);

                //write string to file
                if (ReadAnother(AppDomain.CurrentDomain.BaseDirectory + @"" + path))
                    System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"" + path, json);
            }
            catch (Exception ex) {/* WriteJsonObject(deger, path);*/Console.WriteLine("Write Ex: " + path + " //" + ex.Message); }
        }
        public static SystemValues ReadSystemFile()
        {
            try
            {
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\System.json", AppDomain.CurrentDomain.BaseDirectory + @"\Assets\System_temp.json", true);
                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\System_temp.json"))
                {
                    string json = r.ReadToEnd();
                    SystemValues items = JsonConvert.DeserializeObject<SystemValues>(value: json);
                    return items;
                }
            }
            catch //(Exception ex)
            {
                return null;
            }
        }

        public static Gosterilenimge ReadAssetFile()
        {
            try
            {
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Set.json", AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Set_temp.json", true);

                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Set_temp.json"))
                {
                    string json = r.ReadToEnd();
                    Gosterilenimge items = JsonConvert.DeserializeObject<Gosterilenimge>(json);
                    return items;
                }

            }
            catch //(Exception ex)
            {
                return null;
            }
        }


        public static Sablon ReadTemplateFile(string path)
        {
            try
            {

                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Sablonlar\" + path))
                {
                    string json = r.ReadToEnd();
                    Sablon items = JsonConvert.DeserializeObject<Sablon>(json);
                    //try
                    //{
                    //    WriteJsonObject(items.Assets[0], "Set.json");
                    //}
                    //catch { }
                    return items;
                }
            }
            catch { return null; }
        }


        public static List<Plan> ReadPlanFile(string path)
        {
            try
            {
                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\Planlar\" + path))
                {
                    string json = r.ReadToEnd();
                    List<Plan> items = JsonConvert.DeserializeObject<List<Plan>>(json);
                    return items;
                }
            }
            catch { return null; }
        }

        public static KavsakSureleri ReadTimeFile()
        {
            try
            {
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\KavsakSureleri.json", AppDomain.CurrentDomain.BaseDirectory + @"\Assets\KavsakSureleri_temp.json", true);

                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\KavsakSureleri_temp.json"))
                {
                    string json = r.ReadToEnd();
                    KavsakSureleri items = JsonConvert.DeserializeObject<KavsakSureleri>(json);
                    return items;
                }
            }
            catch { return null; }
        }
        public static List<GunlukPlan> ReadHaftalikFile()
        {
            try
            {
                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\HaftalikPlan.json"))
                {
                    string json = r.ReadToEnd();
                    List<GunlukPlan> items = JsonConvert.DeserializeObject<List<GunlukPlan>>(json);
                    return items;
                }
            }
            catch { return null; }
        }
        public static List<Plan> ReadYillikFile()
        {
            try
            {
                using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Assets\YillikPlan.json"))
                {
                    string json = r.ReadToEnd();
                    List<Plan> items = JsonConvert.DeserializeObject<List<Plan>>(json);
                    return items;
                }
            }
            catch { return null; }
        }

        public static bool ReadAnother(string path)
        {
            try
            {
                var fileStream = new FileInfo(path);
                FileStream fs = fileStream.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                fs.Close();
                return true;
            }
            catch //(IOException ex)
            {
                return false;
            }
        }
    }

}
