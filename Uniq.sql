CREATE TABLESPACE TCC
DATAFILE 'C:\Users\Shadow\Documents\TCC\UNIQ\TCC_CODIGO\01.DBF'
SIZE 1M AUTOEXTEND ON MAXSIZE 10M ONLINE;

CREATE USER UNIQ IDENTIFIED BY LUMIEL
DEFAULT TABLESPACE TCC
TEMPORARY TABLESPACE TEMP
ACCOUNT UNLOCK;

drop user UNIQ;

Grant all privileges to  UNIQ;

CREATE TABLE  TB_CLIENTE(
Id_Cliente INTEGER PRIMARY KEY NOT NULL,
Nome_Cliente VARCHAR2(100) NOT NULL,
Nasc_Cliente VARCHAR2(10) NOT NULL,
RG_Cliente VARCHAR2(13) NOT NULL,
CPF_Cliente VARCHAR2(14) NOT NULL,
Endereço_Cliente VARCHAR2(100) NOT NULL,
Email_Cliente VARCHAR2(100) NOT NULL,
Senha_Cliente VARCHAR2(20) NOT NULL,
User_Cliente VARCHAR2(50) NOT NULL,
Status_Cliente VARCHAR2(10) DEFAULT('Ativo') 
);

CREATE TABLE TB_Curso(
ID_Curso integer primary key not null,
Nome_Curso varchar2(50) not null,
Duração_Curso varchar2(20) not null,
Cargos_Curso varchar2(500) not null,
Localização_Curso varchar2(500) not null,
Financiamento_Curso varchar2(50) not null,
Descrição_Curso varchar2(1000) not null,
Tipo_Curso varchar2(100) not null);


CREATE TABLE TB_FUNCIONARIOS(
ID_Func integer primary key not null,
Nome_Func varchar2(50) not null,
Cargo_Func varchar2(100) not null,
RG_Func varchar2(12) not null,
CPF_Func varchar2(12) not null,
Endereço_Func varchar2(1000) not null,
Email_Func varchar2(100) not null,
Nasc_Func varchar2(10) not null,
Titulo_Func varchar2(14) not null,
Salario_Func varchar2(50) not null,
Contrato_Func varchar2(50) not null,
Sexo_Func varchar2(50) not null);


CREATE TABLE TB_Faculdade(
ID_Facul integer primary key not null,
Nome_Facul varchar2(50) not null,
Ranking_Facul varchar2(20) not null,
Localização_Facul varchar2(50) not null,
Financiamento_Facul varchar2(20) not null,
Tipo_Facul varchar2(50) not null,
Graduação_Facul varchar2(30) not null,
Descrição_Facul varchar2(100) not null
)

CREATE TABLE TB_CONTAS(
ID_Conta integer primary key not null,
Nome_Conta varchar2 (30) not null,
Valor_Conta varchar2 (10) not null,
Responsavel_Conta varchar2 (50) not null,
Validade_Conta varchar2 (10) not null
)

CREATE TABLE CONTAS_RECEBER(
ID_RECIBO INTEGER PRIMARY KEY NOT NULL,
NOME_RECIBO  VARCHAR2 (30)NOT NULL,
VALOR_RECIBO VARCHAR2(10)NOT NULL,
PRAZO_RECIBO VARCHAR2(10)NOT NULL,
FORM_RECIBO VARCHAR2 (25)NOT NULL
)

CREATE SEQUENCE SEQ_TBFACULDADE START WITH 1

CREATE SEQUENCE SEQ_TBRECIBO START WITH 1

CREATE SEQUENCE SEQ_TBFUNCIONARIO START WITH 1;

CREATE SEQUENCE SEQ_TBCURSO START WITH 1;

CREATE SEQUENCE SEQ_TBCLIENTE START WITH 1;

CREATE SEQUENCE SEQ_TBCONTAS START WITH 1;

select * from TB_FACULDADE;

SELECT * FROM TB_CLIENTE;

SELECT * FROM TB_FUNCIONARIOS;

SELECT * FROM TB_CURSO;

SELECT * FROM TB_CONTAS;

SELECT * FROM CONTAS_RECEBER;

DROP TABLE TB_FACULDADE;

DROP TABLE TB_FUNCIONARIOS;

DROP TABLE CONTAS_RECIBO;

DROP TABLE TB_CLIENTE;

DROP TABLE TB_CURSO;

DROP TABLE TB_CONTAS;

ALTER TABLE TB_CLIENTE ADD STATUS_CLIENTE CHAR DEFAULT (1) ;

ALTER TABLE TB_CLIENTE ADD DTCAD_CLIENTE DATE DEFAULT SYSDATE ;

ALTER TABLE TB_CONTAS ADD PAGAMENTO VARCHAR2 (50);

UPDATE TB_Faculdade SET
Nome_Facul= 'ok',
Ranking_Facul='ok',
Localização_Facul='ok',
Financiamento_Facul='ok',
Tipo_Facul='ok',
Graduação_Facul='ok',
Descrição_Facul='ok'
WHERE Nome_Facul='ok'

UPDATE TB_CLIENTE SET
Nome_Cliente='Test ol',
Nasc_Cliente='11/11/1111',
RG_Cliente='11,111,111-1',
Endereço_Cliente='resr',
Email_Cliente='test',
User_Cliente='test'
WHERE CPF_CLIENTE='111111111-11'

 

UPDATE TB_Faculdade SET 
Nome_Facul='j',
Ranking_Facul='',
Localização_Facul='ok',
Financiamento_Facul='ok',
Tipo_Facul='ok',
Graduação_Facul='ok', 
Descrição_Facul='ok'
WHERE Nome_Facul='ok'

UPDATE TB_Curso SET 
Nome_Curso='jose', 
Duração_Curso='ok', 
Cargos_Curso='ok', 
Localização_Curso='ok',
Financiamento_Curso='ok',
Descrição_Curso='ok', 
Tipo_Curso='ok' WHERE Nome_Curso='ok'

UPDATE TB_Curso SET 
Nome_Curso='ok',
Duração_Curso='ok',
Cargos_Curso='ok',
Localização_Curso='ok',
Financiamento_Curso='ok',
Descrição_Curso='ok',
Tipo_Curso='ok'
WHERE Nome_Curso='ok'

UPDATE TB_Curso SET
Nome_Curso='eletronica',
Duração_Curso='3 anos', 
Cargos_Curso='Eletronico', 
Localização_Curso='Mutinga', 
Financiamento_Curso='Pago',
Descrição_Curso='Chuveiro', 
Tipo_Curso='A distancia'
WHERE Nome_Curso='eletronica'

UPDATE TB_CONTAS SET 
Nome_Conta= 'luz', 
Valor_Conta='102,00',
Responsavel_Conta='Brenda',
Validade_Conta='11/09/2002',
Pagamento='Cartao'
WHERE Nome_Conta ='luz'



UPDATE TB_Faculdade SET Nome_Facul= 'ok', Ranking_Facul='ok',Localização_Facul='ok',Financiamento_Facul='ok', Tipo_Facul='ok', Graduação_Facul='ok', Descrição_Facul='ok' WHERE Nome_Facul='ok'

INSERT INTO TB_FUNCIONARIOS(ID_Func,Nome_Func,Cargo_Func,RG_Func,CPF_Func,Endereço_Func,Email_Func,Nasc_Func,Titulo_Func,Salario_Func,Contrato_Func,Sexo_Func)VALUES (SEQ_TBFUNCIONARIO.NEXTVAL,'Test','test','11,111,111-1','111111111-11','test','test','11/11/1111','1111 1111 1111','test','test','test')

UPDATE TB_FUNCIONARIOS SET Nome_Func='João Belarmino dos Santos d',Cargo_Func='Ferreirod',RG_Func='33,333,223-3',CPF_Func='333333333-33',Endereço_Func='Itapevid',Email_Func='joao@gmail.comd',Nasc_Func='33/22/3333',Titulo_Func='3333 3322 3333',Salario_Func='2522,00',Contrato_Func='ABF001d',Sexo_Func= 'Masculino' WHERE CPF_Funci='333333333-33'

UPDATE TB_CONTAS SET Nome_Conta= 'Luz', Valor_Conta='1200,00',Responsavel_Conta='Lucasss',Validade_Conta='22/12/2017',PAGAMENTO='Boletoss'WHERE Nome_Conta ='Luz'

INSERT INTO TB_FUNCIONARIOS(ID_Func,Nome_Func,Cargo_Func,RG_Func,CPF_Func,Endereço_Func,Email_Func,Nasc_Func,Titulo_Func,Salario_Func,Contrato_Func,Sexo_Func)VALUES (SEQ_TBFUNCIONARIO.NEXTVAL,'Lucas Neves Santos Barbosa','Gerente de programação','39,217,510-1','489829498-79','Rua Elza Ghedini/ JD. Gabriela 1 / Jandira/SP','lucas_meupaijair@hotmail.com','27/09/2001','9538 7196 4876','R$6500,00','AMF6681','Masculino')