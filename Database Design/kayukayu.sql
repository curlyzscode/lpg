-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 02, 2020 at 09:33 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kayukayu`
--

-- --------------------------------------------------------

--
-- Table structure for table `dailyclosing`
--

CREATE TABLE `dailyclosing` (
  `id_daily` varchar(20) NOT NULL,
  `jumlah_transaksi` int(11) NOT NULL,
  `jumlah_item_terjual` int(11) NOT NULL,
  `jumlah_pendapatan` double NOT NULL,
  `jumlah_harga_konter` double NOT NULL,
  `jumlah_keuntungan` double NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail_transaksi` int(11) NOT NULL,
  `id_transaksi` varchar(20) NOT NULL,
  `id_menu` varchar(20) NOT NULL,
  `nama_menu` varchar(50) NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `stok` int(11) NOT NULL,
  `harga_jual` double NOT NULL,
  `qty` int(11) NOT NULL,
  `total_harga` double NOT NULL,
  `status_transaksi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail_transaksi`, `id_transaksi`, `id_menu`, `nama_menu`, `kategori`, `stok`, `harga_jual`, `qty`, `total_harga`, `status_transaksi`) VALUES
(79, '2002010001', 'B0001', 'Bakso', 'Makanan', 20, 13000, 1, 13000, 'Refund'),
(80, '2002010001', 'C0001', 'Suki', 'Makanan', 3, 20000, 1, 20000, 'Refund'),
(81, '2002010001', 'A0002', 'Teh Manis', 'Minuman', 15, 4000, 1, 4000, 'Berhasil'),
(83, '2002010002', 'A0001', 'Kopi', 'Minuman', 10, 5000, 2, 10000, 'Berhasil'),
(84, '2002010002', 'B0001', 'Bakso', 'Makanan', 20, 13000, 1, 13000, 'Refund'),
(87, '2002010003', 'A0001', 'Kopi', 'Minuman', 10, 5000, 2, 10000, 'Berhasil'),
(88, '2002010003', 'B0001', 'Bakso', 'Makanan', 20, 13000, 2, 26000, 'Berhasil'),
(89, '2002010004', 'A0001', 'Kopi', 'Minuman', 10, 5000, 2, 10000, 'Berhasil'),
(90, '2002010005', 'A0001', 'Kopi', 'Minuman', 10, 5000, 2, 10000, 'Berhasil'),
(91, '2002010006', 'A0002', 'Teh Manis', 'Minuman', 15, 4000, 2, 8000, 'Berhasil'),
(92, '2002010007', 'A0002', 'Teh Manis', 'Minuman', 15, 4000, 3, 12000, 'Berhasil'),
(93, '2002010008', 'A0001', 'Kopi', 'Minuman', 10, 5000, 4, 20000, 'Berhasil'),
(94, '2002020001', 'A0002', 'Teh Manis', 'Minuman', 15, 4000, 2, 8000, 'Berhasil'),
(95, '2002020001', 'C0001', 'Suki', 'Makanan', 3, 20000, 1, 20000, 'Refund'),
(101, '2002020002', 'c0001', 'Suki', 'Makanan', 3, 20000, 2, 40000, 'Berhasil');

-- --------------------------------------------------------

--
-- Table structure for table `konter`
--

CREATE TABLE `konter` (
  `id_konter` varchar(20) NOT NULL,
  `nama_konter` varchar(50) NOT NULL,
  `owner` varchar(50) NOT NULL,
  `nik` varchar(30) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_hp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `konter`
--

INSERT INTO `konter` (`id_konter`, `nama_konter`, `owner`, `nik`, `alamat`, `no_hp`) VALUES
('A', 'Dapur Julied', 'Rika Susanti', '32146789726357', 'Purwakarta', '089678543214'),
('B', 'Kedai Minuman', 'Bang Toyib', '32145789076543', 'Maracang', '089765432134'),
('C', 'Suki ', 'Koh Asep', '32134567890987', 'Purwakarta', '087654324567');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id_menu` varchar(20) NOT NULL,
  `nama_menu` varchar(50) NOT NULL,
  `harga_jual` double NOT NULL,
  `harga_konter` double NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `stok` int(11) NOT NULL,
  `id_konter` varchar(20) NOT NULL,
  `username_input` varchar(20) NOT NULL,
  `waktu_input` datetime NOT NULL,
  `username_edit` varchar(20) NOT NULL,
  `waktu_edit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`id_menu`, `nama_menu`, `harga_jual`, `harga_konter`, `kategori`, `stok`, `id_konter`, `username_input`, `waktu_input`, `username_edit`, `waktu_edit`) VALUES
('A0001', 'Kopi', 5000, 3000, 'Minuman', 10, 'A', 'tiacahyantri', '2020-02-01 09:20:22', 'tiacahyantri', '2020-02-02 10:57:51'),
('A0002', 'Teh Manis', 4000, 3000, 'Minuman', 10, 'A', 'tiacahyantri', '2020-02-01 11:56:45', 'tiacahyantri', '2020-02-02 11:01:37'),
('B0001', 'Bakso', 13000, 12000, 'Makanan', 10, 'B', 'tiacahyantri', '2020-02-01 09:39:09', 'tiacahyantri', '2020-02-02 11:01:59'),
('B0002', 'Mie Ayam', 13000, 12000, 'Makanan', 7, 'B', 'tiacahyantri', '2020-02-01 11:57:22', '', '0000-00-00 00:00:00'),
('C0001', 'Suki', 20000, 18000, 'Makanan', 3, 'C', 'tiacahyantri', '2020-02-01 11:56:06', '', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `refund`
--

CREATE TABLE `refund` (
  `id_refund` int(20) NOT NULL,
  `id_transaksi` varchar(20) NOT NULL,
  `id_menu` varchar(20) NOT NULL,
  `nama_menu` varchar(20) NOT NULL,
  `qty` int(11) NOT NULL,
  `harga_jual` double NOT NULL,
  `total_harga` double NOT NULL,
  `nominal_refund` double NOT NULL,
  `status_transaksi` varchar(20) NOT NULL,
  `ket_refund` varchar(50) NOT NULL,
  `username` varchar(20) NOT NULL,
  `waktu_refund` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `refund`
--

INSERT INTO `refund` (`id_refund`, `id_transaksi`, `id_menu`, `nama_menu`, `qty`, `harga_jual`, `total_harga`, `nominal_refund`, `status_transaksi`, `ket_refund`, `username`, `waktu_refund`) VALUES
(1, '2002010001', 'B0001', 'Bakso', 1, 13000, 13000, 13000, 'Refund', 'Pemesanan Lebih', 'tiacahyantri', '2020-02-01 14:30:47'),
(2, '2002020001', 'C0001', 'Suki', 1, 20000, 20000, 20000, 'Refund', 'Kelebihan', 'tiacahyantri', '2020-02-02 10:56:28');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(20) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `waktu_transaksi` time NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `no_meja` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `diskon` int(11) NOT NULL,
  `total_bayar` double NOT NULL,
  `pembayaran` double NOT NULL,
  `kembalian` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `tanggal_transaksi`, `waktu_transaksi`, `nama_pelanggan`, `no_meja`, `username`, `diskon`, `total_bayar`, `pembayaran`, `kembalian`) VALUES
('2002010001', '0000-00-00', '11:59:27', 'Tia', 5, 'tiacahyantri', 2, 58800, 60000, 1200),
('2002010002', '0000-00-00', '13:01:40', 'Kiki', 1, 'tiacahyantri', 0, 36000, 40000, 4000),
('2002010003', '0000-00-00', '15:37:44', 'Mamah', 3, 'tiacahyantri', 5, 34200, 35000, 800),
('2002010004', '0000-00-00', '00:00:00', 'Huu', 3, 'tiacahyantri', 0, 10000, 10000, 0),
('2002010005', '0000-00-00', '15:46:39', 'Bibi', 3, 'tiacahyantri', 0, 10000, 10000, 0),
('2002010006', '0000-00-00', '15:48:11', 'Hii', 2, 'tiacahyantri', 0, 8000, 10000, 2000),
('2002010007', '0000-00-00', '15:51:20', 'Tia', 3, 'tiacahyantri', 0, 12000, 15000, 3000),
('2002010008', '0000-00-00', '15:53:31', 'Tia', 3, 'tiacahyantri', 0, 20000, 20000, 0),
('2002020001', '0000-00-00', '10:54:36', 'Tia', 4, 'tiacahyantri', 4, 46080, 50000, 3920),
('2002020002', '2020-02-02', '11:40:25', 'FGHF', 3, '', 2, 39200, 40000, 800);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(12) NOT NULL,
  `status` varchar(20) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `bagian` varchar(30) NOT NULL,
  `jenis_kelamin` varchar(20) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_hp` varchar(20) NOT NULL,
  `status_kerja` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `status`, `nama_user`, `bagian`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `no_hp`, `status_kerja`) VALUES
('sekar', '123456', 'Admin', 'Sekar Nur', 'Admin', 'Perempuan', 'Purwakarta', '2000-01-31', 'Purwakarta', '089765434567', 'Tidak Aktif'),
('tiacahyantri', '123456789', 'Admin', 'Tia Cahyantri', 'Admin', 'Perempuan', 'Purwakarta', '2000-11-28', 'Purwakarta', '081210305329', 'Aktif');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dailyclosing`
--
ALTER TABLE `dailyclosing`
  ADD PRIMARY KEY (`id_daily`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail_transaksi`),
  ADD KEY `id_menu` (`id_menu`),
  ADD KEY `id_transaksi` (`id_transaksi`);

--
-- Indexes for table `konter`
--
ALTER TABLE `konter`
  ADD PRIMARY KEY (`id_konter`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`),
  ADD KEY `id_konter` (`id_konter`),
  ADD KEY `username` (`username_input`);

--
-- Indexes for table `refund`
--
ALTER TABLE `refund`
  ADD PRIMARY KEY (`id_refund`),
  ADD KEY `id_transaksi` (`id_transaksi`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT for table `refund`
--
ALTER TABLE `refund`
  MODIFY `id_refund` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `dailyclosing`
--
ALTER TABLE `dailyclosing`
  ADD CONSTRAINT `dailyclosing_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`);

--
-- Constraints for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_2` FOREIGN KEY (`id_menu`) REFERENCES `menu` (`id_menu`);

--
-- Constraints for table `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`id_konter`) REFERENCES `konter` (`id_konter`);

--
-- Constraints for table `refund`
--
ALTER TABLE `refund`
  ADD CONSTRAINT `refund_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `transaksi` (`id_transaksi`),
  ADD CONSTRAINT `refund_ibfk_2` FOREIGN KEY (`username`) REFERENCES `user` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
