CREATE DATABASE petshop_pi;

USE petshop_pi;

CREATE TABLE ENDERECO (
idEnd INT NOT NULL AUTO_INCREMENT,
rua CHAR(45) NOT NULL,
numero CHAR(5) NOT NULL,
comp CHAR(45),
bairro CHAR(30) NOT NULL,
cidade CHAR(30) NOT NULL,
estado CHAR(2) NOT NULL,
cep INT NOT NULL,
PRIMARY KEY (idEnd)
);

CREATE TABLE CLIENTE (
cpf bigint NOT NULL,
nomeCli CHAR(45) NOT NULL,
telFixo CHAR(15),
telCel CHAR(15) NOT NULL,
email CHAR(100),
idEnd INT NOT NULL,
CONSTRAINT fkENDERECO FOREIGN KEY (idEnd) REFERENCES ENDERECO (idEnd),
PRIMARY KEY (cpf)
);

CREATE TABLE ANIMAL (
idAni INT NOT NULL AUTO_INCREMENT,
nomeAni CHAR(30) NOT NULL,
porte CHAR(30) NOT NULL,
cor CHAR(30) NOT NULL,
raca CHAR(30) NOT NULL,
PRIMARY KEY(idAni)
);

CREATE TABLE ANIMALxCLIENTE (
cpf  bigint NOT NULL,
idAni INT NOT NULL,
CONSTRAINT fkCLIENTE FOREIGN KEY (cpf) REFERENCES CLIENTE (cpf),
CONSTRAINT fkANIMAL FOREIGN KEY (idAni) REFERENCES ANIMAL (idAni),
PRIMARY KEY (cpf, idAni)
);

CREATE TABLE SERVICO (
idServ INT NOT NULL AUTO_INCREMENT,
descr CHAR(45) NOT NULL,
valorServ DECIMAL(10,2) NOT NULL,
flag VARCHAR(10) NOT NULL,
PRIMARY KEY (idServ)
);

CREATE TABLE OS (
idOS INT NOT NULL AUTO_INCREMENT,
dataOS DATE NOT NULL,
cpf bigint NOT NULL,
idAni INT NOT NULL,
valorTotal DECIMAL(10,2) NOT NULL,
CONSTRAINT fkANIMALxCLIENTE1 FOREIGN KEY (cpf) REFERENCES ANIMALxCLIENTE (cpf),
CONSTRAINT fkANIMALxCLIENTE2 FOREIGN KEY (idAni) REFERENCES ANIMALxCLIENTE (idAni),
PRIMARY KEY (idOS)
);

CREATE TABLE ITEM (
idOS INT NOT NULL,
idServ INT NOT NULL,
valorItem DECIMAL(10,2) NOT NULL,
CONSTRAINT fkOS FOREIGN KEY (idOS) REFERENCES OS (idOS) ON DELETE CASCADE,
CONSTRAINT fkSERVICO FOREIGN KEY (idServ) REFERENCES SERVICO (idServ),
PRIMARY KEY (idOS, idServ)

);

SHOW TABLES;

INSERT INTO ENDERECO(rua, numero, bairro, cidade, estado, cep) 
VALUES 
('Rua dos Vianas',
 '171', 'Bairro Amorim',
 'Cidade São Paulo', 
 'SP',
 09391001);

INSERT INTO CLIENTE VALUES (42684257809, 'Wesley Guimarães',null, '999330099', 'wees.guimaraes@gmail.com', 1), 
(36451328804,'Patricia Paixão',null ,9999999999, 'patricia@gmail.com', 1),
(48462167809, 'Gabriel Perillo', null, 948557845, 'gabriel.perillo2011@gmail.com', 1),
(47594150848, 'Henrique Silva Antonio', null, 988888888, 'henriantonio@live.com', 1),
(22179153805, 'Rodrigo da Col Gil', null, 985325205, 'roddacol@gmail.com', 1);

INSERT INTO ANIMAL VALUES (default, 'Thor', 'Pequeno', 'Marrom', 'Pinscher'),
(default, 'Max', 'Pequeno', 'Marrom', 'Yorkshire'),
(default, 'Stark', 'Médio', 'Branco', 'Pitbull'),
(default, 'Stev', 'Médio', 'Preto', 'Lessie'),
(default, 'Miojo', 'Pequeno', 'Cinza', 'Unknown');

INSERT INTO ANIMALxCLIENTE VALUES (42684257809, 1),
(36451328804, 2),
(48462167809, 3),
(47594150848, 4),
(22179153805, 5);

INSERT INTO SERVICO VALUES (default, 'Banho', 20.00, 'Ativo'),
(default, 'Tosa', 30.00, 'Ativo'),
(default, 'Banho & Tosa', 50.00, 'Ativo'),
(default, 'Cortar unha', 15.00, 'Ativo');

show tables;