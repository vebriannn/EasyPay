-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table ewallet.detail_aktifitas
CREATE TABLE IF NOT EXISTS `detail_aktifitas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pengguna` int DEFAULT NULL,
  `saldo_masuk` double DEFAULT NULL,
  `saldo_keluar` double DEFAULT NULL,
  `tahun` year NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Index 2` (`id_pengguna`),
  CONSTRAINT `FK_detail_aktifitas_users` FOREIGN KEY (`id_pengguna`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.detail_netflix
CREATE TABLE IF NOT EXISTS `detail_netflix` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomor_pembelian` varchar(50) NOT NULL,
  `produk` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Index 2` (`nomor_pembelian`),
  CONSTRAINT `FK_detail_netflix_riwayat_transaksi` FOREIGN KEY (`nomor_pembelian`) REFERENCES `riwayat_transaksi` (`nomor_pembelian`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.detail_payment
CREATE TABLE IF NOT EXISTS `detail_payment` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pengguna` int DEFAULT NULL,
  `nomor_tujuan` varchar(50) DEFAULT NULL,
  `jumlah_transfer` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_detail_payment_users` (`id_pengguna`),
  CONSTRAINT `FK_detail_payment_users` FOREIGN KEY (`id_pengguna`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.detail_pdam
CREATE TABLE IF NOT EXISTS `detail_pdam` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomor_pembelian` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `meteran_id` varchar(100) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  KEY `FK_detail_pdam_riwayat_transaksi` (`nomor_pembelian`),
  CONSTRAINT `FK_detail_pdam_riwayat_transaksi` FOREIGN KEY (`nomor_pembelian`) REFERENCES `riwayat_transaksi` (`nomor_pembelian`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.detail_pln
CREATE TABLE IF NOT EXISTS `detail_pln` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomor_pembelian` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nama` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `kwh` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `token_listrik` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `meteran_id` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Index 2` (`nomor_pembelian`),
  CONSTRAINT `FK_detail_pln_riwayat_transaksi` FOREIGN KEY (`nomor_pembelian`) REFERENCES `riwayat_transaksi` (`nomor_pembelian`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.detail_pulsa_data
CREATE TABLE IF NOT EXISTS `detail_pulsa_data` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomor_pembelian` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `kategori_produk` enum('pulsa','data') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nomor` varchar(50) NOT NULL,
  `produk` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `status` enum('berhasil','gagal') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_detail_pulsa_riwayat_transaksi` (`nomor_pembelian`),
  CONSTRAINT `FK_detail_pulsa_riwayat_transaksi` FOREIGN KEY (`nomor_pembelian`) REFERENCES `riwayat_transaksi` (`nomor_pembelian`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.riwayat_transaksi
CREATE TABLE IF NOT EXISTS `riwayat_transaksi` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pengguna` int NOT NULL,
  `nomor_pembelian` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `jenis_pembelian` enum('pln','pdam','pulsa','data','netflix') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `harga` double NOT NULL,
  `tanggal_pembelian` datetime NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE KEY `Index 2` (`nomor_pembelian`),
  KEY `FK_riwayat_transaksi_users` (`id_pengguna`),
  CONSTRAINT `FK_riwayat_transaksi_users` FOREIGN KEY (`id_pengguna`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.riwayat_transfer
CREATE TABLE IF NOT EXISTS `riwayat_transfer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pengguna` int NOT NULL,
  `kode_transfer` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nama` varchar(50) NOT NULL,
  `bank_tujuan` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `no_rek` varchar(50) NOT NULL,
  `total_transfer` double NOT NULL,
  `fee_admin` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK__users` (`id_pengguna`),
  CONSTRAINT `FK__users` FOREIGN KEY (`id_pengguna`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

-- Dumping structure for table ewallet.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `gender` enum('pria','perempuan') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `nomor` varchar(255) NOT NULL,
  `pin` varchar(50) NOT NULL DEFAULT '',
  `tipe_pengguna` enum('premium','free') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'free',
  `saldo_wallet` double NOT NULL DEFAULT '0',
  KEY `Index 1` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
