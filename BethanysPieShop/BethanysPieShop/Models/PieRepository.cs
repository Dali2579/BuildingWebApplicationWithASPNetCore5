using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PieRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Pie> AllPies => applicationDbContext.Pies.Include(c=>c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => applicationDbContext.Pies.Where(pie => pie.IsPieOfTheWeek).ToList();

        public Pie GetPieById(int pieId)
        {
            return applicationDbContext.Pies.FirstOrDefault(pie => pie.PieId == pieId);
        }
    }
}
