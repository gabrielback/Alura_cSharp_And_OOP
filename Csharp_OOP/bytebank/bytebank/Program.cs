using bytebank.Contas;
using bytebank.Titular;

Cliente cliente1 = new Cliente("Carlos", "062.138.939-32", "Programador", "cc202-meT");
ContaCorrente cc1 = new ContaCorrente(cliente1,"00058223-1","3948-1",1235.55);

Console.WriteLine(cc1);

Cliente cliente2 = new Cliente("Diego", "038.762.199-36", "Professor", "cc203-meT");
ContaCorrente cc2 = new ContaCorrente(cliente2, "00058359-1", "1536-1", 1000);
//ContaCorrente cc2 = cc1; // Apontando para o mesmo endereço de memória cc1, portanto todas as alterações refletidas na cc2 serão modificadas em cc1

Console.WriteLine(cc2);

cc1.Transferir(380, cc2);

Console.WriteLine(cc1);
Console.WriteLine(cc2);

Console.WriteLine("Contas criadas: " + ContaCorrente.TotalContasCriadas);

Cliente cliente4 = new Cliente("Diego", "038.762.199-36", "Professor", "cc203-meT");
ContaCorrente cc4 = new ContaCorrente(cliente2, "00058359-1", "1536-1", 1000);

Console.WriteLine("Contas criadas: "+ContaCorrente.TotalContasCriadas);

Console.ReadKey();