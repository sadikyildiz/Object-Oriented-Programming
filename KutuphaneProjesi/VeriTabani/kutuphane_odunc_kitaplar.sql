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
-- Table structure for table `odunc_kitaplar`
--

DROP TABLE IF EXISTS `odunc_kitaplar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odunc_kitaplar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ogr_no` int NOT NULL,
  `kitap_id` int NOT NULL,
  `verilis_tarihi` date NOT NULL,
  `teslim_tarihi` date DEFAULT NULL,
  `aciklama` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`,`ogr_no`,`kitap_id`),
  KEY `fk_odunc_kitaplar_ogrenciler_idx` (`ogr_no`),
  KEY `fk_odunc_kitaplar_kitaplar1_idx` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_kitaplar1` FOREIGN KEY (`kitap_id`) REFERENCES `kitaplar` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_ogrenciler` FOREIGN KEY (`ogr_no`) REFERENCES `ogrenciler` (`ogrenci_no`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odunc_kitaplar`
--

LOCK TABLES `odunc_kitaplar` WRITE;
/*!40000 ALTER TABLE `odunc_kitaplar` DISABLE KEYS */;
INSERT INTO `odunc_kitaplar` VALUES (11,145,3,'2022-02-09',NULL,NULL),(12,222,2,'2022-02-09','2026-06-02',''),(13,336,12,'2022-02-09',NULL,NULL),(14,555,11,'2022-02-16',NULL,NULL),(15,985,1,'2022-02-16',NULL,NULL),(16,411,6,'2022-02-16',NULL,NULL),(18,150,10,'2022-02-24','2026-06-02',''),(19,344,8,'2022-02-18',NULL,NULL),(20,222,16,'2026-06-02',NULL,'2 gün içerisinde getirecek');
/*!40000 ALTER TABLE `odunc_kitaplar` ENABLE KEYS */;
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
