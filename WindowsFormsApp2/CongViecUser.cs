using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class CongViecUser
    {
        private string maCV;
        private string userID;
        private string congViec;
        private string diaChi;
        private string chiTiet;
        private DateTime ngayLamViec;
        private List<Image> imgList = null;
        public string MaCV { get => maCV; set => maCV = value; }
        public string UserID { get => userID; set => userID = value; }
        public string CongViec { get => congViec; set => congViec = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string ChiTiet { get => chiTiet; set => chiTiet = value; }
        public List<Image> ImgList { get => imgList; set => imgList = value; }
        public DateTime NgayLamViec { get => ngayLamViec; set => ngayLamViec = value; }

        public CongViecUser(string maCV, string userID, string congViec, string diaChi, string chiTiet, DateTime ngayLamViec, List<Image> imgList)
        {
            MaCV = maCV;
            UserID = userID;
            CongViec = congViec;
            DiaChi = diaChi;
            ChiTiet = chiTiet;
            ImgList = imgList;
            NgayLamViec = ngayLamViec;
        }
        public CongViecUser() { }
    }
}
