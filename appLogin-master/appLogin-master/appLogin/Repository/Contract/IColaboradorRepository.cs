﻿using appLogin.Models;

namespace appLogin.Repository.Contract
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);
        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void AtualizarSenha(Colaborador colaborador);

        void Excluir(int Id);
        Colaborador ObterColaborador(int Id);

        List<Colaborador> ObterColaboradorPorEmail(string Email);

        IEnumerable<Colaborador> ObterTodosColaboradors();
    }
}
