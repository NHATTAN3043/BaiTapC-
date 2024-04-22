namespace QLSV_code_first.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        public string KName { get; set; }

        public List<SinhVien> SinhViens { get; set; }
    }
}
