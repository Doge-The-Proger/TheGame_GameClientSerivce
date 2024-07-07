using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusGameClientMVP.GameLogic
{
    public enum Direction
    {
        Left = 1,
        Right = 2,
        Up = 3,
        Down = 4,
    }
   public class Note
    {
        public Direction Direction;
        public float SecondsFromStart;
        //can be 0
        public float DurationInSeconds;
    }
}
