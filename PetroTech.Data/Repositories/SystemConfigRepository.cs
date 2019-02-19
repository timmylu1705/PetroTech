﻿using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;


namespace PetroTech.Data.Repositories
{
    public class SystemConfigRepository : Repository<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
