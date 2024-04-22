namespace QLSV_code_first.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<SinhVien> SinhViens { get; set; }

    }
}
