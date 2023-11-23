using Microsoft.AspNetCore.Mvc;

namespace DuongThiHang_211211501.Models.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
		QLHangHoaContext _context;
		List<LoaiHang> loaiHang;
		public LoaiHangViewComponent(QLHangHoaContext context)
		{
			_context = context;
			loaiHang = _context.LoaiHangs.ToList();
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("RenderLoaiHang", loaiHang);
		}
	}
}
