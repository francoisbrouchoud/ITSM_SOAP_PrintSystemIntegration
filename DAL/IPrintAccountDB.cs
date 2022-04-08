namespace DAL
{
    public interface IPrintAccountDB
    {
        bool AddChfByUsername(string username, decimal amount);
        decimal GetChfByUsername(string username);
    }
}