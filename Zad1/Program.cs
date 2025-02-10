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
        long odp = 0;
        while(n>0){
            //odp = odp | (n&1);
            //odp = odp << 1;
            //n = n >> 1; 
            odp = (odp << 1) | (n&1);
            n = n >> 1;
        }
        return odp;
        //return odp>>1;
    }
    //Mnożenie binarnie
    static long cztery_z_gpt(long a, long b){
        long wynik = 0;
        while(b != 0){
            if((b&1) == 1){
                wynik += a;
            }
            a = a << 1;
            b = b >> 1;
        }
        return wynik;
    }
    //Dany jest ciąg liczb, w którym każda liczba występuje dokładnie dwa razy, oprócz jednej, która występuje raz. Napisz funkcję ZnajdzUnikalnaLiczbe(int[] arr), która znajdzie tę jedyną liczbę.
    static long piec_z_gpt(long[] n){
        //logiczne rozwiązanie ale chujnia bo n^2
        /*for(int i = 0; i < n.Length; i++){
            long jeden = n[i];
            int counter = 0;
            for(int j = i+1; j< n.Length; j++){
                if((jeden ^ n[j]) == 0) counter ++;
            }
            if(counter == 0) return jeden;
        } 
        return -1;*/
        long wynik = 0;
        for(int i = 0; i < n.Length;i++){
            wynik ^= n[i];
        }
        return wynik;
    }
    //Zadanie 1: Sprawdzenie, czy liczba jest potęgą 2
    static bool zad1(long n){
        long maska = ~n;
        return n > 0 && ((n & maska)== 0); 
    }
    //Zadanie 2: Odwrócenie bitów w liczbie
    static long zad2(long n){
        long odp = 0;
        while(n>0){
            odp = (odp << 1) | (n & 1);
            n = n >> 1;
        }
        return odp;
    }
    //Zadanie 3: Sprawdzenie, czy liczba jest liczbą parzystą lub nieparzystą
    static bool CzyParzysta(long n){
        return (n & 1) == 0;
    }
    static bool CzyNieparzysta(long n){
        return (n&1) == 1;
    }
    //Zadanie 4: Zliczanie liczby bitów ustawionych na 1
    static long IleJedynek(long n){
        long counter = 0;
        while(n>0){
            if((n&1) == 1) counter ++;
            n = n>>1;
        }
        return counter;
    }
    //Zadanie 5: Sprawdzanie, czy dwa liczby mają te same bity w określonych pozycjach
    static bool Czy_2_3_takiesame(long n, long m){
        long n_na_2 = (n >> 2) & 1;
        long m_na_2 = (m >> 2) & 1;
        long n_na_3 = (n >> 3) & 1;
        long m_na_3 = (m >> 3) & 1;
        return (n_na_2 == m_na_2 && n_na_3 == m_na_3);
    }
    //Zadanie 6: Ustawianie konkretnego bitu na wartość 1
    static long Ustawienie_1_na_6(long n){
        long maska = 0b1000000;
        return n | maska;
    }
    //Zadanie 7: Liczba bitów różniących się między dwiema liczbami
    static long Liczba_roznic(long n, long m){
        long odp = n ^ m;
        long counter = 0;
        while(odp>0){
            counter += (odp & 1);
            odp = odp >> 1;
        }
        return counter;
    }
    //Zadanie 8: Odczyt bitu w danej pozycji
    static int Odczyt_z_pozycji_2(long n){
        return (int)((n>>2) & 1);
    }
    //Zadanie 9: Mnożenie przez 2 i dzielenie przez 2
    static long Mnozenie_przez_2(long n){
        return n << 1;
    }
    static long Dzielenie_przez_2(long n){
        return n >> 1;
    }
    //Zadanie 10: Ustawianie bitu na 0
    static long Ustawienie_bitu_6_na_0(long n){
        //maska powinna być długości 64 znaków ale nie chce mi się tego pisać
        long maska = 0b1111111111111111110111111;
        return (n & maska);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Parzysta(123));
    }
}
