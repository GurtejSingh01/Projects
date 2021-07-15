using System;
using System.Collections.Generic;
using System.Text;

namespace A2GurtejSingh
{
    class CrudOperationsInA2
    {
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter _employeesTableAdapter;
        private NorthwindDataSet.EmployeesDataTable _tblEmps;

        private NorthwindDataSetTableAdapters.Employees1TableAdapter _employeesTableAdapter1;
        private NorthwindDataSet.Employees1DataTable _tblEmps1;

       

        private NorthwindDataSetTableAdapters.OrdersTableAdapter _OrderstableAdapter;
        private NorthwindDataSet.OrdersDataTable _tblOrders;


        internal CrudOperationsInA2()
        {
            _employeesTableAdapter = new NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            _tblEmps = new NorthwindDataSet.EmployeesDataTable();

            _employeesTableAdapter1 = new NorthwindDataSetTableAdapters.Employees1TableAdapter();
            _tblEmps1 = new NorthwindDataSet.Employees1DataTable();

            _OrderstableAdapter = new NorthwindDataSetTableAdapters.OrdersTableAdapter();
            _tblOrders = new NorthwindDataSet.OrdersDataTable();
        }

        internal void GetAllEmployees()
        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            Console.WriteLine("\nEmployees:\n");
            _employeesTableAdapter.Fill(_tblEmps);
            
            Console.WriteLine($"\n{"ID",5} {"FirstName",-15}" +
            $"{"LastName",-15}{"Title",-28}{"BirthDate",10}\n");
            

            foreach(var row in _tblEmps)
            {
               
                Console.WriteLine($"{row.EmployeeID,5} {row.FirstName,-15}" +
                     $"{row.LastName,-15}{row.Title,-28}{row.BirthDate,10}");
            }

            Console.Write("\n\nress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal void GetEmpByName(String Name)
        {
           
            Console.WriteLine("\nSearch by Employees Name:\n");
            
            _tblEmps = _employeesTableAdapter.SearchByName(Name);

            Console.WriteLine($"\n{"ID",5} {"FirstName",-15}" +
            $"{"LastName",-15}{"Title",-28}{"BirthDate",10}\n");



            foreach (var row in _tblEmps)
            {
                Console.WriteLine($"{row.EmployeeID,5} {row.FirstName,-15}" +
                      $"{row.LastName,-15}{row.Title,-28}{row.BirthDate,10}");
            }
            Console.Write("\n\nress any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }


       internal void GetEmpAge()
        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            Console.WriteLine("\nEmployees Sorted by Age:\n");
            
            _tblEmps1 = _employeesTableAdapter1.GetEmpAge();
            Console.WriteLine($"\n{"ID",5} {"FirstName",-15}" +
            $"{"LastName",-15}{"Title",-28}{"BirthDate",10}{"Age",10}\n");

            foreach (var row in _tblEmps1)
            {
                
                Console.WriteLine($"{row.EmployeeID,5} {row.FirstName,-15}" +
                      $"{row.LastName,-15}{row.Title,-28}{row.BirthDate,10}{row.Age+" Years",10}");
            }
            Console.Write("\n\nress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal void GetAllOrders()
        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            Console.WriteLine("\nOrders:\n");
            _tblOrders = _OrderstableAdapter.GetShipmentInfo();
            Console.WriteLine($"\n{"ID",5} {"Employee Name",-20}" +
            $"{"Order Date",-25}{"Shipped Date",-25}{"City",-20}{"Country",-10}\n");

            foreach (var row in _tblOrders)
            {

                Console.WriteLine($"{row.OrderID,5} {row.EmployeeName,-20}" +
                      $"{row.OrderDate,-25}{row.ShippedDate,-25}{row.ShipCity,-20}{row.ShipCountry,-10}");
            }
            Console.Write("\n\nress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }

    }

