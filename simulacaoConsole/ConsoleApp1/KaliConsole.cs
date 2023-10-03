public class KaliConsole
{
    private WhoamiCommand whoamiCommand = new WhoamiCommand();

    public void Start()
    {
        Console.WriteLine("Kali Linux console simulator");
        while (true)
        {
            Console.Write("# ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            switch (input.Trim().ToLower())
            {
                case "whoami":
                    whoamiCommand.Execute();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Command not found");
                    break;
            }
        }
    }
}
