
class Program {
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] tablica = new int[10];

        for (int i = 0; i < tablica.Length; i++) {
            tablica[i] = random.Next(0, 1001);
        }

        Console.WriteLine("Liczby parzyste w tablicy:");
        foreach (int liczba in tablica) {
            if (liczba % 2 == 0) {
                Console.WriteLine(liczba);
            }
        }
    }
}
