
CREATE TABLE `configuaration_type_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `configuaration_description` nvarchar(100) DEFAULT NULL,
  `configuration_remarks_fld` nvarchar(500) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
); 