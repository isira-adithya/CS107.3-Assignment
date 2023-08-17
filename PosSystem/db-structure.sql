/* Drop the orderproducts table */
DROP TABLE IF EXISTS orderproducts;

/* Drop the products table */
DROP TABLE IF EXISTS products;

/* Drop the orders table */
DROP TABLE IF EXISTS orders;

/* Drop the users table */
DROP TABLE IF EXISTS users;


/* Creating the products table */
CREATE TABLE products (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
	name VARCHAR(1024) NOT NULL, 
	stock INT NOT NULL, 
	price FLOAT NOT NULL, 
	description VARCHAR(4096) NOT NULL
);

/* Creating the users table */
CREATE TABLE users (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
	first_name VARCHAR(1024) NOT NULL, 
	last_name VARCHAR(1024) NOT NULL, 
	username VARCHAR(1024) NOT NULL, 
	password VARCHAR(1024) NOT NULL, 
	email VARCHAR(1024) NOT NULL, 
	role VARCHAR(1024) NOT NULL
);

/* Creating the orders table */
CREATE TABLE orders (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	customer_first_name VARCHAR(1024) NOT NULL, 
	customer_last_name VARCHAR(1024) NOT NULL, 
	customer_phone_number VARCHAR(1024) NOT NULL, 
	customer_address VARCHAR(1024) NOT NULL, 
	customer_email VARCHAR(1024) NOT NULL, 
	date_time DATETIME NOT NULL, 
	phone_number VARCHAR(1024) NOT NULL, 
	amount FLOAT NOT NULL, 
	paymentMethod VARCHAR(1024) NOT NULL
);

/* Creating the orderproducts table */
CREATE TABLE orderproducts (
	id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	product_id INT NOT NULL,
	order_id INT NOT NULL,
	quantity INT NOT NULL,
	FOREIGN KEY (product_id) REFERENCES products(id),
	FOREIGN KEY (order_id) REFERENCES orders(id)
);



/* Adding Users */
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ('Isira', 'Adithya', 'isira_adithya', 'pass123', 'me@isiraadithya.com', 'ADMIN');
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ('Isira', 'Adithya (User Account)', 'isira_adithya_user', 'pass123', 'user@isiraadithya.com', 'USER');