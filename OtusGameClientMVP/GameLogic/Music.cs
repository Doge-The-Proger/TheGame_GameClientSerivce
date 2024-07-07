using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusGameClientMVP.GameLogic
{
    public class Music
    {
        public int Id;
        public string Name;
        public List<Note> Notes = new();
        public string filenameMp3;
    }
}
