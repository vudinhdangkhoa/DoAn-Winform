using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace winform
{
    internal class DungChung
    {
        //public static string BaseUrl = "http://localhost:5225/api/";
        public static string BaseUrl = "https://2gcqx76s-5225.asse.devtunnels.ms/api/";
        public static string getUrl(string url)=> BaseUrl + url;

        public static async Task<dynamic> GetDataTongQuan(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(getUrl(url));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (HttpRequestException e)
            {
                // Xử lý lỗi không kết nối được tới server
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }
        }

        public static async Task<dynamic> GetInfoStaff(int userId)
        {

            try
            {
                HttpClient clinet = new HttpClient();
                HttpResponseMessage response = await clinet.GetAsync(getUrl("DashBoard/GetInfoStaff/" + userId));
                Console.WriteLine("status code getInforStaff:", response.StatusCode);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }

                return null;
            }
            catch (HttpRequestException e)
            {
                // Xử lý lỗi không kết nối được tới server
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }

        }

        public static async Task<dynamic> GetSoLuongHocVienMoiTrong6Thang()
        {

            try
            {

                HttpClient client= new HttpClient();
                HttpResponseMessage response= await client.GetAsync(getUrl("DashBoard/GetSoLuongHocVienMoiTrong6Thang"));

                Console.WriteLine("status code GetSoLuongHocVienMoiTrong6Thang:", response.StatusCode);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }
                return null;

            }
            catch(HttpRequestException e)
            {
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }

        }

        public static async Task<dynamic> GetLopHocItem()
        {

            try
            {

                HttpClient client= new HttpClient();
                HttpResponseMessage response = await client.GetAsync(getUrl("DashBoard/GetLopHocItem"));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }
                return null;


            }
            catch(HttpRequestException e)
            {

                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }

        }
    }

    public class UCQuanLyHocVien
    {
        
        public static async Task<dynamic> GetKhoaHoc()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(DungChung.getUrl("KhoaHoc/GetAllKhoaHoc"));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (HttpRequestException e)
            {
                // Xử lý lỗi không kết nối được tới server
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }
        }

        public static async Task<dynamic> GetHocVien()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(DungChung.getUrl("QLHocVien/GetAllHocVien"));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                }
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (HttpRequestException e)
            {
                // Xử lý lỗi không kết nối được tới server
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                return null;
            }
        }
    }
}
