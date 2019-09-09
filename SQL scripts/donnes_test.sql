-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Erstellungszeit: 09. Sep 2019 um 07:19
-- Server-Version: 5.7.26
-- PHP-Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `johrbil_chariot`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `evenement`
--

DROP TABLE IF EXISTS `evenement`;
CREATE TABLE IF NOT EXISTS `evenement` (
  `Eve_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Eve_Date` timestamp NOT NULL,
  `Eve_Message` varchar(50) DEFAULT NULL,
  `Lot_Numero` int(11) NOT NULL,
  PRIMARY KEY (`Eve_ID`),
  KEY `Evenement_Lot_FK` (`Lot_Numero`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `evenement`
--

INSERT INTO `evenement` (`Eve_ID`, `Eve_Date`, `Eve_Message`, `Lot_Numero`) VALUES
(1, '2019-09-09 09:00:00', 'Barrière lumineuse activée', 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lot`
--

DROP TABLE IF EXISTS `lot`;
CREATE TABLE IF NOT EXISTS `lot` (
  `Lot_Numero` int(11) NOT NULL AUTO_INCREMENT,
  `Lot_Nom` varchar(30) DEFAULT NULL,
  `Lot_NumeroRecette` int(11) NOT NULL,
  `Lot_DateCreation` timestamp NOT NULL,
  `Lot_DateButoir` timestamp NULL DEFAULT NULL,
  `Lot_Quantite` int(11) NOT NULL,
  `Lot_QuantiteAtteinte` int(11) NOT NULL,
  `Rct_Numero` int(11) NOT NULL,
  `Stu_ID` int(11) NOT NULL,
  PRIMARY KEY (`Lot_Numero`),
  KEY `Lot_Recette_FK` (`Rct_Numero`),
  KEY `Lot_Status0_FK` (`Stu_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `lot`
--

INSERT INTO `lot` (`Lot_Numero`, `Lot_Nom`, `Lot_NumeroRecette`, `Lot_DateCreation`, `Lot_DateButoir`, `Lot_Quantite`, `Lot_QuantiteAtteinte`, `Rct_Numero`, `Stu_ID`) VALUES
(1, 'Roue lot 1', 1, '2019-09-09 02:00:00', '2019-09-09 17:00:00', 10, 5, 1, 2),
(2, 'Roue lot 1', 2, '2019-09-10 01:00:00', NULL, 50, 0, 1, 3);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `operation`
--

DROP TABLE IF EXISTS `operation`;
CREATE TABLE IF NOT EXISTS `operation` (
  `Opr_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Opr_Numero` int(11) NOT NULL,
  `Opr_Position` int(11) NOT NULL,
  `Opr_Temps` int(11) NOT NULL,
  `Opr_Description` varchar(50) DEFAULT NULL,
  `Opr_Quittance` tinyint(1) NOT NULL,
  `Rct_Numero` int(11) NOT NULL,
  PRIMARY KEY (`Opr_ID`),
  KEY `Operation_Recette_FK` (`Rct_Numero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `operation`
--

INSERT INTO `operation` (`Opr_ID`, `Opr_Numero`, `Opr_Position`, `Opr_Temps`, `Opr_Description`, `Opr_Quittance`, `Rct_Numero`) VALUES
(1, 1, 3, 5, 'Fait tourner les serviettes', 1, 1),
(2, 2, 3, 0, NULL, 1, 2);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `recette`
--

DROP TABLE IF EXISTS `recette`;
CREATE TABLE IF NOT EXISTS `recette` (
  `Rct_Numero` int(11) NOT NULL AUTO_INCREMENT,
  `Rct_Nom` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Rct_Numero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `recette`
--

INSERT INTO `recette` (`Rct_Numero`, `Rct_Nom`) VALUES
(1, 'Roue 1'),
(2, 'Cube cubique');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `status`
--

DROP TABLE IF EXISTS `status`;
CREATE TABLE IF NOT EXISTS `status` (
  `Stu_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Stu_Etat` varchar(50) NOT NULL,
  PRIMARY KEY (`Stu_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `status`
--

INSERT INTO `status` (`Stu_ID`, `Stu_Etat`) VALUES
(1, 'Terminé'),
(2, 'En cours de production'),
(3, 'En attente');

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `evenement`
--
ALTER TABLE `evenement`
  ADD CONSTRAINT `Evenement_Lot_FK` FOREIGN KEY (`Lot_Numero`) REFERENCES `lot` (`Lot_Numero`);

--
-- Constraints der Tabelle `lot`
--
ALTER TABLE `lot`
  ADD CONSTRAINT `Lot_Recette_FK` FOREIGN KEY (`Rct_Numero`) REFERENCES `recette` (`Rct_Numero`),
  ADD CONSTRAINT `Lot_Status0_FK` FOREIGN KEY (`Stu_ID`) REFERENCES `status` (`Stu_ID`);

--
-- Constraints der Tabelle `operation`
--
ALTER TABLE `operation`
  ADD CONSTRAINT `Operation_Recette_FK` FOREIGN KEY (`Rct_Numero`) REFERENCES `recette` (`Rct_Numero`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
