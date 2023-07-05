using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Models
{
    public class User
    {
		public User() => Events = new HashSet<Events>();
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get;  set; }
		public string Email { get; set; }
		public ICollection<Events> Events { get; set; }
	}
}
