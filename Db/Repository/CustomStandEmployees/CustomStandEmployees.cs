using InteractionDb.Repository.CustomStandEmployees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.CustomStand


{
    public class CustomStandEmployees(ApplicationContext context) : ICustomStandEmployees
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.CustomStandEmployees> _customStandEmployees = context.Set<ModelTables.CustomStandEmployees>() ;
      

        public async Task<ModelTables.CustomStandEmployees> GetbyId(int id)
        {

            ModelTables.CustomStandEmployees customStandEmployees =  await _customStandEmployees.SingleOrDefaultAsync(x => x.Id == id);
            if (customStandEmployees == null) return null;
            return  customStandEmployees;
        }

        public async Task<List<ModelTables.CustomStandEmployees>> GetAll()
        {
           List<ModelTables.CustomStandEmployees> customStandEmployees = await _customStandEmployees.ToListAsync();
            if (customStandEmployees == null) return null;
            return customStandEmployees;
        }

        public void Insert(ModelTables.CustomStandEmployees customStandEmployees)
        {
             _customStandEmployees.Add(customStandEmployees);
            context.SaveChanges();

        }

        public void Update(ModelTables.CustomStandEmployees customStandEmployees)
        {
            _customStandEmployees.Update(customStandEmployees);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customStandEmployees = _customStandEmployees.SingleOrDefault(x => x.Id == id);
            if (customStandEmployees == null) return;
            _customStandEmployees.Remove(customStandEmployees);
            context.SaveChanges();

        }
    }
}
