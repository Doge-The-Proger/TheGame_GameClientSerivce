using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OtusGameClientMVP.GameLogic;

namespace OtusGameClientMVP.Utilities
{
    public class MusicStoreManager
    {

        public const string LocalDirectoryName = "Music";
        public const string XMLExtension = "xml";
        public const string MP3Extension = "mp3";
        public const int TestMusicId = 1;

        public Music GetMusic(int id)
        {
            string filename = GetFileName(id);
            var xml = GetMusicXML(id);
            var notes = XmlToNotes.GetNotes(xml);
            return new Music() { filenameMp3 = $"{filename}.{MP3Extension}", Id = id, Name = filename, Notes = notes };
        }

        private XDocument GetMusicXML(int id)
        {
            string filename = GetFileName(id);
            string filenameXml = $"{filename}.{XMLExtension}";

            if (!CheckLocalFileExist(filenameXml))
            {
                LoadMusicFile(id, LocalDirectoryName, filename);
            }

            string filePath = Path.Combine(LocalDirectoryName, filenameXml);
            XDocument xml = XDocument.Load(filePath);
            return xml;
        }


        private bool CheckLocalFileExist(string filename)
        {
            CheckOrCreateLocalDirectory();
            if (!File.Exists(Path.Combine(LocalDirectoryName, filename)))
            {
                return false;
            }
            return true;
        }

        private void CheckOrCreateLocalDirectory()
        {
            if (!Directory.Exists(LocalDirectoryName))
            {
                Directory.CreateDirectory(LocalDirectoryName);
            }
        }

        //TODO: load xml file from database to local storage
        private void LoadMusicFile(int id, string directory, string filename)
        {
            //Load xml file to {directory}\{filename}.{XMLExtension}
            //Load mp3 file to {directory}\{filename}.{MP3Extension}
        }

        //TODO: get file name from database
        private string GetFileName(int id)
        {
            return $"{id}";
        }
    }
}
