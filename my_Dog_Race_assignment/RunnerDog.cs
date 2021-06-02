using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Dog_Race_assignment
{
    public class RunnerDog
    {
        Random obj = new Random();
        public int move_Dog() {
            return obj.Next(1, 50);
        }

        //this code is used to anoune the result like win or lose the game 
        public int resultSetup(String Rcord, int win, int blance) {
            String[] filter = Rcord.Split(' ');
            if (Convert.ToInt32(filter[2].ToString()) == win)
            {
                return blance + Convert.ToInt32(filter[6].ToString());
            }
            else {

                return blance - Convert.ToInt32(filter[6].ToString());
            }

        }


    }
}
