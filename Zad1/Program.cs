namespace Zad1;

class Program
{
    static bool Parzysta(int n){
        return (n & 1) == 0;
    }
    static void Binarnie(long n){
        string  odp = "";
        while(n > 0){
            long reszta = n%2;
            odp += reszta;
            n = n/2;
        }
        string plc = "";
        for(int i = odp.Length-1; i >= 0; i--){
            plc += odp[i];
        }
        System.Console.WriteLine(plc);
    }
    static void Dziesietnie(long n){
        int i = 0;
        long odp = 0;
        while(n>0){
            odp += ((n & 1) * Potega(i));
            n = n>>1;
            i++;
        }
        System.Console.WriteLine(odp);
    }
    static long Potega(int i){
        if(i == 0) return 1;
        return 2*Potega(i-1);
    }
    static long Zamiana_na_1_bajcie(long n){
        long maska = 0xFF;
        return (n ^ maska);
    }
    static long Zamiana_69(long n){
        long maksa = 0b0000000011100000;
        return (n ^ maksa);
    }
    //Napisz funkcję w C#, która sprawdza, czy w danej liczbie całkowitej n dokładnie 3. bit (licząc od 0) jest ustawiony na 1.
    static bool jeden_z_gpt(long n){
        return ((n&8)==8) ? true : false;
    }
    //Napisz funkcję LiczbaJedynkowychBitow(int n), która zwróci liczbę bitów ustawionych na 1 w liczbie n
    static long dwa_z_gpt(long n){
        long counter = 0;
        while(n>0){
            counter += (n&1);
            n = n>>1;
        }
        return counter;
    }
    //Napisz funkcję OdwrocBity(int n), która zwróci liczbę, której bity są w odwrotnej kolejności
    static long trzy_z_gpt(long n){
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Parzysta(123));
    }
}
