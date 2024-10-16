namespace WeaponLine;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("gulle tutumunu yazin: ");
        int gulletutumu = int.Parse(Console.ReadLine());

        Console.WriteLine("gulle sayini yazin: ");
        int gullesayi = int.Parse(Console.ReadLine());

        Console.WriteLine("bosalma muddetini yazin (saniye): ");
        int bosalmamuddeti = int.Parse(Console.ReadLine());


        WeaponLine kalasnikov = new WeaponLine(gulletutumu, gullesayi, bosalmamuddeti);

        Console.WriteLine("""

            0 - İnformasiya almaq üçün
            1 - Shoot üçün
            2 - Fire üçün
            3 - GetRemainBulletCount üçün
            4 - Reload üçün
            5 - ChangeFireMode üçün
            6 - Proqrami dayandirmaq üçün

         """);

        bool flag = true;

        while (flag)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 0:
                    kalasnikov.Info();
                    break;
                case 1:
                    kalasnikov.Shoot();
                    break;
                case 2:
                    kalasnikov.Fire();
                    break;
                case 3:
                    kalasnikov.GetRemainBulletCount();
                    break;
                case 4:
                    kalasnikov.Reload();
                    break;
                case 5:
                    kalasnikov.ChangeFireMode();
                    break;
                case 6:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("duzgun reqem yazin");
                    Console.WriteLine("""

                        0 - İnformasiya almaq üçün
                        1 - Shoot üçün
                        2 - Fire üçün
                        3 - GetRemainBulletCount üçün
                        4 - Reload üçün
                        5 - ChangeFireMode üçün
                        6 - Proqrami dayandırmaq üçün

                     """);
                    break;
            }
        }
    }
}