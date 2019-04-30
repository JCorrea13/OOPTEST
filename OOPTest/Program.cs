using System;
using System.Collections.Generic;
using System.Linq;
using OOPTest.Interfaces;
using OOPTest.Models;
using OOPTest.Utils;
    
namespace OOPTest
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Expected output:
				SquarePantsMeme - Rate: 5 - (c) InterWebz
				SquarePantsMeme - Rate: 5
				SquarePantsMeme - Rate: 5
				VideoMeme - Length: 1:00 - Rate: 4
				VideoMeme - Length: 1:00 - Rate: 4 - (c) InterWebz
				1:00
			*/

			var list = new List<IMeme>()
			{
				new SquarePantsMeme(5) as ImageMeme,
				new VideoMeme { Rate = 4},
			};

			Console.WriteLine(MemeFormatter.GetMemeData(list.First(), true));

			foreach (var item in list)
			{
				switch (item)
				{
					case ImageMeme image:
						Console.WriteLine(image);
						Console.WriteLine(image.GetData(true));
						break;
					case VideoMeme video:
						Console.WriteLine(video);
						Console.WriteLine(video.GetData(true));
						Console.WriteLine(video.Length);
						break;
					default:
						throw new InvalidOperationException();
				}
			}

			Console.ReadLine();
		}
	}
}
