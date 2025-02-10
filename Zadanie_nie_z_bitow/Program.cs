namespace Zadanie_nie_z_bitow;

class Program
{
    //###########2018########################

    static string[] Rozdzielenie(string napis){
        string[] ans = new string[napis.Length];
        string plc_hldr = "";
        int index = 0;

        foreach(char s in napis){
            if((s >= 'A' && s <= 'Z') || (s >= 'a' && s <= 'z')){
                plc_hldr += s;
            }
            else{
                ans[index] = plc_hldr;
                plc_hldr = "";
                index++;
            }
        }
        ans[index] = plc_hldr;
        return ans;
    }
    static bool CzyTyleSamo(string napis){
        char[] samogloski = {'a','e','u','o','i'};
        int counter = 0;
        foreach(char i in napis){
            int jest = 0;
            foreach(char c in samogloski){
                if(c == i){
                    jest ++;
                    counter++;
                }
            }
            if(jest == 0) counter --;
        }
        return counter == 0;
    }
    static string F2(string napis){
        string odp = "!";
        string[] wyrazy = Rozdzielenie(napis);
        foreach(string s in wyrazy){
            if(CzyTyleSamo(s)){
                odp = s;
            }
        }
        return odp;
    }

    static string NaSzesc(int liczba){
        string napis= "";
        while(liczba > 0){
            napis += liczba % 6;
            liczba = liczba / 6;
        }
        string odp = "";
        for(int i = napis.Length-1; i >= 0;i--){
            odp += napis[i];
        }
        return odp;
    }
    static uint F4(int liczba) {
        string n = NaSzesc(liczba);
        uint suma = 0;
        foreach(int c in n){
            suma += (uint)(c);
        }
        return suma;
    }


    //###########2021########################
    static bool CzyPierwsza(int n){
        if(n < 2) return false;
        for(int i = 2; i < n; i++){
            if(n % i == 0) return false;
        }
        return true;
    }
    static short A1(int[] T){
        int maks = int.MinValue;
        int min = int.MaxValue;

        foreach(int t in T){
            if(CzyParzysta(t)){
                if(t > maks){
                    maks = t;
                }
                if(t < min){
                    min = t;
                }
            }
        }   
        return (short)((maks+min)/2);
    }    


    static int NaSiedem(int n){
        bool ujemna =  (n < 0);
        if(ujemna) n = (-1) * n;
        string napis = "";

        while(n>0){
            napis += n%7;
            n = n / 7;
        }
        return (ujemna) ? (-1)* Convert.ToInt32(napis[0]) : Convert.ToInt32(napis[0]) ;
    }
    static uint A2(int liczba){
        int n = NaSiedem(liczba);
        if(Math.Abs(liczba) < 7) return (uint)(Math.Abs(n));
        return A2(liczba/7);
    }




    //###########2024########################
    static bool CzyParzysta(int liczba){
        return (liczba & 1) == 1;
    }

    //powinno być rekurencją ale się zapomniałem  
    static short S1(long liczba){
        string napis = Convert.ToString(liczba);
        int maks = int.MaxValue;
        int mini = int.MinValue;
        foreach(char i in napis){
            int skibidi = (int)(i);
            if(CzyParzysta(skibidi)){
                maks = (maks > skibidi) ? maks : skibidi;
            }
            else{
                mini = (mini > skibidi) ? mini : skibidi;
            }
        } 
        return (maks == int.MaxValue) ? (short)(mini) : (short)(maks);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
