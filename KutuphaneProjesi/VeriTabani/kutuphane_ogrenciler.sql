-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: kutuphane
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ogrenciler`
--

DROP TABLE IF EXISTS `ogrenciler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrenciler` (
  `ogrenci_no` int NOT NULL,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `sinif` tinyint NOT NULL,
  `cinsiyet` varchar(7) NOT NULL,
  `telefon` varchar(12) NOT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrenciler`
--

LOCK TABLES `ogrenciler` WRITE;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
INSERT INTO `ogrenciler` VALUES (99,'Ayşe','Y.',9,'Kız','048726589'),(145,'Esat','E.',11,'Erkek','066378412'),(150,'Emirhan','Ç.',11,'Erkek','059542222'),(188,'Ali','K.',9,'Erkek','072223641'),(222,'Zeynep','Ö.',10,'Kız','047238471'),(336,'Murat','Tekin',11,'Erkek','999655555'),(344,'Esra','Ö.',10,'Kız','036047841'),(411,'Samet','K.',10,'Erkek','887749961'),(460,'Yakup','B.',11,'Erkek','086306894'),(461,'Serpil','K',9,'Kız','876665561'),(555,'Ayşe','C.',11,'Kız','046378855'),(763,'Serhat','E.',12,'Erkek','986665748'),(985,'Mehmet','D.',12,'Erkek','018835412');
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-02 16:18:16
