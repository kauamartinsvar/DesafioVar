using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

CREATE TABLE Tab_Pessoa (
    Id INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(50),
    Cpf VARCHAR(11),
	DataNascimento DATE,
  Genero VARCHAR(10),
  Endereco VARCHAR(200),
  Telefone VARCHAR(20),
  Email VARCHAR(100),
);


CREATE TABLE Tab_Conta_Corrente (
    Id INT IDENTITY PRIMARY KEY,
Id_Pessoa INT,
    Numero_Conta VARCHAR(20),
    Saldo DECIMAL(10, 2),
    FOREIGN KEY(Id_Pessoa) REFERENCES Tab_Pessoa(ID)
);


CREATE TABLE Tab_Cartao (
    Id INT IDENTITY PRIMARY KEY,
Id_Pessoa INT,
    Numero_Cartao VARCHAR(16),
    Data_Validade DATE,
    Cvv INT,
    FOREIGN KEY (Id_Pessoa) REFERENCES Tab_Pessoa(Id)
);


CREATE TABLE Tab_Saldo (
    Id INT IDENTITY PRIMARY KEY,
Id_Conta_Corrente INT,
    Saldo DECIMAL(10, 2),
    FOREIGN KEY(Id_Conta_Corrente) REFERENCES Tab_Conta_Corrente(Id)
);


CREATE TABLE Tab_Hist_Transacao (
    Id INT IDENTITY PRIMARY KEY,
    Id_Cartao INT,
    Id_Conta_Corrente INT,
    Valor_Compra DECIMAL(10, 2),
    Data_Compra DATE,
    Forma_pagamento VARCHAR(10),
    FOREIGN KEY(Id_Cartao) REFERENCES Tab_CARTAO(Id),
    FOREIGN KEY(ID_CONTA_CORRENTE) REFERENCES Tab_Conta_Corrente(Id)
);

INSERT INTO Tab_Pessoa ( NOME, CPF)
VALUES('kaua ferreira', '56025888841');


INSERT INTO Tab_Conta_Corrente ( ID_PESSOA, NUMERO_CONTA, SALDO)
VALUES(1, '1234567890', 1000.00);


INSERT INTO Tab_Cartao ( ID_PESSOA, NUMERO_CARTAO, DATA_VALIDADE, CVV)
VALUES(1, '1111222233334444', '2025-12-31', 123);


INSERT INTO Tab_Saldo ( ID_CONTA_CORRENTE, SALDO)
VALUES(1, 1000.00);


--Inserindo dados na tabela HIST_TRANSACAO
INSERT INTO Tab_Hist_Transacao (ID_CARTAO, ID_CONTA_CORRENTE, VALOR_COMPRA, DATA_COMPRA, FORMA_PAGAMENTO)
VALUES(1, 1, 200.00, '2023-06-12', 'DÉBITO')


