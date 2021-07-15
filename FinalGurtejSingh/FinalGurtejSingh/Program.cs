using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGurtejSingh
{
    class Program
    {
        static void Main(string[] args)
        {

            CrudOperationsInFinal crud = new CrudOperationsInFinal();

            do
            {
                try
                {
                    int x = crud.Menu();

                    switch (x)
                    {
                        case 1: //Get All Cities
                            crud.GetCities();
                            break;
                        case 2: //Get All Countries
                            crud.GetCountries();
                            break;
                        case 3: //Add new Country
                            crud.AddCountry();
                            break;
                        case 4:  // Add new City
                            crud.AddCities();
                            break;
                        case 5: //update a City
                            crud.UpdateCities();
                            break;

                        case 6: //Exit
                            Environment.Exit(0);
                            break;
                        //case 7: //Exit
                        //    crud.delete();
                        //    break;
                        default:
                            Console.WriteLine("Invalid Choice, Please try again!!!");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Choice, Please try again!!!");


                }
            } while (true);
        }



        
    }
    }

