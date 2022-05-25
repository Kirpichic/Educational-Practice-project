CREATE DATABASE  IF NOT EXISTS `rubrum_crucis_database` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rubrum_crucis_database`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: rubrum_crucis_database
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `вакцины`
--

DROP TABLE IF EXISTS `вакцины`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `вакцины` (
  `регистрационный_номен` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `вакцина` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `валентность` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `способ_введения` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `тип` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `количество_действующего_вещества` varchar(1000) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `адъювант` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `другие_вещества` varchar(1000) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `страна-производитель` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `возраст` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `бременность` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`регистрационный_номен`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `вакцины`
--

LOCK TABLES `вакцины` WRITE;
/*!40000 ALTER TABLE `вакцины` DISABLE KEYS */;
INSERT INTO `вакцины` VALUES ('P N003865/01','Гриппол','3 (типы А+А+В)','Внутремышечно или глубоко подкожу','Гемагглютинины вируса гриппа','Штамы, используемые для данного эпидсезона:А штамм 5 мкг гемаглютигина; другой А штамм 5 мкг гемаглютигина; В штамм 11 мкг гемаглютигина.','Полиоксидоний (азоксимера бромид)','Консервант Тиомерсал или без консерванта, фосфтно-солевой буферный раствор','Россия','Без консерванта: от 6 месяцев','По решению врача со 2 триместра'),('ЛП-004951','Гриппол Квадривалент','4 (типы А+А+В+В)','Внутремышечно или глубоко подкожу','Гемагглютинины вируса гриппа','Штамы, используемые для данного эпидсезона: А штамм 5 мкг гемаглютигина; другой А штамм 5 мкг гемаглютигина; В штамм 5 мкг гемаглютигина, ...','Полиоксидоний (азоксимера бромид)','Консервант Тиомерсал или без консервнта, форсфано-солевой буферный раствор','Россия','Без консерванта: от 6 лет','Со 2 триместра'),('ЛС-000484','Вакцина гриппозная инактивированная элюатно-центрифужная жидкая','3 (типы А+А+В)','Подкожно','Гемагглютинины вируса гриппа','Штамы, используемые для данного эпидсезона: гемаглютинины вируса гриппа двух подтипов А по 10 мкг, гемаглютинин вируса гриппа типа В 13 мкг.','Нет','Стабилизатор Альбумин, консервант Тиомерсал','Россия','От 18 лет','Притивопоказано'),('П N014493/01','Ваксигрип','3 (типы А+А+В)','Внутремышечно или глубоко подкожу','Инактивированный очищенный вирус','Штамы, используемые для данного эпидсезона: А штамм 15 мкг гемаглютигина; другой А штамм 15 мкг гемаглютигина; В штамм 15 мкг гемаглютигина.','Нет','Фосфатно-солевой буферный раствор. В следовых количествах: формальдегид, октоксинол-9, неомицин, овальбумин.','Франция','От 6 месяцев','Со 2 триместра'),('П N015694/01','Инфлювак','3 (типы А+А+В)','Внутремышечно или глубоко подкожу','Субъединичная инактивированная','Штамы, используемые для данного эпидсезона: А штамм 15 мкг гемаглютигина; другой А штамм 15 мкг гемаглютигина; В штамм 15 мкг гемаглютигина.','Нет','Калия хлорид; калия дигидрофосфат; натрия фосфата дигидрат; натрия хлорид; кальция хлорида дигидрат; магния хлорида гексагидрат; вода для...','Нидерланды','От 6 месяцев','Со 2 триместра');
/*!40000 ALTER TABLE `вакцины` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `договора`
--

DROP TABLE IF EXISTS `договора`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `договора` (
  `№` int NOT NULL,
  `дата` date DEFAULT NULL,
  `врач` int NOT NULL,
  `пациент` bigint NOT NULL,
  `номер_услуги` int DEFAULT NULL,
  `название_услуги` varchar(45) DEFAULT NULL,
  `стоимость_услуги` decimal(10,0) DEFAULT NULL,
  `способ_оплаты` varchar(10) DEFAULT NULL,
  `скидка` int DEFAULT NULL,
  `id_вакцины` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`№`,`врач`,`пациент`),
  KEY `Услуга_idx` (`номер_услуги`),
  KEY `Стоимость услуги_idx` (`стоимость_услуги`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `договора`
--

LOCK TABLES `договора` WRITE;
/*!40000 ALTER TABLE `договора` DISABLE KEYS */;
INSERT INTO `договора` VALUES (1,'2021-09-16',1,1,1,'Терапевтический осмотр',100,'безнал',0,'P N003865/01'),(2,'2002-01-01',4,7,3,'Чистка зубов (Ультразвук)',1000,'Нал',50,''),(7,'2022-05-19',1,5,1,'Терапевтический осмотр1',100,'Нал',0,''),(10,'2022-05-20',1,2,6,'Вакцинация',1000,'Нал',0,''),(11,'2022-05-19',1,1,1,'ааа',10000,'Нал',0,'');
/*!40000 ALTER TABLE `договора` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `клиенты`
--

DROP TABLE IF EXISTS `клиенты`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `клиенты` (
  `полис` bigint NOT NULL,
  `фио` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `номер_телефона` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `дата_рождения` date DEFAULT NULL,
  `пол` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `медицинская_карта` bigint DEFAULT NULL,
  `статус` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`полис`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `клиенты`
--

LOCK TABLES `клиенты` WRITE;
/*!40000 ALTER TABLE `клиенты` DISABLE KEYS */;
INSERT INTO `клиенты` VALUES (1,'Гришин Артём Никитич','+7 (912) 627-41-74','1995-06-26','м',1,'юр. лицо'),(2,'Зверева Анастасия Максимовна','+7 (923) 890-29-28','1997-11-23','ж',2,'физ. лицо'),(3,'Сорокина Дарья Никитична','+7 (994) 321-61-39','1993-12-23','ж',3,'физ. лицо'),(4,'Суханова София Артёмовна','+7 (914) 413-50-81','1999-02-17','ж',4,'юр. лицо'),(5,'Нестерова Мария Романовна','+7 (996) 971-21-16','1997-05-21','ж',5,'юр. лицо'),(6,'Смирнов Пётр Сергеевич','+7 (960) 385-12-12','1968-12-01','м',6,'физ. лицо');
/*!40000 ALTER TABLE `клиенты` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `сотрудники`
--

DROP TABLE IF EXISTS `сотрудники`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `сотрудники` (
  `id` int NOT NULL,
  `фио` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `номер_телефона` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `дата_рождения` date DEFAULT NULL,
  `специальность` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `дата_приёма_на_работу` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `сотрудники`
--

LOCK TABLES `сотрудники` WRITE;
/*!40000 ALTER TABLE `сотрудники` DISABLE KEYS */;
INSERT INTO `сотрудники` VALUES (1,'Васильева Владислава Гордеевна','+7 (917) 980-90-32','1995-05-23','Терапевт','2019-10-17'),(2,'Виноградова Екатерина Иванова','+7 (975) 705-61-72','2000-01-15','Отоларинголог','2018-02-14'),(3,'Калашников Иван Александрович','+7 (964) 635-64-67','1990-10-09','Пародонтолого','2015-12-13'),(4,'Морозов Максим Сергеевич','+7 (911) 513-30-33','1997-10-23','Стамотолог','2019-06-11'),(5,'Ерофеева Алиса Михайлова','+7 (960) 394-49-11','1991-12-01','Радиолог','2018-04-07');
/*!40000 ALTER TABLE `сотрудники` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `услуги`
--

DROP TABLE IF EXISTS `услуги`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `услуги` (
  `№` int NOT NULL,
  `услуга` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `стоимость_услуги` decimal(10,0) NOT NULL,
  `исполняющий_сотрудник` int DEFAULT NULL,
  PRIMARY KEY (`№`),
  KEY `фио_сотрудника_idx` (`исполняющий_сотрудник`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `услуги`
--

LOCK TABLES `услуги` WRITE;
/*!40000 ALTER TABLE `услуги` DISABLE KEYS */;
INSERT INTO `услуги` VALUES (1,'Терапевтический осмотр',100,1),(2,'Услуга отоларинголога',500,2),(3,'Чистка зубов (Ультразвук)',1000,3),(4,'Удаление кариеса',1500,4),(5,'Лечение артрита',2000,5),(6,'Вакцинация',100,1);
/*!40000 ALTER TABLE `услуги` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'rubrum_crucis_database'
--

--
-- Dumping routines for database 'rubrum_crucis_database'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-20 14:03:28
