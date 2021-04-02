using System.Collections;

namespace CalculatorLibrary
{
    public class AlgorithmTypes : IEnumerable
    {
        public const string ReversePolishNotationAlgorithm = "ReversePolishNotationAlgorithm";
        public const string SimpleAlgorithm = "SimpleAlgorithm";

        public IEnumerator GetEnumerator()
        {
            yield return ReversePolishNotationAlgorithm;
            yield return SimpleAlgorithm;
        }
    }
}
