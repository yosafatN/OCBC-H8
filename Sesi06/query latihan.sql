--A
CREATE DATABASE staff; 

--B
CREATE TABLE data_staff (
	nik Int,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15)
);

--C,D
INSERT INTO data_staff (nik,nama,alamat,handphone) VALUES
(100,'nama1','alamat1','0800000000001'),
(101,'nama2','alamat2','0800000000002');

--E
ALTER TABLE data_staff ADD joindate date;
INSERT INTO data_staff(nik,nama,alamat,handphone, joindate)
VALUES(102,'nama3','alamat3','0800000000003','2010-01-01');

--F
SELECT TOP 2 * FROM data_staff;

--G
SELECT TOP 3 * FROM data_staff;

--H
CREATE TABLE staffoutsource (
	nik Int,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15),
	joindate date
);

--I
INSERT INTO staffoutsource (nik,nama,alamat,handphone,joindate) VALUES
(200,'nama out1','alamat1','0800000000101','2010-01-01'),
(201,'nama out2','alamat2','0800000000102','2010-01-01'),
(202,'nama out3','alamat3','0800000000103','2010-01-02'),
(203,'nama out4','alamat4','0800000000104','2010-01-02'),
(204,'nama out5','alamat5','0800000000105','2010-01-03'),
(205,'nama out6','alamat6','0800000000106','2010-01-04'),
(206,'nama out7','alamat7','0800000000107','2010-01-04'),
(207,'nama out8','alamat8','0800000000108','2010-01-05'),
(208,'nama out9','alamat9','0800000000109','2010-01-06'),
(209,'nama out10','alamat10','0800000000110','2010-01-06');

--J
SELECT * FROM data_staff ds JOIN staffoutsource do ON ds.joindate = do.joindate;

--K
SELECT * FROM data_staff ds RIGHT JOIN staffoutsource do ON ds.joindate = do.joindate;

--L
SELECT * FROM data_staff ds LEFT JOIN staffoutsource do ON ds.joindate = do.joindate;

--M
SELECT * FROM data_staff ds FULL JOIN staffoutsource do ON ds.joindate = do.joindate;