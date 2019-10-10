using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace _6._7__枚举
{
   public class GameMoves
    {
        private IEnumerator cross;
        private IEnumerator circle;
        public GameMoves()
        {
            cross = Cross();
            circle = Circle();
        }
        private int move = 0;
        const int MaxMoves = 9;
        public IEnumerator Cross()
        {
            while(true)
            {
                Console.WriteLine("Cross,move{0}", move);
                if (++move >= MaxMoves)
                    yield break;
                yield return circle;
            }
        }
        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine("Circle,move{0}", move);
                if (++move >= MaxMoves)
                    yield break;
                yield return circle;
            }
        }
    }
}
