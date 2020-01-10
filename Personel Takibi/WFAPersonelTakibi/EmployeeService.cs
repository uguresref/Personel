using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi
{
    public class EmployeeService : IService<Employee>
    {

        private static List<Employee> employees = new List<Employee>();

        public void Add(Employee entity)
        {
            employees.Add(entity);
        }

        public bool Delete(Employee entity)
        {
            return employees.Remove(entity);
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(Guid id)
        {
            return employees.FirstOrDefault(x => x.Id == id);

        public void Update(Employee entity)
        {
          
        }
    }
}
