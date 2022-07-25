using Practicaweb.API.Models;

namespace Practicaweb.API
{
    public class UsersData  // "Base de datos  xD"
    {
        //public static UsersData UniqueInstance { get; } = new UsersData(); // Permite que se mantenga el orden de la lista
        public List<userDto> Users { get; set; }

        public UsersData()
        {
            Users = new List<userDto>
            {
                new userDto()
                {
                    Id = 1,
                    Name = "User1",
                    bills = new List<BillDto>
                    {
                        new BillDto()
                        {
                            Id = 1,
                            Name = "Nick Gaturro Cotillon",
                            CUIT = 1254769865,
                            Price = 15885.20,
                            Description = "15 fusiles AR15"

                        },
                        new BillDto()
                        {
                            Id = 2,
                            Name = "COTO",
                            CUIT = 6986556654,
                            Price = 52000.55,
                            Description = "4 peras"

                        },
                        new BillDto()
                        {
                            Id = 3,
                            Name = "Easy",
                            CUIT = 1125446852,
                            Price = 41000.33,
                            Description = "20 Ficus con maceta"


                        }
                    }
                },
                new userDto()
                {
                    Id = 2,
                    Name = "User2",
                    bills = new List<BillDto>
                    {
                        new BillDto()
                        {
                            Id = 4,
                            Name = "Alfredo Casero, Estilistas",
                            CUIT = 6661452388,
                            Price = 250,
                            Description = "Corte de pelo"

                        },
                        new BillDto()
                        {
                            Id = 5,
                            Name = "Shell",
                            CUIT = 9868525633,
                            Price = 15000,
                            Description = "Tanque lleno"

                        },
                        new BillDto()
                        {
                            Id = 6,
                            Name = "Servicio de Aguas",
                            CUIT = 998685744,
                            Price = 4200,
                            Description = "Devengamiento por pago de servicios"

                        }
                    }
                },
                new userDto()
                {
                    Id = 3,
                    Name = "user3",
                    bills = new List<BillDto>
                    {
                        new BillDto()
                        {
                            Id = 7,
                            Name = "Juan Carlos Albañiles",
                            CUIT = 4578123696,
                            Price = 10000,
                            Description = "Servicio de reparacion de paredes"

                        },
                        new BillDto()
                        {
                            Id = 8,
                            Name = "Canal 3",
                            CUIT = 5475321598,
                            Price = 120000,
                            Description = "Servicio de publicidad"

                        },
                        new BillDto()
                        {
                            Id = 9,
                            Name = "Rotiseria",
                            CUIT = 7789996585,
                            Price = 5000.02,
                            Description = "5 Empanadas"

                        }
                    }
                }
            };
        }
    }
}
