namespace WeaponLine;

class WeaponLine
{
    private int _gulletutumu;
    private int _gullesayi;
    private int _bosalmamuddeti;
    private bool _atismodu = false;

    public WeaponLine(int gulletutumu1, int gullesayi1, int bosalmamuddeti1)
    {
        gulletutumu = gulletutumu1;
        gullesayi = gullesayi1;
        bosalmamuddeti = bosalmamuddeti1;
    }

    public void Info()
    {
        string mode;
        if (_atismodu)
            mode = "avtomatik";
        else
            mode = "tekli";
        Console.WriteLine("gulle tutumu: " + _gulletutumu + "\ngulle sayi: " + _gullesayi + "\nbosalma muddeti: " + _bosalmamuddeti + " saniye" + "\natis modu: " + mode);
    }

    public int gulletutumu
    {
        get { return _gulletutumu; }
        set
        {
            if (value > 0)
            {
                _gulletutumu = value;
            }
            else
            {
                Console.WriteLine("gulle tutumuna menfi eded ve ya 0 daxil etmisiniz. buna gorede gulle tutumu 10 olaraq goturulecek");
                _gulletutumu = 10;
            }
        }
    }
    public int gullesayi
    {
        get { return _gullesayi; }
        set
        {
            if (value >= 0 && value <= _gulletutumu)
            {
                _gullesayi = value;
            }
            else
            {
                Console.WriteLine("gulle sayina menfi ve ya gulle tutumundan boyuk eded daxil etmisiniz. buna gorede gulle sayi 0 olaraq goturulecek");
            }
        }
    }
    public int bosalmamuddeti
    {
        get { return _bosalmamuddeti; }
        set
        {
            if (value > 0)
            {
                _bosalmamuddeti = value;
            }
            else
            {
                Console.WriteLine("bosalma muddetine menfi eded ve ya 0 daxil etmisiniz. buna gorede bosalma muddeti 1 saniye olaraq goturulecek");
                _bosalmamuddeti = 1;
            }
        }
    }
    public bool atismodu
    {
        get { return _atismodu; }
        set { _atismodu = value; }
    }



    public void Shoot()
    {
        if (_gullesayi > 0)
        {
            _gullesayi--;
            Console.WriteLine("ates acildi");
        }
        else
        {
            Console.WriteLine("gulle bitib, reload ele");
        }
    }
    public void Fire()
    {
        if (_atismodu)
        {
            if (_gullesayi > 0)
            {
                Console.WriteLine("gulle " + 1.0 * _gullesayi / _gulletutumu * _bosalmamuddeti + " saniyeye bitdi");
                _gullesayi = 0;
            }
            else
            {
                Console.WriteLine("gulle bitib, reload ele");
            }
        }
        else
        {
            Console.WriteLine("atis modunu deyisin");
        }
    }
    public void GetRemainBulletCount()
    {
        Console.WriteLine(_gulletutumu - _gullesayi);
    }

    public void Reload()
    {
        _gullesayi = _gulletutumu;
        Console.WriteLine("darag dolduruldu");
    }

    public void ChangeFireMode()
    {
        _atismodu = !_atismodu;
    }
}