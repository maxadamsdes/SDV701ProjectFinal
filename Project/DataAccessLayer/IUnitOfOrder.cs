namespace InstrumentShop.DataAccessLayer
{
    public interface IUnitOfOrder
    {
        IOrderRepository OrderRepository { get; }

        void Dispose();
        void Save();
    }
}