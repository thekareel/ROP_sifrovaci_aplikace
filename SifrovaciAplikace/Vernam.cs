using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SifrovaciAplikace
{
    class Vernam
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public Vernam(StreamReader streamReader, StreamWriter streamWriter)
        {
            this.streamReader = streamReader;
            this.streamWriter = streamWriter;
        }

        public void Zasifruj(StreamWriter klicStreamWriter)
        {
            char znak;
            Random random = new Random();
            while (!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if ((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z'))
                {
                    int hodnotaPosunu = random.Next(26);
                    char znakPosunu = (char)('a' + hodnotaPosunu);
                    klicStreamWriter.Write(znakPosunu);

                    if (znak >= 'a' && znak <= 'z')
                    {
                        znak = (char)((znak + hodnotaPosunu - 'a') % 26 + 'a');
                    }
                    else
                    {
                        znak = (char)((znak + hodnotaPosunu - 'A') % 26 + 'A');
                    }
                }
                streamWriter.Write(znak);
            }
        }

        public void Desifruj(StreamReader klicStreamReader)
        {
            char znak;
            while (!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if ((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z'))
                {
                    char znakKlice = (char)klicStreamReader.Read();
                    znakKlice = char.ToLower(znakKlice);
                    int hodnotaPosunu = znakKlice - 'a';

                    if (znak >= 'a' && znak <= 'z')
                    {
                        int poziceZnaku = (znak - hodnotaPosunu - 'a') % 26;
                        if (poziceZnaku < 0)
                        {
                            poziceZnaku += 26;
                        }
                        znak = (char)(poziceZnaku + 'a');
                    }
                    else
                    {
                        int poziceZnaku = (znak - hodnotaPosunu - 'A') % 26;
                        if (poziceZnaku < 0)
                        {
                            poziceZnaku += 26;
                        }
                        znak = (char)(poziceZnaku + 'A');
                    }
                }
                streamWriter.Write(znak);
            }
        }
    }
}
