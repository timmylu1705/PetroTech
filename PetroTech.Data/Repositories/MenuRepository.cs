using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Repositories
{
    public interface IMenuRepository
    {

    }

    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
