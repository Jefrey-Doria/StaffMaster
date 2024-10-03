CREATE TABLE employees
(
	id INT PRIMARY KEY IDENTITY(1,1),
	employee_id VARCHAR (MAX) NULL,
	first_name VARCHAR (MAX) NULL,
	last_name VARCHAR (MAX) NULL,
	current_address VARCHAR (MAX) NULL,
	contact_info VARCHAR (MAX) NULL,
	email VARCHAR (MAX) NULL,
	gender VARCHAR (MAX) NULL,
	position VARCHAR (MAX) NULL,
	image VARCHAR (MAX) NULL,
	salary INT NULL,
	status VARCHAR(MAX) NULL,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL
)

select * from employees

CREATE TABLE clients
(
	id INT PRIMARY KEY IDENTITY(1,1),
	client_id VARCHAR (MAX) NULL,
	first_name VARCHAR (MAX) NULL,
	last_name VARCHAR (MAX) NULL,
	contact_info VARCHAR (MAX) NULL,
	email VARCHAR (MAX) NULL,
	status VARCHAR(MAX) NULL,
	assigned_employee VARCHAR(MAX) NULL,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL
)

select * from clients

select * from users

SELECT COUNT(id) FROM clients WHERE delete_date IS NULL