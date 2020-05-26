namespace AulaPOOCelular
{
    public class celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;

        public string Ligar(){
            return "Ligando...";
            
            if(ligado){
                return "O celular ja esta ligado.";
            }          
        }  
        public string Desligar(){
            return "Desligando...";

            if(!ligado){
                return "O celular ja esta desligado";
            }
        }
        public string FazerLigacao(){
            return "Chamando...";

            if(!ligado){
                return "Nao e possivel fazer uma ligacao com o celular desligado.";
            }
        }
        public string EnviarMensagem(){
            return "Mensagem enviada";
        }
    
    }
}