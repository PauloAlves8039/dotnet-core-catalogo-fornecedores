using CatalogoFornecedores.Business.Notificaoes;
using System.Collections.Generic;

namespace CatalogoFornecedores.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
