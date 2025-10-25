CREATE TABLE `erabiltzaileak` (
  `idx` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idx`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



INSERT INTO hibernateprobak.erabiltzaileak (usuario,nombre,email) VALUES
	 ('jul_aro_aye','Julen Arostegi','julen@goierri.eus'),
	 ('iker_urr_iri','Iker','iker@gmail.com');
