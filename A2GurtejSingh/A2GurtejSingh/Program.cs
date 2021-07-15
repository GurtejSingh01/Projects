using System;

namespace A2GurtejSingh
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudOperationsInA2 Crud = new CrudOperationsInA2();

            

           
                do
            {
                try
                {
                    int x = Menu();

                    switch (x)
                    {
                        case 1: //Get Employees
                            Crud.GetAllEmployees();
                            break;
                        case 2: //Get Employee by Name
                            Console.Clear();
                            Console.Write("\nEnter Employee Name: ");
                            String Name = Console.ReadLine();
                            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                            Crud.GetEmpByName(Name);

                            break;
                        case 3:
                            Crud.GetEmpAge();
                            break;
                        case 4:
                            Crud.GetAllOrders();
                            break;

                        case 5: //Exit
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice, Please try again!!!");
                            break;
                    }
              
            }
            catch (Exception)
                {
                Console.WriteLine("Invalid Choice, Please try again!!!");
                    

            }
        } while (true);
        }
            

      
        static int Menu()
        {
            Console.WriteLine("\n\n\t\tASSIGNMENT-2 by GURTEJ SINGH");
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Get all Employees");
            Console.WriteLine("\t2 - Search Employees by Name");
            Console.WriteLine("\t3 - Sort Employees by Age");
            Console.WriteLine("\t4 - Get all Orders");
            Console.WriteLine("\t5 - Exit");
            Console.Write("\nEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }

            
        }
}
