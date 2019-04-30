using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.Interfaces
{
	interface IMeme
	{
		string Name { get; }
		int Rate { get; set; }
        string Author { get; }
		string GetData(bool flag);
	}
}
