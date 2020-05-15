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
-- Temporary view structure for view `view_voilations`
--

DROP TABLE IF EXISTS `view_voilations`;
/*!50001 DROP VIEW IF EXISTS `view_voilations`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_voilations` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`,
 1 AS `video_day`,
 1 AS `video_hour`,
 1 AS `video_id`,
 1 AS `video_name`,
 1 AS `video_path`,
 1 AS `violation_id`,
 1 AS `violation_video_path`,
 1 AS `violation_frame_path`,
 1 AS `violation_datetime`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `qry_video_year`
--

DROP TABLE IF EXISTS `qry_video_year`;
/*!50001 DROP VIEW IF EXISTS `qry_video_year`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `qry_video_year` AS SELECT 
 1 AS `video_year`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `video_view_by_date`
--

DROP TABLE IF EXISTS `video_view_by_date`;
/*!50001 DROP VIEW IF EXISTS `video_view_by_date`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `video_view_by_date` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`,
 1 AS `video_day`,
 1 AS `video_hour`,
 1 AS `video_id`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `qry_video_hour`
--

DROP TABLE IF EXISTS `qry_video_hour`;
/*!50001 DROP VIEW IF EXISTS `qry_video_hour`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `qry_video_hour` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`,
 1 AS `video_day`,
 1 AS `video_hour`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `qry_video_month`
--

DROP TABLE IF EXISTS `qry_video_month`;
/*!50001 DROP VIEW IF EXISTS `qry_video_month`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `qry_video_month` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `video_view`
--

DROP TABLE IF EXISTS `video_view`;
/*!50001 DROP VIEW IF EXISTS `video_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `video_view` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`,
 1 AS `video_day`,
 1 AS `video_hour`,
 1 AS `video_id`,
 1 AS `video_name`,
 1 AS `video_path`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `qry_video_day`
--

DROP TABLE IF EXISTS `qry_video_day`;
/*!50001 DROP VIEW IF EXISTS `qry_video_day`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `qry_video_day` AS SELECT 
 1 AS `video_year`,
 1 AS `video_month`,
 1 AS `video_day`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `view_voilations`
--

/*!50001 DROP VIEW IF EXISTS `view_voilations`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_voilations` AS select `vv`.`video_year` AS `video_year`,`vv`.`video_month` AS `video_month`,`vv`.`video_day` AS `video_day`,`vv`.`video_hour` AS `video_hour`,`vv`.`video_id` AS `video_id`,`vv`.`video_name` AS `video_name`,`vv`.`video_path` AS `video_path`,`v`.`Id` AS `violation_id`,`v`.`violation_video_path` AS `violation_video_path`,`v`.`violation_frame_path` AS `violation_frame_path`,`v`.`violation_datetime` AS `violation_datetime` from (`video_view` `vv` join `violations` `v` on((`vv`.`video_id` = `v`.`video_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `qry_video_year`
--

/*!50001 DROP VIEW IF EXISTS `qry_video_year`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `qry_video_year` AS select distinct `video_view`.`video_year` AS `video_year` from `video_view` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `video_view_by_date`
--

/*!50001 DROP VIEW IF EXISTS `video_view_by_date`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `video_view_by_date` AS select year(`v`.`video_datetime`) AS `video_year`,month(`v`.`video_datetime`) AS `video_month`,dayofmonth(`v`.`video_datetime`) AS `video_day`,hour(`v`.`video_datetime`) AS `video_hour`,`v`.`Id` AS `video_id` from `videos` `v` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `qry_video_hour`
--

/*!50001 DROP VIEW IF EXISTS `qry_video_hour`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `qry_video_hour` AS select distinct `video_view`.`video_year` AS `video_year`,`video_view`.`video_month` AS `video_month`,`video_view`.`video_day` AS `video_day`,`video_view`.`video_hour` AS `video_hour` from `video_view` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `qry_video_month`
--

/*!50001 DROP VIEW IF EXISTS `qry_video_month`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `qry_video_month` AS select distinct `video_view`.`video_year` AS `video_year`,`video_view`.`video_month` AS `video_month` from `video_view` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `video_view`
--

/*!50001 DROP VIEW IF EXISTS `video_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `video_view` AS select `ks_video_voilation`.`video_year` AS `video_year`,`ks_video_voilation`.`video_month` AS `video_month`,`ks_video_voilation`.`video_day` AS `video_day`,`ks_video_voilation`.`video_hour` AS `video_hour`,`ks_video_voilation`.`video_id` AS `video_id`,`ks_video_voilation`.`video_name` AS `video_name`,`ks_video_voilation`.`video_path` AS `video_path` from (select `vv`.`video_year` AS `video_year`,`vv`.`video_month` AS `video_month`,`vv`.`video_day` AS `video_day`,`vv`.`video_hour` AS `video_hour`,`vv`.`video_id` AS `video_id`,`v`.`video_name` AS `video_name`,`v`.`video_path` AS `video_path` from (`video_view_by_date` `vv` join `videos` `v` on((`vv`.`video_id` = `v`.`Id`))) group by `vv`.`video_year`,`vv`.`video_month`,`vv`.`video_day`,`vv`.`video_hour`) `ks_video_voilation` order by `ks_video_voilation`.`video_year` desc,`ks_video_voilation`.`video_month` desc,`ks_video_voilation`.`video_day` desc,`ks_video_voilation`.`video_hour` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `qry_video_day`
--

/*!50001 DROP VIEW IF EXISTS `qry_video_day`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `qry_video_day` AS select distinct `video_view`.`video_year` AS `video_year`,`video_view`.`video_month` AS `video_month`,`video_view`.`video_day` AS `video_day` from `video_view` */;
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

-- Dump completed on 2020-03-18 17:43:40
