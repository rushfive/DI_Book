using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Book
{
	public interface IRequestSystemContext
	{
		public string SystemId { get; set; } // eg "R1_QADPX"
		public string MongoConnectionString { get; set; }
	}
}
