
















/*ATM maşınları 4 və ya 6 rəqəmli PİN kodlara icazə verir və PİN kodlar tam 4 və ya 6 rəqəmdən başqaheç nə
 ehtiva edə bilməz. Funksiya etibarlı PIN sətrini ötürübsə, qaytarın true, əks halda qaytarın false*/
#region 
/*public class Kata
{
    public bool ValidatePin(string pin)
    {
        if (pin.Length != 6 && pin.Length != 4) return false;
        return true;



    }
}*/

#endregion

/*Sətirdə eyni miqdarda "x" və "o" hərflərinin olub olmadığını yoxlayın.
Metod boolean qaytarmalı və hərflərə həssas olmalıdır. Sətirdə istənilən simvol ola bilər.*/
#region

/*public class Kata
{
    public bool XO(string input)
    {
        int Xcount = 0;
        int Ocount = 0;

        foreach (char item in input)
        {
            if (item == 'x' || item == 'X')
            {
                Xcount++;

            }
            else if (item == 'o' || item == 'O')
            {

                Ocount++;
            }
        }
        return Xcount == Ocount;

    }
}*/
#endregion

/*Sadə, bir sıra sözlər verildikdə, ən qısa söz(lər)in uzunluğunu qaytarın.*/
#region
/*public static class Kata
{
    public static int FindShort(string s)
    {
        if (s == null) { return 0; }
        string[] sozler = s.Split(' ');
        int minsoz = sozler.Min(x => x.Length);
        return minsoz;
    }
}*/

#endregion

/*Timmy və Sarah aşiq olduqlarını düşünürlər, lakin yaşadıqları yerdən yalnız hər biri bir çiçək götürdükdən sonra biləcəklər.
 Çiçəklərdən birinin ləçəkləri cüt, digərinin isə tək sayda ləçəkləri varsa, deməli, onlar aşiqdirlər.
Hər bir çiçəyin ləçəklərinin sayını götürəcək və aşiq olduqda doğru, sevmədikdə isə yalana dönəcək funksiya yazın.*/
#region
/*public class LoveDetector
{
    public bool LoveFunc(int flower1, int flower2)
    {
        // Çiçəklərin ləçəklərinin sayı cüt və ya tək olduğunu yoxlayın
        bool flower1IsEven = flower1 % 2 == 0;
        bool flower2IsEven = flower2 % 2 == 0;

        // Şərtləri yoxlayın: biri cüt, digəri isə tək olmalıdır
        return flower1IsEven != flower2IsEven;
    }
}*/
#endregion

/*Tam ədədlərin boş olmayan massivini nəzərə alaraq, dəyərləri ardıcıllıqla birlikdə vurmağın nəticəsini qaytarın.*/
#region
/*public class Kata
{
    public static int Grow(int[] x)
    {
        int cvb = 1;
        foreach (var i in x)
        {

            cvb *= i;
        }
        return cvb;

    }
}*/

#endregion
/*Rəqəmlər toplusunu nəzərə alaraq, hər birinin əksini qaytarın. Hər bir müsbət mənfi, mənfi isə müsbət olur.*/
#region
/*public static class ArraysInversion
{
    public static int[] InvertValues(int[] input)
    {
        return input.Select(x => -x).ToArray();
    }
}*/

#endregion

/*gecə yarısından sonra saat, dəqiqə və saniyələri millisekundlara çevirmək üçün bir funksiya yazmaq lazimdir.
 Verilən h, m, və s dəyişənləri əsasında vaxtı millisekundlarda hesabla (h-saat, m-degige, s-saniyedir) */
#region

/*public static class Clock
{
    static int results = 0;
    public static int Past(int h, int m, int s)
    {
        int saat = h * 60 * 60 * 1000;
        int degige = m * 60 * 10 * 10 * 10;
        int saniye = s * 1000;
        results = saat + degige + saniye;
        return results;


    }
}*/

#endregion


/*Sinifinizdə imtahan var idi və siz ondan keçdiniz. Təbrik edirik!
Amma siz iddialı insansınız. Sinifinizdəki orta şagirddən daha yaxşı olub-olmadığınızı bilmək istəyirsiniz.
Siz həmyaşıdlarınızın test balları ilə bir sıra alırsınız. İndi ortalamanı hesablayın və xalınızı müqayisə edin!
trueƏgər daha yaxşısınızsa, geri qayıdın , əks halda false!
Qeyd:
Sizin xallarınız sinifinizin balları sırasına daxil edilmir. Orta balı hesablayarkən onları unutma!*/
#region
/*public class Kata
{


    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int count = ClassPoints.Length;
        int sum = 0;
        foreach (var item in ClassPoints)
        {

            sum += item;


        }
        var result = sum / count;
        return result < YourPoints;

    }
}*/


#endregion

/*Tam ədədlərin siyahısını verərək, onun elementlərinin cəminin tək və ya cüt olduğunu müəyyənləşdirin.
Cavabınızı sətir uyğunluğu "odd"və ya kimi verin "even".
Əgər giriş massivi boşdursa, onu belə hesab edin: [0](sıfır olan massiv).*/
#region

/*public class Kata
{
    public static string OddOrEven(int[] array)
    {
        int result = 0;
        foreach (int i in array)
        {
            result += i;
        }
        if (result % 2 == 0)
        {
            return "even";
        }
        return "odd";
    }

}*/
#endregion


/*Bu sadə tapşırıqda sizə bir nömrə verilir və onu mənfi etmək lazımdır. Amma bəlkə rəqəm artıq mənfidir?
 o halda oldugu kimi qayitsin*/
#region
/*public static class Kata
{
    public static int MakeNegative(int number)
    {
        if (number < 0)
        {
            return number;
        }
        return -Math.Abs(number);
    }
}*/
#endregion


/*Verilmiş siyahıdakı ədədlərin ortasını hesablayan funksiyanı yazın.

Qeyd: Boş massivlər 0 qaytarmalıdır.*/

#region

/*class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        int count = 0;
        double sum = 0;

        foreach (var item in array)
        {

            sum += item;
            count++;
        }

        return sum / count;

    }
}*/
#endregion

/*Sətirdən boşluqları aradan qaldıran bir funksiya yazın, sonra nəticə sətrini qaytarın.*/
#region
/*public static class SpacesRemover
{
    public static string NoSpace(string input)
    {
        string text = input.Replace(" ", "");
        return text;
    }

}*/
#endregion

/*Bir qəhrəman missiyasını başa çatdırmaq üçün qalaya gedir. Ancaq ona dedilər ki, qala bir neçə güclü əjdaha ilə əhatə olunub!
 * hər əjdaha məğlub olmaq üçün 2 güllə alır, qəhrəmanımızın nə qədər güllə daşıması lazım olduğunu bilmir.. Fərz etsək ki, o, müəyyən
 * sayda güllə tutacaq və başqa müəyyən sayda əjdaha ilə döyüşmək üçün irəliləyəcək, o, sağ qalacaqmı? Əyər Məglub olacaqsa false olmazsa true donsun*/
#region
/*class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        if (bullets / 2 >= dragons)
        {
            return true;
        }
        return false;
    }
}*/
#endregion

/*0-9 arasında bir rəqəm təqdim edildikdə, onu sözlə qaytarın.
Giriş :: 1
Çıxış :: "Bir".*/
#region
/*public class Kata
{
    public static string SwitchItUp(int number)
    {
        switch (number)
        {
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";



        }
        return "Nine";
    }
}*/
#endregion

/*Metodun misaldakikimi islemesini temin edin (input 5 output -5, input -3 output 3)*/
#region
/*public class Kata
{
    public static int Opposite(int number)
    {
        if (number == -Math.Abs(number))
        {
            return Math.Abs(number);
        }
        return -Math.Abs(number);
    }
}*/
#endregion

/*Bu tapşırıqda sizdən üçbucağın iki daxili bucağının dərəcə ilə verildiyini nəzərə alaraq, üçüncü bucağı tapmaq üçün bir funksiya yazmağınızı istəyirlər.
Üçbucağın daxili bucaqlarının cəmi 180 dərəcə olduğuna görə, üçüncü bucağı tapmaq üçün verilmiş iki bucağı toplamaq və 180 dərəcədən çıxmaq lazımdır.*/
#region
/*public static class Kata
{

    public static int OtherAngle(int a, int b)
    {
        int derece = 180;
        int results = 0;
        results = a + b;

        return derece - results;
    }
}*/
#endregion

/*Bir metod yaz strin gebul elesin ve geriye string donsun , gebul etdiyi textin boyuk herflerini kicik , kicikleri ise boyuk elesin */
#region
/*public static class StringExt
{
    public static string ToAlternatingCase(this string s)
    {
        char[] chars = s.ToCharArray();
        string results = null;
        foreach (char c in chars)
        {
            if (char.IsUpper(c))
            {
                results += c.ToString().ToLower();
            }
            else if (char.IsLower(c))
            {
                results += c.ToString().ToUpper();

            }
            else
            {
                results += c;
            }

        }
        return results;
    }
}*/
#endregion
/*Bob avtobus sürücüsü işləyir. Bununla belə, o, şəhər sakinləri arasında son dərəcə populyarlaşdı. Onun avtobusuna minmək
 * istəyən bu qədər sərnişinlə o, bəzən avtobusda kifayət qədər yer qalmaması problemi ilə üzləşməli olur! O istəyir ki, bütün
 * sərnişinləri sığdıra biləcəyini söyləyən sadə bir proqram yazasınız.

Tapşırıqlara Baxış:
Üç parametri qəbul edən funksiya yazmalısınız:

capsürücü istisna olmaqla, avtobusun tuta biləcəyi insanların sayıdır.
onsürücü istisna olmaqla avtobusda olan insanların sayıdır.
waitsürücü istisna olmaqla, avtobusa minmək üçün gözləyən insanların sayıdır.
Kifayət qədər yer varsa, 0-ı qaytarın, yoxdursa, götürə bilmədiyi sərnişinlərin sayını qaytarın.*/
#region
/*
    public static class Kata
    {

        public static int Enough(int cap, int on, int wait)
        {
            int res = 0;
            res += cap - on;
            if (wait >= res)
            {
                return wait - res;

            }
            else
            {
                return 0;
            }
            return res;
        }

    }*/
#endregion
/*Funksiyanız iki arqument alır:
hazırkı ata yaşı (illər)
oğlunun indiki yaşı (il)
Atanın neçə il əvvəl oğlundan iki dəfə böyük olduğunu hesablayın (yaxud neçə ildən sonra iki dəfə böyük olacaq). Cavab keçmişdə və
ya gələcəkdə olmasından asılı olmayaraq həmişə 0-dan böyük və ya bərabərdir.*/
#region
/* public class TwiceAsOldSolution
    {
        static int results = 0;
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            results = sonYears*2-dadYears ;
            
            if (results == -Math.Abs(results))
            {
                results=  Math.Abs(results);
            }
            return results;
        }
      
    }*/
#endregion

/*Tarakan ən sürətli böcəklərdən biridir. Sürətini saatda km ilə alan və onu saniyədə sm ilə qaytaran, tam ədədə yuvarlaqlaşdırılan funksiya yazın.*/
#region
/*public class Cockroach
    {
        static double result = 0;
        public static int CockroachSpeed(double x)
        {
            result = x* 27.78;
            return (int)result;

        }
    }*/
#endregion
/*Metodun parametirine daxil edilen textte eyer kicik her varsa False donsun, yox eyer hamisi boyukdurse true donsun*/
#region

/*
    public static class StringExtensions
    {
        
        public static bool IsUpperCase(this string text)
        {
             char[] chars = text.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsLower(c))
                {
                    return false;
                }
                else
                {
                     chars.ToString();
                }

            }
            return true;
        }
    }*/
#endregion
 