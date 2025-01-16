using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal interface ISeries
	{
		public int Current { get; set; }

		public void GetNext();

		public void Reset()
		{
			Current = 0;
		}
	}

	public class SeriesByTwo : ISeries
	{
		public int Current { get; set; }

		public void GetNext()
		{
			Current += 2;
		}


	}

	public class SeriesByThree : ISeries
	{
		public int Current { get; set; }

		public void GetNext()
		{
			Current += 3;
		}


	}

	public class SeriesByFour : ISeries
	{
		public int Current { get; set; }

		public void GetNext()
		{
			Current += 4;
		}


	}
}
