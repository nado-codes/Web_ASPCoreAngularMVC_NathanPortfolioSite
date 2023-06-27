namespace NPS.Interfaces
{
    internal interface IBaseService<Model> where Model: IBaseModel
    {
        public Task<IEnumerable<Model>> GetAll();

        public Task<Model> GetAsync(long id);

        public Task<Model> AddAsync(Model item);

        public Task<Model> UpdateAsync(Model item);

        public Task<Model> DeleteAsync(long id);
    }

}