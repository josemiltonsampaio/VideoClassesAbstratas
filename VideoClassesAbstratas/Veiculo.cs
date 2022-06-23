namespace VideoClassesAbstratas;
public abstract class Veiculo
{
    public int NivelCombustivel { get; set; }
    public bool Ligado { get; set; }
    public void Ligar() => Ligado = true;
    public void Desligar() => Ligado = false;
    public virtual string Buzinar() => "FOM-FOM";
    public bool EstaLigado() => Ligado;

}

public class Moto : Veiculo
{
    public override string Buzinar()
    {
        return "BI-BI";
    }
}

public class Carro : Veiculo
{

}

//public abstract class Veiculo
//{
//    public int NivelCombustivel { get; set; }
//    public bool Ligado { get; set; }
//    public abstract void Ligar();
//    public abstract void Desligar();
//    public abstract string Buzinar();
//    public bool EstaLigado() => Ligado;

//}
//public class Moto : Veiculo
//{
//    public override string Buzinar() => "BI-BI";
//    public override void Desligar() => Ligado = false;
//    public override void Ligar() => Ligado = true;
//}

//public class Carro : Veiculo
//{
//    public override string Buzinar() => "FOM-FOM";
//    public override void Desligar() => Ligado = false;
//    public override void Ligar() => Ligado = true;
//}