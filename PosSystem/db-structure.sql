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

/* Creating the customers table */
CREATE TABLE customers (
	id INT NOT NULL AUTO_INCREMENT, 
	first_name TEXT NOT NULL, 
	last_name TEXT NOT NULL, 
	phone_number TEXT NOT NULL, 
	address TEXT NOT NULL, 
	email TEXT NOT NULL, 
	PRIMARY KEY (id)
);

/* Creating the orders table */
CREATE TABLE orders (
	id INT NOT NULL AUTO_INCREMENT,
	customerId INT,
	products JSON NOT NULL, 
	date_time DATETIME NOT NULL, 
	phone_number TEXT NOT NULL, 
	amount DOUBLE NOT NULL, 
	paymentMethod TEXT NOT NULL, 
	PRIMARY KEY (id),
	FOREIGN KEY (customerId) REFERENCES customers(id)
);