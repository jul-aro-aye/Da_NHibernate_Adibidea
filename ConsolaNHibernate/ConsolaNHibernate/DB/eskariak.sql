CREATE TABLE `eskariak` (
  `id` int NOT NULL AUTO_INCREMENT,
  `data` date DEFAULT NULL,
  `zenbatekoa` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


INSERT INTO hibernateprobak.eskariak (`data`,zenbatekoa) VALUES
	 ('2025-10-25',20.99),
	 ('2025-09-30',80.00),
	 ('2025-10-15',55.25);
