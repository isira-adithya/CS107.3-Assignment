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
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ('Isira', 'Adithya', 'admin', 'admin123', 'me@isiraadithya.com', 'ADMIN');
INSERT INTO users(first_name, last_name, username, password, email, role) VALUES ('Isira', 'Adithya (User Account)', 'user', 'user123', 'user@isiraadithya.com', 'USER');



/* Adding Products */

-- Inserting a laptop
INSERT INTO products (name, stock, price, description)
VALUES ('Laptop X1', 50, 999.99, 'Powerful laptop with high-resolution display.');

-- Inserting a smartphone
INSERT INTO products (name, stock, price, description)
VALUES ('Smartphone S10', 100, 799.99, 'Latest model with advanced camera features.');

-- Inserting a gaming console
INSERT INTO products (name, stock, price, description)
VALUES ('Gaming Console G2', 25, 499.99, 'Next-gen gaming console for immersive gaming experience.');

-- Inserting a book
INSERT INTO products (name, stock, price, description)
VALUES ('Book: The Adventure Begins', 200, 19.99, 'First book in an epic fantasy series.');

-- Inserting a fitness tracker
INSERT INTO products (name, stock, price, description)
VALUES ('Fitness Tracker FT1', 75, 89.99, 'Monitor your daily activity and health.');

-- Inserting a coffee maker
INSERT INTO products (name, stock, price, description)
VALUES ('Coffee Maker C3', 30, 59.99, 'Brew delicious coffee in minutes.');

-- Inserting a portable speaker
INSERT INTO products (name, stock, price, description)
VALUES ('Portable Speaker P2', 50, 129.99, 'High-quality speaker for music on the go.');

-- Inserting a winter jacket
INSERT INTO products (name, stock, price, description)
VALUES ('Winter Jacket WJ1', 20, 149.99, 'Stay warm and stylish in the cold.');

-- Inserting a board game
INSERT INTO products (name, stock, price, description)
VALUES ('Board Game B4', 40, 34.99, 'Fun strategy game for friends and family.');

-- Inserting a gardening kit
INSERT INTO products (name, stock, price, description)
VALUES ('Gardening Kit G5', 15, 79.99, 'Start your own garden with this comprehensive kit.');

-- Inserting a wireless headphones
INSERT INTO products (name, stock, price, description)
VALUES ('Wireless Headphones H3', 80, 149.99, 'Immerse yourself in music with these high-quality wireless headphones.');

-- Inserting a cooking utensil set
INSERT INTO products (name, stock, price, description)
VALUES ('Cooking Utensil Set U2', 60, 39.99, 'Complete set of kitchen utensils for your cooking needs.');

-- Inserting a bicycle
INSERT INTO products (name, stock, price, description)
VALUES ('Mountain Bike M7', 15, 699.99, 'Durable mountain bike for off-road adventures.');

-- Inserting a pet grooming kit
INSERT INTO products (name, stock, price, description)
VALUES ('Pet Grooming Kit G7', 35, 29.99, 'Keep your furry friend looking neat and tidy with this grooming kit.');

-- Inserting a designer handbag
INSERT INTO products (name, stock, price, description)
VALUES ('Designer Handbag D5', 10, 599.99, 'Elegant handbag from a renowned fashion brand.');

-- Inserting a home security camera
INSERT INTO products (name, stock, price, description)
VALUES ('Security Camera S8', 50, 129.99, 'Monitor your home with this high-definition security camera.');

-- Inserting a camping tent
INSERT INTO products (name, stock, price, description)
VALUES ('Camping Tent T3', 25, 199.99, 'Spacious tent for outdoor camping trips.');

-- Inserting a musical keyboard
INSERT INTO products (name, stock, price, description)
VALUES ('Musical Keyboard K6', 10, 299.99, 'Express your musical creativity with this versatile keyboard.');

-- Inserting a baby stroller
INSERT INTO products (name, stock, price, description)
VALUES ('Baby Stroller S4', 40, 129.99, 'Comfortable and convenient stroller for your little one.');

-- Inserting a hiking backpack
INSERT INTO products (name, stock, price, description)
VALUES ('Hiking Backpack B9', 20, 79.99, 'Carry your gear comfortably on your outdoor adventures.');



/* Adding Products */

-- Inserting an order with multiple products
INSERT INTO orders (customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, phone_number, amount, paymentMethod)
VALUES ('John', 'Doe', '123-456-7890', '123 Main St', 'john@nsbm.ac.lk', '2023-08-23 10:00:00', '555-123-4567', 549.98, 'Credit Card');

-- Adding products to the order
INSERT INTO orderproducts (product_id, order_id, quantity)
VALUES (3, 1, 2), -- Adding 2 units of product with ID 3
       (8, 1, 1); -- Adding 1 unit of product with ID 8

-- Inserting another order
INSERT INTO orders (customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, phone_number, amount, paymentMethod)
VALUES ('Jane', 'Smith', '987-654-3210', '456 Oak Ave', 'jane@nsbm.ac.lk', '2023-08-23 15:30:00', '555-987-6543', 169.99, 'PayPal');

-- Adding products to the second order
INSERT INTO orderproducts (product_id, order_id, quantity)
VALUES (5, 2, 1), -- Adding 1 unit of product with ID 5
       (12, 2, 3); -- Adding 3 units of product with ID 12

-- Inserting a new order
INSERT INTO orders (customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, phone_number, amount, paymentMethod)
VALUES ('Alice', 'Johnson', '555-555-5555', '789 Elm St', 'alice@nsbm.ac.lk', '2023-08-24 11:45:00', '555-555-5555', 299.95, 'Credit Card');

-- Adding products to the order
INSERT INTO orderproducts (product_id, order_id, quantity)
VALUES (1, 3, 1), -- Adding 1 unit of product with ID 1
       (7, 3, 2); -- Adding 2 units of product with ID 7

-- Inserting another order
INSERT INTO orders (customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, phone_number, amount, paymentMethod)
VALUES ('Michael', 'Brown', '111-222-3333', '234 Maple Rd', 'michael@nsbm.ac.lk', '2023-08-25 14:15:00', '555-444-5555', 114.98, 'Cash');

-- Adding products to the order
INSERT INTO orderproducts (product_id, order_id, quantity)
VALUES (9, 4, 1), -- Adding 1 unit of product with ID 9
       (14, 4, 1); -- Adding 1 unit of product with ID 14

-- Inserting another order
INSERT INTO orders (customer_first_name, customer_last_name, customer_phone_number, customer_address, customer_email, date_time, phone_number, amount, paymentMethod)
VALUES ('Emily', 'Williams', '777-888-9999', '567 Pine Ln', 'emily@nsbm.ac.lk', '2023-08-26 09:30:00', '555-666-7777', 419.97, 'Credit Card');

-- Adding products to the order
INSERT INTO orderproducts (product_id, order_id, quantity)
VALUES (2, 5, 3), -- Adding 3 units of product with ID 2
       (10, 5, 1); -- Adding 1 unit of product with ID 10
