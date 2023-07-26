namespace APIAuthorization.Interfaces
{
    public interface IRepository
    {
        public Task Insert(object obj);

        public Task Update(object obj);
        public Task Delete(int id);
        public Task<object> GetById(int id);

        public IQueryable GetAll();
    }
}
