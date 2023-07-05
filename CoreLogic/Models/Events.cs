using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Models
{
	public class Events
	{
		public int Id { get; set; }
		public string Event_Type { get; set; }
        public string  Venue { get; set; }
        public int Noof_Guests { get; set; }


        public int UserId { get; set; }
		public User user { get; set; }

	}
}
