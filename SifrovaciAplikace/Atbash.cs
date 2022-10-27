using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SifrovaciAplikace
{
    class Atbash
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public Atbash(StreamReader streamReader, StreamWriter streamWriter)
        {
            this.streamReader = streamReader;
            this.streamWriter = streamWriter;
        }

        public void Zasifruj()
        {
            char znak;
            while (!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if (znak >= 'a' && znak <= 'z')
                {
                    znak = (char)('z' - ((znak - 'a') % 26));
                }
                else if (znak >= 'A' && znak <= 'Z')
                {
                    znak = (char)('Z' - ((znak - 'A') % 26));
                }
                streamWriter.Write(znak);
            }
        }

        public void Desifruj()
        {
            Zasifruj();
        }
    }
}
