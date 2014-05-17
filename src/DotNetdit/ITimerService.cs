namespace DotNetdit
{
    public interface ITimerService
    {
        ITimeBuilder Days();

        ITimeBuilder Hours();

        ITimeBuilder Minutes();

        ITimeBuilder Seconds();
    }
}