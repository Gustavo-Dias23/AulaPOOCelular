namespace AulaPOOCelular
{
    public class celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public string Ligar(){
            if(ligado){
                return "O celular ja esta ligado.";
            }
            else{
                return "Ligando...";
            }
                      
        }  
        public string Desligar(){
            if(ligado)
            {
                return "Desligando...";
            }
            else{
                return "O celular já está desligado.";
            }
        }
        public string FazerLigacao(){
            if(!ligado){
                return "Nao e possivel fazer uma ligacao com o celular desligado.";
            }
            else{
                return "Chamando...";
            }
        }
        public string EnviarMensagem(){
            if(ligado){
            return "Mensagem enviada.";
            }
            else{
                return "Nao e possivel enviar mensagem com o celular desligado.";
            }
    }
    }
}