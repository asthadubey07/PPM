namespace PPM.UIConsole
{
    public class MainConsoleUi
    {
        public void AllMenu()
        {
            ProjectConsoleUi projectConsoleUi = new();
            EmployeeConsoleUi employeeConsoleUi = new();
            RoleConsoleUi roleConsoleUi = new();
            while (true)
            {
                ShowMainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        projectConsoleUi.ProjectModule();
                        break;
                    case "2":
                        employeeConsoleUi.EmployeeModule();
                        break;
                    case "3":
                        roleConsoleUi.RoleModule();
                        break;
                    case "4":
                        Exit();
                        return;
                    default:
                        Default();
                        break;
                }
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Project Module");
            Console.WriteLine("2. Employee Module");
            Console.WriteLine("3. Role Module");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
        }

        public static void Default()
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Invalid choice. Please select a valid option.");
            System.Console.ResetColor();
        }

        public static void Exit()
        {
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Thank you for chosing PPM!!");
            System.Console.ResetColor();
        }
    }
}
