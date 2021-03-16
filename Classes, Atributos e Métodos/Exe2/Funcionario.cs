using System.Globalization;
namespace Exe2
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double p){
            SalarioBruto = SalarioBruto + (SalarioBruto * p / 100.0);
        }

        public override string ToString() {
        return Nome
        + ", R$ "
        + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}