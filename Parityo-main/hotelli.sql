-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 15.02.2024 klo 13:28
-- Palvelimen versio: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `Ktunnus` varchar(25) NOT NULL,
  `Etunimi` varchar(20) NOT NULL,
  `Sukunimi` varchar(50) NOT NULL,
  `Lahiosoite` varchar(50) NOT NULL,
  `Postinumero` varchar(10) NOT NULL,
  `Postitoimipaikka` int(25) NOT NULL,
  `Salasana` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `HuoneID` int(11) NOT NULL,
  `Huonetyyppi` int(11) NOT NULL,
  `Puhelin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `HuoneenID` int(11) NOT NULL,
  `Huonetyyppi` varchar(50) NOT NULL,
  `Puhelin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`Ktunnus`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`HuoneID`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`HuoneenID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `huoneet`
--
ALTER TABLE `huoneet`
  MODIFY `HuoneID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  MODIFY `HuoneenID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
