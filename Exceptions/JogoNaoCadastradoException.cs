using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException: Exception    {
        public JogoNaoCadastradoException()
    : base("Este Jogo não está cadastrado")
        { }
    }
}
