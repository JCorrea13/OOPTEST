using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTest.Interfaces;

namespace OOPTest.Models
{
	abstract class ImageMeme : IMeme
	{
		public abstract string Name { get; }
		public int Rate { get; set; }
        public abstract string Author { get; }
        public abstract string GetData(bool flag);
        
	}
}
