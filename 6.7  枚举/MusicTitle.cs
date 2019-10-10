using System;
using System.Collections.Generic;
using System.Text;

namespace _6._7__枚举
{
   public  class MusicTitles
    {
        string[] names = { "Tubuar Bells","Hergest Ridge","Ommadawn","Platinum"};
        public IEnumerator<string>GetEnumerator()
        {
            for(int i=0;i<4;i++)
            {
                yield return names[i];
            }
        }
        public IEnumerable<string>Reverse()
        {
            for(int i=3;i>=0;i--)
            {
                yield return names[i];
            }
        }
        public IEnumerable<string> Subset(int index,int length)
        {
            for (int i=index;i<index+length;i++)
            {
                yield return names[i];
            }
        }
    }
}
