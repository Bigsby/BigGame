using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGame.Objects
{
    public class Score
    {
        public long Value { get; set; }
        public DateTime Time { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
        public byte[] Data { get; set; }
    }
}
