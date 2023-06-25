# Print System service with SOAP

This project follows a 3-tier architecture consisting of the Business Logic Layer (BLL), Data Access Layer (DAL), and Data Transfer Objects (DTO). It provides a web service called "PrintPaymentSystem" for managing payments and print accounts in a printing system.

The web service offers the following operations:

- AddChfByCardId: Adds a CHF amount to a print account associated with a specific card ID.
- AddChfByUsername: Adds a CHF amount to a print account associated with a specific username.
- GetQuantityByUsername: Retrieves the quantity of available prints in a print account associated with a specific username.
- GetChfByUsername: Retrieves the CHF amount available in a print account associated with a specific username.

Additionally, the project includes a Windows Forms application called "PrintPaymentSystem_Demo." This demo application utilizes the deployed service to demonstrate its functionality.
