using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SifrovaciAplikace
{
    class Caesar
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public Caesar(StreamReader streamReader, StreamWriter streamWriter)
        {
            this.streamReader = streamReader;
            this.streamWriter = streamWriter;
        }

        public void Zasifruj(long klic)
        {
            char znak;
            klic %= 26;
            while(!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if (znak >= 'a' && znak <= 'z')
                {
                    int poziceZnaku = (int)((znak + klic - 'a') % 26);
                    if (poziceZnaku < 0)
                    {
                        poziceZnaku += 26;
                    }
                    znak = (char)(poziceZnaku + 'a');
                }
                else if (znak >= 'A' && znak <= 'Z')
                {
                    int poziceZnaku = (int)((znak + klic - 'A') % 26);
                    if (poziceZnaku < 0)
                    {
                        poziceZnaku += 26;
                    }
                    znak = (char)(poziceZnaku + 'A');
                }
                streamWriter.Write(znak);
            }
        }
        public void Zasifruj(StreamReader klicStreamReader)
        {
            long klic = long.Parse(klicStreamReader.ReadToEnd());
            Zasifruj(klic);
        }

        public void Desifruj(long klic)
        {
            char znak;
            klic %= 26;
            while (!streamReader.EndOfStream)
            {
                znak = (char)streamReader.Read();

                if (znak >= 'a' && znak <= 'z')
                {
                    int poziceZnaku = (int)((znak - klic - 'a') % 26);
                    if (poziceZnaku < 0)
                    {
                        poziceZnaku += 26;
                    }
                    znak = (char)(poziceZnaku + 'a');
                }
                else if (znak >= 'A' && znak <= 'Z')
                {
                    int poziceZnaku = (int)((znak - klic - 'A') % 26);
                    if (poziceZnaku < 0)
                    {
                        poziceZnaku += 26;
                    }
                    znak = (char)(poziceZnaku + 'A');
                }
                streamWriter.Write(znak);
            }
        }
        public void Desifruj(StreamReader klicStreamReader)
        {
            long klic = long.Parse(klicStreamReader.ReadToEnd());
            Desifruj(klic);
        }
    }
}
