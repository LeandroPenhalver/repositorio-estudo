﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEventoCommand : BaseEventoCommand
    {
        public AtualizarEventoCommand(
            Guid id,
            string nome,
            string descricaoCurta,
            string descricaoLonga,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valor,
            bool online,
            string nomeEmpresa,
            Guid organizadorId,
            Endereco endereco,
            Guid categoriaId)
        {
            Id = id;
            Nome = nome;
            DescricaoCurta = descricaoCurta;
            DescricaoLonga = descricaoLonga;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;
            OrganizadorId = organizadorId;
            Endereco = endereco;
            CategoriaId = categoriaId;
        }
    }
}
