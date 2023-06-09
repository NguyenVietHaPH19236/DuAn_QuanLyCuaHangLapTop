﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using DAL.Model;
using BUS.IServices.IServiceSanPham;
using BUS.Services.ServiceSanPham;

namespace Presentation
{
    public partial class FormSanPhamBanPhim : Form
    {
        public delegate void GetBanPhim(string hangsx, int kieukn, string kieubp, string led, string layout, string kichthuoc, float trongluong, string mausac, string keycaps);
        public event GetBanPhim GetBanPhimEvent;
        private BanPhim banPhim;
        public FormSanPhamBanPhim()
        {
            InitializeComponent();
            
        }
        public FormSanPhamBanPhim(BanPhim ban)
        {
            InitializeComponent();
            banPhim = ban;
            
           
        }

        private void _view_MatchBanPhim(object? sender, EventArgs e)
        {
            
        }

        private void comboBox_ketnoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_textchanged(object sender, EventArgs e)
        {
            var check = float.TryParse(tb_trongluong.Text.Trim(), out _);
            if (!check && tb_trongluong.Text != "")
            {
                MessageBox.Show("Trọng lượng phải là số");
                return;
            }
            string hangsx = tb_hangsx.Text.Trim();
            int kieukn = 0;
            if (!string.IsNullOrEmpty(tb_ketnoi.Text.Trim()))
            {
                kieukn = int.Parse(tb_ketnoi.Text.Trim());
            }
            String kieubp = tb_kieubp.Text.Trim();
            String led = tb_led.Text.Trim();
            String layout = tb_layout.Text.Trim();
            string kichthuoc = tb_kichthuoc.Text.Trim();
            float trongluong = 0;
            if (!string.IsNullOrEmpty(tb_trongluong.Text.Trim()))
            {
                trongluong = float.Parse(tb_trongluong.Text.Trim());
            }
            string mausac = tb_mausac.Text.Trim();
            string keycaps = tb_keycaps.Text.Trim();

            if (GetBanPhimEvent != null)
                GetBanPhimEvent(hangsx, kieukn, kieubp, led, layout, kichthuoc, trongluong, mausac, keycaps);
        }

        private void FormSanPhamBanPhim_Load(object sender, EventArgs e)
        {
            if (banPhim != null)
            {
                tb_hangsx.Text=banPhim.HangSanXuat;
                tb_ketnoi.Text=banPhim.KieuKetNoi.ToString();
                tb_led.Text=banPhim.Led;
                tb_layout.Text=banPhim.Layout;
                tb_kieubp.Text=banPhim.KieuBanPhim;
                tb_trongluong.Text=banPhim.TrongLuong.ToString();
                tb_kichthuoc.Text=banPhim.KichThuoc;
            }
        }
    }
}
