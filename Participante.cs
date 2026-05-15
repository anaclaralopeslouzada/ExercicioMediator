using System;

namespace ChatMediator {
    public class Participante : Usuario {
        public Participante(IChatMediator mediador, string nome) : base(mediador, nome) { }

        public override void Enviar(string mensagem) {
            Console.WriteLine($"\n>>> {Nome} enviando: {mensagem}");
            _mediador.EnviarMensagem(mensagem, this);
        }

        public override void Receber(string mensagem, string deQuem) {
            Console.WriteLine($"[{Nome} recebeu de {deQuem}]: {mensagem}");
        }
    }
}