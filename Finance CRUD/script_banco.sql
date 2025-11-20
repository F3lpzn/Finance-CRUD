CREATE DATABASE FinanceDB;
GO

USE FinanceDB;
GO

CREATE TABLE Lancamentos (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Descricao VARCHAR(100) NOT NULL,  
    Valor DECIMAL(18, 2) NOT NULL,    
    DataLancamento DATETIME NOT NULL, 
    Tipo VARCHAR(20) NOT NULL         
);
GO