using DuongThiHang_211211501.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuongThiHang_211211501.ViewComponents
{
	public class HangHoaViewComponent : ViewComponent
	{
		QLHangHoaContext _context;
		List<HangHoa> hanghoa;
		public HangHoaViewComponent(QLHangHoaContext context)
		{
			_context = context;
			hanghoa = _context.HangHoas.ToList();
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("RenderHangHoa", hanghoa);
		}
	}
}
