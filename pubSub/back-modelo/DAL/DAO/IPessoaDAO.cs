using System.Collections.Generic;
using back_modelo.DAL.Models;

namespace back_modelo.DAL.DAO
{
    public interface IPessoaDAO
    {
        List<Pessoa> ObterPessoas();
        Pessoa ObterPessoaPorId(string idPessoa);
        Pessoa ObterPessoaPorCPF(string cpf);
        List<Pessoa> ObterPessoasPorCor(string cor);
        int ObterTotalPessoas();
        void InserirPessoa(Pessoa novaPessoa);
        void AtualizarPessoa(string idPessoa, Pessoa novaPessoa);
        void DeletarPessoa(string idPessoa);
    }
}