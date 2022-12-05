using WeKeepOnTrying.Client;

namespace WeKeepOnTrying.Models
{
    public class Roulette
    {
        public bool placebet;
        public bool odd;
        public bool even;
        public bool isRed;
        public bool isBlack;
        public bool isFirst12;
        public bool isSecond12;
        public bool isThird12;
        public bool oneto18;
        public bool nineteento36;
        public double payout;
        public string Outer12Win;
        public string Outer12(int value)
        {
            Spin spin = new Spin();
            if (spin.GetValue(value).val > 0 && spin.GetValue(value).val <= 12)
            {
                isFirst12 = true;
                Outer12Win = "First 12";
                return Outer12Win;
            }
            else if (spin.GetValue(value).val > 12 && spin.GetValue(value).val <= 24)
            {
                isSecond12 = true;
            }
            else if (spin.GetValue(value).val > 24 && spin.GetValue(value).val <= 36)
            {
                isThird12 = true;
            }
            else
            {
                int n = 0; //to be edited
            }
            return Outer12Win;
        }
        public void play(int num)
        {

            if (num % 2 == 0)
            {
                even = true;
            }
            else
            {
                odd = true;
            }
        }

        public void BettingSpot(string spot)
        {

        }
    }
}
