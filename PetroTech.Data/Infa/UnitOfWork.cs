namespace PetroTech.Data.Infa
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBFactory dBFactory;
        private PetroDbContext petroDbContext;

        public UnitOfWork(IDBFactory dBFactory)
        {
            this.dBFactory = dBFactory;
        }

        public PetroDbContext PetroDbContext
        {
            get { return petroDbContext ?? (petroDbContext = dBFactory.Init()); }
        }

        public void Commit()
        {
            PetroDbContext.SaveChanges();
        }
    }
}