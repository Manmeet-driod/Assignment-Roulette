using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    // creating the class to call in in main page
    class russian
    {
        public int loadchamber;
        public int bulletemiss = 2;
        public int shoot = 6;
        public int bulleteload = 1;


        public int chamberspin(int s)
        {
            if (s == 6)
            {
                s = 1;

            }
            else
            {
                s++;
            }

            return s;
        }
       public int Shoot()
        {
            // for shoot button 
            int score = 0;
            if (shoot > 0 && bulleteload == loadchamber)
            {
                score = 1;
            }
            else if (shoot > 0 && loadchamber != bulleteload)
            {
                score = 2;
                shoot = shoot - 1;
                loadchamber = chamberspin(loadchamber);
            }
            return score;
        }
    }
}

