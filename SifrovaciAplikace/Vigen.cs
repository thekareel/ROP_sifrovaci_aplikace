using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SifrovaciAplikace
{
    class Vigen
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public Vigen(StreamReader streamReader, StreamWriter streamWriter)
        {
            this.streamReader = streamReader;
            this.streamWriter = streamWriter;
        }

        public void Zasifruj(string klic)
        {
            char znak;
            int i = 0;
            while(!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if ((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z'))
                {
                    if (i > klic.Length - 1)
                    {
                        i = 0;
                    }

                    char znakKlice = char.ToLower(klic[i]);
                    ++i;
                    int hodnotaPosunu = znakKlice - 'a';

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
        public void Zasifruj(StreamReader klicStreamReader)
        {
            string klic = klicStreamReader.ReadToEnd();
            Zasifruj(klic);
        }

        public void Desifruj(string klic)
        {
            char znak;
            int i = 0;
            while (!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if ((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z'))
                {
                    if (i > klic.Length - 1)
                    {
                        i = 0;
                    }

                    char znakKlice = char.ToLower(klic[i]);
                    ++i;
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
        public void Desifruj(StreamReader klicStreamReader)
        {
            string klic = klicStreamReader.ReadToEnd();
            Desifruj(klic);
        }
    }
}
