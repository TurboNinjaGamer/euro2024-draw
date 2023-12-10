using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatZreb
{
    public class PositionsPot
    {
        List<int> positions;

        public PositionsPot(int count)
        {
            this.positions = new List<int>();
            for(int i = 0; i < count; i++)
            {
                positions.Add(i);
            }
        }

        public int GetPosition()
        {
            Shuffle(positions);
            int position = GetAndRemove(positions, positions.Count - 1);
            return position;
        }
        public int GetFirstPosition()
        {
            int position = GetAndRemove(positions, 0);
            return position;
        }
        private int GetAndRemove(List<int> list, int index)
        {
            int result = list[index];
            list.Remove(result);
            return result;
        }
        private void Shuffle(List<int> list)
        {
            Random r = new Random();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int index = r.Next(0, list.Count);
                int temp = list[index];
                list[index] = list[i];
                list[i] = temp;
            }
        }
    }
}
