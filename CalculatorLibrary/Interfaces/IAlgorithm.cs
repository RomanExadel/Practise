namespace Calculator
{
    public interface IAlgorithm
    {
        double Algorithm(string instruction);

        void CheckValidInstruction(string instruction);
    }
}
