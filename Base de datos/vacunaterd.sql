-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-07-2021 a las 21:33:17
-- Versión del servidor: 10.4.20-MariaDB
-- Versión de PHP: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `vacunaterd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dosis`
--

CREATE TABLE `dosis` (
  `Id` int(11) NOT NULL,
  `Cedula_persona` varchar(12) NOT NULL,
  `Vacuna_id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Provincia_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `Cedula` varchar(12) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `Telefono` varchar(12) NOT NULL,
  `Fecha_nacimiento` date NOT NULL,
  `Provincia_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincias`
--

CREATE TABLE `provincias` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `provincias`
--

INSERT INTO `provincias` (`Id`, `Nombre`) VALUES
(16, 'dd'),
(17, 'santo domingo'),
(18, 'santo domingo'),
(19, 'santo domingo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacunas`
--

CREATE TABLE `vacunas` (
  `Id` int(11) NOT NULL,
  `Nombre` int(20) NOT NULL,
  `Dosis_necesarias` int(11) NOT NULL,
  `Dias_entre_dosis` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `dosis`
--
ALTER TABLE `dosis`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`Cedula`);

--
-- Indices de la tabla `provincias`
--
ALTER TABLE `provincias`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `vacunas`
--
ALTER TABLE `vacunas`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `dosis`
--
ALTER TABLE `dosis`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `provincias`
--
ALTER TABLE `provincias`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `vacunas`
--
ALTER TABLE `vacunas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
