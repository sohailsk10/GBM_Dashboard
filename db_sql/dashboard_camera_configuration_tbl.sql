
CREATE TABLE `camera_configuration_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `folder_fid` varchar(500) DEFAULT NULL,
  `camera_ip_fid` varchar(100) DEFAULT NULL,
  `camera_user_id` varchar(50) DEFAULT NULL,
  `camera_password_fid` varchar(50) DEFAULT NULL,
  `camera_port_no_fid` int(11) DEFAULT NULL,
  `camera_active_fid` int(11) DEFAULT NULL,
  `config_id_fld` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  KEY `fk_camera_config_tbl_config_tbl_idx` (`config_id_fld`),
  CONSTRAINT `fk_camera_config_tbl_config_tbl` FOREIGN KEY (`config_id_fld`) REFERENCES `configuration_tbl` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ;