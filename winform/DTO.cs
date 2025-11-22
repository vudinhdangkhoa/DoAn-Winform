using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform
{
    // Class cha: Chứa thông tin Phụ huynh và List học viên
    public class AddHocVienRequest
    {
        public string tenPH { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string gioiTinh { get; set; }
        // 1. Biến này dùng để binding với DateTimePicker (dùng nội bộ Winform)
        [JsonIgnore] // Không gửi biến này lên server
        public DateTime? NgaySinhPH_Raw { get; set; }

        // 2. Biến này mới là cái gửi lên Server (tự động convert sang chuỗi yyyy-MM-dd)
        [JsonProperty("ngaySinhPH")]
        public string NgaySinhPH_String
        {
            get
            {
                // Nếu null thì trả về null, nếu có dữ liệu thì format yyyy-MM-dd
                return NgaySinhPH_Raw?.ToString("yyyy-MM-dd");
            }
        }
        public List<HocVienDTO> dsHocVien { get; set; } = new List<HocVienDTO>();
    }

    // Class con: Thông tin từng học viên
    public class HocVienDTO
    {
        public string tenHv { get; set; }
        [JsonIgnore]
        public DateTime? NgaySinh_Raw { get; set; }

        [JsonProperty("ngaySinh")]
        public string NgaySinh_String
        {
            get { return NgaySinh_Raw?.ToString("yyyy-MM-dd"); }
        }
        public string gioiTinh { get; set; }
        public List<int> dsLopId { get; set; } = new List<int>();
    }

    // Class phụ: Dùng để hiển thị tên lớp trong ComboBox/List
    public class LopHocSimpleDTO
    {
        public int IdLopHoc { get; set; }
        public string TenLop { get; set; }
        public decimal HocPhi { get; set; }
        public decimal GiamGia { get; set; }

        // Tính tiền thực tế = Học phí - Giảm giá (Không âm)
        public decimal ThanhTien => (HocPhi - GiamGia) > 0 ? (HocPhi - GiamGia) : 0;

        // Property hỗ trợ hiển thị trên ComboBox: "Tên lớp - 1.600.000đ"
        public string DisplayText
        {
            get
            {
                return $"{TenLop} ({ThanhTien.ToString("#,##0")} đ)";
            }
        }
    }

    public class ViewHocCuDTO
    {
        public int idLoaiHocCu { get; set; }
        public string tenLoai { get; set; }
        public int idHocCu { get; set; }
        public string tenHocCu { get; set; }
        public double giaBan { get; set; }
        public int soLuong { get; set; }
        public double giamGia { get; set; } // Giá trị giảm giá tính toán từ server
    }

    public class ViewLoaiHocCuDTO
    {
        public int idLoaiHocCu { get; set; }
        public string tenLoai { get; set; }
    }
}
