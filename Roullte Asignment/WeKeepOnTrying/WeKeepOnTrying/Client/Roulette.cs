using WeKeepOnTrying.Interface;

namespace WeKeepOnTrying.Client
{
    public class Roulette : IRoulette
    {
        public bool result;
       
        public override bool Calculate1st12Odds(int number)
        {
            if (number <= 12)
            {
                result=true;
                return result;
            }
            else
            {
                result=false;
                return result;
            }

        }

        public override bool Calculate2nd12Odds(int number)
        {
            if (number >= 12 && number<=24)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        public override bool Calculate3rd12Odds(int number)
        {
            if (number >= 24 && number==36)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        public override void Placebet(double amount,int num,int bmoney,string color = "")
        {
            double betamount = amount;
            int bets;
            int bets_made;
            int[] bet_num = new  int [num];
            int[] bet_money= new int [bmoney];
            while (betamount!=0)
            {
            }


        }
    }
}
