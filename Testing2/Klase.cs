using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;

namespace Testing2
{
	public class Delioc
	{
		private Parametri param;

		public Delioc (Parametri p )
		{
			param = p;
		}

		public decimal Deli()
			=> param.x / param.y; 
	}

	public class Parametri
	{
		public virtual decimal x { get; set; }
		public virtual decimal y { get; set; }

		public Parametri(decimal a, decimal b)
		{
			x = b;
			y = a;
		}
	}
}
