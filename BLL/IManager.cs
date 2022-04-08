namespace BLL
{
    public interface IManager
    {
        void AddChfByCardId(int cardId, decimal amountChf);
        void AddChfByUsername(string username, decimal amountChf);
        decimal GetChfbyUsername(string username);
        decimal GetQuantityByUsername(string username);
    }
}