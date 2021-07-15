using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGurtejSingh
{
    class CrudOperationsInFinal
    {

        internal void GetCities()

        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\nCities:\n");
            Console.WriteLine($"{"City ID ",5}{"City Name",-20}{"IsCapital ",-8}{"Country Name",-25}{"Continent Name",-20}{"Population",10}\n");
            using (var Context = new WorldDBEntities())
            {
                var cities = from c in Context.Cities
                             select c;

                foreach (var a in cities)

                {
                    String result = a.IsCapital ? "Yes" : "";
                    Console.WriteLine($"{a.CityID,5} \t{a.CityName,-20}{result,-10}{a.Country.CountryName,-25}{a.Country.Continent.ContinentName,-20}{a.Population,10}");
                }
            }
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal void GetCountries()

        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\nCountries:\n");
            Console.WriteLine($"{"CountryID",10} \t{"CountryName",-20}{"Capitals",-20}{"Continent",-20}{"Language",-15}{"Currency",10}\n");
            using (var Context = new WorldDBEntities())
            {
                var countries = from c in Context.Countries
                                select c;
                                
                foreach (var v in countries)

                {
                    var Capitals = (from vv in Context.Cities
                            where vv.Country.CountryName == v.CountryName 
                            select vv).FirstOrDefault();
                    if(Capitals.IsCapital == true) 
                    {
                    Console.WriteLine($"{v.CountryID,10} \t{v.CountryName,-20}{Capitals.CityName,-20}{v.Continent.ContinentName,-20}{v.Language,-20}{v.Currency,10}");
                    } 
                }
                
            }
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal void AddCountry()

        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\nAdd Country:\n");
            
            using (var Context = new WorldDBEntities())
            {

            Country country = new Country();
            Console.WriteLine("Enter the Country Code: ");
            String Code = Console.ReadLine();
            Console.WriteLine("Enter the Country Name: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter the Country Language: ");
            String Language = Console.ReadLine();
            Console.WriteLine("Enter the Currency: ");
            String Currency = Console.ReadLine();


           
                var Con = from c in Context.Continents
                              select c;

                foreach (var a in Con)

                {

                    Console.WriteLine($"{a.ContinentID,5} \t{a.ContinentName,-20}");
                }
            
            Console.WriteLine("Enter the Continent ID: ");
            int Cid = int.Parse(Console.ReadLine());

            country.CountryName = Name;
            country.CountryCode = Code;
            country.Language = Language;
            country.Currency = Currency;
            country.ContinentID = Cid;

            Context.Countries.Add(country);
                Context.SaveChanges();

         }   


            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal void AddCities()

        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\n ADD City:\n");
            using (var Context = new WorldDBEntities())
            {
                City city = new City();

                Console.WriteLine("Enter the City Name: ");
                String Name = Console.ReadLine();
                Console.WriteLine("City is Capital! Write Y or y for Yes OR N or n for NO: ");
                String Cap = Console.ReadLine();

                bool capital;
                if (Cap == "Y")
                {
                    capital = true;
                }
                else if (Cap == "y")
                {
                    capital = true;
                }
                else
                {
                    capital = false;
                }

                var cities = from c in Context.Countries
                             select c;

                foreach (var a in cities)

                {
                    Console.WriteLine($"{a.CountryID,5} \t{a.CountryName,-20}");
                }

                Console.WriteLine("\nEnter the Country ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the City Popupation: ");
                long Pop = long.Parse(Console.ReadLine());

                

                city.CityName = Name;
                city.IsCapital = capital;
                city.CountryID = id;
                city.Population = Pop;
                

                Context.Cities.Add(city);
                Context.SaveChanges();


            }
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }


        internal void UpdateCities()

        {
            Console.Clear();
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\n Update City:\n");
            Console.WriteLine($"{"City ID ",5}{"City Name",-20}{"IsCapital ",-8}{"Country Name",-25}{"Continent Name",-20}{"Population",10}\n");
            using (var Context = new WorldDBEntities())
            {
                var cities = from c in Context.Cities
                             select c;

                foreach (var a in cities)

                {
                    String result = a.IsCapital ? "Yes" : "";
                    Console.WriteLine($"{a.CityID,5} \t{a.CityName,-20}{result,-10}{a.Country.CountryName,-25}{a.Country.Continent.ContinentName,-20}{a.Population,10}");
                }

                Console.WriteLine("\nEnter the City ID to Update: ");
                int idd = int.Parse(Console.ReadLine());

                var find = from ids in Context.Cities
                           where ids.CityID == idd
                           select ids;

                foreach (var w in find)
                {
                    String result = w.IsCapital ? "Yes" : "";
                    Console.WriteLine($"{w.CityID,5} \t{w.CityName,-20}{result,-10}{w.Country.CountryName,-25}{w.Country.Continent.ContinentName,-20}{w.Population,10}");
                }



                City city = Context.Cities.Find(idd);

                    Console.WriteLine("\nEnter the City Name: ");
                    String Name = Console.ReadLine();
                    Console.WriteLine("City is Capital! Write Y or y for Yes OR N or n for NO: ");
                    String Cap = Console.ReadLine();

                    bool capital;
                    if (Cap == "Y")
                    {
                        capital = true;
                    }
                    else if (Cap == "y")
                    {
                        capital = true;
                    }
                    else
                    {
                        capital = false;
                    }

                var con = from c in Context.Countries
                             select c;

                foreach (var a in con)

                {
                    Console.WriteLine($"{a.CountryID,5} \t{a.CountryName,-20}");
                }



                Console.WriteLine("\nEnter the Country ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the City Popupation: ");
                    long Pop = long.Parse(Console.ReadLine());

                    city.CityName = Name;
                    city.IsCapital = capital;
                    city.CountryID = id;
                    city.Population = Pop;

                     Context.SaveChanges();


                }
                Console.Write("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        internal int Menu()
        {
            Console.WriteLine("\n\n\t\tFinal Exam by GURTEJ SINGH");
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Get all Cities");
            Console.WriteLine("\t2 - Get all Countries");
            Console.WriteLine("\t3 - Add New Country");
            Console.WriteLine("\t4 - Add New City");
            Console.WriteLine("\t5 - Update a City");
            Console.WriteLine("\t6 - Exit");
            Console.Write("\nEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        //internal void delete()
        //{
        //    Console.WriteLine("Enter id :");
        //    int id = int.Parse(Console.ReadLine());
        //    using (var Context = new WorldDBEntities())
        //    {
        //        Country country = Context.Countries.Find(id);

        //        Context.Countries.Remove(country);
        //        Context.SaveChanges();
        //    }

        //    }

    }
    }

