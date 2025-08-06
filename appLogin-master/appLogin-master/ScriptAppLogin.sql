create database LoginCore;
use LoginCore;

create table Cliente(
id int auto_increment primary key,
nome varchar(50) not null,
Nascimento DateTime not null,
Sexo Char(1),
CPF Varchar(11) not null,
Telefone varchar(14) not null,
Email varchar(50) not null,
Senha varchar(8) not null,
ConfirmacaoSenha varchar(8) not null,
Situacao char(1) not null);

create table Colaborador(
id int auto_increment primary key,
Nome varchar(50) not null,
Email Varchar(8) not null,
Senha varchar(8) not null, 
Tipo varchar(8) not null
);
