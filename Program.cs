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

