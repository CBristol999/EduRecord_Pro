CREATE DATABASE  IF NOT EXISTS `enrollmentmanagementdb` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `enrollmentmanagementdb`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: enrollmentmanagementdb
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `tblaccount`
--

DROP TABLE IF EXISTS `tblaccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblaccount` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblaccount`
--

LOCK TABLES `tblaccount` WRITE;
/*!40000 ALTER TABLE `tblaccount` DISABLE KEYS */;
INSERT INTO `tblaccount` VALUES ('admin','1234','Sir Paya'),('sirpaya','123456','Joemel Resare');
/*!40000 ALTER TABLE `tblaccount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblay`
--

DROP TABLE IF EXISTS `tblay`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblay` (
  `aycode` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Open',
  PRIMARY KEY (`aycode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblay`
--

LOCK TABLES `tblay` WRITE;
/*!40000 ALTER TABLE `tblay` DISABLE KEYS */;
INSERT INTO `tblay` VALUES ('2021-2022','Open'),('2022-2023','Close'),('2023-2024','Close');
/*!40000 ALTER TABLE `tblay` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblbilling`
--

DROP TABLE IF EXISTS `tblbilling`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblbilling` (
  `id` int NOT NULL AUTO_INCREMENT,
  `enrollmentid` int NOT NULL,
  `feesid` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblbilling`
--

LOCK TABLES `tblbilling` WRITE;
/*!40000 ALTER TABLE `tblbilling` DISABLE KEYS */;
INSERT INTO `tblbilling` VALUES (1,3,1),(2,3,2),(3,2,1),(4,2,2),(5,7,1),(6,7,2),(7,7,3),(8,7,4),(9,3,3),(10,2,3);
/*!40000 ALTER TABLE `tblbilling` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblenrollment`
--

DROP TABLE IF EXISTS `tblenrollment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblenrollment` (
  `enrollmentid` int NOT NULL AUTO_INCREMENT,
  `lrn` varchar(50) NOT NULL,
  `sectionid` int NOT NULL,
  `aycode` varchar(50) NOT NULL,
  `edate` date NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Enrolled',
  PRIMARY KEY (`enrollmentid`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblenrollment`
--

LOCK TABLES `tblenrollment` WRITE;
/*!40000 ALTER TABLE `tblenrollment` DISABLE KEYS */;
INSERT INTO `tblenrollment` VALUES (2,'4234234244',1,'2021-2022','2023-04-17','Enrolled'),(3,'173827131',2,'2021-2022','2023-04-17','Enrolled'),(5,'4234234244',1,'2022-2023','2023-04-19','Dropped'),(6,'173827131',1,'2022-2023','2023-04-19','Dropped'),(7,'42349989854',3,'2021-2022','2023-05-10','Enrolled'),(8,'213231312',2,'2021-2022','2024-12-16','Enrolled'),(9,'213231312',1,'2023-2024','2024-12-16','Enrolled');
/*!40000 ALTER TABLE `tblenrollment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfees`
--

DROP TABLE IF EXISTS `tblfees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblfees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fees` varchar(50) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `fees` (`fees`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfees`
--

LOCK TABLES `tblfees` WRITE;
/*!40000 ALTER TABLE `tblfees` DISABLE KEYS */;
INSERT INTO `tblfees` VALUES (1,'Tuition',25000.00),(2,'Registration',1500.00),(3,'Library',250.00),(4,'Computer Laboratory',1500.00);
/*!40000 ALTER TABLE `tblfees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpayment`
--

DROP TABLE IF EXISTS `tblpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblpayment` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pdate` date NOT NULL,
  `enrollmentid` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpayment`
--

LOCK TABLES `tblpayment` WRITE;
/*!40000 ALTER TABLE `tblpayment` DISABLE KEYS */;
INSERT INTO `tblpayment` VALUES (1,'2023-04-21',2,2000.00),(2,'2023-04-25',3,1000.00),(3,'2023-04-25',2,5000.00),(4,'2023-04-26',2,3000.00),(5,'2023-05-10',7,15000.00),(6,'2023-05-10',3,4750.00),(7,'2023-05-10',2,6750.00),(8,'2023-05-10',7,250.00);
/*!40000 ALTER TABLE `tblpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsection`
--

DROP TABLE IF EXISTS `tblsection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsection` (
  `id` int NOT NULL AUTO_INCREMENT,
  `section` varchar(50) NOT NULL,
  `level` varchar(50) NOT NULL,
  `adviserid` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `section` (`section`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsection`
--

LOCK TABLES `tblsection` WRITE;
/*!40000 ALTER TABLE `tblsection` DISABLE KEYS */;
INSERT INTO `tblsection` VALUES (1,'Prep 1','Preparatory','11319990143'),(2,'Kinder 1 - A','Kinder 1','113202020032'),(3,'Earth','Grade 1','1138983294');
/*!40000 ALTER TABLE `tblsection` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblstudent`
--

DROP TABLE IF EXISTS `tblstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblstudent` (
  `lrn` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `bdate` date NOT NULL,
  `age` int NOT NULL,
  `father` varchar(50) NOT NULL,
  `father_occupation` varchar(50) NOT NULL,
  `mother` varchar(50) NOT NULL,
  `mother_occupation` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`lrn`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblstudent`
--

LOCK TABLES `tblstudent` WRITE;
/*!40000 ALTER TABLE `tblstudent` DISABLE KEYS */;
INSERT INTO `tblstudent` VALUES ('173827131','Romero','Fausto','Magbanwa','Surigao City','2017-05-14',6,'Faustino Romero','Bank Employee','Virginia Romero','Teacher','Active'),('213231312','Gandol','Thommy','T','marilao, bulacan','2007-03-08',18,'norman','jeepney','cait','housewife','Active'),('4234234244','Baybay','Rose','Narciso','Suriago City, Surigao del Norte','2017-01-14',7,'Greg Baybay','Teacher','Rosalina Baybay','Teacher','Active'),('42349989854','Tan','Ramboo','X','Surigao City','2019-05-10',5,'Ram Tan','Businessman','Boo Tan','Businesswoman','Active');
/*!40000 ALTER TABLE `tblstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblteacher`
--

DROP TABLE IF EXISTS `tblteacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblteacher` (
  `teacherid` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`teacherid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblteacher`
--

LOCK TABLES `tblteacher` WRITE;
/*!40000 ALTER TABLE `tblteacher` DISABLE KEYS */;
INSERT INTO `tblteacher` VALUES ('11319990143','Resare','Joemel','E.','09191234567','Surigao City','jresare@gmail.com'),('113202020032','Go','Joanne','N','09197654321','Claver, SDN','go.joanne@g,ail.com'),('1138983294','Logo','Echo','M','09126589874','Surigao City','echo@gmail.com');
/*!40000 ALTER TABLE `tblteacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbluser` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vwbilling`
--

DROP TABLE IF EXISTS `vwbilling`;
/*!50001 DROP VIEW IF EXISTS `vwbilling`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwbilling` AS SELECT 
 1 AS `enrollmentid`,
 1 AS `lrn`,
 1 AS `student`,
 1 AS `level`,
 1 AS `section`,
 1 AS `aycode`,
 1 AS `amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwenrollment`
--

DROP TABLE IF EXISTS `vwenrollment`;
/*!50001 DROP VIEW IF EXISTS `vwenrollment`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwenrollment` AS SELECT 
 1 AS `enrollmentid`,
 1 AS `lrn`,
 1 AS `student`,
 1 AS `level`,
 1 AS `section`,
 1 AS `adviserid`,
 1 AS `adviser`,
 1 AS `aycode`,
 1 AS `edate`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwpayment`
--

DROP TABLE IF EXISTS `vwpayment`;
/*!50001 DROP VIEW IF EXISTS `vwpayment`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwpayment` AS SELECT 
 1 AS `id`,
 1 AS `pdate`,
 1 AS `enrollmentid`,
 1 AS `lrn`,
 1 AS `student`,
 1 AS `level`,
 1 AS `section`,
 1 AS `amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwsection`
--

DROP TABLE IF EXISTS `vwsection`;
/*!50001 DROP VIEW IF EXISTS `vwsection`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwsection` AS SELECT 
 1 AS `id`,
 1 AS `level`,
 1 AS `section`,
 1 AS `adviserid`,
 1 AS `adviser`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwtotalpayment`
--

DROP TABLE IF EXISTS `vwtotalpayment`;
/*!50001 DROP VIEW IF EXISTS `vwtotalpayment`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwtotalpayment` AS SELECT 
 1 AS `enrollmentid`,
 1 AS `total`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwtuition`
--

DROP TABLE IF EXISTS `vwtuition`;
/*!50001 DROP VIEW IF EXISTS `vwtuition`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwtuition` AS SELECT 
 1 AS `id`,
 1 AS `enrollmentid`,
 1 AS `feesid`,
 1 AS `fees`,
 1 AS `amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vwbilling`
--

/*!50001 DROP VIEW IF EXISTS `vwbilling`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwbilling` AS select `e`.`enrollmentid` AS `enrollmentid`,`e`.`lrn` AS `lrn`,`e`.`student` AS `student`,`e`.`level` AS `level`,`e`.`section` AS `section`,`e`.`aycode` AS `aycode`,ifnull(sum(`t`.`amount`),0) AS `amount` from (`vwenrollment` `e` left join `vwtuition` `t` on((`e`.`enrollmentid` = `t`.`enrollmentid`))) where (`e`.`status` like 'Enrolled') group by `e`.`lrn`,`e`.`aycode` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwenrollment`
--

/*!50001 DROP VIEW IF EXISTS `vwenrollment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwenrollment` AS select `e`.`enrollmentid` AS `enrollmentid`,`e`.`lrn` AS `lrn`,concat(`s`.`lname`,', ',`s`.`fname`,' ',`s`.`mname`) AS `student`,`sec`.`level` AS `level`,`sec`.`section` AS `section`,`sec`.`adviserid` AS `adviserid`,`sec`.`adviser` AS `adviser`,`e`.`aycode` AS `aycode`,`e`.`edate` AS `edate`,`e`.`status` AS `status` from ((`tblenrollment` `e` join `tblstudent` `s` on((`s`.`lrn` = `e`.`lrn`))) join `vwsection` `sec` on((`sec`.`id` = `e`.`sectionid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwpayment`
--

/*!50001 DROP VIEW IF EXISTS `vwpayment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwpayment` AS select `p`.`id` AS `id`,`p`.`pdate` AS `pdate`,`p`.`enrollmentid` AS `enrollmentid`,`v`.`lrn` AS `lrn`,`v`.`student` AS `student`,`v`.`level` AS `level`,`v`.`section` AS `section`,`p`.`amount` AS `amount` from (`tblpayment` `p` join `vwenrollment` `v` on((`v`.`enrollmentid` = `p`.`enrollmentid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwsection`
--

/*!50001 DROP VIEW IF EXISTS `vwsection`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwsection` AS select `s`.`id` AS `id`,`s`.`level` AS `level`,`s`.`section` AS `section`,`s`.`adviserid` AS `adviserid`,concat(`t`.`lname`,', ',`t`.`fname`,' ',`t`.`mname`) AS `adviser` from (`tblsection` `s` join `tblteacher` `t` on((`t`.`teacherid` = `s`.`adviserid`))) order by `s`.`level`,`s`.`section` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwtotalpayment`
--

/*!50001 DROP VIEW IF EXISTS `vwtotalpayment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwtotalpayment` AS select `tblpayment`.`enrollmentid` AS `enrollmentid`,ifnull(sum(`tblpayment`.`amount`),0) AS `total` from `tblpayment` group by `tblpayment`.`enrollmentid` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwtuition`
--

/*!50001 DROP VIEW IF EXISTS `vwtuition`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb3 */;
/*!50001 SET character_set_results     = utf8mb3 */;
/*!50001 SET collation_connection      = utf8mb3_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwtuition` AS select `b`.`id` AS `id`,`b`.`enrollmentid` AS `enrollmentid`,`b`.`feesid` AS `feesid`,`f`.`fees` AS `fees`,`f`.`amount` AS `amount` from (`tblbilling` `b` join `tblfees` `f` on((`f`.`id` = `b`.`feesid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-19 10:40:17
