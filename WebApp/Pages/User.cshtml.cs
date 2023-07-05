using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
	public class UserModel : PageModel
	{
		UserService service;

		public int UserId { get; set; }



		public List<User> user { get; set; }

		public void OnGet()
		{
			service = new UserService();
			user = service.GetAll();
		}
	}
}
