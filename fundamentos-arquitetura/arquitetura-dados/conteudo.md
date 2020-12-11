# Arquitetura de Dados

## Modelo Sustentável 

- Estruturação
- Durabilidade
- Velocidade
- Controle de Acessi
- Isolamento

## Importância 

- Dados
- Informação
- Conhecimento

## SGBD - Sistema de Gerenciamento de Banco de Dados

- Linguagem de Definição

- Linguagem de Manipulação

- Dicionario de Dados

  

## Modelos de Banco de Dados

- Modelo Flat 
- Modelo Hierárquico
- Modelo Relacional 
- Redes - Grapho
- Orientado a Objetos
- Objeto - Relacional
- Big Data (Há várias características)



## Banco de Dados Relacionais (SGDBR)

### Modelagem 

- Modelo conceitual - MER
- Modelo Lógico - Implementação

### Normalização 

1ª.. 5ª Formas normais 

1, 2 e 3ª - Mais Comum

 

## SGBDR - SQL 

- DDL - Data Definition Language
- DML - Data Manipulation Language 
- DQL - Data Query Language 



## DDL 

``` sql
CREATE TABLE CLIENTE
(
    CODIGO NUMBER(10) NOT NULL PRIMARY KEY,
    NOME VARCHAR(50) NOT NULL,
    TELEFONE VARCHAR(15)
)
```



## DML

```sql
INSERT INTO CLIENTE (CODIGO,NOME,TELEFONE)
VALUES (1,"LOREM IPSUM","(88) 999 9999")

DELETE FROM CLIENTE
WHERE CODIGO = 1

UPDATE CLIENTE
SET NOME = "LOREM IPSUM"
WHERE CODIGO = 1
```



## DQL 

```sql
SELECT CODIGO,
	   NOME
FROM CLIENTE
<WHERE> CODIGO = 1
	<GROUP BY> PROFISSAO
	<HAVING> COUNT(1)>0
<ORDER BY> NOME, CODIGO
```



