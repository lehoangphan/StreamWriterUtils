using System;

namespace StreamWriterUtils
{
    public class TextWriter
    {
        public bool Write(string path, string content)
        {
            try
            {
                using (System.IO.StreamWriter file =
                                                   new System.IO.StreamWriter
                                                   (path, false, System.Text.Encoding.UTF8))
                {
                    file.WriteLine(content);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
