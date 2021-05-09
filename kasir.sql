-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Nov 2018 pada 04.40
-- Versi server: 10.1.33-MariaDB
-- Versi PHP: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lks_kasir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_beli`
--

CREATE TABLE `detail_beli` (
  `id_beli` varchar(20) NOT NULL,
  `id_barang` varchar(20) NOT NULL,
  `qty` int(11) NOT NULL,
  `disc` int(11) DEFAULT NULL,
  `subtotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_beli`
--

INSERT INTO `detail_beli` (`id_beli`, `id_barang`, `qty`, `disc`, `subtotal`) VALUES
('123', 'B0001', 2, 0, 20000),
('12323', 'B0001', 20, 0, 240000),
('1000', 'B0002', 100, 0, 1000000),
('1000', 'B0001', 10, 0, 120000),
('09091', 'B0001', 10, 0, 120000),
('09091', 'B0002', 10, 0, 100000),
('0099', 'B0002', 10, 0, 100000),
('0099', 'B0001', 10, 0, 120000),
('111111', 'B0002', 10, 10, 90000),
('111111', 'B0001', 10, 5, 114000),
('039029320', 'B0001', 10, 10, 108000);

--
-- Trigger `detail_beli`
--
DELIMITER $$
CREATE TRIGGER `after_beli` AFTER INSERT ON `detail_beli` FOR EACH ROW BEGIN
update tb_barang set jumlah = new.qty + jumlah where id_barang = new.id_barang;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `delete_beli` AFTER DELETE ON `detail_beli` FOR EACH ROW BEGIN
update tb_barang set jumlah = jumlah - old.qty where id_barang = old.id_barang;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_jual`
--

CREATE TABLE `detail_jual` (
  `id_jual` varchar(20) NOT NULL,
  `id_barang` varchar(20) NOT NULL,
  `qty` int(11) NOT NULL,
  `disc` int(11) DEFAULT NULL,
  `subtotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_jual`
--

INSERT INTO `detail_jual` (`id_jual`, `id_barang`, `qty`, `disc`, `subtotal`) VALUES
('Anu-0001/09/2018', 'B0002', 2, 0, 24000),
('Anu-0001/09/2018', 'B0001', 4, 0, 60000),
('Anu-0002/09/2018', 'B0002', 4, 0, 48000),
('Anu-0003/09/2018', 'B0001', 2, 0, 30000),
('Anu-0004/09/2018', 'B0002', 1, 0, 12000),
('Anu-0005/09/2018', 'B0002', 1, 0, 12000),
('Anu-0006/09/2018', 'B0001', 2, 0, 24000),
('Anu-0007/09/2018', 'B0001', 2, 0, 30000),
('Anu-0008/09/2018', 'B0002', 2, 0, 24000),
('Anu-0008/09/2018', 'B0001', 10, 0, 150000);

--
-- Trigger `detail_jual`
--
DELIMITER $$
CREATE TRIGGER `after_jual` AFTER INSERT ON `detail_jual` FOR EACH ROW BEGIN
UPDATE tb_barang SET jumlah = jumlah - new.qty 
where id_barang = new.id_barang;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `delete_jual` AFTER DELETE ON `detail_jual` FOR EACH ROW BEGIN

UPDATE tb_barang SET jumlah = jumlah + old.qty 
where id_barang = old.id_barang;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `header_beli`
--

CREATE TABLE `header_beli` (
  `id_beli` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  `kasir` varchar(20) NOT NULL,
  `supplier` varchar(20) NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `header_beli`
--

INSERT INTO `header_beli` (`id_beli`, `tanggal`, `kasir`, `supplier`, `total`) VALUES
('0099', '2018-09-20', 'KR00001', 'S001', 220000),
('039029320', '2018-09-20', 'KR00001', 'S001', 204000),
('09091', '2018-09-20', 'KR00001', 'S002', 0),
('1000', '2018-09-20', 'KR00001', 'S002', 0),
('111111', '2018-09-20', 'KR00001', 'S002', 204000),
('123', '2018-09-20', 'KR00002', 'S001', 20000),
('12323', '2018-09-20', 'KR00001', 'S002', 0),
('22323232', '2018-09-20', 'KR00001', 'S002', 0),
('23232323', '2018-09-20', 'KR00001', 'S002', 0),
('323232', '2018-09-20', 'KR00001', 'S002', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `header_jual`
--

CREATE TABLE `header_jual` (
  `id_jual` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  `kasir` varchar(20) NOT NULL,
  `customer` varchar(20) NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `header_jual`
--

INSERT INTO `header_jual` (`id_jual`, `tanggal`, `kasir`, `customer`, `total`) VALUES
('Anu-0001/09/2018', '2018-09-20', 'KR00001', 'C001', 84000),
('Anu-0002/09/2018', '2018-09-20', 'KR00001', 'C002', 48000),
('Anu-0003/09/2018', '2018-09-20', 'KR00001', 'C001', 30000),
('Anu-0004/09/2018', '2018-09-20', 'KR00001', 'C002', 12000),
('Anu-0005/09/2018', '2018-09-20', 'KR00001', 'C002', 12000),
('Anu-0006/09/2018', '2018-09-20', 'KR00001', 'C002', 24000),
('Anu-0007/09/2018', '2018-09-20', 'KR00001', 'C002', 30000),
('Anu-0008/09/2018', '2018-09-21', 'KR00001', 'C002', 174000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_akses`
--

CREATE TABLE `tb_akses` (
  `id` varchar(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `keterangan` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_akses`
--

INSERT INTO `tb_akses` (`id`, `nama`, `keterangan`) VALUES
('1', 'admin', NULL),
('2', 'kasir', NULL),
('3', 'manajer', NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_barang`
--

CREATE TABLE `tb_barang` (
  `id_barang` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `harga_beli` double NOT NULL,
  `harga_jual` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_barang`
--

INSERT INTO `tb_barang` (`id_barang`, `nama`, `jumlah`, `satuan`, `harga_beli`, `harga_jual`) VALUES
('B0001', 'Beras', 62, 'KG', 12000, 15000),
('B0002', 'Gula pasir', 128, 'KG', 10000, 12000),
('B0003', 'SIkat Gigi', 10, 'buah', 4300, 5000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_costumer`
--

CREATE TABLE `tb_costumer` (
  `id_cost` varchar(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` text,
  `no_telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_costumer`
--

INSERT INTO `tb_costumer` (`id_cost`, `nama`, `alamat`, `no_telp`) VALUES
('C001', 'Kevin', 'Distrik Undefined', '08888888888'),
('C002', 'Build', 'Tokyo', '08999999999');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_supplier`
--

CREATE TABLE `tb_supplier` (
  `id_supplier` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` text,
  `no_telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_supplier`
--

INSERT INTO `tb_supplier` (`id_supplier`, `nama`, `alamat`, `no_telp`) VALUES
('S001', 'Ammar', 'Purbalingga', '08571344859'),
('S002', 'Tupil', 'Puraligga', '08564663214');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `id_user` varchar(10) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` text,
  `telp` varchar(20) DEFAULT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL,
  `status` varchar(20) NOT NULL,
  `position` enum('1','0') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id_user`, `nama`, `alamat`, `telp`, `username`, `password`, `status`, `position`) VALUES
('KR00001', 'Nyoto', 'Jakarta', '08889991', 'admin', '123', '1', '1'),
('KR00002', 'Juni', 'Brebes', '0999988', 'kasir', '123', '2', '0'),
('KR00003', 'Dani', 'Brebes', '567788800', 'manajer', '123', '3', '1'),
('KR00004', 'Ammar1', 'Purbalingga1', '0857134448571', 'root1', 'root1', '3 ', '0');

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `v_beli`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `v_beli` (
`NomorFaktur` varchar(20)
,`tanggal` date
,`Supplier` varchar(50)
,`Kasir` varchar(100)
,`total` double
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `v_detail`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `v_detail` (
`NomorFaktur` varchar(20)
,`KodeBarang` varchar(20)
,`NamaBarang` varchar(100)
,`qty` int(11)
,`satuan` varchar(20)
,`HargaJual` double
,`subtotal` double
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `v_detailbeli`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `v_detailbeli` (
`NomorFaktur` varchar(20)
,`KodeBarang` varchar(20)
,`nama` varchar(100)
,`qty` int(11)
,`satuan` varchar(20)
,`HargaBeli` double
,`disc` int(11)
,`subtotal` double
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `v_jual`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `v_jual` (
`NomorFaktur` varchar(20)
,`tanggal` date
,`Kasir` varchar(50)
,`Pelanggan` varchar(50)
,`total` double
);

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `v_kwi`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `v_kwi` (
`NomorFaktur` varchar(20)
,`tanggal` date
,`customer` varchar(20)
,`Pelanggan` varchar(50)
,`KasirID` varchar(20)
,`Kasir` varchar(100)
,`id_barang` varchar(20)
,`NamaBarang` varchar(100)
,`harga_jual` double
,`qty` int(11)
,`subtotal` double
);

-- --------------------------------------------------------

--
-- Struktur untuk view `v_beli`
--
DROP TABLE IF EXISTS `v_beli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_beli`  AS  select `header_beli`.`id_beli` AS `NomorFaktur`,`header_beli`.`tanggal` AS `tanggal`,`tb_supplier`.`nama` AS `Supplier`,`tb_user`.`nama` AS `Kasir`,`header_beli`.`total` AS `total` from ((`header_beli` join `tb_user` on((`tb_user`.`id_user` = `header_beli`.`kasir`))) join `tb_supplier` on((`tb_supplier`.`id_supplier` = `header_beli`.`supplier`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_detail`
--
DROP TABLE IF EXISTS `v_detail`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_detail`  AS  select `detail_jual`.`id_jual` AS `NomorFaktur`,`detail_jual`.`id_barang` AS `KodeBarang`,`tb_barang`.`nama` AS `NamaBarang`,`detail_jual`.`qty` AS `qty`,`tb_barang`.`satuan` AS `satuan`,`tb_barang`.`harga_jual` AS `HargaJual`,`detail_jual`.`subtotal` AS `subtotal` from (`tb_barang` join `detail_jual` on((`tb_barang`.`id_barang` = `detail_jual`.`id_barang`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_detailbeli`
--
DROP TABLE IF EXISTS `v_detailbeli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_detailbeli`  AS  select `detail_beli`.`id_beli` AS `NomorFaktur`,`detail_beli`.`id_barang` AS `KodeBarang`,`tb_barang`.`nama` AS `nama`,`detail_beli`.`qty` AS `qty`,`tb_barang`.`satuan` AS `satuan`,`tb_barang`.`harga_beli` AS `HargaBeli`,`detail_beli`.`disc` AS `disc`,`detail_beli`.`subtotal` AS `subtotal` from (`detail_beli` join `tb_barang` on((`tb_barang`.`id_barang` = `detail_beli`.`id_barang`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_jual`
--
DROP TABLE IF EXISTS `v_jual`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_jual`  AS  select `header_jual`.`id_jual` AS `NomorFaktur`,`header_jual`.`tanggal` AS `tanggal`,`tb_costumer`.`nama` AS `Kasir`,`tb_costumer`.`nama` AS `Pelanggan`,`header_jual`.`total` AS `total` from ((`header_jual` join `tb_costumer` on((`tb_costumer`.`id_cost` = `header_jual`.`customer`))) join `tb_user` on((`tb_user`.`id_user` = `header_jual`.`kasir`))) order by `header_jual`.`id_jual` ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_kwi`
--
DROP TABLE IF EXISTS `v_kwi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_kwi`  AS  select `detail_jual`.`id_jual` AS `NomorFaktur`,`header_jual`.`tanggal` AS `tanggal`,`header_jual`.`customer` AS `customer`,`tb_costumer`.`nama` AS `Pelanggan`,`header_jual`.`kasir` AS `KasirID`,`tb_user`.`nama` AS `Kasir`,`detail_jual`.`id_barang` AS `id_barang`,`tb_barang`.`nama` AS `NamaBarang`,`tb_barang`.`harga_jual` AS `harga_jual`,`detail_jual`.`qty` AS `qty`,`detail_jual`.`subtotal` AS `subtotal` from ((((`tb_barang` join `detail_jual` on((`tb_barang`.`id_barang` = `detail_jual`.`id_barang`))) join `header_jual` on((`detail_jual`.`id_jual` = `header_jual`.`id_jual`))) join `tb_costumer` on((`tb_costumer`.`id_cost` = `header_jual`.`customer`))) join `tb_user` on((`tb_user`.`id_user` = `header_jual`.`kasir`))) ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detail_beli`
--
ALTER TABLE `detail_beli`
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_beli` (`id_beli`);

--
-- Indeks untuk tabel `detail_jual`
--
ALTER TABLE `detail_jual`
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_jual` (`id_jual`);

--
-- Indeks untuk tabel `header_beli`
--
ALTER TABLE `header_beli`
  ADD PRIMARY KEY (`id_beli`),
  ADD KEY `id_beli_2` (`id_beli`),
  ADD KEY `kasir` (`kasir`),
  ADD KEY `supplier` (`supplier`);

--
-- Indeks untuk tabel `header_jual`
--
ALTER TABLE `header_jual`
  ADD PRIMARY KEY (`id_jual`),
  ADD KEY `kasir` (`kasir`),
  ADD KEY `customer` (`customer`),
  ADD KEY `id_jual` (`id_jual`);

--
-- Indeks untuk tabel `tb_akses`
--
ALTER TABLE `tb_akses`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`);

--
-- Indeks untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`id_barang`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indeks untuk tabel `tb_costumer`
--
ALTER TABLE `tb_costumer`
  ADD PRIMARY KEY (`id_cost`),
  ADD KEY `id_cost` (`id_cost`);

--
-- Indeks untuk tabel `tb_supplier`
--
ALTER TABLE `tb_supplier`
  ADD PRIMARY KEY (`id_supplier`),
  ADD KEY `id_supplier` (`id_supplier`);

--
-- Indeks untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id_user`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `status` (`status`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_beli`
--
ALTER TABLE `detail_beli`
  ADD CONSTRAINT `detail_beli_ibfk_2` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`),
  ADD CONSTRAINT `detail_beli_ibfk_3` FOREIGN KEY (`id_beli`) REFERENCES `header_beli` (`id_beli`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `detail_jual`
--
ALTER TABLE `detail_jual`
  ADD CONSTRAINT `detail_jual_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`),
  ADD CONSTRAINT `detail_jual_ibfk_2` FOREIGN KEY (`id_jual`) REFERENCES `header_jual` (`id_jual`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `header_beli`
--
ALTER TABLE `header_beli`
  ADD CONSTRAINT `header_beli_ibfk_1` FOREIGN KEY (`kasir`) REFERENCES `tb_user` (`id_user`),
  ADD CONSTRAINT `header_beli_ibfk_2` FOREIGN KEY (`supplier`) REFERENCES `tb_supplier` (`id_supplier`);

--
-- Ketidakleluasaan untuk tabel `header_jual`
--
ALTER TABLE `header_jual`
  ADD CONSTRAINT `header_jual_ibfk_1` FOREIGN KEY (`kasir`) REFERENCES `tb_user` (`id_user`),
  ADD CONSTRAINT `header_jual_ibfk_2` FOREIGN KEY (`customer`) REFERENCES `tb_costumer` (`id_cost`);

--
-- Ketidakleluasaan untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD CONSTRAINT `tb_user_ibfk_1` FOREIGN KEY (`status`) REFERENCES `tb_akses` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
