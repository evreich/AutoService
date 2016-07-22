-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: dbautoservice
-- ------------------------------------------------------
-- Server version	5.7.10-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201607170744452_InitialCreate','AutoService.Migrations.Configuration','�\0\0\0\0\0\0\�\\Yo\�6~_ �A\�c\�t\�3Xl\�hg\�\�/�Mۆ\�\��d\�Ru��\�(\�\�\"�,���/�u�\�\�V�̋M��U���\�������y�#\�\�\'\�\�?��� 	1Y��9]}���\�o�6{\�O\�O\�w��w��d\'���\�\�4 F\�$\�A�dɊN�$��0��:<�\��\�h\n��\�xy\�\�:\'\�P�\�~�\'$�\r\�Q�HB��r�\�,�\��!۠\0N�Ӝ&KHq\0�w��e��0��\�F1���|�PD�\�Ƿ,i���r\�Pt��\�\nE��7��\�\��\�j\�V��<�I<�\�\�\�r��:�V�\�\�\�\�6�=\�p�̵.6�ğ�\���u�\�QʿQ�Ye\�(<i��\��\r�w\�\��\�)�\�i��\�*��p�ox�I>\09!y\�b1�؜2���\�d)}��U)\�y\�{S�n�\�d�\�\�\�ׯ|\�-�\�#��.齤I\n�)�^!J!%��f����@\�j53\�<��@O?Y\�>�\�{g�	\�j��\��`\�k���9t.\�Ͱ�U~���k\�p��/dq�\"�\�8\�\n\�\Z3��n{�R\�2�G�Y�\Z��\�Z��|\�\Z�b:{��R\\1u\�<\'c�I��:�j�b�\��k`\�7�9\'b[I.\��JI���\�\�9\�AC�f\�&\�lڄ�� SnͰ8S}\r5���yJ\�;��Xd�ý(3BP{H\�\�t\�p\�!�rY[H�}+w.�\�@o.h�:�U)\����\�\�oa�\�<Ɋb\��[qzOB�OG:E鈹��\����#\�Ll}�9I?\��\�\�U�B\Z6��<��<\�\r�;N�\�\�\\H�\�\�\�\�]��\�����u\'�!���X¶��?\�\�\"�n胠o\�8�\'0�3e�g\�\�\�/ ����o x@3�����\r\Z\�R(��1S1�	�\�	����\�\�!�	^�f.�fY\�b/�Z]\�z,)x-UFs:�\��\�M�a�Ǭ\�\�#\�%yP�Nq92GY�B\�L���,u\��d\�B\�[�?Y�򘁢9sfzL�\�0	�E\�M\�HzE�`\�\\�y <��\�\��js\�5׮�\�6�kWfS	=\��j�ˌ�$\��,8�\�h\�\��bs+4\�Kƞ�B���>\n�\�\�\�2�5U5\�%T$Y\�a\�t*(�\"��f[���2C\�\�\�F޻͠L}YY�\�\np\�K�\�9�IĲ+�k�E\�R�q��AUN�\�\�u����A-,�K;�kP���/,Gi\�\�9�U\�%\�1\�S�̢�O/�F=��\�H���@\��%!+c��i\��T\�TSMg�\���%�Z4��νjѶ*�\�м�M\�X�T6u��\�h�a���vV�xK�p6�n9�)<�AfyM���Wb\�2�m�-\�$=\�iF��\�=\��<��\�,\�!��g\Z�\n\�\��g#Қo���4�y\��y&-��*�M�\�E(�v\�I�\�ĝ\�\�\�\�I�#8��$��\�\�Cܩ\�,\�H\�C�̢\�\�C=6ʬԙ���Y\�殣�Sj\�0J$�F)��\�\�\�3\"�E^\��\�\�\�~�Yԃ��\\L.r�\�/O��\�K\�}B�%1�\�\�ՙ����(#��\�A������a\�Ѐ \�\��+�ƫ�\�\�9�¤8*1\�~B�h�u\�xx+\�\�f\'\�\r\�ʛmն\�\�~[_\\\�\\\���#D��M�\�G�!X��l�~��<8igswz!�\�d����&��N��D\�@8L$��d�\�8,\�\�`�M\�\�hVT��\r����\���\�8䧖\���?Q��I�cu9R}�@� �\�!���\�Z�\�\�18Ͳ0����A\�^{x\�|?;\����\�={QB\�\�­a2�%o[&rsJ�\�K�\��a`\�ۆ�\�X���_\�$����ѱw�\�]Ew\�\�\�;��\�X|hڗY��k[�]��C\�\��hؗ۲�	1�\�\�\�@�ҋ�U�\�یB&��\�R����×6us\�*�%�w\�D�Af��\�\�Hi�\�\�\�_�E�+��\� Sm\��\��\��\�Uw[�^e�K��6�n��vE7�s��m\�#��4In/�){\�G���|�\r(=��#X�\�\�\��]��FO��\�[�95�Xo]��\�\�N�!�\�G�\0�D�\�st�8�\��\�}\�v)6ܭ�(\��7\�^1\�v9:h\�]]f\�n9�a\�կ%\�\�!\�>a\�����\�\�\�\�\�\�e\�lol�wy���l��1�0g�����q\�\�\�%�4\�Z�!��\�,Mg\�=g\r�\���O�Ǭ�X�`j�ގ\�IV7��6�9�g�RA�\�j$3U�FGU�jUkW\��\�3\�&;Rt@���\�\�»�_O�\�\�uÂ�G%�\�ߜ�UReM�\���(\nY\�?M)^���\�\0���k��o5\�\����˜nr\�T��>R�|�究���@U\�\�\��\�1T`bb~\'wI\�\�8j�\�\�\�rdw�\�	���ⶤ�*j�\\s�0�T\\�\�\����\rě�1\�.\�=\�6�\�f�#�Q�\\=ֹ�tB\��\�;�\�)���GC\�~e\��-x���E\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cars`
--

DROP TABLE IF EXISTS `cars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cars` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Mark` longtext,
  `Model` longtext,
  `Year` int(11) NOT NULL,
  `Power` int(11) NOT NULL,
  `Transmission` int(11) NOT NULL,
  `ClientId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `ClientId` (`ClientId`),
  CONSTRAINT `Client_Cars` FOREIGN KEY (`ClientId`) REFERENCES `clients` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=210 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cars`
--

LOCK TABLES `cars` WRITE;
/*!40000 ALTER TABLE `cars` DISABLE KEYS */;
INSERT INTO `cars` VALUES (160,'Mazda','6',2008,150,1,136),(161,'Toyota','Camry',2007,150,0,137),(162,'Audi','TT',2013,180,1,137),(163,'Mazda','CX-5',2015,170,0,137),(164,'Toyota','Camry',2011,150,0,137),(165,'Mazda','CX-5',2011,170,2,138),(166,'Toyota','Land Cruiser',2013,249,1,138),(167,'Toyota','Land Cruiser',2014,249,1,139),(168,'Mazda','6',2015,150,1,140),(169,'Lada','Granta',2005,107,2,140),(170,'Toyota','Camry',2013,150,1,141),(171,'Mazda','6',2014,150,1,141),(172,'Mazda','CX-5',2008,170,1,141),(173,'Audi','TT',2008,180,2,142),(174,'Hyandai','i40',2010,141,1,143),(175,'Audi','Q7',2011,252,0,144),(176,'Mazda','CX-5',2011,170,2,144),(177,'Hyandai','i40',2007,141,0,144),(178,'Lada','Granta',2005,107,0,144),(179,'Hyundai','Solaris',2011,107,2,145),(180,'Audi','Q7',2006,252,1,146),(181,'Lada','XRAY',2006,122,2,147),(182,'Lada','Granta',2007,107,2,148),(183,'Hyandai','i40',2010,141,2,148),(184,'Hyandai','i40',2007,141,2,149),(185,'Toyota','Land Cruiser',2007,249,0,149),(186,'Audi','Q7',2009,252,2,150),(187,'Lada','Granta',2006,107,0,150),(188,'Toyota','Camry',2010,150,0,151),(189,'Hyundai','Solaris',2007,107,2,152),(190,'Hyandai','i40',2013,141,0,153),(191,'Toyota','Land Cruiser',2009,249,2,154),(192,'Toyota','Camry',2006,150,0,154),(193,'Audi','TT',2012,180,2,155),(194,'Mazda','CX-5',2013,170,1,156),(195,'Mazda','CX-5',2010,170,0,157),(196,'Lada','Granta',2008,107,1,157),(197,'Lada','Granta',2005,107,0,158),(198,'Lada','Granta',2005,107,2,158),(199,'Hyandai','i40',2011,141,1,159),(200,'Hyandai','i40',2014,141,0,159),(201,'Audi','Q7',2005,252,1,160),(202,'Hyandai','i40',2014,141,1,161),(203,'Hyandai','i40',2015,141,1,162),(204,'Lada','Granta',2008,107,1,163),(205,'Toyota','Land Cruiser',2005,249,1,163),(206,'Lada','XRAY',2009,122,2,164),(207,'Audi','TT',2011,180,1,164),(208,'Audi','TT',2007,180,2,164),(209,'Toyota','Land Cruiser',2014,249,1,165);
/*!40000 ALTER TABLE `cars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clients` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Surname` longtext,
  `Name` longtext,
  `Midname` longtext,
  `Year` int(11) NOT NULL,
  `Phone` longtext,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=166 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (136,'Меликбекян','Сергей','Александрович',1971,'89941157892'),(137,'Проскурякова','Надежда','Сергеевна',1981,'895698135'),(138,'Кожевникова','Полина','Николаевна',1972,'89681978025'),(139,'Подхолзин','Никита','Александрович',1989,'89891257361'),(140,'Кожевникова','Элина','Игоревна',1980,'89554144728'),(141,'Кожевников','Илья','Максимович',1992,'89521821242'),(142,'Кондрахин','Олег','Николаевич',1986,'89913355661'),(143,'Пономарева','Элина','Максимовна',1971,'89180190157'),(144,'Подхолзин','Дмитрий','Владимирович',1985,'89521112758'),(145,'Подхолзин','Сергей','Олегович',1976,'89675985387'),(146,'Иванов','Александр','Николаевич',1984,'89364564088'),(147,'Дмитриевцева','Виктория','Николаевна',1976,'89819577663'),(148,'Меликбекян','Олег','Игоревич',1980,'89259740969'),(149,'Шипилов','Илья','Максимович',1971,'89249423566'),(150,'Иванов','Олег','Олегович',1961,'89623426405'),(151,'Дмитриевцева','Наталья','Владимировна',1988,'89374111211'),(152,'Черноухов','Александр','Игоревич',1970,'89170796519'),(153,'Черноухов','Александр','Анатольевич',1984,'89131969684'),(154,'Дмитриевцева','Элина','Александровна',1984,'89587917677'),(155,'Черноухов','Максим','Максимович',1993,'89250293709'),(156,'Шарапова','Наталья','Александровна',1989,'89253096129'),(157,'Иванова','Виктория','Александровна',1968,'89877206391'),(158,'Воронин','Олег','Александрович',1965,'89662987078'),(159,'Иванов','Сергей','Артурович',1993,'89869847356'),(160,'Дмитриевцева','Надежда','Николаевна',1980,'8962170472'),(161,'Меликбекян','Сергей','Анатольевич',1979,'89482029426'),(162,'Подхолзин','Александр','Анатольевич',1996,'89413782615'),(163,'Шипилов','Артур','Владимирович',1965,'89732619921'),(164,'Подхолзин','Олег','Игоревич',1966,'89468973731'),(165,'Пономарева','Полина','Ивановна',1967,'89560823728');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Price` int(11) NOT NULL,
  `TimeBegin` datetime NOT NULL,
  `TimeEnd` datetime DEFAULT NULL,
  `CarId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `CarId` (`CarId`),
  CONSTRAINT `Order_Car` FOREIGN KEY (`CarId`) REFERENCES `cars` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=851 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (801,6000,'2016-07-05 00:36:55','2016-07-14 09:54:51',160),(802,11500,'2016-07-05 10:32:54','2016-07-11 23:01:45',161),(803,1000,'2016-07-13 11:27:45',NULL,165),(804,7000,'2016-07-03 18:11:11','2016-07-07 21:25:13',167),(805,2000,'2016-07-08 23:37:21','2016-07-14 16:25:58',168),(806,8500,'2016-07-02 07:33:40','2016-07-05 21:08:40',170),(807,6500,'2016-07-06 22:13:27','2016-07-12 09:12:50',173),(808,12000,'2016-07-12 11:22:41',NULL,174),(809,3000,'2016-07-12 16:41:02',NULL,175),(810,5000,'2016-07-08 14:18:07','2016-07-14 00:26:03',179),(811,6000,'2016-07-11 05:59:39',NULL,180),(812,12000,'2016-07-09 20:03:42','2016-07-10 12:25:04',181),(813,5500,'2016-07-01 09:11:33','2016-07-08 22:52:41',182),(814,10000,'2016-07-12 01:32:54',NULL,184),(815,8000,'2016-07-03 01:34:44','2016-07-10 23:28:21',186),(816,6000,'2016-07-03 14:18:12','2016-07-09 14:49:48',188),(817,5000,'2016-07-07 20:43:32','2016-07-11 07:17:05',189),(818,7000,'2016-07-12 01:33:06',NULL,190),(819,2500,'2016-07-03 09:41:03','2016-07-08 20:12:25',191),(820,2500,'2016-07-11 03:36:51',NULL,193),(821,9000,'2016-07-13 17:13:46',NULL,194),(822,6500,'2016-07-03 07:37:36','2016-07-03 17:29:31',195),(823,7000,'2016-07-02 02:29:38','2016-07-09 03:05:20',197),(824,12000,'2016-07-05 11:45:03','2016-07-14 11:36:57',199),(825,4000,'2016-07-13 21:44:48',NULL,201),(826,12000,'2016-07-05 15:54:56','2016-07-10 15:52:45',202),(827,12000,'2016-07-07 15:30:53','2016-07-11 10:21:50',203),(828,12000,'2016-07-14 09:41:29',NULL,204),(829,6000,'2016-07-11 04:56:56',NULL,206),(830,11500,'2016-07-10 18:32:46',NULL,209),(831,2500,'2016-07-05 04:32:30','2016-07-09 11:24:13',176),(832,12000,'2016-07-08 06:04:12','2016-07-14 11:28:32',192),(833,5500,'2016-07-12 21:23:47',NULL,171),(834,8500,'2016-07-11 02:40:39',NULL,205),(835,5500,'2016-07-04 12:10:46','2016-07-08 03:06:24',187),(836,12000,'2016-07-06 06:44:34','2016-07-12 19:07:09',162),(837,6500,'2016-07-14 22:09:54',NULL,198),(838,8500,'2016-07-01 00:32:56','2016-07-14 21:33:42',166),(839,5000,'2016-07-13 10:54:21',NULL,207),(840,8000,'2016-07-14 20:15:13',NULL,177),(841,12000,'2016-07-11 13:31:57',NULL,163),(842,12000,'2016-07-07 08:04:18','2016-07-09 21:48:07',200),(843,12000,'2016-07-12 15:05:07',NULL,196),(844,11500,'2016-07-04 19:02:54','2016-07-14 09:10:57',208),(845,1500,'2016-07-04 07:42:57','2016-07-05 17:10:43',178),(846,8500,'2016-07-04 04:17:05','2016-07-05 12:16:17',183),(847,3000,'2016-07-08 21:20:43','2016-07-13 13:33:37',164),(848,2000,'2016-07-12 04:25:22',NULL,185),(849,3000,'2016-07-07 09:26:24','2016-07-09 16:28:29',172),(850,2500,'2016-07-01 05:54:18','2016-07-01 20:24:33',169);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workorders`
--

DROP TABLE IF EXISTS `workorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workorders` (
  `Work_Id` int(11) NOT NULL,
  `Order_Id` int(11) NOT NULL,
  PRIMARY KEY (`Work_Id`,`Order_Id`),
  KEY `Work_Orders_Target` (`Order_Id`),
  CONSTRAINT `Work_Orders_Source` FOREIGN KEY (`Work_Id`) REFERENCES `works` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `Work_Orders_Target` FOREIGN KEY (`Order_Id`) REFERENCES `orders` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workorders`
--

LOCK TABLES `workorders` WRITE;
/*!40000 ALTER TABLE `workorders` DISABLE KEYS */;
INSERT INTO `workorders` VALUES (113,801),(114,801),(115,801),(113,802),(114,802),(115,802),(116,802),(117,802),(118,802),(114,803),(113,804),(115,804),(116,804),(113,805),(115,806),(116,806),(117,806),(118,806),(113,807),(114,807),(117,807),(118,807),(113,808),(114,808),(115,808),(116,808),(117,808),(118,808),(119,808),(113,809),(118,809),(119,809),(113,810),(115,810),(115,811),(117,811),(113,812),(114,812),(115,812),(116,812),(117,812),(118,812),(119,812),(113,813),(114,813),(116,813),(118,813),(113,814),(114,814),(115,814),(117,814),(118,814),(119,814),(113,815),(115,815),(117,815),(114,816),(116,816),(117,816),(113,817),(114,817),(116,817),(114,818),(116,818),(117,818),(118,818),(119,818),(113,819),(119,819),(116,820),(118,820),(113,821),(114,821),(115,821),(116,821),(118,821),(119,821),(115,822),(117,822),(118,822),(115,823),(117,823),(118,823),(119,823),(113,824),(114,824),(115,824),(116,824),(117,824),(118,824),(119,824),(117,825),(118,825),(119,825),(113,826),(114,826),(115,826),(116,826),(117,826),(118,826),(119,826),(113,827),(114,827),(115,827),(116,827),(117,827),(118,827),(119,827),(113,828),(114,828),(115,828),(116,828),(117,828),(118,828),(119,828),(115,829),(117,829),(113,830),(114,830),(115,830),(116,830),(117,830),(118,830),(113,831),(118,831),(113,832),(114,832),(115,832),(116,832),(117,832),(118,832),(119,832),(113,833),(115,833),(119,833),(115,834),(116,834),(117,834),(118,834),(113,835),(117,835),(119,835),(113,836),(114,836),(115,836),(116,836),(117,836),(118,836),(119,836),(115,837),(117,837),(119,837),(113,838),(114,838),(116,838),(117,838),(118,838),(114,839),(115,839),(118,839),(119,839),(114,840),(115,840),(117,840),(118,840),(119,840),(113,841),(114,841),(115,841),(116,841),(117,841),(118,841),(119,841),(113,842),(114,842),(115,842),(116,842),(117,842),(118,842),(119,842),(113,843),(114,843),(115,843),(116,843),(117,843),(118,843),(119,843),(113,844),(114,844),(115,844),(116,844),(117,844),(118,844),(114,845),(119,845),(113,846),(114,846),(116,846),(117,846),(119,846),(115,847),(113,848),(114,849),(116,849),(116,850),(118,850);
/*!40000 ALTER TABLE `workorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `works`
--

DROP TABLE IF EXISTS `works`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `works` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` longtext,
  `Price` int(11) NOT NULL,
  `Runtime` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=120 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `works`
--

LOCK TABLES `works` WRITE;
/*!40000 ALTER TABLE `works` DISABLE KEYS */;
INSERT INTO `works` VALUES (113,'Замена тормозных колодок',2000,120),(114,'Заправка кондиционера',1000,30),(115,'Замена масла',3000,40),(116,'Диагностика',2000,120),(117,'Компьютерная диагностика',3000,60),(118,'Замена маслянного фильтра',500,10),(119,'Замена воздушного фильтра',500,10);
/*!40000 ALTER TABLE `works` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-21 22:55:20
