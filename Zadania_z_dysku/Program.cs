namespace Zadania_z_dysku;

class Program
{
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
