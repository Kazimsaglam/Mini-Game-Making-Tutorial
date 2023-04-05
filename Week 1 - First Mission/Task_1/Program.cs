namespace Task_1
{

    public class NewMath
    {
        public int Min(int p1, int p2)
        {
            if (p1 < p2)
                return p1;
            else if (p1 == p2)
                return p2;
            else
                return p2;
        }

        public int Max(int p1, int p2)
        {
            if (p1 > p2)
                return p1;
            else if (p1 == p2)
                return p2;
            else
                return p2;
        }

        public int Factoriel(int p)
        {
            if (p <= 1)
                return 1;

            return p * Factoriel(p -1);
        }

        public int[] Short(int[] dizi)
        {
            int gecici;
            Console.WriteLine("Dizinin İlk Hali :");

            foreach (int deger in dizi)
            {
                Console.Write(deger + " ");
            }

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = gecici;
                    }
                }
            }

            Console.WriteLine("\nDizinin Son Hali : ");
            return dizi;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int ilkSayi, ikinciSayi, result;

            NewMath newMath = new NewMath();

            while(true)
            {
                Console.WriteLine("1 - Min Deger Bulma");
                Console.WriteLine("2 - Max Deger Bulma");
                Console.WriteLine("3 - Faktoriyel Hesaplama");
                Console.WriteLine("4 - Dizi Sıralama");
                Console.Write("Yapmak İstediğiniz İşlem : ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("İlk sayiyi girin : ");
                        ilkSayi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nİkinci sayiyi girin : ");
                        ikinciSayi = Convert.ToInt32(Console.ReadLine());
                        result = newMath.Min(ilkSayi, ikinciSayi);
                        Console.WriteLine($"Min Deger = {result}\n");
                        break;

                    case 2:
                        Console.Write("İlk sayiyi girin : ");
                        ilkSayi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nİkinci sayiyi girin : ");
                        ikinciSayi = Convert.ToInt32(Console.ReadLine());
                        result = newMath.Max(ilkSayi, ikinciSayi);
                        Console.WriteLine($"Max Deger = {result}\n");
                        break;

                    case 3:
                        Console.Write("Faktöriyeli İstenen Sayiyi Girin : ");
                        ilkSayi = Convert.ToInt32(Console.ReadLine());
                        result = newMath.Factoriel(ilkSayi);
                        Console.WriteLine($"Faktöriyel Sonuç = {result}\n");
                        break;
                    case 4:
                        Console.Write("Kaç Elemanlı Dizi Olsun : ");
                        int eSayi = Convert.ToInt32(Console.ReadLine());
                        int[] dizi = new int[eSayi];

                        for (int i = 0; i < dizi.Length; i++)
                        {
                            Console.Write($"Dizinin {i+1}. Değeri :  ");
                            dizi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        dizi = newMath.Short(dizi);
                        foreach (int deger in dizi)
                        {
                            Console.Write(deger + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }    
        }
    }
}