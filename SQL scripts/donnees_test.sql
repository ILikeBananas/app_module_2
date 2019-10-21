-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 21 oct. 2019 à 07:53
-- Version du serveur :  5.7.23
-- Version de PHP :  7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `johrbil_chariot`
--

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

DROP TABLE IF EXISTS `evenement`;
CREATE TABLE IF NOT EXISTS `evenement` (
  `Eve_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Eve_Date` datetime NOT NULL,
  `Eve_Message` varchar(50) DEFAULT NULL,
  `Lot_Numero` int(11) NOT NULL,
  PRIMARY KEY (`Eve_ID`),
  KEY `Evenement_Lot_FK` (`Lot_Numero`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `evenement`
--

INSERT INTO `evenement` (`Eve_ID`, `Eve_Date`, `Eve_Message`, `Lot_Numero`) VALUES
(1, '2019-10-21 00:00:00', 'UNE PUTAIN D\'EXPLOSION EST SURVENUE WSH', 1);

-- --------------------------------------------------------

--
-- Structure de la table `lot`
--

DROP TABLE IF EXISTS `lot`;
CREATE TABLE IF NOT EXISTS `lot` (
  `Lot_Numero` int(11) NOT NULL AUTO_INCREMENT,
  `Lot_Nom` varchar(30) DEFAULT NULL,
  `Lot_DateCreation` datetime NOT NULL,
  `Lot_DateButoir` datetime DEFAULT NULL,
  `Lot_Quantite` int(11) NOT NULL,
  `Lot_QuantiteAtteinte` int(11) DEFAULT NULL,
  `Rct_Numero` int(11) NOT NULL,
  `Stu_ID` int(11) NOT NULL,
  PRIMARY KEY (`Lot_Numero`),
  KEY `Lot_Recette_FK` (`Rct_Numero`),
  KEY `Lot_Status0_FK` (`Stu_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `lot`
--

INSERT INTO `lot` (`Lot_Numero`, `Lot_Nom`, `Lot_DateCreation`, `Lot_DateButoir`, `Lot_Quantite`, `Lot_QuantiteAtteinte`, `Rct_Numero`, `Stu_ID`) VALUES
(1, 'premier lot', '2019-10-21 00:00:00', '2019-10-31 00:00:00', 69, 0, 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `operation`
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `operation`
--

INSERT INTO `operation` (`Opr_ID`, `Opr_Numero`, `Opr_Position`, `Opr_Temps`, `Opr_Description`, `Opr_Quittance`, `Rct_Numero`) VALUES
(1, 1, 2, 2, 'waouw', 1, 1),
(2, 2, 1, 1, 'asdsa', 0, 2),
(3, 3, 5, 0, 'Destruction de l\'objet', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `recette`
--

DROP TABLE IF EXISTS `recette`;
CREATE TABLE IF NOT EXISTS `recette` (
  `Rct_Numero` int(11) NOT NULL AUTO_INCREMENT,
  `Rct_Nom` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Rct_Numero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `recette`
--

INSERT INTO `recette` (`Rct_Numero`, `Rct_Nom`) VALUES
(1, 'Première recette'),
(2, 'test');

-- --------------------------------------------------------

--
-- Structure de la table `status`
--

DROP TABLE IF EXISTS `status`;
CREATE TABLE IF NOT EXISTS `status` (
  `Stu_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Stu_Etat` varchar(50) NOT NULL,
  PRIMARY KEY (`Stu_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `status`
--

INSERT INTO `status` (`Stu_ID`, `Stu_Etat`) VALUES
(1, 'en attente'),
(2, 'en production');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD CONSTRAINT `Evenement_Lot_FK` FOREIGN KEY (`Lot_Numero`) REFERENCES `lot` (`Lot_Numero`);

--
-- Contraintes pour la table `lot`
--
ALTER TABLE `lot`
  ADD CONSTRAINT `Lot_Recette_FK` FOREIGN KEY (`Rct_Numero`) REFERENCES `recette` (`Rct_Numero`),
  ADD CONSTRAINT `Lot_Status0_FK` FOREIGN KEY (`Stu_ID`) REFERENCES `status` (`Stu_ID`);

--
-- Contraintes pour la table `operation`
--
ALTER TABLE `operation`
  ADD CONSTRAINT `Operation_Recette_FK` FOREIGN KEY (`Rct_Numero`) REFERENCES `recette` (`Rct_Numero`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
