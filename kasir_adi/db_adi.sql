-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Okt 2025 pada 09.46
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_adi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail` int(11) NOT NULL,
  `id_transaksi` char(14) NOT NULL,
  `nama_menu` varchar(30) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail`, `id_transaksi`, `nama_menu`, `harga`, `jumlah`, `subtotal`) VALUES
(11, '25101509429976', 'es susu', 20000, 3, 60000),
(12, '25101509429976', 'ayam geprek', 7000, 3, 21000),
(13, '25101509432370', 'bakso', 10000, 3, 30000),
(14, '25101509432370', 'ayam geprek', 7000, 3, 21000),
(15, '25101509455934', 'es susu', 20000, 4, 80000),
(16, '25101509455934', 'es capucino', 20000, 3, 60000),
(17, '25101509498635', 'es susu', 20000, 3, 60000),
(18, '25101509498635', 'es capucino', 20000, 3, 60000),
(19, '25101509532236', 'ayam geprek', 7000, 3, 21000),
(20, '25101509532236', 'es capucino', 20000, 2, 40000),
(21, '25101509545888', 'es susu', 20000, 2, 40000),
(22, '25101501265421', 'Nasi Goreng', 20000, 3, 60000),
(23, '25101501265421', 'es capucino', 20000, 2, 40000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_menu`
--

CREATE TABLE `jenis_menu` (
  `id_jenis` char(6) NOT NULL,
  `nama_jenis` varchar(30) NOT NULL,
  `status_jenis` enum('aktif','nonaktif','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `jenis_menu`
--

INSERT INTO `jenis_menu` (`id_jenis`, `nama_jenis`, `status_jenis`) VALUES
('J00001', 'minuman', 'aktif'),
('J00005', 'Tidak tersedia', 'aktif'),
('J35980', 'makanan pedas', 'aktif'),
('J45814', 'makanan', 'aktif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `konfigurasi`
--

CREATE TABLE `konfigurasi` (
  `id` int(11) NOT NULL,
  `nama_resto` varchar(40) NOT NULL,
  `alamat` text NOT NULL,
  `no_kantor` varchar(13) NOT NULL,
  `pajak` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `konfigurasi`
--

INSERT INTO `konfigurasi` (`id`, `nama_resto`, `alamat`, `no_kantor`, `pajak`) VALUES
(1, 'REST adi maulana', 'jalan soekarno adi 47', '088991151868', 10);

-- --------------------------------------------------------

--
-- Struktur dari tabel `menu`
--

CREATE TABLE `menu` (
  `id_menu` char(7) NOT NULL,
  `id_jenis` char(6) NOT NULL,
  `nama_menu` varchar(30) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `menu`
--

INSERT INTO `menu` (`id_menu`, `id_jenis`, `nama_menu`, `harga`) VALUES
('M000001', 'J00001', 'es teh', 10000),
('M309601', 'J00005', 'bakso', 10000),
('M462923', 'J00001', 'es susu', 20000),
('M552528', 'J00001', 'es capucino', 20000),
('M831892', 'J35980', 'mie jebeww', 20000),
('M933742', 'J45814', 'Nasi Goreng', 20000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `pesanan`
--

CREATE TABLE `pesanan` (
  `id` int(11) NOT NULL,
  `id_menu` char(7) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pesanan`
--

INSERT INTO `pesanan` (`id`, `id_menu`, `jumlah`, `subtotal`) VALUES
(71, 'M462923', 2, 40000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `petugas`
--

CREATE TABLE `petugas` (
  `id_petugas` char(5) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `no` varchar(13) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `level` enum('kasir','admin','owner','') NOT NULL,
  `status_petugas` enum('aktif','nonaktif','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `nama`, `no`, `username`, `password`, `level`, `status_petugas`) VALUES
('P0001', 'adi malana ', '088991151868', 'adi123', 'adi123', 'owner', 'aktif'),
('P0002', 'abas', '089256151612', 'abas12', 'abas12', 'admin', 'aktif'),
('P0003', 'riyadi lukmana', '085236572087', 'riyadi12', 'riyadi12', 'kasir', 'aktif'),
('P1207', 'abd rohman ', '0888238273', 'rohman12', 'rohman12', 'kasir', 'aktif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` char(14) NOT NULL,
  `id_petugas` char(5) NOT NULL,
  `tgl` datetime NOT NULL,
  `pelanggan` varchar(60) NOT NULL,
  `jenis_pesan` enum('dine in','take away','','') NOT NULL,
  `sub_total` int(11) NOT NULL,
  `persen` varchar(10) NOT NULL,
  `pajak` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `id_petugas`, `tgl`, `pelanggan`, `jenis_pesan`, `sub_total`, `persen`, `pajak`, `total`, `bayar`, `kembalian`) VALUES
('25101501265421', 'P0003', '2025-10-15 01:26:10', 'aura cinta', 'dine in', 100000, '10 %', 10000, 110000, 120000, 10000),
('25101509429976', 'P0003', '2025-10-15 09:42:43', 'adi', 'take away', 81000, '10 %', 8100, 89100, 100000, 10900),
('25101509432370', 'P0003', '2025-10-14 09:43:52', 'gyan', 'dine in', 51000, '10 %', 5100, 56100, 60000, 3900),
('25101509455934', 'P0003', '2025-10-15 09:45:19', 'adimau', 'dine in', 140000, '10 %', 14000, 154000, 160000, 6000),
('25101509498635', 'P0003', '2025-10-15 09:49:26', 'yoga', 'take away', 120000, '10 %', 12000, 132000, 140000, 8000),
('25101509532236', 'P1207', '2025-10-14 09:53:15', 'rohman', 'take away', 61000, '10 %', 6100, 67100, 100000, 32900),
('25101509545888', 'P1207', '2025-10-15 09:54:39', 'adisaja', 'dine in', 40000, '10 %', 4000, 44000, 50000, 6000);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `vdetaill`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `vdetaill` (
`id_detail` int(11)
,`id_transaksi` char(14)
,`id_petugas` char(5)
,`tgl` datetime
,`pelanggan` varchar(60)
,`jenis_pesan` enum('dine in','take away','','')
,`sub_total` int(11)
,`persen` varchar(10)
,`pajak` int(11)
,`total` int(11)
,`bayar` int(11)
,`kembalian` int(11)
,`nama_menu` varchar(30)
,`harga` int(11)
,`jumlah` int(11)
,`subtotal` int(11)
,`nama` varchar(60)
,`nama_resto` varchar(40)
,`alamat` text
,`no_kantor` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `viewmenu`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `viewmenu` (
`id_menu` char(7)
,`id_jenis` char(6)
,`nama_jenis` varchar(30)
,`status_jenis` enum('aktif','nonaktif','','')
,`nama_menu` varchar(30)
,`harga` int(11)
,`nama_resto` varchar(40)
,`alamat` text
,`no_kantor` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `vpesanan`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `vpesanan` (
`id` int(11)
,`id_menu` char(7)
,`id_jenis` char(6)
,`nama_jenis` varchar(30)
,`status_jenis` enum('aktif','nonaktif','','')
,`nama_menu` varchar(30)
,`harga` int(11)
,`jumlah` int(11)
,`subtotal` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `vpetugas`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `vpetugas` (
`id_petugas` char(5)
,`nama` varchar(60)
,`no` varchar(13)
,`username` varchar(20)
,`password` varchar(20)
,`level` enum('kasir','admin','owner','')
,`status_petugas` enum('aktif','nonaktif','','')
,`nama_resto` varchar(40)
,`alamat` text
,`no_kantor` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `vtransaksi`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `vtransaksi` (
`id_transaksi` char(14)
,`id_petugas` char(5)
,`nama` varchar(60)
,`tgl` datetime
,`pelanggan` varchar(60)
,`jenis_pesan` enum('dine in','take away','','')
,`sub_total` int(11)
,`persen` varchar(10)
,`pajak` int(11)
,`total` int(11)
,`bayar` int(11)
,`kembalian` int(11)
,`nama_resto` varchar(40)
,`alamat` text
);

-- --------------------------------------------------------

--
-- Struktur untuk view `vdetaill`
--
DROP TABLE IF EXISTS `vdetaill`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vdetaill`  AS SELECT `detail_transaksi`.`id_detail` AS `id_detail`, `detail_transaksi`.`id_transaksi` AS `id_transaksi`, `transaksi`.`id_petugas` AS `id_petugas`, `transaksi`.`tgl` AS `tgl`, `transaksi`.`pelanggan` AS `pelanggan`, `transaksi`.`jenis_pesan` AS `jenis_pesan`, `transaksi`.`sub_total` AS `sub_total`, `transaksi`.`persen` AS `persen`, `transaksi`.`pajak` AS `pajak`, `transaksi`.`total` AS `total`, `transaksi`.`bayar` AS `bayar`, `transaksi`.`kembalian` AS `kembalian`, `detail_transaksi`.`nama_menu` AS `nama_menu`, `detail_transaksi`.`harga` AS `harga`, `detail_transaksi`.`jumlah` AS `jumlah`, `detail_transaksi`.`subtotal` AS `subtotal`, `petugas`.`nama` AS `nama`, `konfigurasi`.`nama_resto` AS `nama_resto`, `konfigurasi`.`alamat` AS `alamat`, `konfigurasi`.`no_kantor` AS `no_kantor` FROM (`konfigurasi` join ((`petugas` join `transaksi` on(`transaksi`.`id_petugas` = `petugas`.`id_petugas`)) join `detail_transaksi` on(`detail_transaksi`.`id_transaksi` = `transaksi`.`id_transaksi`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `viewmenu`
--
DROP TABLE IF EXISTS `viewmenu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewmenu`  AS SELECT `menu`.`id_menu` AS `id_menu`, `menu`.`id_jenis` AS `id_jenis`, `jenis_menu`.`nama_jenis` AS `nama_jenis`, `jenis_menu`.`status_jenis` AS `status_jenis`, `menu`.`nama_menu` AS `nama_menu`, `menu`.`harga` AS `harga`, `konfigurasi`.`nama_resto` AS `nama_resto`, `konfigurasi`.`alamat` AS `alamat`, `konfigurasi`.`no_kantor` AS `no_kantor` FROM (`konfigurasi` join (`jenis_menu` join `menu` on(`menu`.`id_jenis` = `jenis_menu`.`id_jenis`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `vpesanan`
--
DROP TABLE IF EXISTS `vpesanan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vpesanan`  AS SELECT `pesanan`.`id` AS `id`, `pesanan`.`id_menu` AS `id_menu`, `menu`.`id_jenis` AS `id_jenis`, `jenis_menu`.`nama_jenis` AS `nama_jenis`, `jenis_menu`.`status_jenis` AS `status_jenis`, `menu`.`nama_menu` AS `nama_menu`, `menu`.`harga` AS `harga`, `pesanan`.`jumlah` AS `jumlah`, `pesanan`.`subtotal` AS `subtotal` FROM ((`menu` join `pesanan` on(`pesanan`.`id_menu` = `menu`.`id_menu`)) join `jenis_menu` on(`menu`.`id_jenis` = `jenis_menu`.`id_jenis`)) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `vpetugas`
--
DROP TABLE IF EXISTS `vpetugas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vpetugas`  AS SELECT `petugas`.`id_petugas` AS `id_petugas`, `petugas`.`nama` AS `nama`, `petugas`.`no` AS `no`, `petugas`.`username` AS `username`, `petugas`.`password` AS `password`, `petugas`.`level` AS `level`, `petugas`.`status_petugas` AS `status_petugas`, `konfigurasi`.`nama_resto` AS `nama_resto`, `konfigurasi`.`alamat` AS `alamat`, `konfigurasi`.`no_kantor` AS `no_kantor` FROM (`konfigurasi` join `petugas`) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `vtransaksi`
--
DROP TABLE IF EXISTS `vtransaksi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vtransaksi`  AS SELECT `transaksi`.`id_transaksi` AS `id_transaksi`, `transaksi`.`id_petugas` AS `id_petugas`, `petugas`.`nama` AS `nama`, `transaksi`.`tgl` AS `tgl`, `transaksi`.`pelanggan` AS `pelanggan`, `transaksi`.`jenis_pesan` AS `jenis_pesan`, `transaksi`.`sub_total` AS `sub_total`, `transaksi`.`persen` AS `persen`, `transaksi`.`pajak` AS `pajak`, `transaksi`.`total` AS `total`, `transaksi`.`bayar` AS `bayar`, `transaksi`.`kembalian` AS `kembalian`, `konfigurasi`.`nama_resto` AS `nama_resto`, `konfigurasi`.`alamat` AS `alamat` FROM (`konfigurasi` join (`petugas` join `transaksi` on(`transaksi`.`id_petugas` = `petugas`.`id_petugas`))) ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `id_transaksi` (`id_transaksi`);

--
-- Indeks untuk tabel `jenis_menu`
--
ALTER TABLE `jenis_menu`
  ADD PRIMARY KEY (`id_jenis`),
  ADD UNIQUE KEY `nama_jenis` (`nama_jenis`);

--
-- Indeks untuk tabel `konfigurasi`
--
ALTER TABLE `konfigurasi`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`),
  ADD UNIQUE KEY `nama_menu` (`nama_menu`),
  ADD KEY `id_jenis` (`id_jenis`);

--
-- Indeks untuk tabel `pesanan`
--
ALTER TABLE `pesanan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_menu` (`id_menu`);

--
-- Indeks untuk tabel `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id_petugas`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `no` (`no`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_petugas` (`id_petugas`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT untuk tabel `konfigurasi`
--
ALTER TABLE `konfigurasi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `pesanan`
--
ALTER TABLE `pesanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `transaksi` (`id_transaksi`);

--
-- Ketidakleluasaan untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`id_jenis`) REFERENCES `jenis_menu` (`id_jenis`);

--
-- Ketidakleluasaan untuk tabel `pesanan`
--
ALTER TABLE `pesanan`
  ADD CONSTRAINT `pesanan_ibfk_1` FOREIGN KEY (`id_menu`) REFERENCES `menu` (`id_menu`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_petugas`) REFERENCES `petugas` (`id_petugas`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
