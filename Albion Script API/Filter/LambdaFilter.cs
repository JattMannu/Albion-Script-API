using System;

namespace Ennui.Api.Filter
{
    public class LambdaFilter<T> : Filter<T>
    {
        Func<T, bool> action;
        public LambdaFilter(Func<T, bool> action)
        {
            this.action = action;
        }

        public bool Ignore(T t)
        {
            return action(t);
        }
    }
}
