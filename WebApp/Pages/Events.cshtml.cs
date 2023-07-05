using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class EventsModel : PageModel
    {
        
			EventsService eventservice;
		public List<Events> events { get; set; }
		public void OnGet()
		{
			eventservice = new EventsService();
			events = eventservice.GetAllEventDetails();
		}
	}
    
}
