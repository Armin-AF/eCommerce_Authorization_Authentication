# e-Commerce App 

This is an eCommerce app that allows stores to create their own company sites and put up their own products. A regular customer that visits the site should be able to view all the products from each of the stores. And add whatever they find to their cart. And a store, or seller, should be able to upload new products to the store that the customer should see.

## Technologies Used
- Entity Framework
- SQL
- .NET
- React

## App Requirements
- Display products with a filter bar and search
- Each product should have its own page, where you can add products to your cart
- The cart should persist in local storage, and only be visible if the user is logged in
- The backend should log each request from the clients in a document of your choice
- The store and the backend should not be open to just anyone. Only an authenticated user (of any three roles) should be able to reach the store and its backend routes
- The app should have three different roles; Super Admin, Store Admin, and User

## Page Requirements
- Login & sign-up page
- Home page
- Profile page


## Login & Sign-Up Page
- The sign-in page should throw an error if the user’s password is incorrect or if the email doesn’t exist (“Email or password is incorrect”)
- Signing a JWT Token and sending back in response.
- User is redirected to the Home page
- The sign-up page should validate if the email has already been used by an existing user, validate the inputs, and save the user into the DB
- Password should be encrypted before saving it in the database

## Home Page
- Once the user is logged in, and redirected to the home page, all the products should be fetched and shown
- A search and filter for looking through products
- Pagination
- Each product should have a link to the store selling the products
- When the user clicks on a product they will be redirected to the products page
## Profile Page
### User
- Can view their entire cart
- Add items to a cart, saved in local storage
- Remove items from a cart
- Update quantity per item in a cart
### Store Admin
- Add button for adding products
- See all the products their store is selling
- Can delete products
- A user can view this page, and see all the products a store is selling
### Super Admin
- View all the different stores
- Can delete an entire store
- Can click on a store from the list and redirect to the Stores page. Here they can do everything as the store admin

## Installation
- Clone the repository
- Navigate to the server folder and run dotnet ef database update to create the database
- Start the backend server by running dotnet run
- Navigate to the client folder and run npm install
- Start the client server by running npm start

## Conclusion

This eCommerce app allows stores to create their own company sites on it and put up their own products. A regular customer can view all the products from each of the stores, and add whatever they find to their cart. The backend logs each request from the clients in a document of your choice, and the store and the backend are not open to just anyone. The app has three different roles; Super Admin, Store Admin, and User. The login and sign-up page, home page, and profile page are all created to meet the app requirements.
