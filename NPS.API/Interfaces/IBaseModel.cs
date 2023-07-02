namespace NPS.Interfaces
{
    public interface IBaseModel
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
