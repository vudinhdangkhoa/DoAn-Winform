using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    internal class DungChung
    {
        public static string BaseUrlImage = "http://localhost:5225";
        public static string BaseUrl = "http://localhost:5225/api/";
        //public static string BaseUrl = "https://2gcqx76s-5225.asse.devtunnels.ms/api/";
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

    public class Helper
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // Pattern regex cho email chuẩn
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;

            // Pattern: Bắt đầu bằng số 0, theo sau là 9 chữ số bất kỳ
            string pattern = @"^0\d{9}$";
            return Regex.IsMatch(phone, pattern);
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

        public static async Task<dynamic> AddHocVien(AddHocVienRequest data)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(DungChung.getUrl("QLHocVien/AddHocVien"), content); // Endpoint
                   
                    if (response.IsSuccessStatusCode)
                    {
                        var message = await response.Content.ReadAsStringAsync();
                       
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(message);
                    }
                    Console.WriteLine("Status code AddHocVien: " + response.StatusCode);

                    // Hoặc xem nội dung lỗi chi tiết từ Server trả về:
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Nội dung lỗi: " + errorContent);
                    MessageBox.Show($"Lỗi: {response.StatusCode}\nChi tiết: {errorContent}");
                    return null;
                }

            }
            catch (HttpRequestException e)
            {
                // Xử lý lỗi không kết nối được tới server
                MessageBox.Show($"Không thể kết nối tới máy chủ: {e.Message}");
                {
                    return null;
                }
            }
        }
    }

    public class UCQuanLyKhuyenMai
    {

        public static async Task<dynamic> GetChuongTrinhKhuyenMai()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(DungChung.getUrl("QLKhuyenMai/GetAllKhuyenMai"));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                    Console.WriteLine(data);
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

        public static async Task<dynamic> GetKhoaHocVaHoaCu()
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync(DungChung.getUrl("QLKhuyenMai/GetKhoaHocVaHoaCu"));
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
                        Console.WriteLine(data);
                    }
                    MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

                }

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
