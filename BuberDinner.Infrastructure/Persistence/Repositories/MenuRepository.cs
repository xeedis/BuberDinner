using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly BuberDinnerDbContext _context;
    public MenuRepository(BuberDinnerDbContext context)
    {
        _context = context;
    }
    public void Add(Menu menu)
    {
        _context.Add(menu);

        _context.SaveChanges();
    }
}
