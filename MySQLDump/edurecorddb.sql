CREATE DATABASE  IF NOT EXISTS `edurecorddb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `edurecorddb`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: edurecorddb
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
-- Table structure for table `academicyear`
--

DROP TABLE IF EXISTS `academicyear`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `academicyear` (
  `id` varchar(100) NOT NULL,
  `aycode` varchar(50) DEFAULT NULL,
  `schoolperiod` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Open',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicyear`
--

LOCK TABLES `academicyear` WRITE;
/*!40000 ALTER TABLE `academicyear` DISABLE KEYS */;
INSERT INTO `academicyear` VALUES ('2022-2023 1st Sem','2022-2023','1st Sem','Open'),('2022-2023 2nd Sem','2022-2023','2nd Sem','Close'),('2023-2024 1st Sem','2023-2024','1st Sem','Close'),('2023-2024 2nd Sem','2023-2024','2nd Sem','Close');
/*!40000 ALTER TABLE `academicyear` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ProgramID` int DEFAULT NULL,
  `year` int DEFAULT NULL,
  `semester` varchar(50) DEFAULT NULL,
  `courseCode` varchar(50) DEFAULT NULL,
  `course_name` varchar(150) DEFAULT NULL,
  `unit` int DEFAULT NULL,
  `teacher` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `ProgramID` (`ProgramID`),
  CONSTRAINT `courses_ibfk_1` FOREIGN KEY (`ProgramID`) REFERENCES `programs` (`ProgramID`)
) ENGINE=InnoDB AUTO_INCREMENT=178 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,1,1,'1st Sem','CS101','Introduction to Programming',3,'Mr. Alan Turing'),(2,1,1,'1st Sem','CS102','Discrete Mathematics',3,'Ms. Ada Lovelace'),(3,1,1,'1st Sem','CS103','Computer Organization',3,'Mr. Charles Babbage'),(4,1,1,'1st Sem','CS104','Technical Writing',3,'Ms. Grace Hopper'),(5,1,1,'1st Sem','CS105','General Chemistry',3,'Dr. Rosalind Franklin'),(6,1,1,'2nd Sem','CS106','Object-Oriented Programming',3,'Mr. James Gosling'),(7,1,1,'2nd Sem','CS107','Data Structures',3,'Mr. Donald Knuth'),(8,1,1,'2nd Sem','CS108','Digital Logic Design',3,'Mr. John Von Neumann'),(9,1,1,'2nd Sem','CS109','Probability and Statistics',3,'Dr. Florence Nightingale'),(10,1,1,'2nd Sem','CS110','General Physics',3,'Dr. Albert Einstein'),(11,1,1,'Summer','CS111','Programming Practicum',3,'Mr. Brian Kernighan'),(12,1,1,'Summer','CS112','Math Foundations',3,'Mr. Kurt Gödel'),(13,1,2,'1st Sem','CS201','Algorithms',3,'Ms. Barbara Liskov'),(14,1,2,'1st Sem','CS202','Database Systems',3,'Dr. Edgar Codd'),(15,1,2,'1st Sem','CS203','Software Engineering',3,'Mr. Fred Brooks'),(16,1,2,'1st Sem','CS204','Operating Systems',3,'Ms. Margaret Hamilton'),(17,1,2,'1st Sem','CS205','Linear Algebra',3,'Dr. Carl Gauss'),(18,1,2,'2nd Sem','CS206','Computer Networks',3,'Dr. Andrew Tanenbaum'),(19,1,2,'2nd Sem','CS207','Theory of Computation',3,'Mr. Alonzo Church'),(20,1,2,'2nd Sem','CS208','Human-Computer Interaction',3,'Ms. Shneiderman'),(21,1,2,'2nd Sem','CS209','Artificial Intelligence',3,'Dr. John McCarthy'),(22,1,2,'2nd Sem','CS210','Physics II',3,'Dr. Richard Feynman'),(23,1,2,'Summer','CS211','Software Development Project',3,'Mr. Linus Torvalds'),(24,1,3,'1st Sem','CS301','Advanced Algorithms',3,'Ms. Frances Allen'),(25,1,3,'1st Sem','CS302','Distributed Systems',3,'Dr. Leslie Lamport'),(26,1,3,'1st Sem','CS303','Machine Learning',3,'Dr. Geoffrey Hinton'),(27,1,3,'1st Sem','CS304','Parallel Computing',3,'Mr. John Backus'),(28,1,3,'1st Sem','CS305','Research Methods in CS',3,'Ms. Karen Spärck Jones'),(29,1,3,'2nd Sem','CS306','Computer Graphics',3,'Dr. Ivan Sutherland'),(30,1,3,'2nd Sem','CS307','Information Security',3,'Ms. Joan Feigenbaum'),(31,1,3,'2nd Sem','CS308','Web Development',3,'Mr. Tim Berners-Lee'),(32,1,3,'2nd Sem','CS309','Natural Language Processing',3,'Dr. Yoshua Bengio'),(33,1,3,'2nd Sem','CS310','Embedded Systems',3,'Mr. Nick Holonyak'),(34,1,3,'Summer','CS311','Capstone Project I',3,'Dr. Vinton Cerf'),(35,1,4,'1st Sem','CS401','Capstone Project II',3,'Dr. Robert Kahn'),(36,1,4,'1st Sem','CS402','Software Testing',3,'Ms. Mary Shaw'),(37,1,4,'1st Sem','CS403','Cybersecurity',3,'Mr. Whitfield Diffie'),(38,1,4,'1st Sem','CS404','Big Data Analytics',3,'Dr. Doug Cutting'),(39,1,4,'1st Sem','CS405','Blockchain Fundamentals',3,'Ms. Satoshi Nakamoto'),(40,1,4,'2nd Sem','CS406','Cloud Computing',3,'Mr. Werner Vogels'),(41,1,4,'2nd Sem','CS407','Mobile Application Development',3,'Mr. Scott Forstall'),(42,1,4,'2nd Sem','CS408','Quantum Computing',3,'Dr. David Deutsch'),(43,1,4,'2nd Sem','CS409','Advanced Database Systems',3,'Dr. Michael Stonebraker'),(44,1,4,'2nd Sem','CS410','Entrepreneurship in Tech',3,'Mr. Elon Musk'),(45,1,4,'Summer','CS411','Industry Practicum',6,'Mr. Steve Jobs'),(46,2,1,'1st Sem','BA101','Principles of Management',3,'Mr. Peter Drucker'),(47,2,1,'1st Sem','BA102','Financial Accounting',3,'Ms. Mary T. Washington'),(48,2,1,'1st Sem','BA103','Business Mathematics',3,'Dr. Carl Gauss'),(49,2,1,'1st Sem','BA104','Microeconomics',3,'Dr. Alfred Marshall'),(50,2,1,'1st Sem','BA105','Business Communication',3,'Ms. Sheryl Sandberg'),(51,2,1,'2nd Sem','BA106','Macroeconomics',3,'Dr. John Keynes'),(52,2,1,'2nd Sem','BA107','Marketing Management',3,'Mr. Philip Kotler'),(53,2,1,'2nd Sem','BA108','Organizational Behavior',3,'Ms. Lillian Gilbreth'),(54,2,1,'2nd Sem','BA109','Business Law',3,'Dr. Oliver Wendell Holmes'),(55,2,1,'2nd Sem','BA110','Statistics for Business',3,'Dr. Florence Nightingale'),(56,2,1,'Summer','BA111','Introduction to Business Analytics',3,'Mr. Hal Varian'),(57,2,2,'1st Sem','BA201','Operations Management',3,'Mr. W. Edwards Deming'),(58,2,2,'1st Sem','BA202','Corporate Finance',3,'Ms. Abigail Johnson'),(59,2,2,'1st Sem','BA203','Entrepreneurship',3,'Mr. Elon Musk'),(60,2,2,'1st Sem','BA204','Business Ethics',3,'Ms. Anita Roddick'),(61,2,2,'1st Sem','BA205','Managerial Accounting',3,'Dr. William Cooper'),(62,2,2,'2nd Sem','BA206','Supply Chain Management',3,'Dr. Sunil Chopra'),(63,2,2,'2nd Sem','BA207','Human Resource Management',3,'Ms. Susan Fowler'),(64,2,2,'2nd Sem','BA208','Global Business Environment',3,'Mr. Thomas Friedman'),(65,2,2,'2nd Sem','BA209','E-commerce',3,'Mr. Jeff Bezos'),(66,2,2,'2nd Sem','BA210','Research Methods in Business',3,'Dr. Clayton Christensen'),(67,2,2,'Summer','BA211','Internship I',3,'Ms. Marissa Mayer'),(68,2,3,'1st Sem','BA301','Strategic Management',3,'Mr. Michael Porter'),(69,2,3,'1st Sem','BA302','Investment Analysis',3,'Ms. Cathie Wood'),(70,2,3,'1st Sem','BA303','Advanced Marketing',3,'Mr. David Ogilvy'),(71,2,3,'1st Sem','BA304','Business Intelligence',3,'Dr. Howard Dresner'),(72,2,3,'1st Sem','BA305','Leadership in Organizations',3,'Ms. Indra Nooyi'),(73,2,3,'2nd Sem','BA306','Risk Management',3,'Mr. Nassim Nicholas Taleb'),(74,2,3,'2nd Sem','BA307','Financial Markets',3,'Dr. Robert Shiller'),(75,2,3,'2nd Sem','BA308','Consumer Behavior',3,'Mr. Daniel Kahneman'),(76,2,3,'2nd Sem','BA309','Corporate Governance',3,'Ms. Ursula Burns'),(77,2,3,'2nd Sem','BA310','Sales Management',3,'Mr. Zig Ziglar'),(78,2,3,'Summer','BA311','Capstone Project I',3,'Dr. Peter Senge'),(79,2,4,'1st Sem','BA401','Capstone Project II',3,'Dr. Henry Mintzberg'),(80,2,4,'1st Sem','BA402','Change Management',3,'Ms. Rosalind Brewer'),(81,2,4,'1st Sem','BA403','International Business',3,'Dr. Pankaj Ghemawat'),(82,2,4,'1st Sem','BA404','Sustainability in Business',3,'Mr. Paul Polman'),(83,2,4,'1st Sem','BA405','Innovation and Design Thinking',3,'Mr. Tim Brown'),(84,2,4,'2nd Sem','BA406','Corporate Social Responsibility',3,'Ms. Rachel Carson'),(85,2,4,'2nd Sem','BA407','Negotiation and Conflict Management',3,'Mr. William Ury'),(86,2,4,'2nd Sem','BA408','Technology Management',3,'Mr. Satya Nadella'),(87,2,4,'2nd Sem','BA409','Advanced Financial Management',3,'Mr. Warren Buffett'),(88,2,4,'2nd Sem','BA410','Business Policy',3,'Dr. Kenneth Andrews'),(89,2,4,'Summer','BA411','Internship II',6,'Ms. Angela Ahrendts'),(90,3,1,'1st Sem','NS101','Fundamentals of Nursing',3,'Ms. Florence Nightingale'),(91,3,1,'1st Sem','NS102','Anatomy and Physiology I',3,'Dr. Henry Gray'),(92,3,1,'1st Sem','NS103','Health Assessment',3,'Ms. Virginia Henderson'),(93,3,1,'1st Sem','NS104','Microbiology for Nurses',3,'Dr. Robert Koch'),(94,3,1,'1st Sem','NS105','Nutrition and Dietetics',3,'Ms. Eliza Apgar'),(95,3,1,'2nd Sem','NS106','Anatomy and Physiology II',3,'Dr. Andreas Vesalius'),(96,3,1,'2nd Sem','NS107','Pharmacology I',3,'Dr. Alexander Fleming'),(97,3,1,'2nd Sem','NS108','Nursing Ethics',3,'Ms. Dorothea Orem'),(98,3,1,'2nd Sem','NS109','Community Health Nursing I',3,'Ms. Lillian Wald'),(99,3,1,'2nd Sem','NS110','Biochemistry',3,'Dr. Linus Pauling'),(100,3,1,'Summer','NS111','Introduction to Nursing Research',3,'Dr. Patricia Benner'),(101,3,2,'1st Sem','NS201','Pathophysiology I',3,'Dr. Rudolf Virchow'),(102,3,2,'1st Sem','NS202','Pharmacology II',3,'Dr. Gertrude Elion'),(103,3,2,'1st Sem','NS203','Adult Health Nursing I',3,'Ms. Clara Barton'),(104,3,2,'1st Sem','NS204','Psychiatric Nursing',3,'Ms. Hildegard Peplau'),(105,3,2,'1st Sem','NS205','Medical-Surgical Nursing I',3,'Ms. Isabel Hampton Robb'),(106,3,2,'2nd Sem','NS206','Pathophysiology II',3,'Dr. Harvey Cushing'),(107,3,2,'2nd Sem','NS207','Adult Health Nursing II',3,'Ms. Mary Breckinridge'),(108,3,2,'2nd Sem','NS208','Community Health Nursing II',3,'Ms. Margaret Sanger'),(109,3,2,'2nd Sem','NS209','Nursing Informatics',3,'Ms. Florence Wald'),(110,3,2,'2nd Sem','NS210','Medical-Surgical Nursing II',3,'Ms. Lavinia Dock'),(111,3,2,'Summer','NS211','Nursing Practicum I',3,'Ms. Betty Neuman'),(112,3,3,'1st Sem','NS301','Maternal and Child Health Nursing I',3,'Ms. Mary Eliza Mahoney'),(113,3,3,'1st Sem','NS302','Pediatric Nursing',3,'Ms. Anna Caroline Maxwell'),(114,3,3,'1st Sem','NS303','Critical Care Nursing I',3,'Ms. Virginia Avenel Henderson'),(115,3,3,'1st Sem','NS304','Nursing Leadership and Management I',3,'Ms. Jean Watson'),(116,3,3,'1st Sem','NS305','Medical-Surgical Nursing III',3,'Ms. Linda Richards'),(117,3,3,'2nd Sem','NS306','Maternal and Child Health Nursing II',3,'Ms. Lucille Petry Leone'),(118,3,3,'2nd Sem','NS307','Geriatric Nursing',3,'Ms. Pearl McIver'),(119,3,3,'2nd Sem','NS308','Critical Care Nursing II',3,'Ms. Callista Roy'),(120,3,3,'2nd Sem','NS309','Nursing Leadership and Management II',3,'Ms. Madeleine Leininger'),(121,3,3,'2nd Sem','NS310','Medical-Surgical Nursing IV',3,'Ms. Mabel Keaton Staupers'),(122,3,3,'Summer','NS311','Capstone Project I',3,'Dr. Ernest Grant'),(123,3,4,'1st Sem','NS401','Capstone Project II',3,'Dr. Elizabeth Kubler-Ross'),(124,3,4,'1st Sem','NS402','Advanced Community Health Nursing',3,'Ms. Edith Cavell'),(125,3,4,'1st Sem','NS403','Oncology Nursing',3,'Ms. Therese Rando'),(126,3,4,'1st Sem','NS404','Emergency and Disaster Nursing',3,'Mr. John Flynn'),(127,3,4,'1st Sem','NS405','Nursing Research Methods',3,'Ms. Martha Rogers'),(128,3,4,'2nd Sem','NS406','Nursing and the Law',3,'Ms. Clara Louise Maass'),(129,3,4,'2nd Sem','NS407','Epidemiology',3,'Dr. John Snow'),(130,3,4,'2nd Sem','NS408','Perioperative Nursing',3,'Ms. Agnes Hunt'),(131,3,4,'2nd Sem','NS409','Advanced Pediatric Nursing',3,'Ms. Mary Ezra Mahoney'),(132,3,4,'2nd Sem','NS410','Global Health Nursing',3,'Ms. Henrietta Stockdale'),(133,3,4,'Summer','NS411','Nursing Practicum II',6,'Ms. Jessie Sleet Scales'),(134,4,1,'1st Sem','ME101','Introduction to Mechanical Engineering',3,'Mr. James Watt'),(135,4,1,'1st Sem','ME102','Engineering Drawing',3,'Mr. Gustave Eiffel'),(136,4,1,'1st Sem','ME103','Engineering Mechanics I',3,'Dr. Isaac Newton'),(137,4,1,'1st Sem','ME104','Mathematics for Engineers I',3,'Dr. Carl Gauss'),(138,4,1,'1st Sem','ME105','Physics for Engineers',3,'Dr. Michael Faraday'),(139,4,1,'2nd Sem','ME106','Computer-Aided Design (CAD)',3,'Ms. Ada Lovelace'),(140,4,1,'2nd Sem','ME107','Engineering Mechanics II',3,'Dr. Archimedes'),(141,4,1,'2nd Sem','ME108','Thermodynamics I',3,'Dr. Sadi Carnot'),(142,4,1,'2nd Sem','ME109','Mathematics for Engineers II',3,'Dr. Leonhard Euler'),(143,4,1,'2nd Sem','ME110','Materials Science',3,'Dr. Henry Bessemer'),(144,4,1,'Summer','ME111','Workshop Practice',3,'Mr. Eli Whitney'),(145,4,2,'1st Sem','ME201','Fluid Mechanics I',3,'Dr. Daniel Bernoulli'),(146,4,2,'1st Sem','ME202','Machine Design I',3,'Mr. Rudolf Diesel'),(147,4,2,'1st Sem','ME203','Manufacturing Processes I',3,'Mr. John Wilkinson'),(148,4,2,'1st Sem','ME204','Dynamics of Machinery',3,'Dr. Robert Hooke'),(149,4,2,'1st Sem','ME205','Electrical Circuits for Engineers',3,'Dr. Nikola Tesla'),(150,4,2,'2nd Sem','ME206','Fluid Mechanics II',3,'Dr. Henri Darcy'),(151,4,2,'2nd Sem','ME207','Thermodynamics II',3,'Dr. William Rankine'),(152,4,2,'2nd Sem','ME208','Machine Design II',3,'Mr. Thomas Newcomen'),(153,4,2,'2nd Sem','ME209','Control Systems',3,'Dr. Norbert Wiener'),(154,4,2,'2nd Sem','ME210','Manufacturing Processes II',3,'Mr. Henry Maudslay'),(155,4,2,'Summer','ME211','Internship I',3,'Mr. George Stephenson'),(156,4,3,'1st Sem','ME301','Heat Transfer',3,'Dr. Fourier Joseph'),(157,4,3,'1st Sem','ME302','Mechanical Vibrations',3,'Dr. Stephen Timoshenko'),(158,4,3,'1st Sem','ME303','Power Plant Engineering',3,'Mr. James Prescott Joule'),(159,4,3,'1st Sem','ME304','Computer-Aided Manufacturing (CAM)',3,'Ms. Margaret Hamilton'),(160,4,3,'1st Sem','ME305','Engineering Economics',3,'Mr. Adam Smith'),(161,4,3,'2nd Sem','ME306','Renewable Energy Systems',3,'Dr. Maria Telkes'),(162,4,3,'2nd Sem','ME307','Robotics and Automation',3,'Mr. Joseph Engelberger'),(163,4,3,'2nd Sem','ME308','Finite Element Analysis',3,'Dr. Ray Clough'),(164,4,3,'2nd Sem','ME309','Industrial Engineering',3,'Ms. Lillian Gilbreth'),(165,4,3,'2nd Sem','ME310','Advanced Machine Design',3,'Mr. William Fairbairn'),(166,4,3,'Summer','ME311','Capstone Project I',3,'Dr. Alan Mulally'),(167,4,4,'1st Sem','ME401','Capstone Project II',3,'Dr. Elon Musk'),(168,4,4,'1st Sem','ME402','Advanced Fluid Mechanics',3,'Dr. Ludwig Prandtl'),(169,4,4,'1st Sem','ME403','Energy Management',3,'Mr. Amory Lovins'),(170,4,4,'1st Sem','ME404','Industrial Safety Engineering',3,'Ms. Grace Hopper'),(171,4,4,'1st Sem','ME405','Mechatronics',3,'Dr. George Devol'),(172,4,4,'2nd Sem','ME406','Hydraulics and Pneumatics',3,'Mr. Blaise Pascal'),(173,4,4,'2nd Sem','ME407','Advanced Thermodynamics',3,'Dr. John Dalton'),(174,4,4,'2nd Sem','ME408','Aerospace Engineering',3,'Mr. Theodore von Kármán'),(175,4,4,'2nd Sem','ME409','Sustainable Manufacturing',3,'Mr. Gifford Pinchot'),(176,4,4,'2nd Sem','ME410','Global Engineering Practices',3,'Mr. George Babcock'),(177,4,4,'Summer','ME411','Internship II',6,'Mr. Frank Whittle');
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrollment`
--

DROP TABLE IF EXISTS `enrollment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrollment` (
  `id` int NOT NULL AUTO_INCREMENT,
  `studentID` int NOT NULL,
  `studentYear` int NOT NULL,
  `schoolperiod` varchar(50) NOT NULL,
  `academicYear` varchar(50) NOT NULL,
  `dateEnrolled` date NOT NULL,
  `studentStatus` varchar(50) NOT NULL DEFAULT 'N/A',
  `course1` varchar(100) DEFAULT NULL,
  `course2` varchar(100) DEFAULT NULL,
  `course3` varchar(100) DEFAULT NULL,
  `course4` varchar(100) DEFAULT NULL,
  `course5` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_students_id` (`studentID`),
  KEY `fk_academic_year` (`academicYear`),
  CONSTRAINT `fk_academic_year` FOREIGN KEY (`academicYear`) REFERENCES `academicyear` (`id`) ON DELETE CASCADE,
  CONSTRAINT `fk_students_id` FOREIGN KEY (`studentID`) REFERENCES `students` (`studentID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrollment`
--

LOCK TABLES `enrollment` WRITE;
/*!40000 ALTER TABLE `enrollment` DISABLE KEYS */;
/*!40000 ALTER TABLE `enrollment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programs`
--

DROP TABLE IF EXISTS `programs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programs` (
  `ProgramID` int NOT NULL AUTO_INCREMENT,
  `ProgramName` varchar(150) NOT NULL,
  PRIMARY KEY (`ProgramID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programs`
--

LOCK TABLES `programs` WRITE;
/*!40000 ALTER TABLE `programs` DISABLE KEYS */;
INSERT INTO `programs` VALUES (1,'Bachelor of Science in Computer Science'),(2,'Bachelor of Science in Business Administration'),(3,'Bachelor of Science in Nursing'),(4,'Bachelor of Science in Mechanical Engineering');
/*!40000 ALTER TABLE `programs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id` int NOT NULL AUTO_INCREMENT,
  `studentID` int NOT NULL,
  `useraccount_id` int NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `middle` varchar(100) DEFAULT NULL,
  `extensionName` varchar(50) DEFAULT NULL,
  `gender` varchar(10) NOT NULL,
  `birthdate` date NOT NULL,
  `phoneNumber` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `citizenship` varchar(60) NOT NULL,
  `birthcountry` varchar(60) NOT NULL,
  `birthplace` varchar(100) NOT NULL,
  `religion` varchar(60) NOT NULL,
  `address` text NOT NULL,
  `profile_photo` longblob,
  `approval` varchar(50) DEFAULT 'Pending',
  `motherName` varchar(100) NOT NULL,
  `motherLast` varchar(100) NOT NULL,
  `motherMiddle` varchar(100) NOT NULL,
  `motherExtension` varchar(50) NOT NULL,
  `motherResidential` text NOT NULL,
  `motherCitizenship` varchar(60) NOT NULL,
  `motherPhone` varchar(50) NOT NULL,
  `motherEmail` varchar(100) NOT NULL,
  `fatherName` varchar(100) NOT NULL,
  `fatherLast` varchar(100) NOT NULL,
  `fatherMiddle` varchar(100) NOT NULL,
  `fatherExtension` varchar(50) NOT NULL,
  `fatherResidential` text NOT NULL,
  `fatherCitizenship` varchar(60) NOT NULL,
  `fatherPhone` varchar(50) NOT NULL,
  `fatherEmail` varchar(100) NOT NULL,
  `contactName` varchar(150) NOT NULL,
  `contactNumber` varchar(60) NOT NULL,
  `previousEducationllvl` varchar(100) NOT NULL,
  `previousprogramSHS` varchar(100) NOT NULL,
  `previousschool` varchar(200) NOT NULL,
  `previousyearAttendent` varchar(50) NOT NULL,
  `previousaward` varchar(100) NOT NULL,
  `currentEducationallvl` varchar(50) NOT NULL,
  `currentProgram` varchar(150) NOT NULL,
  `currentyearLevel` int NOT NULL,
  `currentschoolPeriod` varchar(50) NOT NULL,
  `currentschoolYear` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `studentID` (`studentID`),
  KEY `fk_useraccount_id` (`useraccount_id`),
  CONSTRAINT `fk_useraccount_id` FOREIGN KEY (`useraccount_id`) REFERENCES `useraccount` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useraccount`
--

DROP TABLE IF EXISTS `useraccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `useraccount` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `owner` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `role` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccount`
--

LOCK TABLES `useraccount` WRITE;
/*!40000 ALTER TABLE `useraccount` DISABLE KEYS */;
INSERT INTO `useraccount` VALUES (1,'admin','123','Christian Bristol','ChristBristol999@gmail.com','Admin');
/*!40000 ALTER TABLE `useraccount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `viewcourses`
--

DROP TABLE IF EXISTS `viewcourses`;
/*!50001 DROP VIEW IF EXISTS `viewcourses`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `viewcourses` AS SELECT 
 1 AS `Student ID`,
 1 AS `Student Name`,
 1 AS `Student Status`,
 1 AS `Program`,
 1 AS `Student Year`,
 1 AS `School Period`,
 1 AS `Course 1`,
 1 AS `Course 2`,
 1 AS `Course 3`,
 1 AS `Course 4`,
 1 AS `Academic Year`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `viewenrollment`
--

DROP TABLE IF EXISTS `viewenrollment`;
/*!50001 DROP VIEW IF EXISTS `viewenrollment`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `viewenrollment` AS SELECT 
 1 AS `Student ID`,
 1 AS `Student Name`,
 1 AS `Student Year`,
 1 AS `School Period`,
 1 AS `Academic Year`,
 1 AS `Date Enrolled`,
 1 AS `Student Status`,
 1 AS `Profile`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `viewcourses`
--

/*!50001 DROP VIEW IF EXISTS `viewcourses`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `viewcourses` AS select `e`.`studentID` AS `Student ID`,concat(`s`.`firstname`,' ',ifnull(`s`.`middle`,''),', ',`s`.`lastname`,' ',' ',ifnull(`s`.`extensionName`,'')) AS `Student Name`,`e`.`studentStatus` AS `Student Status`,`s`.`currentProgram` AS `Program`,`e`.`studentYear` AS `Student Year`,`e`.`schoolperiod` AS `School Period`,`e`.`course1` AS `Course 1`,`e`.`course2` AS `Course 2`,`e`.`course3` AS `Course 3`,`e`.`course4` AS `Course 4`,`e`.`academicYear` AS `Academic Year` from (`enrollment` `e` join `students` `s` on((`e`.`studentID` = `s`.`studentID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `viewenrollment`
--

/*!50001 DROP VIEW IF EXISTS `viewenrollment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `viewenrollment` AS select `e`.`studentID` AS `Student ID`,concat(`s`.`firstname`,' ',ifnull(`s`.`middle`,''),', ',`s`.`lastname`,' ',' ',ifnull(`s`.`extensionName`,'')) AS `Student Name`,`e`.`studentYear` AS `Student Year`,`e`.`schoolperiod` AS `School Period`,`e`.`academicYear` AS `Academic Year`,`e`.`dateEnrolled` AS `Date Enrolled`,`e`.`studentStatus` AS `Student Status`,`s`.`profile_photo` AS `Profile` from (`enrollment` `e` join `students` `s` on((`e`.`studentID` = `s`.`studentID`))) */;
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

-- Dump completed on 2024-12-19 11:28:24
