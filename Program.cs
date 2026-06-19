using System.Net;
using System.Xml.Linq;

namespace Homework_6_1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            /*Task 6_1 Website */
            /*
            Console.WriteLine("Hello, New Site!");

            Website site = new Website();
            site.InputData();
            Console.WriteLine(site.ToString());

            Website site1 = new Website();
            Console.Write("Input name of site: ");
            site1.Name = Console.ReadLine();
            Console.Write("Input path to site: ");
            site1.Path = Console.ReadLine();
            Console.Write("Input description of site: ");
            site1.Description = Console.ReadLine();
            Console.Write("Input website address: ");
            site1.Address = Console.ReadLine();

            Console.WriteLine(site1.ToString());
            */
            /*Task 6_2 */
            /*
            Console.WriteLine("--- Creat 1 magazine with parametrs constructor  ---");
            Magazine magazine1 = new Magazine("IT_Tech", 2018, "Magazine about IT-tech", "+380991112233", "info@ittech.com");
            magazine1.PrintData();

            Console.WriteLine("\n--- Creat 2 magazine (with error) ---");
            Magazine magazine2 = new Magazine("Error Magazine", 2035, "Desc", "123", "wrong_email_no_dog");
            magazine2.PrintData();

            Console.WriteLine("\n--- Creat 3 magazine via access to field of class ---");
            Magazine magazine3 = new Magazine();
            magazine3.InputData();
            Console.WriteLine("\n--- Result ---");
            magazine3.PrintData();

            Console.ReadKey();
            */

            /*Task 6_3 Shop*/

            Console.WriteLine("--- Create shop with uncorrect email ---");
            Shop wrongEmailShop = new Shop("First Shop", "Underfined city", "Desc about profile", "1234455", "uncorrect_email_com");
            Console.WriteLine(wrongEmailShop);

            Console.WriteLine("\n--- Create interactive Shop ---");
            Shop shop1 = new Shop();
            shop1.InputData();
            Console.WriteLine(shop1);

            Console.WriteLine("\n--- Create 3 magazine with correct data ---");
            Shop shop3 = new Shop("Great", "Kharkiv city", "IT shop", "+380751122335", "great_it@victory.ua");
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine(shop3);

            Shop shop4 = new Shop();

            Console.WriteLine("------ Step-by-step store data entry ------");

            // Виклик кожного методу окремо
            shop4.InputName();
            shop4.InputAddress();
            shop4.InputProfile();
            shop4.InputPhone();
            shop4.InputEmail();

            // Виведення результату
            Console.WriteLine("\n------ Result ------");
            Console.WriteLine(shop4);
        }
    }
    /*Task 6_3 Shop*/
    public class Shop
    {
        private string email;
        public string Name { get; set; }
        public string Address { get; set; }
        public string ProfileDescription { get; set; }
        public string Phone { get; set; }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != null && value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Uncorrect email. Default value is set.");
                    email = "unknown@shop.com";
                }
            }
        }

        public Shop()
        {
            Name = "Underfined";
            Address = "Underfined";
            ProfileDescription = "No Desc";
            Phone = "+380000000000";
            Email = "info@shop.com";
        }

        public Shop(string name, string address, string profile, string phone, string email)
        {
            Name = name;
            Address = address;
            ProfileDescription = profile;
            Phone = phone;
            Email = email;
        }

        public void InputName()
        {
            Console.Write("Input name of shop: ");
            Name = Console.ReadLine();
        }
        public void InputAddress()
        {
            Console.Write("Input address: ");
            Address = Console.ReadLine();
        }
        public void InputProfile()
        {
            Console.Write("Input profile desc: ");
            ProfileDescription = Console.ReadLine();
        }

        public void InputPhone()
        {
            Console.Write("Input phone: ");
            Phone = Console.ReadLine();
        }
        public void InputEmail()
        {
            string inputEmail;
            do
            {
                Console.Write("Enter Email (have to contain '@'): ");
                inputEmail = Console.ReadLine();
                if (!inputEmail.Contains("@"))
                {
                    Console.WriteLine("Error! E-mail have to contain '@'. Try again.");
                }
            } while (!inputEmail.Contains("@"));

            Email = inputEmail;
        }

        public void InputData()
        {
            Console.WriteLine("===== Enter data about shop =====");
            Console.Write("Enter name of Shop: "); Name = Console.ReadLine();
            Console.Write("Enter address: "); Address = Console.ReadLine();
            Console.Write("Enter profile desc: "); ProfileDescription = Console.ReadLine();
            Console.Write("Enter Phone: "); Phone = Console.ReadLine();

            string inputEmail;
            do
            {
                Console.Write("Enter Email (have to contain '@'): ");
                inputEmail = Console.ReadLine();
                if (!inputEmail.Contains("@"))
                {
                    Console.WriteLine("Error! E-mail have to contain '@'. Try again.");
                }
            } while (!inputEmail.Contains("@"));
            Email = inputEmail;
            Console.WriteLine("Data saved successfully!\n");
        }

        public override string ToString()
        {
            return $"--- Shop: {Name} ---\n" +
                   $"Address: {Address}\n" +
                   $"Profile: {ProfileDescription}\n" +
                   $"Phone: {Phone}\n" +
                   $"E-mail: {Email}";
        }
    }

    /*Task 6_2 */
    /*
    class Magazine
    {
        string name;
        int foundationYear;
        string description;
        string phone;
        string email;


        public Magazine()
        {
        }

        public Magazine(string name, int foundationYear, string description, string phone, string email)
        {
            Name = name;
            FoundationYear = foundationYear;
            Description = description;
            Phone = phone;
            Email = email;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int FoundationYear
        {
            get { return foundationYear; }
            set 
            {
                if (value > 0 && value <= DateTime.Now.Year)
                {
                    foundationYear = value;
                }
                else
                {
                    Console.WriteLine("[Error] Incorrect year. Set to 2000.");
                    foundationYear = 2000;
                }
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if(value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("[Error] Email must contain '@'. Default value set.");
                    email = "unknown@example.com";
                }
            }
        }
        public void InputData()
        {
            Console.WriteLine("--- Input data ---");
            Console.Write("Name of Magazine: ");
            Name = Console.ReadLine();
            Console.Write("Foundation year: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                FoundationYear = year;
            }
            else
            {
                Console.WriteLine("Number error. Year set to 2000.");
                FoundationYear = 2000;
            }
            Console.Write("Description: ");
            Description = Console.ReadLine();

            Console.Write("Phone: ");
            Phone = Console.ReadLine();

            while (true)
            {
                Console.Write("Email (whith '@'): ");
                string inputEmail = Console.ReadLine();
                if (inputEmail.Contains("@"))
                {
                    Email = inputEmail;
                    break;
                }
                Console.WriteLine("Error, Email doesn't contains '@'. Try more.");
            }
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Magazine: " + Name + "\n" +
                   "Foundation year: " + FoundationYear + "\n" +
                   "Description: " + Description + "\n" +
                   "Phone: " + Phone + "\n" +
                   "Email: " + Email;
        }

    }
    */

    /*Task 6_1 */
    /*
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
    */
}
