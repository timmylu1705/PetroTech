using System;

namespace PetroTech.Data.Infa
{
    public interface IDBFactory : IDisposable
    {
        PetroDbContext Init();
    }
}