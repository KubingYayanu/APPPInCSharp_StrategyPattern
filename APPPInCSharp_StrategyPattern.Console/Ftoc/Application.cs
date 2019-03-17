namespace APPPInCSharp_StrategyPattern.Console.Ftoc
{
    public interface Application
    {
        void Init();

        void Idle();

        void Cleanup();

        bool Done();
    }
}