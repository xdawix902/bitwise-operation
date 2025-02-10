using System.Diagnostics.Metrics;

namespace Powtorka;

class Program
{
    //Zadanie: Liczenie izolowanych bitów
    static int CountIsolatedBits(int liczba){
        int count = 0;
        int wzor = 0b010;
        
        while(liczba > 0){
            int maska = liczba & 0b111;
            if(maska == wzor) count++;
            liczba = liczba >> 1;
        }
        return count;
    }

    
    //Zadanie: Zamiana bitów w parach
    static int SwapBitsInPairs(int liczba){
        int odp = 0;
        int i = 0;
        while(liczba > 0){
            int maska = 0b11;
            maska = liczba ^ maska;
            odp = odp | (maska << 2*i);
            liczba = liczba >> 2;
            i++;
        }
        return liczba;
    }



    //Zadanie: Liczenie odwróconych par bitów
    static int CountInvertedPairs(int liczba){
        int wzor1 = 0b10;
        int wzor2 = 0b01;
        int counter = 0;

        while(liczba > 0){
            int maska = liczba & 0b11;

            if(maska == wzor1 || maska == wzor2) counter ++;
            liczba = liczba >> 1;
        }
        return counter;
    }

    //#########2023#######
    static byte S3(int rejestr, byte wzor){
        int maska = wzor & 0b11;
        byte counter = 0;

        while(rejestr > 0){
            int liczba = rejestr & 0b11;
            if(liczba == maska) counter += 1; 
            rejestr = rejestr >> 1;
        }
        return counter;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
