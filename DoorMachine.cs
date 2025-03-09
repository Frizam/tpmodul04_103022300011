using System;

namespace tpmodul4_103022300011
{
    class DoorMachine
    {
        // Enum untuk merepresentasikan state pintu
        public enum DoorState
        {
            Terkunci,
            Terbuka
        }
        private DoorState currentState;

        // Konstruktor dengan state awal "Terkunci"
        public DoorMachine()
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        // Method untuk membuka pintu
        public void BukaPintu()
        {
            if (currentState == DoorState.Terkunci)
            {
                Console.WriteLine("(Membuka pintu)");
                currentState = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka!");
            }
        }

        // Method untuk mengunci pintu
        public void KunciPintu()
        {
            if (currentState == DoorState.Terbuka)
            {
                Console.WriteLine("(Mengunci pintu)");
                currentState = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci!");
            }
        }
    }
}
