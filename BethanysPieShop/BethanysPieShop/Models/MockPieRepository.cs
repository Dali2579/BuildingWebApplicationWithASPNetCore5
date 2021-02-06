using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{PieId=1,Name="Strawberry Pie", Price=15.95M,ShortDescription="Strawberry Pie",LongDescription="Strawberry Pie",AllergyInformation="None",Instock=true,IsPieOfTheWeek=false},
            new Pie{PieId=2,Name="Cheese cake", Price=18.95M,ShortDescription="Strawberry Pie",LongDescription="Strawberry Pie",AllergyInformation="None",Instock=true,IsPieOfTheWeek=false},
            new Pie{PieId=1,Name="Pumpkin Pie", Price=25.95M,ShortDescription="Strawberry Pie",LongDescription="Strawberry Pie",AllergyInformation="None",Instock=true,IsPieOfTheWeek=false}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(pie => pie.PieId == pieId);
        }
    }
}
