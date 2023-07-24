/* Creating the products table */
CREATE TABLE products (
	id INT NOT NULL AUTO_INCREMENT , 
	name TEXT NOT NULL , 
	quantity INT NOT NULL , 
	price DOUBLE NOT NULL , 
	description TEXT NOT NULL , 
	PRIMARY KEY (id)
);

/* Creating the users table */
CREATE TABLE users (
	id INT NOT NULL AUTO_INCREMENT, 
	first_name TEXT NOT NULL, 
	last_name TEXT NOT NULL, 
	username TEXT NOT NULL, 
	password TEXT NOT NULL, 
	email TEXT NOT NULL, 
	role TEXT NOT NULL, 
	PRIMARY KEY (id)
);

/* Creating the orders table */
CREATE TABLE orders (
	id INT NOT NULL AUTO_INCREMENT,
	customer_first_name TEXT NOT NULL, 
	customer_last_name TEXT NOT NULL, 
	customer_phone_number TEXT NOT NULL, 
	customer_address TEXT NOT NULL, 
	customer_email TEXT NOT NULL, 
	products JSON NOT NULL, 
	date_time DATETIME NOT NULL, 
	phone_number TEXT NOT NULL, 
	amount DOUBLE NOT NULL, 
	paymentMethod TEXT NOT NULL, 
	PRIMARY KEY (id)
);

-- Adding Users
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ("Isira", "Adithya", "isira_adithya", "pass123", "me@isiraadithya.com", "ADMIN");
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ("Isira", "Adithya (User Account)", "isira_adithya_user", "pass123", "user@isiraadithya.com", "USER");