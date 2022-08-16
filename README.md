# **Customer Account Api**   

----  
 
----

* [Guidelines](#**guidelines**)  
* [Controllers](#**controllers**)
    * [Customer](#customer)
        * [Delete Customer v1.](#--delete-customer-v1.)
        * [Post Customer v1.](#--post-customer-v1.)
        * [Update Customer v1.](#--update-customer-v1.)
        * [Get Customers v1.](#--Get-customers-v1.)
----

## **Controllers**

### Customer

#### - Delete Customer v1.

- [ *DELETE* /api/customeraccount/v1/customer/{id} ]


	- **Description:** This method delete the Customer by id.   
 


	- **Dependencies:**  
            Access to SqlServer DB  


	- **Request:**
		```json
		{ }
		```
	- **Response:**
		* *200 - OK*           
		```json 
		{ }
		```

#### - Post Customer v1.

- [ *POST* /api/customeraccount/v1/customer ]


	- **Description:** This method criate a Customer in DB.   
 


	- **Dependencies:**  
            Access to SqlServer DB  


	- **Request:**
		```json
		{
           "name": "string",
           "old": "string",
           "civilStatus": "string",
           "document": "string",
           "city": "string",
           "state": "string"
		}
		```
	- **Response:**
		* *200 - OK*           
		```json 
		{ }
		```

#### - Post Customer v1.

- [ *PUT* /api/customeraccount/v1/customer/update/{id}" ]


	- **Description:** This method uodate a Customer in DB.   
 


	- **Dependencies:**  
            Access to SqlServer DB  


	- **Request:**
		```json
		{
           "name": "string",
           "old": "string",
           "civilStatus": "string",
           "document": "string",
           "city": "string",
           "state": "string"
		}
		```
	- **Response:**
		* *200 - OK*           
		```json 
		{ }
		```

#### - Get Customers v1

- [ *GET* /api/customeraccount/v1/customers/{skip}/{take}" ]


	- **Description:** This method get Customers in DB.   
 


	- **Dependencies:**  
            Access to SqlServer DB  


	- **Request:**
		```json
		{}
		```
	- **Response:**
		* *200 - OK*           
		```json 
		[
		   {
              "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "name": "string",
              "old": "string",
              "civilStatus": "string",
              "document": "string",
              "city": "string",
              "state": "string"
           }
		]
		```
