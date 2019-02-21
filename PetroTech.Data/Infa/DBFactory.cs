namespace PetroTech.Data.Infa
{
    public class DBFactory : Disposable, IDBFactory
    {
        private PetroDbContext petroDbContext;

        public PetroDbContext Init()
        {
            return petroDbContext ?? (petroDbContext = new PetroDbContext());
        }

        protected override void DisposeCore()
        {
            if (petroDbContext != null)
                petroDbContext.Dispose();
        }
    }
}