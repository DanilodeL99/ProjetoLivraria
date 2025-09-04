-- 	CRIANDO O BANCO DE DADOS
CREATE DATABASE BDLivraria;

-- USANDO BANCO DE DADOS
USE BDLivraria;
-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbPedido(
	codPedido int primary key auto_increment,
    nomeLivro varchar(50),
    valorLivro varchar(50),
    valorOpcao varchar(50),
    valorTotal varchar(50)
);

-- CONSULTANDO BANCO DE DADOS

SELECT * FROM tbPedido;