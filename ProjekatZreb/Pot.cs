using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatZreb
{
    public class Pot
    {
        public List<Slip> slips;
        bool firstCall = true;
        public bool isFirstPot = false;
        
        public Pot(bool isFirstPot, List<Slip> slips)
        {
            this.isFirstPot = isFirstPot;
            this.slips = slips;
        }

        public Slip GetSlip()
        {
            if (isFirstPot)
            {
                if(firstCall == true)
                {
                    firstCall = false;
                    Slip team = GetAndRemove(slips, 0);
                    return team;
                }
                else
                {
                    Shuffle(slips);
                    Slip team = GetAndRemove(slips, slips.Count - 1);
                    return team;
                }
            }
            else {
                Shuffle(slips);
                Slip team = GetAndRemove(slips, slips.Count - 1);
                return team;
            }
            
        }
        private Slip GetAndRemove(List<Slip> list, int index)
        {
            Slip result = list[index];
            list.Remove(result);
            return result;
        }
        private void Shuffle(List<Slip> list)
        {
            Random r = new Random();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                int index = r.Next(0, list.Count);
                Slip temp = list[index];
                list[index] = list[i];
                list[i] = temp;
            }
        }
    }
}
