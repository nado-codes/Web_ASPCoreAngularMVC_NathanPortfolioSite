namespace NPS.Interfaces
{
    public interface IBaseService<Model> where Model: IBaseModel
    {
        public Task<IEnumerable<Model>> GetAllAsync();

        public Task<Model> GetAsync(long id);

        public Task<Model> AddAsync(Model item);

        public Task<int> UpdateAsync(Model item);

        public Task<int> DeleteAsync(long id);
    }

}