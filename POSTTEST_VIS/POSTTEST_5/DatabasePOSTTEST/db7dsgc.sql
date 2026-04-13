-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Apr 2026 pada 17.36
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db7dsgc`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbatribute`
--

CREATE TABLE `tbatribute` (
  `kodeatribut` varchar(10) NOT NULL,
  `atribut` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbatribute`
--

INSERT INTO `tbatribute` (`kodeatribut`, `atribut`) VALUES
('Atribute1', 'Fire'),
('Atribute2', 'Water'),
('Atribute3', 'Earth'),
('Atribute4', 'Lightning'),
('Atribute5', 'Wind'),
('Atribute6', 'Light'),
('Atribute7', 'Darkness');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkarakter`
--

CREATE TABLE `tbkarakter` (
  `kodekarakter` varchar(15) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `kodeAtribut` varchar(10) NOT NULL,
  `atk` int(12) NOT NULL,
  `def` int(12) NOT NULL,
  `hp` int(12) NOT NULL,
  `pasif` varchar(255) NOT NULL,
  `skill1` varchar(255) NOT NULL,
  `skill2` varchar(255) NOT NULL,
  `ultimate` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbkarakter`
--

INSERT INTO `tbkarakter` (`kodekarakter`, `nama`, `kodeAtribut`, `atk`, `def`, `hp`, `pasif`, `skill1`, `skill2`, `ultimate`) VALUES
('char1', 'Budi', 'Atribute5', 1, 2, 3, 'Pasif', 'Skill1', 'Skill2', 'Ultimate'),
('Char2', 'Rikooooo', 'Atribute4', 879, 633, 14210, 'setiap menggunakan skill akan mengakibatkan tambahan damage sebanyak 10% attack (mengabaikan deffense)', 'Memberikan damage sebesar 150% atk kepada semua musuh', 'Memberikan damage sebesar 250% pada 1 musuh', 'Meningkatkan semua stat sebanyak 30% kemudian memberikan damage sebesar 250% atk kepada semua musuh');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbatribute`
--
ALTER TABLE `tbatribute`
  ADD PRIMARY KEY (`kodeatribut`);

--
-- Indeks untuk tabel `tbkarakter`
--
ALTER TABLE `tbkarakter`
  ADD PRIMARY KEY (`kodekarakter`),
  ADD KEY `charatribute` (`kodeAtribut`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbkarakter`
--
ALTER TABLE `tbkarakter`
  ADD CONSTRAINT `charatribute` FOREIGN KEY (`kodeAtribut`) REFERENCES `tbatribute` (`kodeatribut`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
