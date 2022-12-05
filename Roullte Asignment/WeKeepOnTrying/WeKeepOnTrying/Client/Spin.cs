using WeKeepOnTrying.Interface;
using WeKeepOnTrying.Models;
using static WeKeepOnTrying.Models.SpinModel;

namespace WeKeepOnTrying.Client
{
    public class Spin : ISpin
    {
        private SpinModel mySpin;
        private Spining Spining;
        public Spin()
        {
             mySpin = new SpinModel();
        }
        public override Spining GetValue(int value)
        {
            if (value == 0)
            {
                Spining.color = "Green";
                Spining.val = value;
                Spining.numType = "Even";

            }else if (value == 32||value==19||value==21|| value==25|| value==34|| value==27|| value==36||
                value==30||value==23||value==5||value==16||value==1||value==14||value==9||value==18||value==7
                ||value==12||value==3)
            {
                Spining.numType = CheckNumber(value);
                Spining.color = "Red";
                Spining.val = value;
                Spining.isEven = mySpin.getisEven;

            }
            else if(value==4||value==15||value==2||value==17||value==6||value==13||value==11||
                value==8||value==10||value==24||value==33||value==20||value==31||value==22||value==29||
                value == 28 || value == 35 || value == 26)
            {
                Spining.numType = CheckNumber(value);
                Spining.color = "Black";
                Spining.val= value;
                Spining.isEven = mySpin.getisEven;
            }
            return Spining;
        }

        public  string CheckNumber(int value)
        {
            string numtype = "";
            if (value % 2 == 0)
            {
                mySpin.getisEven = true;
                 numtype = "Even";
            }
            else
            {
                mySpin.getisEven = false;
                numtype = "Odd";
            }
            return numtype;
        }

        public void SaveSpin(SpinModel addSpin)
        {
            
        }

    }
}
