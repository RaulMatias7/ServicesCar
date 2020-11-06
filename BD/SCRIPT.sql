
CREATE DATABASE  db_estacao;
GO

use db_estacao;


go

CREATE TABLE Sistema(
    id int PRIMARY key IDENTITY,
    nome VARCHAR(50) UNIQUE not NULL,
	localizacao VARCHAR(100),
    NIF VARCHAR(50),
	tel VARCHAR(20),
	email VARCHAR(50),
	logotipo image,
	num_promocao int default 10,
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

go

CREATE TABLE Servicos(
    id int PRIMARY key IDENTITY,
    nome VARCHAR(50) UNIQUE not NULL,
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

go

CREATE TABLE SubServicos(
    id int IDENTITY primary key,
    idServico int not NULL,
    modelo VARCHAR(50) not NULL,
    preco DECIMAL(11,2) DEFAULT 0,
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	unique(idServico,modelo),
    FOREIGN KEY(idServico) REFERENCES Servicos (id) on DELETE CASCADE on UPDATE CASCADE 
);

go

CREATE TABLE Funcionarios(
    id int PRIMARY key IDENTITY,
    nome VARCHAR(100) not NULL,
    username VARCHAR(25) DEFAULT NULL,
    dataN date, 
    sexo VARCHAR(12) CHECK(sexo='Feminino' or sexo='Masculino'),
    senha VARCHAR(100) DEFAULT NULL,
	acesso VARCHAR(12) CHECK(acesso='Admin' or acesso='Gerente' or acesso='Nenhum'),
    estado varchar(20) default null,
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

go

CREATE TABLE Grupos(
    id int PRIMARY key IDENTITY,
    grupo VARCHAR(100) UNIQUE not NULL,
    data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

go

CREATE TABLE FuncGroup(
    id int PRIMARY key IDENTITY,
    idFuncionario int not NULL,
	idGrupo int,
	unique(idFuncionario,idGrupo),
    FOREIGN KEY(idFuncionario) REFERENCES Funcionarios (id),
	FOREIGN KEY(idGrupo) REFERENCES Grupos(id)
);

go

CREATE TABLE Clientes(
    id int PRIMARY key IDENTITY,
    Nome VARCHAR(100) not NULL,
    NIF VARCHAR(100) DEFAULT NULL,
    sexo VARCHAR(12) CHECK(sexo='Feminino' or sexo='Masculino'),
    contacto VARCHAR(15) DEFAULT NULL,
	email VARCHAR(50) DEFAULT NULL,
    dataN date,
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP	
);

go

CREATE TABLE Pagamentos(
    id int PRIMARY key IDENTITY,
	cliente varchar(50) default null,
    horaEntrada TIME not NULL,
    dataEntrada DATE not NULL,
    montante DECIMAL(11,2) DEFAULT 0,
    multicaixa DECIMAL(11,2) DEFAULT 0,
    estado VARCHAR(20) CHECK (estado='activo' or estado='cancelado') not NULL,
    total DECIMAL(11,2) DEFAULT 0,
	idFuncionario int not NULL,
    FOREIGN KEY(idFuncionario) REFERENCES Funcionarios (id)
    );	

go

CREATE TABLE Atendimento(
    id int PRIMARY key IDENTITY,
	idPagamento INT not NULL,
    idSubServico INT not NULL,
    idGrupo INT not NULL,
    marca VARCHAR(20) DEFAULT NULL,
    matricula VARCHAR(20) NOT NULL,
	tipoPagamento VARCHAR(14) CHECK (tipoPagamento='multicaixa' or tipoPagamento='montante' or tipoPagamento='ambos') not NULL,
    valor DECIMAL(11,2) DEFAULT 0,
    FOREIGN KEY(idSubServico) REFERENCES SubServicos (id),
	FOREIGN KEY(idPagamento) REFERENCES Pagamentos (id) on delete cascade,
	FOREIGN KEY(idGrupo) REFERENCES Grupos (id)
    );

go

	
 CREATE TABLE Promocoes(
    id int PRIMARY key IDENTITY,
    matricula VARCHAR(20) NOT NULL UNIQUE,
    contagem INT DEFAULT 0,
	total int default 0
	);

go

CREATE TABLE Caixa(
    id int PRIMARY key IDENTITY,
    totalMontante DECIMAL(11,2) DEFAULT 0,
    totalMulticaixa DECIMAL(11,2) DEFAULT 0,
    dataE date not NULL,
    idFuncionario int not NULL,
	unique(dataE,idFuncionario),
    FOREIGN KEY(idFuncionario) REFERENCES Funcionarios (id),
    );
	
go

CREATE TABLE Empresas(
    id int PRIMARY key IDENTITY,
    nome VARCHAR(100) not NULL,
    NIF VARCHAR(100) DEFAULT NULL,
    localizacao VARCHAR(100) DEFAULT NULL,
    descricao text,
    contacto VARCHAR(15),
    email VARCHAR(50),
    banco varchar(20),
    num_conta VARCHAR(50),
    IBAN VARCHAR(50),
	data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_modificacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

go

CREATE TABLE FaturasEmpresa(
    id int PRIMARY key IDENTITY,
    idEmpresa int not NULL,
    numEncomenda int,
    tipo VARCHAR(100),
    kilos int,
    precoKilo DECIMAL(11,2) DEFAULT 0,
    Total DECIMAL(11,2) DEFAULT 0,
    FOREIGN KEY(idEmpresa) REFERENCES Empresas (id),
    data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP
	);

go

-- CRIAÇÃO DE FUNÇÕES
create function fn_say_month (@mes1 int)
returns varchar(20) as
begin
declare @mes varchar(20);
if(@mes1=1)
set @mes='Janeiro';
else if(@mes1=2) 
set @mes='Fevereiro';
else if(@mes1=3) 
set @mes='Março';
else if(@mes1=4) 
set @mes='Abril';
else if(@mes1=5)
set @mes='Maio';
else if(@mes1=6) 
set @mes='Junho';
else if(@mes1=7) 
set @mes='Julho';
else if(@mes1=8) 
set @mes='Agosto';
else if(@mes1=9)
set @mes='Setembro';
else if(@mes1=10)
set @mes='Outubro';
else if(@mes1=11)
set @mes='Novembro';
else if(@mes1=12)
set @mes='Dezembro';
else
set @mes=@mes1;
return @mes;
end;

go

-- CRIAÇÃO DAS TRIGGER
CREATE TRIGGER tgPromocao on dbo.Atendimento after INSERT AS
BEGIN
DECLARE @totMatricula int, @newMatricula VARCHAR(20);
set @newMatricula= (SELECT matricula from dbo.Atendimento where id=(IDENT_CURRENT('dbo.Atendimento')));
SET @totMatricula= (select count(matricula) from Promocoes where matricula=@newMatricula);

IF(@totMatricula=0)
INSERT INTO Promocoes VALUES (@newMatricula,1,1);
else
UPDATE Promocoes set contagem=(contagem+1), total=(total+1) where matricula=@newMatricula;
end

go

create TRIGGER tgCaixa on Atendimento after INSERT AS
BEGIN
DECLARE @totMontante int,@totMulticaixa int,@idFuncionario int,@data date,@contCaixa int;

set @idFuncionario= (select idFuncionario from Pagamentos 
where estado='activo' and id=IDENT_CURRENT('dbo.Pagamentos'));

set @data= (select dataEntrada from Pagamentos 
where estado='activo' and id=IDENT_CURRENT('dbo.Pagamentos') and idFuncionario=@idFuncionario);

select @totMontante=sum(montante), @totMulticaixa=sum(multicaixa)  from Pagamentos 
where estado='activo' and dataEntrada=@data and idFuncionario=@idFuncionario;

set @contCaixa= (select COUNT(*) from Caixa where dataE=@data and idFuncionario=@idFuncionario);

IF(@contCaixa=0)
begin
	insert into Caixa values (default,default,@data,@idFuncionario);
end
		update Caixa set totalMontante=@totMontante, totalMulticaixa=@totMulticaixa
		 where dataE=@data and idFuncionario=@idFuncionario;
end

go

-- CRIAÇÃO DE VIEW

go

create VIEW vwAtendimentos as
select p.id, p.cliente,s.nome 'serviço', sb.modelo, g.grupo, a.marca,
 a.matricula,a.tipoPagamento 'pagamento',a.valor,p.horaEntrada 'hora', p.dataEntrada 'data',
  p.estado, f.nome 'funcionário' 
  from pagamentos p JOIN Atendimento a on p.id=a.idpagamento
                           JOIN Grupos g on g.id=a.idgrupo
                           JOIN SubServicos sb on sb.id=a.idSubServico
                           JOIN Servicos s on s.id=sb.idServico
                           JOIN Funcionarios f on f.id=p.idfuncionario;

go
						   
create VIEW vwCaixa as
select c.id, c.totalMontante 'montante', c.totalMulticaixa 'multicaixa', 
(c.totalMontante+c.totalMulticaixa) 'total', CONCAT(DAY(c.dataE),' de ',dbo.fn_say_month(MONTH(c.dataE)), ' de ', year(c.dataE) ) 'referência' , dataE 'data', f.nome 'funcionário' from caixa c join 
funcionarios f on c.idFuncionario=f.id;

go

create view vwFacturasEmpresas as
select f.id,f.idEmpresa,e.nome,f.numEncomenda,f.tipo,f.kilos,f.precoKilo,f.Total,f.data_criacao
 from FaturasEmpresa f join Empresas e on f.idEmpresa=e.id;


go
						   -- CRIAÇÃO DE PROCEDURES
create procedure [dbo].[spUpdateCaixa] (@idPagamento int) as
begin
DECLARE @totMontante int,@totMulticaixa int, @idFuncionario int,@data date, @estado varchar(13);

set @estado= (select estado from Pagamentos 
where  id=@idPagamento);

if(@estado='cancelado')
begin

set @idFuncionario= (select idFuncionario from Pagamentos 
where id=@idPagamento);

set @data= (select dataEntrada from Pagamentos 
where id=@idPagamento);

select @totMontante=sum(montante), @totMulticaixa=sum(multicaixa)  from Pagamentos 
where id=@idPagamento;

	update Caixa set totalMontante=(totalMontante-@totMontante), 
	totalMulticaixa=(totalMulticaixa-@totMulticaixa) 
		where dataE=@data and idFuncionario=@idFuncionario;
end
end


go
