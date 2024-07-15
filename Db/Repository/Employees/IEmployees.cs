using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Employees
{
    public interface IEmployees
    {
        Task<InteractionDb.ModelTables.Employees> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.Employees>> GetAll();
        void Update(InteractionDb.ModelTables.Employees employees);
        void Insert(InteractionDb.ModelTables.Employees employees );
        void Delete(int id);
    }
}
