using System;

namespace DotNetdit
{
    public interface ITimeBuilder
    {
        ITimerService And();

        ITimeService Do(Action<Reddit> predicate); // todo - do i need func?
    }
}