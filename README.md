# DNS-DessertAndShakes
Dessert and Shakes Restaurant Online Ordering for CPSC final Project


1.	Homepage – This is going to be the default page for the customer. It will allow user to enter username and password and the three buttons will be login, sign up, Exit.
2.	Sign up – This will allow to create new user on the software. The username and passwords will be saved in the database. The other fields will be First Name, Last Name, Email – Address, Password, Confirm Password and Phone number. The username will be the user email address.
3.	Login Screen – As the user login in the user will be allowed to choose the main category of the products, that will be Ice cream, Thick shakes, Fruit sticks, Sandwich, Premium Stick and Ultimate Creation.
4.	Each of the above will have sub options to choose the flavors, topping and quantity. This will be 6 forms each.
5.	Cart- The total of all the products the customer has selected including the total and tax. The location of the carry-out or delivery will be displayed. The flag for carry out or delivery will be displayed on the next page.  
6.	Address and payment – This page will allow the customer to add the payment method that will be primarily credit or debit card and the radio button for either carry-out or delivery. When the user clicks on the delivery, the Customer will be prompted to enter delivery address.

The first screen will be login screen, login, password, login button, sign up button and exit button. Once the customer is ready to Order, the GUI will allow them to choose product like Ice-crease, shakes, sandwich, beverages. To make the process even faster, they will have an option to pay online with their credit/debit cards or either they can pay in store. The orders will be saved in the database in order to recall the order for purchase next time. Most of the customer order their sandwich the same way they ordered earlier. 

For Sandwich Menu, the customer will be allowed to choose their bread and cheese using the Radio buttons, the veggies and sauces will be check boxes so the customer will be allowed to add or remove their options. As the user clicks on different options, the images of the food will be display on the side. There will be a running total for the price.  The customer will be allowed to print the current receipt or previously ordered receipts. 

In the back end, the database will have four tables.
1.	Customer Information. Primary key will be customer id.
This includes customer id, login, password, name, email and phone number.
2.	Product Information. Primary key will be product id.
This includes product id, name, ingredients, price, calories
3.	Orders table. Primary key will be combination of customer id and product id.
This includes customer id, product id, price of the total order, date and time of the order and location of the order.
4.	Store location table. Primary key will be store id.
This includes store id, location, phone number, hours of operation and address. 

Program Flow Diagram
 

Program Input: User Login (The very first page for user to login or signup)
•	User must input the correct email and password to login to the system.
•	Sign up (to create a new account for login and ordering): The user must enter Name, address, city, state, zip code, phone number, email, password and credit card details to create a new account.
The Homepage wrapper: The navigation panel consist of button to navigate to different parts of the project and there is exit button to exit the whole system and also log off button to switch the user. 
Program Output: 
•	User login screen, available labels and textboxes
•	User login DB connection check string will display if the connection is successful to the DB.
•	Sign up screen show the DNS company logo and labels and textboxes asking for user information in process to delivery, make a payment and log in to the system. 
•	Homepage displays the information about the products in general. 
•	Menu screen displays the list of products available from the company to users.
•	Delivery or carryout screen display and prompts user to select the radio button and select the items from the combo boxes and select the quantities to order a product.
•	My Account screen allows users to update their personal information that is stored and also displays the information that was used to create an account. 

Program Description:

User Login

For the user any user to login, the interface prompts the user to input the email and password in order to log in to the system, if the user is using the system for the first time, they must sign up before the login. A sign-up button is provided in login screen that redirects the users to another screen. The connection check screen checks the connection to the database and returns if the connection is successful. Login button checks the email and password from the text boxes, converts password in hashed encryption and then opens the connection to the DB looks up for that user.

Sign Up
	For creating a new user, it uses it requires all the field to be filled in order to save to the database. There is input validation used to check if the email already exists in the database so there are no duplicates. Passwords are hashed with SHA 256 encryption algorithm. The create user button will execute the query and if all the information is correct, a new row of the user information will be saved in the database. The signup form will close by itself and redirect back to the admin page. 

Homepage
  	As the user logs in the home page is just a general information about products with some pictures. It’s a basic wrapper with navigation panel on the side that has buttons with the names of pages and they are Home (itself), Menu, Delivery, Carry out, My Account and My Cart. There is also a button to log off and log out.  

Menu
	This screen contains the information about and list of all the product available. Text boxes are not editable, and it is only for the users or even admins at this moment. Currently there are 80 items for ice creams and about 10 items for sandwiches. 

Delivery 
	This screen allows users to list the products that they might purchase. The user has to select proper radio buttons to make correct decision and update the product information. The products contain and it displays Category, Name of the product, Price and Sub category.  The user can navigate the products using the combo box of the product ID. If the user clicks on the ice cream radio button, a query will execute and load all the items from the database where the product category is ice cream. It will do the same with other categories. Once the combo box for the ice creams are loaded, the use can select the product using combo box where the product id is loaded. The combo box is available to select the quantity and button to add to the cart.

My Account 
	This is for the user to update its personal information that they used while creating the account. They are not allowed to change the user ID or email. The email is used to login and it is unique from the database. There is button to update the information to database. Once the user clicks on update button, there will be input validation before saving to the database.

Cart
	The cart displays the data in the grid view to the products inside the cart that user selected and allows to delete the product from the cart. The user cannot edit the cart from the grid view but there is a delete button to delete a selected cart ID from the combo box. The labels display the information and quantity outside the data grid table. 

Globals
	This class contains only two attributes that is current User and Current User ID that are used to keep the track of the user who is making the purchase and adding to the cart. These attributes are updated during the log in and log off time. 

Admin Home Page (wrapper)
	This page contains multiple custom controls which are loaded one over another. The admins pages are designed differently than regular user. 

Admin Product custom control
	This page allows the admin the view the inventory as well as change the price and the information about the product. Admin can add new product but cannot change the product ID because it is auto-generate from the database. The products can be Delete from selecting proper product id from the combo box. The delete button will look up the product id in the product table from the database to delete. The Admin cannot edit the product grid view table. 

Algorithm Analysis
Arrays
Algorithm description: “The arrays are available in C#. Arrays hold multiple variables and it is easy to process using loops. To find the data and insert, delete or edit the content of data at particular index is easy. 
Algorithm Analysis: I have not handled the arrays that much in the program, I am mostly using triggers to validate from the database. I have used the arrays in global class that loads up during program startup and populated every time when it reads the contents from the database. This can cause problem in debugging. This could also lead to slower the development of this project in future. So, every time there is an interaction with the database, the data is populated in the global class before it is loaded and refreshed in the labels and combo boxes. For smaller amount of data, it is not that problem, but when the project is deployed in the field. It could make the system slower down specially for the admins when there are high number of users. The application could also be slow if we add hundred times the number of current products. If we use a picture for every product, it will use a lot of hardware resource and slower the project for both users and admin.   

DB documentation
  
  DB description: DB name is DNS.accdb. It is stored in access database with interaction of the data like adding a new user, looking up the user during log in, view the products, view the cart and the same thing with the admin. More over the admin can also view and edit the tables like Product, Users, OrderLogs and Store.  

DB type: Access database

DB tables:
Users:  
•	It has all the information about the user. He can add the products to the cart, view the cart, delete items from his cart. 
•	This user cannot view other users information.
•	This user cannot edit the price of the products
•	This user cannot view order logs
•	Primary Key : ID (users number in the system)
•	Surrogate Key : email
Products:
•	It has all the information about the products.
•	Primary Key : productID
Store info:
•	Contains information about the store from where the orders are going to be dine in or carry out or delivery
•	Primary Key: StoreID
Order Logs:
•	Contain the logs of the products that are already purchased by the user. Once the user check out the product, the orders are no longer available in the cart. They are saved in order log which is only accessible by the admin at the moment. 
•	Primary Key: ID
•	Foreign Key: CartID, customer ID and ProductID
Cart:
•	This contains the information about the orders from the user. This is helpful because if the user logout automatically, the order that were not purchased are saved in the database. 
•	Primary Key: CartID
•	Foreign Key: customerID, storeID and productID.
DB relationship diagram:

 
Know issues:
•	Anyone can become an admin by having the name admin, they can user any user name they want, there could be multiple users with the same name but there could not be a user with same email address. This could be fixed by checking the user id as an admin rather than checking the user name. 
•	The validation of user email is not 100% valid. It only checks for the @ symbol and .com. 
•	The user validation for the phone number could be more professional. 
Future enhancements
•	The password are only hashed. It could be more secure by upgrading the encryption algorithm to SHA384 or SHA512. 
•	There could be salting with hashing or salt and pepper with hashing to make it more secure but it will take more time to decrypt the passwords.
•	There is only one store available for user to carryout, deliver or dine in. During deployment, there could be more than one store and user should be able to select the store they want.
•	There could a custom control for user to select the location of the store using the zip code or city and state. 
•	There could be details of the ingredients and calories for the products in the menu as well as in the database.
•	The detailed selections of the products topping selected by the user are not saved in the database. 
•	There could be a custom control for users to preview the previous orders and also print them.
