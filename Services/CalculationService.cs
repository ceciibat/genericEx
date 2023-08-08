
namespace Fix.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable         // a lista vai ter que ser de um tipo T qualquer desde que esse tipo seja uma implementação da itfc IComparable 
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)             // comparando de uma forma genérica, utilizando a interface IComparable | > 0 = Console.WriteLine("maria".CompareTo("alex")); que tem como resultado: 1
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
