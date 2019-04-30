using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.Models
{
	class SquarePantsMeme : ImageMeme
	{
        public SquarePantsMeme(int Rate)
        {
            this.Rate = Rate;
        }
		public override string Name => typeof(SquarePantsMeme).ToString();

        public override string Author { get; } = "InterWebz";

        public override string GetData(bool flag) => $"SquarePantsMeme - Rate: {Rate} {(flag ? $" - (c) {Author}": "")}";

        public override string ToString()
        {
            return GetData(false);
        }
    }
}
