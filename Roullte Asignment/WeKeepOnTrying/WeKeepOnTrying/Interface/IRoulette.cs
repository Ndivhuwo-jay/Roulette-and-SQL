using LanguageExt.TypeClasses;

namespace WeKeepOnTrying.Interface
{
    public abstract class IRoulette
    {
        public abstract void Placebet(double money,int Num, int bmoney, string color="");
        public abstract bool Calculate1st12Odds(int number);
        public abstract bool Calculate2nd12Odds(int number);
        public abstract bool Calculate3rd12Odds(int number);

    }
}
