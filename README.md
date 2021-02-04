# Orderwise App

Write a Xamarin Forms app that can run on multiple platforms that meets the following requirements:

Database:

The app must create a database with the following tables and fields:
Customers table
CustomerId [Integer, primary key, auto increment]
CustomerCode [String max 8 chars, unique index, not null]
CustomerName [String max 128 chars, not null]
Telephone [String max 10 chars]
Cellphone [String max 10 chars]
Address 1 [String max 128 chars]
Address 2 [String max 128 chars]
Address 3 [String max 128 chars]
Address 4 [String max 128 chars]
PostalCode [String max 8 chars]
CustomerCategoryId [Integer, not null]

CustomerCategories table
CustomerCateforyId [Integer primary key, auto increment]
Description [String, max chars 32, not null]

Products table
ProductId [Integer, primary key, auto increment]
ProductCode [String, max chars 8, unique index, not null]
ProductName [String max chars 64, not null]

Orders table
OrderId [Integer, primary key, auto increment]
CustomerId [Integer, not null]
OrderDate [date field, not null]
CustomerReference [String, max chars 32]

OrderItems table
OrderItemId [Integer, primary key, auto increment]
OrderId [Integer, not null]
ProductId [Integer, not null]
Quantity [Integer, not null]
UnitPrice [Double, not null]
 
UI:

Main (Home/Landing) page
Must be able to navigate to Customers page
Must be able to navigate to the Products page
Must be able to navigate to the Customer Categories page
Must be able to navigate to the Orders page

Customers page
List all customers in the database
List must show for each customer (you can choose the layout of the row):
Customer name
Customer code
Customer category

Must be able to add new customer
Must be able to delete a customer

When tapping on a customer a menu must popup up with the following options:
Customer details (opens the customer details page, where data can be edited)
Order (open the new order page)
New/Edit customer page
Capture all customer fields

Product page
List all products in the database
Must be able to add new product
Must be able to delete product

When tapping on existing product open product details page
Customer categories page
List all categories
Add, edit and delete categories

Order page
List the orders in the database
List must show for each order:
Customer name
Order date
Total order value

Be able to create a new order, edit existing order or delete an order

New order page
Be able to select a product
Capture quantity and price for the selected product
Add selected product to the order
Show if a product is already on the order using an indicator of sorts
Show running total as items are added or removed from the order
 
On all pages ensure validation is done for required fields, etc.

Show off your Xamarin skills where ever possible by demonstrating the use of the following concepts:

Styles
Custom renderers
Binding
Triggers
Converters
Behaviours
Resources
Design principles