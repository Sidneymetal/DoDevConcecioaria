/*CDD = ConcecionariaDoDev*/
SELECT * FROM CDD_Carros
Create Table CDD_Cliente(
  id int PRIMARY KEY,
  nome varchar (200),
  cpf char(11),
  dataNascimento date,
  email varchar(200),
  telefone varchar(11)
);
Create Table CDD_Funcionarios(
  id int PRIMARY KEY,
  nome varchar (200),
  cpf char(11),
  dataNascimento date,
  cargo varchar (20)
);
Create Table CDD_Carros( 
  id int PRIMARY KEY,
  marca varchar (100),
  modelo varchar (100),
  ano TIMESTAMP,
  quilometragem int,
  cor varchar (20),
  transmissaoAutomatica varchar(20),
  combustivel varchar(20),
  valor boolean
);
Create Table CDD_Motos(
  id int PRIMARY KEY,
  marca varchar (100),
  modelo varchar (100),
  quilometragem int,
  cor varchar (20),
  cilindradas varchar(20),
  partidal varchar(20),
  valor boolean
);
Create Table CDD_Vendas(
  id int PRIMARY KEY,
  formaDePagamento varchar (20),
  valor boolean
);

ALTER TABLE CDD_Vendas ADD COLUMN ID_Funcionario int;
ALTER TABLE CDD_Vendas ADD COLUMN ID_Cliente int;
ALTER TABLE CDD_Carros ADD COLUMN ID_Venda int;
ALTER TABLE CDD_Motos ADD COLUMN ID_Venda int;

ALTER TABLE CDD_Vendas ADD CONSTRAINT fk_id_Funcionario FOREIGN KEY (ID_Funcionario) REFERENCES CDD_Funcionarios(id);
ALTER TABLE CDD_Vendas ADD CONSTRAINT fk_id_Cliente FOREIGN KEY (ID_Cliente) REFERENCES CDD_Cliente(id);
ALTER TABLE CDD_Carros ADD CONSTRAINT fk_id_Vendas FOREIGN KEY (ID_Venda) REFERENCES CDD_Vendas(id);
ALTER TABLE CDD_Motos ADD CONSTRAINT fk_id_Vendas FOREIGN KEY (ID_Venda) REFERENCES CDD_Vendas(id);




