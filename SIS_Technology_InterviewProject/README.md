# SIS_Technology_InterviewProject

# This project is created to cover Interview Assignment to showcase knowledge in Blazor, Dapper, DevExpress and MS SQL.

# 31/05/2024 - Project updated to Clean Architecture.


# This is the database SQL used for testing.
CREATE DATABASE BlazorDapperDb
USE BlazorDapperDb
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(250) NOT NULL,
    Category NVARCHAR(250) NOT NULL,
    UnitPrice FLOAT NOT NULL,
    DateAdded DATE NOT NULL
);

# Insert data into the Products table
INSERT INTO Products (ProductName, Category, UnitPrice, DateAdded) VALUES
('Apple iPhone 13', 'Electronics', 799.00, '2023-09-14'),
('Samsung Galaxy S21', 'Electronics', 699.99, '2022-01-29'),
('Sony WH-1000XM4', 'Audio', 348.00, '2021-08-18'),
('Dell XPS 13', 'Computers', 999.99, '2020-11-02'),
('Bose QuietComfort 35 II', 'Audio', 299.00, '2019-03-14'),
('Apple MacBook Pro', 'Computers', 1299.00, '2018-05-21'),
('Samsung QLED TV', 'Home Appliances', 1199.99, '2017-07-09'),
('Dyson V11 Vacuum', 'Home Appliances', 599.99, '2016-10-22'),
('Apple iPad Pro', 'Tablets', 799.00, '2015-03-27'),
('Amazon Kindle Paperwhite', 'Tablets', 129.99, '2014-11-12'),
('HP Spectre x360', 'Computers', 1099.99, '2023-04-11'),
('Google Pixel 6', 'Electronics', 599.00, '2022-10-05'),
('Sonos One', 'Audio', 199.00, '2021-06-25'),
('Microsoft Surface Pro 7', 'Computers', 749.99, '2020-09-15'),
('LG OLED TV', 'Home Appliances', 1399.99, '2019-02-18'),
('JBL Flip 5', 'Audio', 119.95, '2018-12-12'),
('Ninja Foodi', 'Home Appliances', 229.99, '2017-08-20'),
('Apple Watch Series 6', 'Electronics', 399.00, '2016-11-10'),
('Echo Dot (4th Gen)', 'Electronics', 49.99, '2015-07-08'),
('Samsung Galaxy Tab S7', 'Tablets', 649.99, '2014-04-22'),
('Roku Ultra', 'Home Appliances', 99.99, '2023-03-15'),
('Canon EOS R5', 'Cameras', 3899.00, '2022-06-17'),
('Nintendo Switch', 'Gaming', 299.99, '2021-10-03'),
('PlayStation 5', 'Gaming', 499.99, '2020-12-15'),
('Xbox Series X', 'Gaming', 499.99, '2019-11-22'),
('GoPro HERO9', 'Cameras', 399.99, '2018-05-10'),
('DJI Mavic Air 2', 'Cameras', 799.99, '2017-03-05'),
('Sony A7 III', 'Cameras', 1999.99, '2016-09-07'),
('Canon Rebel T7i', 'Cameras', 749.99, '2015-02-19'),
('Nikon D850', 'Cameras', 2999.95, '2014-08-01'),
('Sony PlayStation VR', 'Gaming', 349.99, '2023-11-20'),
('Oculus Quest 2', 'Gaming', 299.00, '2022-09-14'),
('Fitbit Charge 4', 'Wearables', 149.95, '2021-02-11'),
('Garmin Forerunner 245', 'Wearables', 299.99, '2020-01-20'),
('Apple AirPods Pro', 'Audio', 249.00, '2019-10-30'),
('Samsung Galaxy Buds Pro', 'Audio', 199.99, '2018-04-04'),
('Sony WF-1000XM3', 'Audio', 228.00, '2017-06-12'),
('Beats Studio3', 'Audio', 349.95, '2016-12-25'),
('Lenovo ThinkPad X1 Carbon', 'Computers', 1429.00, '2015-11-16'),
('Asus ROG Zephyrus G14', 'Computers', 1449.99, '2014-08-08'),
('Razer Blade 15', 'Computers', 1699.99, '2023-07-14'),
('MSI GS66 Stealth', 'Computers', 1799.99, '2022-04-21'),
('Gigabyte Aero 15', 'Computers', 1899.99, '2021-09-09'),
('Acer Predator Helios 300', 'Computers', 1299.99, '2020-05-22'),
('Alienware m15', 'Computers', 1499.99, '2019-07-13'),
('Corsair K95 RGB', 'Computers', 199.99, '2018-02-18'),
('Logitech G502', 'Computers', 79.99, '2017-05-25'),
('SteelSeries Arctis 7', 'Computers', 149.99, '2016-11-11'),
('Dell UltraSharp U2720Q', 'Computers', 539.99, '2023-02-11'),
('Samsung T5 SSD', 'Computers', 169.99, '2022-10-20'),
('Western Digital My Passport', 'Computers', 99.99, '2021-12-05'),
('Seagate Backup Plus', 'Computers', 119.99, '2020-07-30'),
('Crucial MX500 SSD', 'Computers', 134.99, '2019-09-17'),
('SanDisk Extreme Portable SSD', 'Computers', 159.99, '2018-06-25'),
('G-Technology G-Drive', 'Computers', 219.99, '2017-11-13'),
('LaCie Rugged Mini', 'Computers', 89.99, '2016-05-04'),
('Kingston DataTraveler', 'Computers', 29.99, '2015-01-21'),
('Apple Magic Mouse 2', 'Computers', 79.00, '2014-12-11'),
('Microsoft Arc Mouse', 'Computers', 69.99, '2023-03-10'),
('Dell KM636', 'Computers', 49.99, '2022-08-15'),
('HP Envy 6055', 'Computers', 129.99, '2021-01-18'),
('Canon Pixma TR150', 'Computers', 249.99, '2020-11-19'),
('Brother HL-L2350DW', 'Computers', 159.99, '2019-08-21'),
('Epson EcoTank ET-2720', 'Computers', 199.99, '2018-10-15'),
('Samsung ProXpress M3820DW', 'Computers', 299.99, '2017-12-28'),
('Lexmark MB2236adw', 'Computers', 249.99, '2016-09-13'),
('Roku Streaming Stick+', 'Home Appliances', 49.99, '2015-04-27'),
('Fire TV Stick 4K', 'Home Appliances', 49.99, '2014-06-06'),
('Chromecast with Google TV', 'Home Appliances', 49.99, '2023-05-01'),
('Apple TV 4K', 'Home Appliances', 179.00, '2022-03-05'),
('Nvidia Shield TV', 'Home Appliances', 149.99, '2021-11-17'),
('Philips Hue Starter Kit', 'Home Appliances', 199.99, '2020-07-21'),
('Ring Video Doorbell 3', 'Home Appliances', 199.99, '2019-11-23'),
('Nest Thermostat', 'Home Appliances', 129.99, '2018-04-11'),
('Arlo Pro 4', 'Home Appliances', 249.99, '2017-06-14'),
('Wyze Cam v3', 'Home Appliances', 35.98, '2016-10-30'),
('August Smart Lock Pro', 'Home Appliances', 229.99, '2015-01-17'),
('iRobot Roomba 980', 'Home Appliances', 899.99, '2014-09-08'),
('Shark IQ Robot Vacuum', 'Home Appliances', 449.99, '2023-06-19'),
('Ecobee SmartThermostat', 'Home Appliances', 249.99, '2022-02-22'),
('Eufy RoboVac 30C', 'Home Appliances', 259.99, '2021-04-03'),
('Philips Airfryer XXL', 'Home Appliances', 349.99, '2020-08-29'),
('Instant Pot Duo 7-in-1', 'Home Appliances', 89.99, '2019-06-18'),
('Breville Smart Oven', 'Home Appliances', 269.95, '2018-01-24'),
('KitchenAid Stand Mixer', 'Home Appliances', 379.99, '2017-05-22'),
('Vitamix 5200 Blender', 'Home Appliances', 449.95, '2016-03-14'),
('Nespresso VertuoPlus', 'Home Appliances', 159.00, '2015-07-31'),
('Keurig K-Elite', 'Home Appliances', 169.99, '2014-10-23'),
('DeLonghi Espresso Machine', 'Home Appliances', 299.95, '2023-09-27'),
('Cuisinart Food Processor', 'Home Appliances', 199.99, '2022-12-14'),
('Anova Precision Cooker', 'Home Appliances', 199.00, '2021-06-07'),
('Instant Pot Ultra', 'Home Appliances', 149.95, '2020-05-10'),
('NutriBullet Blender', 'Home Appliances', 89.99, '2019-11-11'),
('Cosori Air Fryer', 'Home Appliances', 119.99, '2018-07-05'),
('Hamilton Beach Slow Cooker', 'Home Appliances', 59.99, '2017-08-18'),
('Oster Toaster Oven', 'Home Appliances', 89.99, '2016-02-29'),
('Black+Decker Blender', 'Home Appliances', 49.99, '2015-04-20'),
('Ninja Food Processor', 'Home Appliances', 99.99, '2023-08-11'),
('Levoit Air Purifier', 'Home Appliances', 149.99, '2022-09-25'),
('Dyson Air Multiplier', 'Home Appliances', 299.99, '2021-12-03');

# Query the data to verify the insertion
SELECT * FROM Products;