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
        public DateTime? ngaySinhPH { get; set; }
        public List<HocVienDTO> DSHocVien { get; set; } = new List<HocVienDTO>();
    }

    // Class con: Thông tin từng học viên
    public class HocVienDTO
    {
        public string tenHv { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public List<int> dsLopId { get; set; } = new List<int>();
    }

    // Class phụ: Dùng để hiển thị tên lớp trong ComboBox/List
    public class LopHocSimpleDTO
    {
        public int IdLopHoc { get; set; }
        public string TenLop { get; set; }
    }
}
