-- MariaDB dump 10.18  Distrib 10.4.16-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: komponenten
-- ------------------------------------------------------
-- Server version	10.4.16-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `deck`
--

DROP TABLE IF EXISTS `deck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deck` (
  `D_ID` int(50) NOT NULL,
  `Groesse` float NOT NULL,
  `Marke` varchar(50) NOT NULL,
  `Thumbnail` varchar(40) DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`D_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deck`
--

LOCK TABLES `deck` WRITE;
/*!40000 ALTER TABLE `deck` DISABLE KEYS */;
INSERT INTO `deck` VALUES (1,8.25,'Baker','baker.png',89.99),(2,8,'DeathWish','deathwish.png',89.99),(3,7.75,'Globe','globe.png',59.99),(4,8.5,'AntiHero','antihero.png',69.99),(5,8,'Antiz','antiz.png',64.99),(6,8.25,'Toymachine','toymachine.png',69.99);
/*!40000 ALTER TABLE `deck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kugellager`
--

DROP TABLE IF EXISTS `kugellager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kugellager` (
  `K_ID` int(50) NOT NULL,
  `ABEC` int(10) NOT NULL,
  `Marke` varchar(50) NOT NULL,
  `Thumbmail` varchar(40) DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`K_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kugellager`
--

LOCK TABLES `kugellager` WRITE;
/*!40000 ALTER TABLE `kugellager` DISABLE KEYS */;
INSERT INTO `kugellager` VALUES (1,7,'REDZ','redz.png',24.99),(2,7,'DGK','dgkb.png',19.99),(3,5,'Idependent','idependentb.png',24.99),(4,5,'BlueTomato','bt.png',19.99),(5,7,'Spitfire','spitfireb.png',19.99);
/*!40000 ALTER TABLE `kugellager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rechnungen`
--

DROP TABLE IF EXISTS `rechnungen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rechnungen` (
  `Quantity` int(50) NOT NULL,
  `Price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rechnungen`
--

LOCK TABLES `rechnungen` WRITE;
/*!40000 ALTER TABLE `rechnungen` DISABLE KEYS */;
/*!40000 ALTER TABLE `rechnungen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reifen`
--

DROP TABLE IF EXISTS `reifen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reifen` (
  `R_ID` int(50) NOT NULL,
  `Durchmesser` int(10) NOT NULL,
  `Marke` varchar(50) NOT NULL,
  `Thumbmail` varchar(40) DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`R_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reifen`
--

LOCK TABLES `reifen` WRITE;
/*!40000 ALTER TABLE `reifen` DISABLE KEYS */;
INSERT INTO `reifen` VALUES (1,54,'Spitfire','spitfire.png',54.99),(2,53,'Bones','bones.png',49.99),(3,55,'Haze','haze.png',29.99),(4,56,'DGK','dgk.png',29.99);
/*!40000 ALTER TABLE `reifen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trucks`
--

DROP TABLE IF EXISTS `trucks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trucks` (
  `T_ID` int(50) NOT NULL,
  `Breite` int(10) NOT NULL,
  `Marke` varchar(50) NOT NULL,
  `Thumbmail` varchar(40) DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`T_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trucks`
--

LOCK TABLES `trucks` WRITE;
/*!40000 ALTER TABLE `trucks` DISABLE KEYS */;
INSERT INTO `trucks` VALUES (1,20,'Independent','independent.png',69.99),(2,21,'Ace','ace.png',69.99),(3,22,'Venture','venture.png',64.99),(4,20,'Thunder','thunder.png',64.99);
/*!40000 ALTER TABLE `trucks` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-11 21:48:29
