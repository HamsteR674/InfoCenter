using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Employees
{
    public class Employees(ApplicationContext context) : IEmployees
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.Employees> _employees = context.Set<ModelTables.Employees>();


        public async Task<ModelTables.Employees> GetbyId(int id)
        {

            ModelTables.Employees employees = await _employees.SingleOrDefaultAsync(x => x.Id == id);
            if (employees == null) return null;
            return employees;
        }

        public async Task<List<ModelTables.Employees>> GetAll()
        {
            List<ModelTables.Employees> employees = await _employees.ToListAsync();
            if (employees == null) return null;
            return employees;
        }

        public void Insert(ModelTables.Employees employees)
        {
            _employees.Add(employees);
            context.SaveChanges();

        }

        public void Update(ModelTables.Employees employees)
        {
            _employees.Update(employees);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var employees = _employees.SingleOrDefault(x => x.Id == id);
            if (employees == null) return;
            _employees.Remove(employees);
            context.SaveChanges();

        }
    }
}
