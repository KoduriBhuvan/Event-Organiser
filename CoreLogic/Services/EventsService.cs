using CoreLogic.Models;
using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
	public class EventsService
	{
		
		public List<Events> GetAllEventDetails()
		{
			MyContext ctx = new MyContext();

			var events = ctx.Events.ToList();
			return events;
		}
		
	}
}
