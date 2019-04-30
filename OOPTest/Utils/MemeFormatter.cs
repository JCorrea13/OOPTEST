using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTest.Interfaces;

namespace OOPTest.Utils
{
	static class MemeFormatter
	{
		public static string GetMemeData(IMeme meme, bool copyright)
		{
			return meme.GetData(copyright);
		}
	}
}
