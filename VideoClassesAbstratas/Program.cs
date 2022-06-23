using VideoClassesAbstratas;

var moto1 = new Moto();
var carro1 = new Carro();

moto1.Ligar();

Console.WriteLine("Limpar moto1");
LimparVeiculo(moto1);

Console.WriteLine("Limpar carro1");
LimparVeiculo(carro1);

Console.WriteLine("Buzinar moto1");
ApertarBuzina(moto1);

Console.WriteLine("Buzinar carro1");
ApertarBuzina(carro1);

void LimparVeiculo(Veiculo veiculo)
{
    if (veiculo.Ligado)
    {
        Console.WriteLine("Por favor desligue o veículo");
    }
    else
    {
        Console.WriteLine("Iniciando limpeza");
    }
}

void ApertarBuzina(Veiculo veiculo)
{
    Console.WriteLine($"Veículo buzinando: {veiculo.Buzinar()}");
}