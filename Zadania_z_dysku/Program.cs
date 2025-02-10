namespace Zadania_z_dysku;

class Program
{
    // uint = 16 bitów
    // int = 32 bity
    // ulong = 32 bity
    // long = 64 bity


    //Zadanie: Zadanie: Liczenie izolowanych bitów
    static int CountIsolatedBits(int liczba){
        int counter = 0;
        while(liczba > 0){
            int maska = liczba & 0b111;
            if(maska == 0b010) counter ++;
            liczba = liczba >> 1;
        }
        return counter;
    }


    //Zadanie: Zamiana bitów w parach
    static int SwapBitsInPairs(int liczba){
        int odp = 0;
        int i = 0;
        while(liczba > 0){
            int maska = 0b11;
            int maska_liczby = liczba & 0b11;
            maska = (maska ^ maska_liczby);
            odp = odp | (maska << 2*i);
            liczba = liczba >> 2;
            i++;
        }
        return odp;
    }

    //Zadanie: Liczenie odwróconych par bitów
    static int CounterInvertedPairs(int liczba){
        int counter = 0;
        long wzor1 = 0b10;
        long wzor2 = 0b01;
        while(liczba > 0){
            long maska = liczba & 0b11;
            if(maska == wzor1 || maska == wzor2) counter ++;
            liczba = liczba >> 1;
        }
        return counter;
    }
    static byte S3(int rejestr, byte wzor){
        byte counter = 0;
        while(rejestr > 0){
            int maska = 0b11;
            maska = maska & rejestr;
            if(maska == wzor) counter ++;
            rejestr = rejestr >> 1;
        }
        return counter;
    }
    static long Bitwise2018_2(long n){
        long maska = 0b1110000000;
        maska = maska & n;
        maska = maska >> 6;
        if(maska == 0){
            maska = 0b111;
        }else{
            maska = maska - 1;
        }
        maska = maska << 6;
        return maska;
    }
    static long Bitwise2018_1(long n){
        long maska = 0b11110000000;
        maska = maska & n;
        maska = maska >> 6;
        if(maska == 0b1111){
            maska = 0;
        }else{
            maska += 1;
        }
        maska = maska << 6;
        return n | maska;
    }
    static long Bitewise2021(long n){
        long maska = n & 0b111100000000;
        maska = maska >> 7;
        if(maska == 0b1111){
            maska = 0;
        }
        else{
            maska = maska + 1;
        }
        maska = maska << 7;
        return n | maska;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
