-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 06 Jul 2023 pada 12.15
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_uas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `judul_film`
--

CREATE TABLE `judul_film` (
  `ID_FILM` varchar(20) NOT NULL,
  `Nama_Film` varchar(50) NOT NULL,
  `Jam_Tayang` varchar(20) NOT NULL,
  `Hari` varchar(10) NOT NULL,
  `Studio` varchar(10) NOT NULL,
  `Harga_Tiket` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `judul_film`
--

INSERT INTO `judul_film` (`ID_FILM`, `Nama_Film`, `Jam_Tayang`, `Hari`, `Studio`, `Harga_Tiket`) VALUES
('F2D2', 'Final 2', '20.00 WIB', 'Senin', 'Regular 2D', 40000),
('JD4', 'Jumanji', '20.00WIB', 'Sabtu', 'Studio 4DX', 61000),
('JRVR', 'Jurasic Park', '18.00', 'Sabtu', 'RealD 3D', 54000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `member`
--

CREATE TABLE `member` (
  `ID_Member` bigint(20) NOT NULL,
  `NamaPengguna` varchar(50) NOT NULL,
  `JenisKelamin` varchar(10) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `NoTlp` varchar(50) NOT NULL,
  `Alamat` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `member`
--

INSERT INTO `member` (`ID_Member`, `NamaPengguna`, `JenisKelamin`, `Email`, `NoTlp`, `Alamat`) VALUES
(72023001, 'Lintang', 'Laki-laki', 'lintang.lp', '09876', 'Karanganyar'),
(72023002, 'Lintung', 'Laki-laki', 'Lintung,llp', '876', 'jhgw');

-- --------------------------------------------------------

--
-- Struktur dari tabel `studio`
--

CREATE TABLE `studio` (
  `KodeStudio` varchar(10) NOT NULL,
  `NamaStudio` varchar(20) NOT NULL,
  `Kapasitas` bigint(20) NOT NULL,
  `TipeCinema` varchar(10) NOT NULL,
  `LebarCinema` varchar(50) NOT NULL,
  `TipeProyektor` varchar(50) NOT NULL,
  `TipeSound` varchar(50) NOT NULL,
  `Sweetbox` varchar(50) NOT NULL,
  `SensorRealistis` varchar(50) NOT NULL,
  `HargaStudio` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `studio`
--

INSERT INTO `studio` (`KodeStudio`, `NamaStudio`, `Kapasitas`, `TipeCinema`, `LebarCinema`, `TipeProyektor`, `TipeSound`, `Sweetbox`, `SensorRealistis`, `HargaStudio`) VALUES
('4DX', 'Studio 4DX', 150, 'Flat', '30 x 12M', 'Absolute Cinema Experience', 'Dolby Digital 7.1', 'Tidak', 'Iya', 16000),
('R2D', 'Regular 2D', 209, 'Curve', '20 x 10M', 'Cannon Proyektor 4K', 'Dolby Digital 7.1', 'Tidak', 'Tidak', 10000),
('R3D', 'RealD 3D', 200, 'Flat', '20 x 10M', 'circular polarized', 'Dolby Digital 7.1', 'Tidak', 'Tidak', 14000),
('SBX', 'SweetBox', 70, 'Flat', '20 x 9M', 'Barco Proyektor 8K', 'Dolby Digital 7.1', 'YA', 'Tidak', 30000),
('STRM', 'Starium', 425, 'Flat', '20 x 8M', 'Barco Proyektor 4K', 'Dolby Digital 7.1', 'tidak', 'tidak', 5000),
('SVC', 'Velvet Class', 50, 'Flat', '30 x 12M', 'Barco Proyektor 12K', 'Dolby Digital 7.1', 'YA', 'Tidak', 50000),
('SX', 'ScreenX', 100, 'Flat 270 D', '50 x 12M', 'Barco Proyektor 8K', 'Dolby Digital 7.1', 'Tidak', 'Tidak', 20000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_Transaksi` int(11) NOT NULL,
  `Member` varchar(20) NOT NULL,
  `Member_Nama` varchar(50) NOT NULL,
  `Judul_Film` varchar(15) NOT NULL,
  `Studio` varchar(15) NOT NULL,
  `Hari` varchar(15) NOT NULL,
  `JamTayang` varchar(20) NOT NULL,
  `NoKursi` varchar(20) NOT NULL,
  `Harga` bigint(20) NOT NULL,
  `Jumlah_Tiket` bigint(20) NOT NULL,
  `D_TotalHarga` bigint(20) NOT NULL,
  `D_Discount` bigint(20) NOT NULL,
  `D_TotalBayar` bigint(20) NOT NULL,
  `B_Pembayaran` bigint(20) NOT NULL,
  `B_Kembalian` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`ID_Transaksi`, `Member`, `Member_Nama`, `Judul_Film`, `Studio`, `Hari`, `JamTayang`, `NoKursi`, `Harga`, `Jumlah_Tiket`, `D_TotalHarga`, `D_Discount`, `D_TotalBayar`, `B_Pembayaran`, `B_Kembalian`) VALUES
(2433, '72023001', 'Lintang', 'Final 2', 'Regular 2D', 'Senin', '20.00 WIB', '300', 40000, 10, 400000, 58000, 342000, 350000, 8000),
(2434, '72023001', 'Lintang', 'Final 2', 'Regular 2D', 'Senin', '20.00 WIB', 'A2', 40000, 6, 240000, 34800, 205200, 300000, 94800),
(2435, '72023001', 'Lintang', 'Final 2', 'Regular 2D', 'Senin', '20.00 WIB', 'C4', 40000, 4, 160000, 8000, 152000, 200000, 48000),
(2436, '72023002', 'Lintung', 'Jumanji', 'Studio 4DX', 'Sabtu', '20.00WIB', 'D3', 61000, 7, 427000, 61915, 365085, 400000, 34915);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `judul_film`
--
ALTER TABLE `judul_film`
  ADD PRIMARY KEY (`ID_FILM`);

--
-- Indeks untuk tabel `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`ID_Member`);

--
-- Indeks untuk tabel `studio`
--
ALTER TABLE `studio`
  ADD PRIMARY KEY (`KodeStudio`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_Transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
