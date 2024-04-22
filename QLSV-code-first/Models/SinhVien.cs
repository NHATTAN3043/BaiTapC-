using Microsoft.OpenApi.Models;

namespace QLSV_code_first.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public int IdClass { get; set; }
        public int IdK { get; set; }
        public Lop Lop { get; set; }
        public Khoa Khoa { get; set; }
    }
}
