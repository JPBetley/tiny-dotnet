using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JPBetley.Tiny_DotNet
{
    public class Tiny
    {
        private string key;

        public Tiny(string key)
        {
            this.key = key;
        }

        public string To(int id)
        {
            string key = this.key;
            id = Math.Abs(id);

            StringBuilder builder = new StringBuilder();
            int radix = key.Length;

            do
            {
                int keyIndex = id % radix;
                builder.Insert(0, key.ElementAt(keyIndex));
                id = (id - keyIndex) / radix;
            } while (id != 0);

            return builder.ToString();
        }

        public int From(string hex)
        {
            string key = this.key;
            int radix = key.Length;
            int length = hex.Length;
            int id = 0;

            for (int i = 0; i < length; i++)
            {
                id += key.IndexOf(hex.ElementAt(i)) * (int)Math.Pow(radix, (length - i - 1));
            }

            return id;
        }
    }
}
