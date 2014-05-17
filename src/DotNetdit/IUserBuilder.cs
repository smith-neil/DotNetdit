namespace DotNetdit
{
    public interface IUserBuilder<out T>
    {
        T WithPassword(string password);
    }
}