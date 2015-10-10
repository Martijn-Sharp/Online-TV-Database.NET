using System;

namespace OnlineTvDatabase.Core.Factory
{
    public interface IObjectUrlFactory
    {
        Uri Create<T>(T input);
    }
}
