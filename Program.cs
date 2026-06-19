namespace Homework_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New Site!");

            Website site = new Website();
            site.InputData();
            Console.WriteLine(site.ToString());
        }
    }

    class Website
    {
        string name;
        string path;
        string description;
        string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void InputData()
        {
            Console.WriteLine("--- Input data about site---");
            Console.Write("Input name of site: ");
            Name = Console.ReadLine();
            Console.Write("Input path to site (example, /home/user/site): ");
            Path = Console.ReadLine();

            Console.Write("Input description of site: ");
            Description = Console.ReadLine();

            Console.Write("Enter the website address (URL, example, https://example.com): ");
            Address = Console.ReadLine();

            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Name of site '{Name}':\n" +
                   $"Address: {Address}\n" +
                   $"Path: {Path}\n" +
                   $"Description: {Description}";
        }
    }
}
