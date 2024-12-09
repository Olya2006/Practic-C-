using Pz1.TaskSystem;

namespace Pz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskController controller = new TaskController();
            controller.Start();
        }

    }
}