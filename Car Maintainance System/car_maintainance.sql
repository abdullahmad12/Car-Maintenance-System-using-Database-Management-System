create database car_maintainance;
use car_maintainance;
create table login (username varchar(50) primary key, password varchar(50));
Insert Into login values ('Admin', 'Admin');
create table employee (emp_id varchar(50) primary key, emp_name varchar(50) not null, emp_gender varchar(50) not null, emp_ph varchar(50) not null unique, emp_salary varchar(50) not null, emp_age varchar(50) not null, emp_cnic varchar(50) not null unique, emp_qualification varchar(50) not null, emp_joining varchar(50) not null, emp_position varchar(50) not null, emp_address varchar(50) not null);
create table customer (c_id varchar(50) primary key, c_name varchar(50), c_contact varchar(50) not null unique, c_email varchar(50) not null unique, c_address varchar(50) not null);
create table services (s_id varchar(50) primary key, s_name varchar(50) unique not null, s_charges varchar(50) not null)
create table part (p_id varchar(50) primary key, p_name varchar(50) unique not null, p_price varchar(50) not null);