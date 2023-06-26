namespace NPS.Interfaces
{
    internal interface IBaseModel
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
