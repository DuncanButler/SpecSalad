using System.Linq;

namespace SpecSalad
{
    public static class ActorExtensions
    {
        public static bool IsUndefined(this string actorName)
        {
            return string.IsNullOrWhiteSpace(actorName);
        }
    }
}