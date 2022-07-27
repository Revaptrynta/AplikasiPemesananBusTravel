-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 27, 2022 at 11:01 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `travel`
--

-- --------------------------------------------------------

--
-- Table structure for table `kendaraan`
--

CREATE TABLE `kendaraan` (
  `id_transaksi` varchar(50) NOT NULL,
  `kelas` varchar(20) NOT NULL,
  `jumlah_bus` int(10) NOT NULL,
  `merk` varchar(25) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `tgl_berangkat` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kendaraan`
--

INSERT INTO `kendaraan` (`id_transaksi`, `kelas`, `jumlah_bus`, `merk`, `warna`, `tgl_berangkat`) VALUES
('IT001', 'Reguler', 3, 'Mercedes-Benz (Reguler)', 'Hijau', '2022-05-08'),
('IT002', 'Ekonomi', 2, 'Hino AK8 (Ekonomi)', 'Biru', '2022-05-01'),
('IT003', 'Reguler', 1, 'Mercedes-Benz (Reguler)', 'Putih', '2022-05-14'),
('IT004', 'VIP', 3, 'jetbus 3+ SDD (VIP)', 'Abu - abu', '2022-04-20'),
('IT005', 'Ekonomi', 1, 'Hino AK8 (Ekonomi)', 'Merah', '2022-06-12'),
('IT006', 'Reguler', 3, 'Mercedes-Benz (Reguler)', 'Biru', '2022-06-26'),
('IT007', 'VIP', 5, 'jetbus 3+ SDD (VIP)', 'Putih', '2022-04-20'),
('IT008', 'Ekonomi', 2, 'Hino AK8 (Ekonomi)', 'Hijau', '2022-08-27'),
('IT009', 'VIP', 4, 'jetbus 3+ SDD (VIP)', 'Hitam', '2022-08-27'),
('IT010', 'Ekonomi', 1, 'Hino AK8 (Ekonomi)', 'Orange', '2022-04-20'),
('IT011', 'Ekonomi', 1, 'Hino AK8 (Ekonomi)', 'Biru', '2022-05-08'),
('IT012', 'Reguler', 4, 'Mercedes-Benz (Reguler)', 'Biru', '2022-06-19');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `kode_travel` varchar(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `tujuan` varchar(100) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `alur_kegiatan` varchar(100) NOT NULL,
  `harga_paket` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`kode_travel`, `nama`, `alamat`, `jenis_kelamin`, `tujuan`, `no_telp`, `alur_kegiatan`, `harga_paket`) VALUES
('KT01', 'Reva', 'Jakarta Utara', 'Perempuan', 'Malang, Jawa Timur', '089622686423', 'Bromo - Kampung Warna warni', '1200000'),
('KT02', 'Ahmad', 'Pondok Kopi, Jakarta timur', 'Laki-laki', 'Bandung, Jawa Barat', '087676545345', 'Kawah Putih Ciwedey', '800000'),
('KT03', 'Silvi', 'Tipar Cakung, Jakarta Timur', 'Perempuan', 'Bogor, Jawa Barat', '0876786545', 'Kebun Raya Bogor', '450000'),
('KT04', 'Wahyu', 'Pulo Gadung, Jakarta Timur', 'Laki-laki', 'Yogyakarta', '089767564564', 'Borobudur - Malioboro', '900000'),
('KT05', 'Rani', 'Sukapura, Jakarta Utara', 'Perempuan', 'TMII, Jakarta Timur', '087654567632', 'Taman Mini Indonesia Indah', '350000'),
('KT06', 'Sofi', 'Babelan, Bekasi', 'Perempuan', 'Tegal, Jawa Tengah', '0812345678675', 'Guci - Bukit Bintang', '900000'),
('KT07', 'Adit', 'Cilincing, Jakarta Utara', 'Laki-laki', 'Lembang Bandung, Jawa Barat', '085743256453', 'Kawah Putih ciwedey - Tangkuban perahu', '800000'),
('KT08', 'Sofyan', 'Pik, Jakarta Timur', 'Laki-laki', 'Bogor, Jawa Barat', '086543456732', 'Curug Ciburial - Goa agung garungang', '450000'),
('KT09', 'Rizky', 'Kelapa gading, Jakarta Utara', 'Laki-laki', 'Malang, Jawa Timur', '08765254323', 'Candi Jago - Taman Kelinci', '1200000'),
('KT10', 'Aqil', 'Kalimalang, Jakarta Timur', 'Laki-laki', 'Monas, Jakarta pusat', '087654567854', 'Monas - Kota Tua', '350000'),
('KT11', 'Vina', 'Jakarta Barat', 'Perempuan', 'Jakarta Selatan', '085642346783', 'Ragunan', '700000'),
('KT12', 'Putri', 'Jakarta Selatan', 'Perempuan', 'Kota Batu malang Jatim', '0865765466', 'Jatim Park - Museum Angkut', '1200000');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(10) NOT NULL,
  `tanggal` varchar(20) NOT NULL,
  `kode_taravel` varchar(10) NOT NULL,
  `tujuan` varchar(100) NOT NULL,
  `Jumlah_bus` int(10) NOT NULL,
  `kelas` varchar(25) NOT NULL,
  `total_harga` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `tanggal`, `kode_taravel`, `tujuan`, `Jumlah_bus`, `kelas`, `total_harga`) VALUES
('IT001', '2022-05-08', 'KT01', 'Malang, Jawa Timur', 3, 'Reguler', '53.100.000'),
('IT002', '2022-05-01', 'KT02', 'Bandung, Jawa Barat', 2, 'Ekonomi', '8.600.000'),
('IT003', '2022-05-14', 'KT03', 'Bogor, Jawa Barat', 1, 'Reguler', '16.950.000'),
('IT004', '2022-04-20', 'KT04', 'Yogyakarta', 3, 'VIP', '53.700.000'),
('IT005', '2022-06-12', 'KT05', 'TMII, Jakarta Timur', 1, 'Ekonomi', '7.350.000'),
('IT006', '2022-06-26', 'KT06', 'Tegal, Jawa Tengah', 3, 'Reguler', '68.700.000'),
('IT007', '2022-04-20', 'KT07', 'Lembang Bandung, Jawa Barat', 5, 'VIP', '89.000.000'),
('IT008', '2022-08-27', 'KT08', 'Bogor, Jawa Barat', 2, 'Ekonomi', '42.900.000'),
('IT009', '2022-08-27', 'KT09', 'Malang, Jawa Timur', 4, 'VIP', '106.800.000'),
('IT010', '2022-04-20', 'KT10', 'Monas, Jakarta pusat', 1, 'Ekonomi', '10.850.000'),
('IT011', '2022-05-08', 'KT11', 'Jakarta Selatan', 1, 'Ekonomi', '4.200.000'),
('IT012', '2022-06-19', 'KT12', 'Kota Batu malang Jatim', 4, 'Reguler', '70.800.000');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(50) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `password` varchar(10) NOT NULL,
  `status` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `nama`, `password`, `status`) VALUES
('admin', 'Yanita', '1212', 'ADMIN'),
('reva', 'REVA', '1234', 'PELANGGAN');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`kode_travel`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
