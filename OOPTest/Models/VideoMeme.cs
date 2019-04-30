using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTest.Interfaces;

namespace OOPTest.Models
{
    class VideoMeme : IMeme
    {
        public string Name => typeof(VideoMeme).ToString();
        public int Rate { get; set; }
        public string Length { get; set; } = "1:00";
        public string Author { get; set; } = "InterWebz";
        public string GetData(bool flag) => 
            $"VideoMeme - Length: {Length} - Rate: {Rate} {(flag ? $" - (c) {Author}" : "")}";
        public override string ToString()
        {
            return GetData(false);
        }
    }
}
