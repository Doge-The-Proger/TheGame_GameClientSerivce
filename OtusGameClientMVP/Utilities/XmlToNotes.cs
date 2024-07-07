using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OtusGameClientMVP.GameLogic;

namespace OtusGameClientMVP.Utilities
{
    public static class XmlToNotes
    {
        public const string NoteElementName = "Note";
        public const string DirectionElementName = "Direction";
        public const string TimeElementName = "Time";
        public const string DurationElementName = "Duration";

        public static List<Note> GetNotes(XDocument file)
        {
            List<Note> notes = new();
            var noteElements = file.Elements(NoteElementName);

            foreach (var noteElement in noteElements)
            {
                int direction = Int32.Parse(noteElement.Element(DirectionElementName)?.Value ?? "0");
                float time = float.Parse(noteElement.Element(TimeElementName)?.Value ?? "-1");
                float duration = float.Parse(noteElement.Element(DurationElementName)?.Value ?? "-1");
                
                //wrong element
                if (time == -1.0f)
                {
                    continue;
                }

                Note note = new() { Direction = (Direction)direction, SecondsFromStart = time, DurationInSeconds = duration };

                notes.Add(note);
            }

            return notes;
        }
    }
}
