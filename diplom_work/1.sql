-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sports_equipment
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `ct_id` int NOT NULL AUTO_INCREMENT,
  `ct_name` varchar(50) NOT NULL,
  PRIMARY KEY (`ct_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Велосипед'),(2,'Самокат'),(3,'Электросамокат'),(4,'Лыжи'),(5,'Коньки'),(6,'Ролики'),(7,'Скетборд');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `cl_id` int NOT NULL AUTO_INCREMENT,
  `cl_first_name` varchar(45) NOT NULL,
  `cl_second_name` varchar(45) NOT NULL,
  `cl_otchestvo` varchar(45) NOT NULL,
  `cl_gender` varchar(1) NOT NULL,
  PRIMARY KEY (`cl_id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Иванов','Иван','Иваныч','м'),(2,'Игнатов','Григорий','Платонович','м'),(3,'Максимов','Касьян','Валентинович','м'),(4,'Фокина','Винетта','Львовна','ж'),(52,'Смирнова','Анфиса','Николаевна','ж');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `pr_id` int NOT NULL AUTO_INCREMENT,
  `pr_name` varchar(150) NOT NULL,
  `pr_cost` int NOT NULL,
  `pr_category` int NOT NULL,
  `pr_image` varchar(100) NOT NULL,
  `pr_quantity_all` int NOT NULL,
  `pr_quantity_current` int NOT NULL,
  `pr_model` varchar(3) NOT NULL,
  PRIMARY KEY (`pr_id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Велосипед горный Stern Energy 1.0 Sport 26',750,1,'products\\Ветровка женская Kappa.jpg',3,2,'м/ж'),(2,'Велосипед горный Trek Fx 2 Disc 700C',1050,1,'products\\Футболка для девочек PUMA Runtrain.jpg',60,60,'м/ж'),(3,'Велосипед для мальчиков Polygon Relic 20',500,1,'products\\Футболка мужская Termit.jpg',15,15,'м'),(4,'Самокат Roces',300,2,'0',20,20,'м/ж'),(5,'Самокат Reaction',600,2,'0',25,25,'м/ж'),(6,'Самокат Reaction Stunt',700,2,'0',10,10,'м/ж'),(7,'Электросамокат Kugoo Kugookirin M4PRO',1500,3,'0',10,10,'м/ж'),(8,'Беговые лыжи детские Madshus',400,4,'0',12,12,'м/ж'),(9,'Беговые лыжи Madshus Fjelltech',550,4,'0',20,20,'м/ж'),(10,'Коньки фигурные женские Nordway',250,5,'0',15,15,'ж'),(11,'Коньки хоккейные Nordway NDW',250,5,'0',15,15,'м'),(12,'Коньки детские Nordway Slide',200,5,'0',20,20,'м/ж'),(13,'Роликовые коньки мужские Roces Yvon',250,6,'0',15,15,'м'),(14,'Коньки фигурные женские Nordway Nicole',250,6,'0',15,15,'ж'),(15,'Коньки раздвижные детские Nordway JULIA',200,6,'0',15,15,'м/ж'),(20,'к',1,1,'0',0,0,'м');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rental`
--

DROP TABLE IF EXISTS `rental`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rental` (
  `rt_id` int NOT NULL AUTO_INCREMENT,
  `rt_client` int NOT NULL,
  `rt_product` int NOT NULL,
  `rt_date_start` datetime NOT NULL,
  `rt_date_end` datetime NOT NULL,
  `rt_active` int NOT NULL,
  PRIMARY KEY (`rt_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rental`
--

LOCK TABLES `rental` WRITE;
/*!40000 ALTER TABLE `rental` DISABLE KEYS */;
INSERT INTO `rental` VALUES (1,1,2,'2022-01-30 12:30:55','2022-01-30 15:30:55',1),(2,3,1,'2022-05-14 12:38:27','2022-05-14 13:38:27',0),(3,3,2,'2022-05-14 12:57:10','2022-05-14 13:57:10',1);
/*!40000 ALTER TABLE `rental` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `role_id` int NOT NULL AUTO_INCREMENT,
  `role_title` varchar(100) NOT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'админ'),(2,'главный менеджер'),(3,'менеджер'),(4,'покупатель');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `size`
--

DROP TABLE IF EXISTS `size`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `size` (
  `sz_id` int NOT NULL AUTO_INCREMENT,
  `sz_name_product` varchar(45) NOT NULL,
  `sz_number` varchar(45) NOT NULL,
  PRIMARY KEY (`sz_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `size`
--

LOCK TABLES `size` WRITE;
/*!40000 ALTER TABLE `size` DISABLE KEYS */;
/*!40000 ALTER TABLE `size` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_login` varchar(45) NOT NULL,
  `user_password` varchar(45) NOT NULL,
  `user_role` int NOT NULL,
  `user_first_name` varchar(45) DEFAULT NULL,
  `user_second_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  KEY `FK_role_idx` (`user_role`),
  CONSTRAINT `FK_role` FOREIGN KEY (`user_role`) REFERENCES `role` (`role_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'1','1',1,'Артём',NULL),(2,'2','2',2,'Денис',NULL),(3,'3','3',3,'Данил',NULL),(4,'4','4',4,'Вася',NULL),(5,'Логин','Пароль',1,'Имя','ФАмилия'),(6,'п','ф',1,'и','ф');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-16  1:30:08
