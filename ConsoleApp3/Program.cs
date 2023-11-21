Random rnd = new Random();
Console.WriteLine("kac adet sayi uretilsin");
int adet = Convert.ToInt32(Console.ReadLine());
HashSet<int> sonuc = new HashSet<int>();

while (sonuc.Count < adet)
{
    sonuc.Add(rnd.Next(1, 101));
}

Console.WriteLine(String.Join(", ", sonuc));


