using System.Text;

namespace Ennui.Api.Builder
{
    public interface Filter<T>
    {
        bool Ignore(T t);
    }
}
