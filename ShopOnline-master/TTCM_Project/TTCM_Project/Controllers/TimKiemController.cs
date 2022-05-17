using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopOnlineConnection;
using TTCM_Project.Models;
using PagedList.Mvc;
using PagedList;
using TTCM_Project.Models.BUS;

namespace TTCM_Project.Controllers
{

    public class TimKiemController : Controller
    {
        // GET: TimKiem
        public ActionResult KetQuaTimKiem(string timkiem , string MaNhaSanXuat, string MaLoaiSanPham, string GiaBatDau, string GiaKetThuc, int page = 1, int pagesize = 3)
        {
            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat");
            ViewBag.MaLoaiSanPham = new SelectList(LoaiSanPhamBUS.DanhSach(), "MaLoaiSanPham", "TenLoaiSanPham");
            var db = TimKiemBUS.TimKiem(timkiem,MaNhaSanXuat, MaLoaiSanPham,GiaBatDau,GiaKetThuc).ToPagedList(page, pagesize);
            return View(db);
        }

    }
}