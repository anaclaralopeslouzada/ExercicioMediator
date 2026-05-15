namespace ChatMediator {
    public abstract class Usuario {
        protected IChatMediator _mediador;
        public string Nome { get; private set; }

        public Usuario(IChatMediator mediador, string nome) {
            _mediador = mediador;
            Nome = nome;
        }

        public abstract void Enviar(string mensagem);
        public abstract void Receber(string mensagem, string deQuem);
    }
}