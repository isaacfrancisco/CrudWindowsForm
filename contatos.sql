-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 23-Dez-2019 às 13:24
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `contatos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `dados`
--

DROP TABLE IF EXISTS `dados`;
CREATE TABLE IF NOT EXISTS `dados` (
  `CodContato` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) DEFAULT NULL,
  `Sexo` varchar(45) DEFAULT NULL,
  `DataDado` varchar(45) DEFAULT NULL,
  `Cidade` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CodContato`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `dados`
--

INSERT INTO `dados` (`CodContato`, `Nome`, `Sexo`, `DataDado`, `Cidade`) VALUES
(10, 'Isaac', 'Masculino', '2019-12-19', 'Juiz de fora'),
(11, 'Francisco', 'Masculino', '2019-12-11', 'Juiz de fora'),
(12, 'Fernanda', 'Feminino', '2019-12-12', 'São Paulo'),
(13, 'Márcio', 'Masculino', '2019-12-06', 'Rio de Janeiro'),
(14, 'Lucas', 'Masculino', '2019-09-01', 'Cabo Frio'),
(15, 'Maria', 'Feminino', '2019-09-01', 'Cabo Frio'),
(16, 'Cristina', 'Feminino', '2019-09-01', 'Rio de janeiro'),
(17, 'Luciana', 'Feminino', '2019-09-01', 'Juiz de Fora');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
