CREATE TABLE `helbideak` (
  `idx` int NOT NULL AUTO_INCREMENT,
  `calle` varchar(50) DEFAULT NULL,
  `ciudad` varchar(30) DEFAULT NULL,
  `codigoPostal` varchar(10) DEFAULT NULL,
  `usuario_idx` int DEFAULT NULL,
  PRIMARY KEY (`idx`),
  UNIQUE KEY `usuario_idx` (`usuario_idx`),
  KEY `usuario_idx_2` (`usuario_idx`),
  CONSTRAINT `FK_4981AD67` FOREIGN KEY (`usuario_idx`) REFERENCES `erabiltzaileak` (`idx`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


INSERT INTO hibernateprobak.helbideak (calle,ciudad,codigoPostal,usuario_idx) VALUES
	 ('Samperio','Ordizia','20240',1),
	 ('Calle Falsa 123','Bilbao','48001',4);
