



/*ATM maşınları 4 və ya 6 rəqəmli PİN kodlara icazə verir və PİN kodlar tam 4 və ya 6 rəqəmdən başqaheç nə
 ehtiva edə bilməz. Funksiya etibarlı PIN sətrini ötürübsə, qaytarın true, əks halda qaytarın false*/
#region 
//public class Kata
//{
//    public bool ValidatePin(string pin)
//    {
//        if (pin.Length != 6 && pin.Length != 4) return false;
//        return true;



//    }
//}

#endregion

/*Sətirdə eyni miqdarda "x" və "o" hərflərinin olub olmadığını yoxlayın.
Metod boolean qaytarmalı və hərflərə həssas olmalıdır. Sətirdə istənilən simvol ola bilər.*/
#region

//public class Kata
//{
//    public bool XO(string input)
//    {
//        int Xcount = 0;
//        int Ocount = 0;

//        foreach (char item in input)
//        {
//            if (item == 'x' || item == 'X')
//            {
//                Xcount++;

//            }
//            else if (item == 'o' || item == 'O')
//            {

//                Ocount++;
//            }
//        }
//        return Xcount == Ocount;

//    }
//}
#endregion

/*Sadə, bir sıra sözlər verildikdə, ən qısa söz(lər)in uzunluğunu qaytarın.*/
#region
//public static class Kata
//{
//    public static int FindShort(string s)
//    {
//        if (s == null) { return 0; }
//        string[] sozler = s.Split(' ');
//        int minsoz = sozler.Min(x => x.Length);
//        return minsoz;
//    }
//}

#endregion

/*Timmy və Sarah aşiq olduqlarını düşünürlər, lakin yaşadıqları yerdən yalnız hər biri bir çiçək götürdükdən sonra biləcəklər.
 Çiçəklərdən birinin ləçəkləri cüt, digərinin isə tək sayda ləçəkləri varsa, deməli, onlar aşiqdirlər.
Hər bir çiçəyin ləçəklərinin sayını götürəcək və aşiq olduqda doğru, sevmədikdə isə yalana dönəcək funksiya yazın.*/
#region
//public class LoveDetector
//{
//    public bool LoveFunc(int flower1, int flower2)
//    {
//        // Çiçəklərin ləçəklərinin sayı cüt və ya tək olduğunu yoxlayın
//        bool flower1IsEven = flower1 % 2 == 0;
//        bool flower2IsEven = flower2 % 2 == 0;

//        // Şərtləri yoxlayın: biri cüt, digəri isə tək olmalıdır
//        return flower1IsEven != flower2IsEven;
//    }
//}
#endregion

/*Tam ədədlərin boş olmayan massivini nəzərə alaraq, dəyərləri ardıcıllıqla birlikdə vurmağın nəticəsini qaytarın.*/
#region
//public class Kata
//{
//    public static int Grow(int[] x)
//    {
//        int cvb = 1;
//        foreach (var i in x)
//        {

//            cvb *= i;
//        }
//        return cvb;

//    }
//}

#endregion
/*Rəqəmlər toplusunu nəzərə alaraq, hər birinin əksini qaytarın. Hər bir müsbət mənfi, mənfi isə müsbət olur.*/
#region
//public static class ArraysInversion
//{
//    public static int[] InvertValues(int[] input)
//    {
//        return input.Select(x => -x).ToArray();
//    }
//}

#endregion

/*gecə yarısından sonra saat, dəqiqə və saniyələri millisekundlara çevirmək üçün bir funksiya yazmaq lazimdir.
 Verilən h, m, və s dəyişənləri əsasında vaxtı millisekundlarda hesabla (h-saat, m-degige, s-saniyedir) */
#region

//public static class Clock
//{
//    static int results = 0;
//    public static int Past(int h, int m, int s)
//    {
//        int saat = h * 60 * 60 * 1000;
//        int degige = m * 60 * 10 * 10 * 10;
//        int saniye = s * 1000;
//        results = saat + degige + saniye;
//        return results;


//    }
//}

#endregion


/*Sinifinizdə imtahan var idi və siz ondan keçdiniz. Təbrik edirik!
Amma siz iddialı insansınız. Sinifinizdəki orta şagirddən daha yaxşı olub-olmadığınızı bilmək istəyirsiniz.
Siz həmyaşıdlarınızın test balları ilə bir sıra alırsınız. İndi ortalamanı hesablayın və xalınızı müqayisə edin!
trueƏgər daha yaxşısınızsa, geri qayıdın , əks halda false!
Qeyd:
Sizin xallarınız sinifinizin balları sırasına daxil edilmir. Orta balı hesablayarkən onları unutma!*/
#region
//public class Kata
//{


//    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
//    {
//        int count = ClassPoints.Length;
//        int sum = 0;
//        foreach (var item in ClassPoints)
//        {

//            sum += item;


//        }
//        var result = sum / count;
//        return result < YourPoints;

//    }
//}


#endregion

/*Tam ədədlərin siyahısını verərək, onun elementlərinin cəminin tək və ya cüt olduğunu müəyyənləşdirin.
Cavabınızı sətir uyğunluğu "odd"və ya kimi verin "even".
Əgər giriş massivi boşdursa, onu belə hesab edin: [0](sıfır olan massiv).*/
#region

//public class Kata
//{
//    public static string OddOrEven(int[] array)
//    {
//        int result = 0;
//        foreach (int i in array)
//        {
//            result += i;
//        }
//        if (result % 2 == 0)
//        {
//            return "even";
//        }
//        return "odd";
//    }

//}
#endregion
