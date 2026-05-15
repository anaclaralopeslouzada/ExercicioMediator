using System;

namespace ChatMediator {
    class Program {
        static void Main(string[] args) {
            IChatMediator sala = new SalaDeChat();

            Usuario u1 = new Participante(sala, "Ana Clara");
            Usuario u2 = new Participante(sala, "Isabella");
            Usuario u3 = new Participante(sala, "Professor Fabio");
            

            sala.AdicionarUsuario(u1);
            sala.AdicionarUsuario(u2);
            sala.AdicionarUsuario(u3);

            u1.Enviar("Oi pessoal, como vocês estão?");
            u2.Enviar("Olá! Vou bem e você?");
            u1.Enviar("Vou bem também, você sabe o que iremos implementar na aula de hoje?");
            u3.Enviar("Olá pessoal! Hoje iremos implementar o Padrão Mediator em uma simulação de chat. Bora!");
        }
    }
}
