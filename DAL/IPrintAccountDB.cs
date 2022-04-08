namespace DAL
{
    public interface IPrintAccountDB
    {
        bool AddChfByUsername(string username, double amount);
        double GetChfByUsername(string username);
    }
}