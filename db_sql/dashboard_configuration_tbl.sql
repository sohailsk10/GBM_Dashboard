
CREATE TABLE `configuration_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `config_type_id` int(11) NOT NULL,
  `configuaration_description_fld` nvarchar(100) DEFAULT NULL,
  `configuration_remarks_fld` nvarchar(500) DEFAULT NULL,
  `user_def1_fld` nvarchar(100) DEFAULT NULL,
  `user_def2_fld` nvarchar(100) DEFAULT NULL,
  `user_def3_fld` nvarchar(100) DEFAULT NULL,
  `user_def4_fld` nvarchar(100) DEFAULT NULL,
  `user_def5_fld` nvarchar(100) DEFAULT NULL,
  
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`) /*!80000 INVISIBLE */,
  KEY `fk_config_tbl_config_type_tbl_idx` (`config_type_id`),
  CONSTRAINT `fk_config_tbl_config_type_tbl` FOREIGN KEY (`config_type_id`) REFERENCES `configuration_type_tbl` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
); 