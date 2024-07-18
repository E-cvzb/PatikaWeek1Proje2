Console.WriteLine("Fiyatını öğrenmek istediğiniz meyveyi belirtiniz(elma,armut,çilek,muz,diğer )"); 
string meyveler= Console.ReadLine().ToLower();// kullanıcını yazadığı kelimeleri küçük harf algılamak için tolower yapısını kullandım

if (meyveler == "çilek")
{

    Console.WriteLine("Çilek ürünün fiyatı 5 TL dır.");
}
else if (meyveler == "elma")
{
    Console.WriteLine("Elma ürünün fiyatı 8 TL dır.");
}
else if (meyveler == "muz")
{
    Console.WriteLine("Muz ürünün fiyatı 4 TL dır.");
}
else if (meyveler == "armut")
{
    Console.WriteLine("Armut ürünün fiyatı 8 TL dır");
}
else if (meyveler=="diğer")
    {

    Console.WriteLine("Diğer meyvelerin fiyat bilgisi bulunmamakta.");
}
else
{
    Console.WriteLine("Geçersiz giriş yaptınız");
}

//if ile yaptğım kod dilimini switch ile alt tarafta yaptım 



Console.WriteLine("Lütfen bilgi almak istediğiniz meyveyi belirtiniz(çilek,muz,armut,elma,diğer)");
 string meyveler1= Console.ReadLine().ToLower();

switch (meyveler1)
{
    case "çilek":
        Console.WriteLine("Çilek ürünün fiyatı 5 Tl dır");
        break;
    case "elma":
        Console.WriteLine("Elma ürünün fiyatı 8 Tl dır.");
        break;
    case "armut":
        Console.WriteLine("Armut ürünün fiyatı 4 TL dır");
            break;
    case "muz":
        Console.WriteLine("Muz ürünün fiyatı 8 TL dır");
        break;
    case "diğer":
        Console.WriteLine("Diğer meyvelerin fiyat bilgisi bulunmaktadır");
        break;
    default:
        Console.WriteLine("Geçersiz giriş yaptınız");
        break;  



}

