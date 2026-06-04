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
-- Table structure for table `kitaplar`
--

DROP TABLE IF EXISTS `kitaplar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint NOT NULL,
  `kitap_adi` varchar(40) NOT NULL,
  `yazar` varchar(40) NOT NULL,
  `yayinevi` varchar(40) NOT NULL,
  `sayfa_sayisi` smallint NOT NULL,
  PRIMARY KEY (`kitap_id`,`tur_id`),
  KEY `fk_kitaplar_kitap_turleri1_idx` (`tur_id`),
  CONSTRAINT `fk_kitaplar_kitap_turleri1` FOREIGN KEY (`tur_id`) REFERENCES `kitap_turleri` (`tur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kitaplar`
--

LOCK TABLES `kitaplar` WRITE;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
INSERT INTO `kitaplar` VALUES (1,1,'Kuyucaklı Yusuf','Sabahattin Ali','Deneme',221),(2,1,'Suç ve Ceza','Dostoyevski','Deneme',687),(3,1,'Beyaz Gemi','Cengiz Aytmatov','Deneme',168),(4,1,'Sinekli Bakkal','Halide Edib Adıvar','Örnek',476),(5,1,'Çalıkuşu','Reşat Nuri Güntekin','Örnek',544),(6,1,'Sefiller','Victor Hugo','Örnek',520),(7,2,'Ömer Seyfettin Hikayelerinden Seçmeler','Ömer Seyfettin','Deneme',176),(8,1,'Küçük Ağa','Tarık Buğra','Deneme',477),(9,1,'Yaban','Yakup Kadri Karaosmanoğlu','Deneme',215),(10,1,'Ölü Canlar','Gogol','Örnek',484),(11,3,'Otuz Beş Yaş','Cahit Sıtkı Tarancı','Örnek',120),(12,3,'Memleketimden İnsan Manzaraları','Nazım Hikmet Ran','Örnek',560),(14,3,'Bütün Şiirleri Orhan Veli','Orhan Veli Kanık','Örnek',247),(15,4,'Anadolu Notları','Reşat Nuri Güntekin','Örnek',287),(16,4,'Seyahatname','Evliya Çelebi','Deneme',828),(17,1,'yaşamak','yaşamak','yaşamak',500);
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;
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
