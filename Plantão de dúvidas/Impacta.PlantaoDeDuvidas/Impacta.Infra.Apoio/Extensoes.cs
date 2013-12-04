using System;

namespace Impacta.Infra.Apoio
{
    public static class Extensoes
    {
        public static T[] RemoveAt<T>(this T[] source, int idx)
        {
            var destination = new T[source.Length - 1];
            if (idx > 0)
                Array.Copy(source, 0, destination, 0, idx);

            if (idx < source.Length - 1)
                Array.Copy(source, idx + 1, destination, idx, source.Length - idx - 1);

            return destination;
        }
    }
}