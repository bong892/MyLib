using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabyCarrot.Tools
{
    public class LogManager
    {
        private string _path;

        #region Constructors
        public LogManager(string path)
        {
            _path = path;
            _SetLogPath();
        }

        public LogManager()
            : this(Path.Combine(ApplicationB.Root, "Log"))
        {            
        }
        #endregion

        #region Methods
        private void _SetLogPath()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _path = Path.Combine(_path, logFile);
        }

        public void Write(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.Write(data);
                }
            }
            catch (Exception ex)
            { }
        }

        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss\t") + data);
                }
            }
            catch (Exception ex)
            { }
        }
        #endregion

    }
}
