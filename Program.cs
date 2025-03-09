// See https://aka.ms/new-console-template for more information
using tpmodul4_103022300011;


Console.Write("Masukkan nama kelurahan: ");
string inputKelurahan = Console.ReadLine();
if (Enum.TryParse(inputKelurahan, out KodePos.Kelurahan daerah)) //untuk mengkonvert inputan kedalam enum
{
    string kodePos = KodePos.GetKodePos(daerah);
    Console.WriteLine("Kode Pos " + inputKelurahan + ": " + kodePos);
}
else {
    Console.WriteLine("Kode Pos " + inputKelurahan + " tidak ditemukan");
}


DoorMachine door = new DoorMachine(); //di set "Terkunci" door state nya
string perintah;

//menu perintah
Console.WriteLine("\nPerintah yang tersedia: ");
Console.WriteLine("- 'BukaPintu' : Untuk membuka pintu");
Console.WriteLine("- 'KunciPintu': Untuk mengunci pintu");
Console.WriteLine("- 'exit'      : Untuk keluar dari program");

while (true)
{
    Console.Write("Masukkan perintah: ");
    perintah = Console.ReadLine();

    //membandingkan apakah inputan perintah sesuai dengan perintah yang tersedia
    if (perintah.Equals("exit", StringComparison.OrdinalIgnoreCase)) 
    {
        Console.WriteLine("Program selesai.");
        break;
    }
    else if (perintah.Equals("BukaPintu", StringComparison.OrdinalIgnoreCase))
    {
        door.BukaPintu(); //door state "Terbuka"
    }
    else if (perintah.Equals("KunciPintu", StringComparison.OrdinalIgnoreCase))
    {
        door.KunciPintu(); //door state "Terkunci"
    }
    else
    {
        Console.WriteLine("Perintah tidak dikenali. Coba lagi.");
    }
}