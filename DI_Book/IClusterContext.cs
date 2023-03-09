using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Book
{
	public interface IClusterContext
	{
		public string OutboundDataApiUrl { get; set; }
	}
}
