namespace InstrumentShop.DataAccessLayer
{
    public interface IUnitOfInstrument
    {
        ICategoryRepository CategoryRepository { get; }
        IInstrumentRepository InstrumentRepository { get; }
        IOrderRepository OrderRepository { get; }
        void Dispose();
        void Save();
    }
}