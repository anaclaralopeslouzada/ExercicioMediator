using System.Collections.Generic;

namespace ChatMediator {
    public class SalaDeChat : IChatMediator {
        private List<Usuario> _usuarios = new List<Usuario>();

        public void AdicionarUsuario(Usuario usuario) {
            _usuarios.Add(usuario);
        }

        public void EnviarMensagem(string mensagem, Usuario remetente) {
            foreach (var u in _usuarios) {
                if (u != remetente) {
                    u.Receber(mensagem, remetente.Nome);
                }
            }
        }
    }
}