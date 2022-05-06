namespace Apoio.Busca
{
    public static class Busca
    {
        public static T? BuscaSequencial<T>(this IEnumerable<T> source, T elem, T? defaultValue = default)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (elem == null) throw new ArgumentNullException("elem");

            foreach(var item in source)
            {
                if (elem.Equals(item))
                    return item;
            }
            return defaultValue;
        }

        public static T? BuscaBinaria<T>(this IEnumerable<T> source, T elem, T? defaultValue = default)
            where T : IComparable<T>
        {
            if (source == null) throw new ArgumentNullException("source");
            if (elem == null) throw new ArgumentNullException("elem");

            int inicio = 0;
            int fim = source.Count();

            int meio = (inicio + fim) / 2;
            while(meio < fim)
            {
                T atual = source.ElementAt(meio);
                int comparacao = atual.CompareTo(elem);

                if (comparacao == 0)
                    return atual;

                if (comparacao < 0)
                    fim = meio - 1;
                else
                    inicio = meio + 1;

                meio = (inicio + fim) / 2;
            }

            return defaultValue;
        }
    }
}
