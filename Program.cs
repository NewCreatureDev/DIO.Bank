using DIO.Bank.System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceUsuario interfaceSistema = new InterfaceUsuario("123");
            interfaceSistema.UtilizarSistema("123");
        }

    }
}
