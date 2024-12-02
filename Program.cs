namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
           //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
           //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
           //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

           int[] zahlenDurcheinander = { 4, 33, 7, 1, 23, 12 };
            int zahlenSortiert;

            for (int i = 0; i < zahlenDurcheinander.Length; i++)
            {
                for (int x = i + 1; x < zahlenDurcheinander.Length; x++)
                {
                    if (zahlenDurcheinander[i] > zahlenDurcheinander[x])
                    {
                        zahlenSortiert = zahlenDurcheinander[x];
                        zahlenDurcheinander[x] = zahlenDurcheinander[i];
                        zahlenDurcheinander[i] = zahlenSortiert;
                    }
                }
                Console.WriteLine(zahlenDurcheinander[i]);
            }


            
        }
    }

}