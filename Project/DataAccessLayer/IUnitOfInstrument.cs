namespace InstrumentShop.DataAccessLayer
{
    public interface IUnitOfInstrument
    {
        ICategoryRepository CategoryRepository { get; }
        IInstrumentRepository InstrumentRepository { get; }

        void Dispose();
        void Save();
    }
}