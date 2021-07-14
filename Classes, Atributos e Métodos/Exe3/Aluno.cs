namespace Exe3
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal(){
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovacao(){
            if (NotaFinal() >= 60.0){
                return true;
            }
            else{
                return false;
            }
        }

        public double NotaRestante(){
            return 60.0 - NotaFinal();
        }
    }
}