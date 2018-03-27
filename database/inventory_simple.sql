-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 27, 2018 at 05:24 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_simple`
--

-- --------------------------------------------------------

--
-- Table structure for table `account_type_table`
--

CREATE TABLE `account_type_table` (
  `account_code` int(11) NOT NULL,
  `account_name` varchar(45) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account_type_table`
--

INSERT INTO `account_type_table` (`account_code`, `account_name`, `description`) VALUES
(1, 'admin', 'for administrator'),
(2, 'cashier', 'for cashier only'),
(3, 'manager', 'for manager who is the head of the company');

-- --------------------------------------------------------

--
-- Table structure for table `category_table`
--

CREATE TABLE `category_table` (
  `categoryNo` int(11) NOT NULL,
  `category_name` varchar(45) NOT NULL,
  `description_category` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category_table`
--

INSERT INTO `category_table` (`categoryNo`, `category_name`, `description_category`) VALUES
(1, 'food', 'food like ugali and floor'),
(2, 'promotion', 'for promotion purpose'),
(3, 'vitamins', 'unga and others'),
(4, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `employee_table`
--

CREATE TABLE `employee_table` (
  `emp_No` int(15) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `middle_name` varchar(45) NOT NULL,
  `address` text NOT NULL,
  `phone` int(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `confirm` varchar(45) NOT NULL,
  `account_type` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_table`
--

INSERT INTO `employee_table` (`emp_No`, `last_name`, `first_name`, `middle_name`, `address`, `phone`, `username`, `password`, `confirm`, `account_type`) VALUES
(1, 'harri', 'harri', 'wachira', '1049 karatina', 70395544, 'harri', 'harri', 'harri', '');

-- --------------------------------------------------------

--
-- Table structure for table `inventory_table`
--

CREATE TABLE `inventory_table` (
  `product_id` int(11) NOT NULL,
  `product_code` varchar(45) NOT NULL,
  `product_name` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  `entry_date` text NOT NULL,
  `quantity` varchar(20) NOT NULL,
  `suplier_code` varchar(45) NOT NULL,
  `Expiry_date` text NOT NULL,
  `manufacturer` varchar(45) NOT NULL,
  `company` varchar(45) NOT NULL,
  `product_category` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory_table`
--

INSERT INTO `inventory_table` (`product_id`, `product_code`, `product_name`, `price`, `entry_date`, `quantity`, `suplier_code`, `Expiry_date`, `manufacturer`, `company`, `product_category`) VALUES
(1, '001', 'sugar', '9', '0000-00-00', '12', '', '0000-00-00', '', '', ''),
(2, '002', 'salt', '1', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(3, '0001', 'blueband', '3', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(5, '004', 'basket', '10', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(6, '009', 'tea', '1', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(7, '003', 'bread', '20', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(8, '0056', 'porish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(9, '1023', 'black polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(10, '123', 'blue polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(11, '032', 'brown polish', '30', '2018-01-11', '', '', '0000-00-00', '', '', ''),
(12, '099', 'white_polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(13, 'C00011', 'yellow_polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(15, 'QIEpl/PO/0000010', 'grey_polish', '400', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(16, 'QIEpl/PO/0000011', 'orange_polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(17, 'QIEpl/PO/0000012', 'red_polish', '30', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(18, 'QIEpl/PO/0000013', 'steel_r', '200', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(19, 'get', 'good', '12', '0000-00-00', '', '', '0000-00-00', '', '', ''),
(20, 'OOIRU', 'NUTS', '20', '2018-03-08', '3', 'SOP01', '0000-00-00', '', '', ''),
(21, '99UU', 'BEANS', '24', '2018-03-08', '4', 'E33', '0000-00-00', '', '', ''),
(22, 'hhg4', 'maize', '21', '2018-03-08', '5', 'ojj56', '2018-03-08', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `sales_table`
--

CREATE TABLE `sales_table` (
  `itemNo` int(11) NOT NULL,
  `item_id` varchar(45) NOT NULL,
  `item_name` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  `quantity` int(45) NOT NULL,
  `vat` varchar(45) NOT NULL,
  `discount` varchar(45) NOT NULL,
  `totalamountdue` varchar(45) NOT NULL,
  `total_cash` varchar(45) NOT NULL,
  `today_date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_table`
--

INSERT INTO `sales_table` (`itemNo`, `item_id`, `item_name`, `price`, `quantity`, `vat`, `discount`, `totalamountdue`, `total_cash`, `today_date`) VALUES
(1, '1', 'sugar', '9', 12, '', '', '', '', '2018-03-27'),
(2, '1', 'sugar', '9', 12, '16', '200', '1728', '1728', '2018-03-27');

-- --------------------------------------------------------

--
-- Table structure for table `supplier_table`
--

CREATE TABLE `supplier_table` (
  `supplier_code` int(20) NOT NULL,
  `supplier_name` varchar(45) NOT NULL,
  `address` text NOT NULL,
  `Contact_No` int(15) NOT NULL,
  `location` varchar(45) NOT NULL,
  `manufacturer` varchar(45) NOT NULL,
  `company_name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier_table`
--

INSERT INTO `supplier_table` (`supplier_code`, `supplier_name`, `address`, `Contact_No`, `location`, `manufacturer`, `company_name`) VALUES
(1, 'bidco', '123 thika', 772233, 'thika', 'unga limited', 'bidco'),
(2, 'daas', '1223 nairobi', 9099, 'daa', 'daa', 'daa');

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE `test` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  `quantity` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account_type_table`
--
ALTER TABLE `account_type_table`
  ADD PRIMARY KEY (`account_code`);

--
-- Indexes for table `category_table`
--
ALTER TABLE `category_table`
  ADD PRIMARY KEY (`categoryNo`);

--
-- Indexes for table `employee_table`
--
ALTER TABLE `employee_table`
  ADD PRIMARY KEY (`emp_No`);

--
-- Indexes for table `inventory_table`
--
ALTER TABLE `inventory_table`
  ADD PRIMARY KEY (`product_id`),
  ADD UNIQUE KEY `product_code` (`product_code`) USING BTREE;

--
-- Indexes for table `sales_table`
--
ALTER TABLE `sales_table`
  ADD PRIMARY KEY (`itemNo`);

--
-- Indexes for table `supplier_table`
--
ALTER TABLE `supplier_table`
  ADD PRIMARY KEY (`supplier_code`),
  ADD UNIQUE KEY `supplier_code_3` (`supplier_code`),
  ADD KEY `supplier_code` (`supplier_code`),
  ADD KEY `supplier_code_2` (`supplier_code`);

--
-- Indexes for table `test`
--
ALTER TABLE `test`
  ADD PRIMARY KEY (`product_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account_type_table`
--
ALTER TABLE `account_type_table`
  MODIFY `account_code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `category_table`
--
ALTER TABLE `category_table`
  MODIFY `categoryNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `employee_table`
--
ALTER TABLE `employee_table`
  MODIFY `emp_No` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `inventory_table`
--
ALTER TABLE `inventory_table`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `sales_table`
--
ALTER TABLE `sales_table`
  MODIFY `itemNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `supplier_table`
--
ALTER TABLE `supplier_table`
  MODIFY `supplier_code` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `test`
--
ALTER TABLE `test`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
