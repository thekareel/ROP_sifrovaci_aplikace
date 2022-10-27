using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SifrovaciAplikace
{
    class ROT13
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public ROT13(StreamReader streamReader, StreamWriter streamWriter)
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
                    znak = (char)((znak + 13 - 'a') % 26 + 'a');
                }
                else if (znak >= 'A' && znak <= 'Z')
                {
                    znak = (char)((znak + 13 - 'A') % 26 + 'A');
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
