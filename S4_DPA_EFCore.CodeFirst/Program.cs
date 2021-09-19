using S4_DPA_EFCore.CodeFirst.Models;
using System;
using System.Collections.Generic;

namespace S4_DPA_EFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var data = new EurocopaDBContext();

            //var position1 = new PlayerPosition()
            //{
            //    Description = "Portero",
            //    Code = "PT"
            //};

            //data.PlayerPosition.Add(position1);
            //data.SaveChanges();

            var position2 = new PlayerPosition()
            {
                Description = "Lateral Izquierdo",
                Code = "LI"
            };

            var position3 = new PlayerPosition()
            {
                Description = "Lateral Derecho",
                Code = "LD"
            };
            var position4 = new PlayerPosition()
            {
                Description = "Mediocampista Ofensivo",
                Code = "MO"
            };

            var positionList = new List<PlayerPosition>();
            positionList.Add(position2);
            positionList.Add(position3);
            positionList.Add(position4);

            data.PlayerPosition.AddRange(positionList);
            data.SaveChanges();


        }
    }
}
