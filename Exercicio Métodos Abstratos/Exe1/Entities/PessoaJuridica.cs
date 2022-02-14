namespace Exe1.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int QuantFuncionario { get; set; }

        public PessoaJuridica(){
        }

        public PessoaJuridica(string nome, double rendaAnual, int quantFuncionario) : base(nome, rendaAnual)
        {
            QuantFuncionario = quantFuncionario;
        }
        public override double Imposto()
        {
            if (QuantFuncionario <= 10){
                return RendaAnual * 0.16;
            }
            else{
                return RendaAnual * 0.14;
            }
        }
    }
}