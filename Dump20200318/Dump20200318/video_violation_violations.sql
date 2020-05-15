-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: video_violation
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `violations`
--

DROP TABLE IF EXISTS `violations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `violations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `video_id` int DEFAULT NULL,
  `violation_video_path` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `violation_frame_path` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `violation_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `FK_videos_violations_video_id_idx` (`video_id`) /*!80000 INVISIBLE */,
  KEY `violations_datetime_idx` (`violation_datetime` DESC),
  CONSTRAINT `FK_videos_violations_video_id` FOREIGN KEY (`video_id`) REFERENCES `videos` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `violations`
--

LOCK TABLES `violations` WRITE;
/*!40000 ALTER TABLE `violations` DISABLE KEYS */;
INSERT INTO `violations` VALUES (1,1,'A:\\Final_Output\\0903_1\\1\\1.avi','A:\\Final_Output\\0903_1\\1\\detected_frame.jpg','2020-03-11 00:02:36'),(2,1,'A:\\Final_Output\\0903_2\\3\\3.avi','A:\\Final_Output\\0903_2\\3\\detected_frame.jpg','2019-03-05 00:03:45'),(10,3,'A:\\Final_Output\\0903_3\\1\\1.avi','A:\\Final_Output\\0903_3\\1\\detected_frame.jpg','2020-03-11 01:04:32'),(11,4,'A:\\Final_Output\\1103_2\\2\\2.avi','A:\\Final_Output\\1103_2\\2\\detected_frame.jpg','2020-03-10 02:23:12'),(12,5,'A:\\Final_Output\\1004_4\\1\\1.avi','A:\\Final_Output\\1004_4\\1\\detected_frame.jpg','2020-04-10 03:21:00'),(13,6,'A:\\Final_Output\\1004_4\\3\\3.avi','A:\\Final_Output\\1004_4\\3\\detected_frame.jpg','2020-04-10 04:21:00'),(14,7,'A:\\Final_Output\\1103_2\\4\\4.avi','A:\\Final_Output\\1103_2\\4\\detected_frame.jpg','2020-04-04 04:21:00'),(15,8,'A:\\Final_Output\\1103_2\\5\\5.avi','A:\\Final_Output\\1103_2\\5\\detected_frame.jpg','2018-04-04 04:21:00');
/*!40000 ALTER TABLE `violations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-18 17:43:40
