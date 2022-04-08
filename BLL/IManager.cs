namespace BLL
{
    public interface IManager
    {
        void AddChfByCardId(int cardId, double amountChf);
        void AddChfByUsername(string username, double amountChf);
        double GetChfbyUsername(string username);
        double GetQuantityByUsername(string username);
    }
}