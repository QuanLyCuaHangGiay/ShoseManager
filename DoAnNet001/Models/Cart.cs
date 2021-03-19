using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNet001.Models
{
    class Cart
    {
        private  string TenSP;
        private string MauSac;
        private string ChatLieu;
        private int kichco;
        private double giatien;
        private int soluong;
        private double TongTien;
     
        public Cart() { }

        public Cart(string tenSP, string mauSac, string chatLieu, int kichco, double giatien, int soluong, double tongtien)
        {
            TenSP = tenSP;
            MauSac = mauSac;
            ChatLieu = chatLieu;
            this.kichco = kichco;
            this.giatien = giatien;
            this.soluong = soluong;
            this.TongTien = tongtien;
           
        }

        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public string MauSac1 { get => MauSac; set => MauSac = value; }
        public string ChatLieu1 { get => ChatLieu; set => ChatLieu = value; }
        public int Kichco { get => kichco; set => kichco = value; }
        public double Giatien { get => giatien; set => giatien = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
