namespace Calculator
{
    class Context
    {
        private IAlgorithm _algorithm;

        public Context(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public double ExecuteAlgorithm(string insturction)
        {
            return _algorithm.Algorithm(insturction);
        }
    }
}
