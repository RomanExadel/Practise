namespace Practise.Structures
{
    interface IProcess
    {
        void Run();

        string Name { get; set; }

        int RunningTime { get; set; }
    }
}