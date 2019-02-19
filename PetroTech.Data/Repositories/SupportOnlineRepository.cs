﻿using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class SupportOnlineRepository : Repository<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}