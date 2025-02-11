namespace Powtorzenie;

class Program
{

    //Zadanie: Liczenie izolowanych bitów
    static int CountIsolatedBits(int liczba){
        int wzor = 0b010;
        int counter = 0;

        while(liczba > 0){
            int maska = liczba & 0b111;
            if(maska == wzor) counter++;
            liczba = liczba >> 1;            
        }
        return counter;
    }


    //Zadanie: Zamiana bitów w parach
    static int SwapBitsInPairs(int liczba){
        int odp = 0;
        int counter = 0;

        while(liczba > 0){
            int maska = liczba ^ 0b11;
            odp = odp | (maska << 2*counter);
            counter = counter + 1;
            liczba = liczba >> 2;
        }
        return odp;
    }



    //Zadanie: Liczenie odwróconych par bitów
    static int CountInvertedPairs(int liczba){
        int wzor1 = 0b10;
        int wzor2 = 0b01;
        int counter = 0;

        while(liczba > 0){
            int maska = liczba & 0b11;
            if(maska == wzor1 || maska == wzor2)counter++;
            liczba = liczba >> 1;
        }
        return counter;
    }



    //Z tego roku
    static byte S3(int rejestr, byte wzor){
        int schemat = wzor & 0b11;
        byte counter = 0;

        while(rejestr>0){
            int maska = rejestr & 0b11;
            if(schemat == maska) counter++;
            rejestr = rejestr >> 1;
        }
        return counter;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
