namespace Zadania_z_dysku;

class Program
{
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
