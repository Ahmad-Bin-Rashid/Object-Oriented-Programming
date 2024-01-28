using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace business_application
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string code = "manager123";
            const string id = "employ123";
            const string ownerCode = "motors123";
            const string ownerUsername = "admin123";
            const string ownerPassword = "123456";

            char backOption;
            string login_Option1 = "";
            string login_Option2 = "";
            string interface1_Option = "";
            string interface2_Option = "";
            string interface3_Option = "";
            string username = "";
            string password = "";
            string passcode = "";

            int managerCount = 0;
            string[] managerName = new string[5];
            string[] managerUsername = new string[5];
            string[] managerPassword = new string[5];
            string[] managerPhoneNumber = new string[5];
            string[] managerCNIC = new string[5];
            string[] managerSalary = new string[5];

            int employeeCount = 0;
            string[] employeeName = new string[50];
            string[] employeeUsername = new string[50];
            string[] employeePassword = new string[50];
            string[] employeePhoneNumber = new string[50];
            string[] employeeCNIC = new string[50];
            string[] employeeSalary = new string[50];

            int customerCount = 0;
            string[] customerName = new string[200];
            string[] customerUsername = new string[200];
            string[] customerPassword = new string[200];
            string[] customerPhoneNumber = new string[200];

            bool checkManager;
            bool checkEmployee;
            bool checkCustomer;
            bool eligible;

            int ownerNoticesCount = 0;
            string[] ownerNotices = new string[200];

            int managerNoticesCount = 0;
            string[] managerNotices = new string[200];

            int managerMessagesCount = 0;
            string[] managerName2 = new string[200];
            string[] managerUsername2 = new string[200];
            string[] managerMessages = new string[200];

            int employeeMessagesCount = 0;
            string[] employeeName2 = new string[200];
            string[] employeeUsername2 = new string[200];
            string[] employeeMessages = new string[200];

            int customerCommentsCount = 0;
            string[] commentingCustomerName = new string[200];
            string[] commentingCustomerUsername = new string[200];
            string[] customerComments = new string[200];

            int customer4ServiceCount = 0;
            string[] customer4ServiceName = new string[200];
            string[] customer4ServiceUsername = new string[200];
            string[] serviceVehicleMake = new string[200];
            string[] serviceVehicleName = new string[200];

            int customer4DriveCount = 0;
            string[] customer4DriveName = new string[200];
            string[] customer4DriveUsername = new string[200];
            string[] customer4DriveVehicle = new string[200];
            string[] vehicles4Drive = new string[7] { "Land Rover", "Ford Ranger", "BMW 8 Series Gran Coupe", "BMW 3 Series Touring", "Mercedes-Benz E-Class Saloon", "Jaguar I-PACE", "Tesla Model 3" };

            int vehicleCount = 0;
            string[] vehicleMake = new string[100];
            string[] vehicleName = new string[100];
            string[] vehicleStock = new string[100];
            string[] vehiclePrice = new string[100];

            int productCount = 0;
            string[] productName = new string[100];
            string[] productStock = new string[100];
            string[] productPrice = new string[100];

            int buyVehicleCustomerCount = 0;
            string[] buyVehicleCustomerName = new string[200];
            string[] buyVehicleCustomerPhoneNumber = new string[200];
            string[] buyVehicleName = new string[200];
            string[] buyVehicleMake = new string[200];
            string[] buyVehiclePrice = new string[200];
            string[] buyVehiclePayment = new string[200];

            int buyProductCustomerCount = 0;
            string[] buyProductCustomerName = new string[200];
            string[] buyProductCustomerPhoneNumber = new string[200];
            string[] buyProductName = new string[200];
            string[] buyProductPrice = new string[200];
            string[] buyProductPayment = new string[200];

            string temporaryUsername;

            PrintHeader1();
            //getUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
            //getUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
            //getCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
            //getVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
            //getProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
            //getVehicleServiceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
            //getTestDerivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
            //getCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
            while (true)
            {
                PrintHeader2();
                PrintMenu("LOGIN");
                login_Option1 = LoginMenu1();
                if (login_Option1 == "1" || login_Option1 == "2" || login_Option1 == "3" || login_Option1 == "4" || login_Option1 == "5")
                {
                    if (login_Option1 == "1")
                    {
                        while (true)
                        {
                            PrintHeader2();
                            PrintMenu("OWNER");
                            login_Option2 = LoginMenu2();

                            if (login_Option2 == "1" || login_Option2 == "2")
                            {
                                if (login_Option2 == "1")
                                {
                                    PrintHeader2();
                                    PrintMenu("OWNER SIGNIN");

                                    CheckPasscode(ref passcode, "Enter Owner Passcode: ");
                                    if (passcode != ownerCode)
                                    {
                                        PrintMessage("Wrong Passcode. You are not the Owner!!");
                                        break;
                                    }
                                    InputCredentials(ref username, ref password);
                                    if (username == ownerUsername && password == ownerPassword)
                                    {
                                        PrintMessage("You SignedIn Successfully...");

                                        while (true)
                                        {
                                            PrintHeader2();
                                            PrintMenu("OWNER");
                                            interface1_Option = OwnerMenu();

                                            if (interface1_Option == "1" || interface1_Option == "2" || interface1_Option == "3" || interface1_Option == "4" || interface1_Option == "5" || interface1_Option == "6" || interface1_Option == "7" || interface1_Option == "8" || interface1_Option == "9" || interface1_Option == "10")
                                            {
                                                if (interface1_Option == "1")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("COMMUNICATE MANAGERS");
                                                        interface2_Option = CommunicateManagersMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("ANNOUNCEMENTS");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(OwnerAnnouncements(ownerNotices, ref ownerNoticesCount));
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("MANAGER MESSAGES");
                                                                ReceiveManagerMessagesMenu(managerName2, managerUsername2, managerMessages, managerMessagesCount);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "2")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View MANAGERS");
                                                    ViewManagersMenu(managerCount, managerName, managerUsername, managerPhoneNumber, managerCNIC, managerSalary);
                                                }
                                                else if (interface1_Option == "3")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("MANAGE MANAGER");
                                                        interface2_Option = ManageManagerMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4" || interface2_Option == "5")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                eligible = false;

                                                                PrintHeader2();
                                                                PrintMenu("ADD MANAGER");

                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }

                                                                eligible = AddManagerMenu(managerCount, managerUsername, managerPassword, managerName, managerPhoneNumber, managerCNIC, managerSalary);
                                                                if (eligible == true)
                                                                {
                                                                    PrintMessage("Manager Account Created Successfully...");
                                                                    managerCount++;
                                                                    //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                                    continue;
                                                                }

                                                                else if (eligible == false)
                                                                {
                                                                    PrintMessage("Username already exists. Please try again using other Credentials...");
                                                                    continue;
                                                                }
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE MANAGER");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(UpdateManagerDetailsMenu(managerCount, managerUsername, managerPassword, managerName, managerPhoneNumber, managerCNIC));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("REMOVE MANAGER");

                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(RemoveManagerMenu(ref managerCount, managerUsername, managerPassword, managerName, managerPhoneNumber, managerCNIC, managerSalary));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE MANAGER");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                //PrintMessage(UpdateManagerSalaryMenu(managerCount, managerUsername, managerPassword, managerName, managerSalary));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "5")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "4")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("VIEM EMPLOYEES");
                                                    ViewEmployeesMenu(employeeCount, employeeName, employeeUsername, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                }
                                                else if (interface1_Option == "5")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View VEHICLES");
                                                    ViewVehicleDetailsMenu(vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                }
                                                else if (interface1_Option == "6")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View PRODUCTS");
                                                    ViewProductDetailsMenu(productCount, productName, productStock, productPrice);
                                                }
                                                else if (interface1_Option == "7")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View EXPENSES");
                                                    ViewExpensesMenu(managerCount, managerSalary, employeeCount, employeeSalary);
                                                }
                                                else if (interface1_Option == "8")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View COMMENTS");
                                                    ViewCommentsMenu(customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                }
                                                else if (interface1_Option == "9")
                                                {
                                                    break;
                                                }
                                                else if (interface1_Option == "10")
                                                {
                                                    //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                    //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                    //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                    //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                    //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                    //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                    //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                    //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                PrintMessage("Invalid Input. Try again!!");
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        PrintMessage("Wrong Credentials!! Try again...");
                                        continue;
                                    }
                                }
                                else if (login_Option2 == "2")
                                {
                                    break;
                                }
                            }
                            else
                            {
                                PrintMessage("Invalid Input. Try again!!");
                                continue;
                            }
                        }
                    }
                    else if (login_Option1 == "2")
                    {
                        while (true)
                        {
                            PrintHeader2();
                            PrintMenu("MANAGER");
                            login_Option2 = LoginMenu2();

                            if (login_Option2 == "1" || login_Option2 == "2")
                            {
                                if (login_Option2 == "1")
                                {
                                    checkManager = false;

                                    PrintHeader2();
                                    PrintMenu("MANAGER SIGNIN");

                                    CheckPasscode(ref passcode, "Enter Company Passcode: ");
                                    if (passcode != code)
                                    {
                                        PrintMessage("Wrong Passcode. You are not a Manager!!");
                                        break;
                                    }

                                    InputCredentials(ref username, ref password);
                                    checkManager = CheckUser(username, password, managerUsername, managerPassword, managerCount);
                                    if (checkManager == true)
                                    {
                                        PrintMessage("You SignedIn Successfully...");
                                        temporaryUsername = username;
                                        while (true)
                                        {
                                            PrintHeader2();
                                            PrintMenu("MANAGER");
                                            interface1_Option = ManagerMenu();

                                            if (interface1_Option == "1" || interface1_Option == "2" || interface1_Option == "3" || interface1_Option == "4" || interface1_Option == "5" || interface1_Option == "6" || interface1_Option == "7" || interface1_Option == "8" || interface1_Option == "9" || interface1_Option == "10" || interface1_Option == "11" || interface1_Option == "12" || interface1_Option == "13" || interface1_Option == "14" || interface1_Option == "15" || interface1_Option == "16")
                                            {
                                                if (interface1_Option == "1")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("ANNOUNCEMENTS");
                                                    ShowOwnerAnnouncements(ownerNotices, ownerNoticesCount);
                                                }
                                                else if (interface1_Option == "2")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("COMMUNICATE OWNER");
                                                    backOption = GoBackMessage();
                                                    if (backOption == '\b')
                                                    {
                                                        continue;
                                                    }
                                                    PrintMessage(ContactOwnerMenu(managerCount, managerName, managerUsername, temporaryUsername, managerName2, managerUsername2, managerMessages, ref managerMessagesCount));
                                                }
                                                else if (interface1_Option == "3")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View VEHICLES");
                                                    ViewVehicleDetailsMenu(vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                }
                                                else if (interface1_Option == "4")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("MODIFY VEHICLES");
                                                        interface2_Option = ModifyVehiclesMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("ADD VEHICLE");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(AddVehicleMenu(ref vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice));
                                                                //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE VEHICLE");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(UpdateVehicleMenu(vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice));
                                                                //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("REMOVE VEHICLE");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(RemoveVehicleMenu(ref vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice));
                                                                //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "5")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View PRODUCTS");
                                                    ViewProductDetailsMenu(productCount, productName, productStock, productPrice);
                                                }
                                                else if (interface1_Option == "6")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("MODIFY PRODUCTS");
                                                        interface2_Option = ModifyProductMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("ADD PRODUCT");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(AddProductMenu(ref productCount, productName, productStock, productPrice));
                                                                //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE PRODUCT");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(UpdateProductMenu(productCount, productName, productStock, productPrice));
                                                                //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("REMOVE PRODUCT");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(RemoveProductMenu(ref productCount, productName, productStock, productPrice));
                                                                //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "7")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("Sold ITEMS");
                                                        interface2_Option = SoldItemsMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("Sold VEHICLES");
                                                                SoldVehiclesMenu(buyVehicleCustomerCount, buyVehicleCustomerName, buyVehicleCustomerPhoneNumber, buyVehicleName, buyVehicleMake, buyVehiclePrice, buyVehiclePayment);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("Sold PRODUCTS");
                                                                SoldProductsMenu(buyProductCustomerCount, buyProductCustomerName, buyProductCustomerPhoneNumber, buyProductName, buyProductPrice, buyProductPayment);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "8")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View EMPLOYEES");
                                                    ViewEmployeesMenu(employeeCount, employeeName, employeeUsername, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                }
                                                else if (interface1_Option == "9")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("MANAGE EMPLOYEES");
                                                        interface2_Option = ManageEmployeeMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4" || interface2_Option == "5")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                eligible = false;

                                                                PrintHeader2();
                                                                PrintMenu("ADD EMPLOYEE");

                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }

                                                                eligible = AddEmployeeMenu(ref employeeCount, employeeUsername, employeePassword, employeeName, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                                if (eligible == true)
                                                                {
                                                                    PrintMessage("Employee Account Created Successfully...");
                                                                    employeeCount++;
                                                                    //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                                    continue;
                                                                }

                                                                else if (eligible == false)
                                                                {
                                                                    PrintMessage("Username already exists. Please try again using other Credentials...");
                                                                    continue;
                                                                }
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE EMPLOYEE");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(UpdateEmployeeDetailsMenu(employeeCount, employeeUsername, employeePassword, employeeName, employeePhoneNumber, employeeCNIC));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("REMOVE EMPLOYEE");

                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(RemoveEmployeeMenu(ref employeeCount, employeeUsername, employeePassword, employeeName, employeePhoneNumber, employeeCNIC, employeeSalary));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("UPDATE SALARY");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                //PrintMessage(UpdateEmployeeSalaryMenu(employeeCount, employeeUsername, employeePassword, employeeName, employeeSalary));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "5")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "10")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("SERVICE DETAILS");
                                                    ServiceDetailsMenu(customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                }
                                                else if (interface1_Option == "11")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("TEST DRIVES DETAILS");
                                                    TestDriveDetailsMenu(customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                }
                                                else if (interface1_Option == "12")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("COMMUNICATE EMPLOYEES");
                                                        interface2_Option = CommunicateEmployeesMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("ANNOUNCEMENTS");
                                                                backOption = GoBackMessage();
                                                                if (backOption == '\b')
                                                                {
                                                                    continue;
                                                                }
                                                                PrintMessage(ManagerAnnouncements(managerNotices, ref managerNoticesCount));
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("EMPLOYEE MESSAGES");
                                                                ReceiveEmployeeMessagesMenu(employeeName2, employeeUsername2, employeeMessages, employeeMessagesCount);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "13")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View COMMENTS");
                                                    ViewCommentsMenu(customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                }
                                                else if (interface1_Option == "14")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("ACCOUNT SETTING");
                                                        interface2_Option = AccountSettingMenu(); ;

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4" || interface2_Option == "5" || interface2_Option == "6")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE NAME");
                                                                PrintMessage(ChangeProfile(managerCount, managerUsername, temporaryUsername, managerName, "Name"));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE USERNAME");
                                                                PrintMessage(ChangeUsername(managerCount, managerUsername, temporaryUsername, "Username"));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE PASSWORD");
                                                                PrintMessage(ChangeProfile(managerCount, managerUsername, temporaryUsername, managerPassword, "Password"));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE MOBILE NUMBER");
                                                                PrintMessage(ChangeProfile(managerCount, managerUsername, temporaryUsername, managerPhoneNumber, "Mobile Number"));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "5")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE CNIC");
                                                                PrintMessage(ChangeProfile(managerCount, managerUsername, temporaryUsername, managerCNIC, "CNIC"));
                                                                //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                            }
                                                            else if (interface2_Option == "6")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "15")
                                                {
                                                    break;
                                                }
                                                else if (interface1_Option == "16")
                                                {
                                                    //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                    //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                    //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                    //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                    //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                    //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                    //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                    //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                PrintMessage("Invalid Input. Try again!!");
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        PrintMessage("Wrong Credentials. Try again!!");
                                        continue;
                                    }
                                }
                                else if (login_Option2 == "2")
                                {
                                    break;
                                }
                            }
                            else
                            {
                                PrintMessage("Invalid Input. Try again!!");
                                continue;
                            }
                        }
                    }
                    else if (login_Option1 == "3")
                    {
                        while (true)
                        {
                            PrintHeader2();
                            PrintMenu("EMPLOYEE");
                            login_Option2 = LoginMenu2();

                            if (login_Option2 == "1" || login_Option2 == "2")
                            {
                                if (login_Option2 == "1")
                                {
                                    checkManager = false;

                                    PrintHeader2();
                                    PrintMenu("EMPLOYEE SIGNIN");

                                    CheckPasscode(ref passcode, "To confirm that you are an Employee enter ID provided by Manager: ");
                                    if (passcode != id)
                                    {
                                        PrintMessage("Wrong ID. You are not an Employee!!");
                                        continue;
                                    }

                                    InputCredentials(ref username, ref password);
                                    checkEmployee = CheckUser(username, password, employeeUsername, employeePassword, employeeCount);

                                    if (checkEmployee == true)
                                    {
                                        PrintMessage("You SignedIn Successfully...");
                                        temporaryUsername = username;
                                        while (true)
                                        {
                                            PrintHeader2();
                                            PrintMenu("EMPLOYEE");
                                            interface1_Option = EmployeeMenu();

                                            if (interface1_Option == "1" || interface1_Option == "2" || interface1_Option == "3" || interface1_Option == "4" || interface1_Option == "5" || interface1_Option == "6" || interface1_Option == "7" || interface1_Option == "8" || interface1_Option == "9" || interface1_Option == "10" || interface1_Option == "11" || interface1_Option == "12")
                                            {
                                                if (interface1_Option == "1")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("ANNOUNCEMENTS");
                                                    ShowManagerAnnouncements(managerNotices, managerNoticesCount);
                                                }
                                                else if (interface1_Option == "2")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("COMMUNICATE MANAGER");
                                                    backOption = GoBackMessage();
                                                    if (backOption == '\b')
                                                    {
                                                        continue;
                                                    }
                                                    PrintMessage(ContactManagerMenu(employeeCount, employeeName, employeeUsername, temporaryUsername, employeeName2, employeeUsername2, employeeMessages, ref employeeMessagesCount));
                                                }
                                                else if (interface1_Option == "3")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View VEHICLES");
                                                    ViewVehicleDetailsMenu(vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                }
                                                else if (interface1_Option == "4")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View PRODUCTS");
                                                    ViewProductDetailsMenu(productCount, productName, productStock, productPrice);
                                                }
                                                else if (interface1_Option == "5")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("Sold ITEMS");
                                                        interface2_Option = SoldItemsMenu();

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("Sold VEHICLES");
                                                                SoldVehiclesMenu(buyVehicleCustomerCount, buyVehicleCustomerName, buyVehicleCustomerPhoneNumber, buyVehicleName, buyVehicleMake, buyVehiclePrice, buyVehiclePayment);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("Sold PRODUCTS");
                                                                SoldProductsMenu(buyProductCustomerCount, buyProductCustomerName, buyProductCustomerPhoneNumber, buyProductName, buyProductPrice, buyProductPayment);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "6")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("SERVICE DETAILS");
                                                    ServiceDetailsMenu(customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                }
                                                else if (interface1_Option == "7")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("TEST DRIVES DETAILS");
                                                    TestDriveDetailsMenu(customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                }
                                                else if (interface1_Option == "8")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("ACCOUNT SETTING");
                                                        interface2_Option = AccountSettingMenu(); ;

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4" || interface2_Option == "5" || interface2_Option == "6")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE NAME");
                                                                PrintMessage(ChangeProfile(employeeCount, employeeUsername, temporaryUsername, employeeName, "Name"));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE USERNAME");
                                                                PrintMessage(ChangeUsername(employeeCount, employeeUsername, temporaryUsername, "Username"));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE PASSWORD");
                                                                PrintMessage(ChangeProfile(employeeCount, employeeUsername, temporaryUsername, employeePassword, "Password"));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE MOBILE NUMBER");
                                                                PrintMessage(ChangeProfile(employeeCount, employeeUsername, temporaryUsername, employeePhoneNumber, "Mobile Number"));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "5")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE CNIC");
                                                                PrintMessage(ChangeProfile(employeeCount, employeeUsername, temporaryUsername, employeeCNIC, "CNIC"));
                                                                //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                            }
                                                            else if (interface2_Option == "6")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "9")
                                                {
                                                    break;
                                                }
                                                else if (interface1_Option == "10")
                                                {
                                                    //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                    //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                    //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                    //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                    //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                    //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                    //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                    //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                PrintMessage("Invalid Input. Try again!!");
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        PrintMessage("Wrong Credentials. Try again!!");
                                        continue;
                                    }
                                }
                                else if (login_Option2 == "2")
                                {
                                    break;
                                }
                            }
                            else
                            {
                                PrintMessage("Invalid Input. Try again!!");
                                continue;
                            }
                        }
                    }
                    else if (login_Option1 == "4")
                    {
                        while (true)
                        {
                            PrintHeader2();
                            PrintMenu("CUSTOMER LOGIN");
                            login_Option2 = CustomerLoginMenu();

                            if (login_Option2 == "1" || login_Option2 == "2" || login_Option2 == "3")
                            {
                                if (login_Option2 == "1")
                                {
                                    checkCustomer = false;
                                    PrintHeader2();
                                    PrintMenu("CUSTOMER SIGNIN");
                                    CreateAccountMessage();
                                    backOption = GoBackMessage();
                                    if (backOption == '\b')
                                    {
                                        continue;
                                    }

                                    InputCredentials(ref username, ref password);
                                    checkCustomer = CheckUser(username, password, customerUsername, customerPassword, customerCount);
                                    if (checkCustomer == true)
                                    {
                                        PrintMessage("You SignedIn Successfully...");
                                        temporaryUsername = username;
                                        while (true)
                                        {
                                            PrintHeader2();
                                            PrintMenu("CUSTOMER");
                                            interface1_Option = CustomerMenu();

                                            if (interface1_Option == "1" || interface1_Option == "2" || interface1_Option == "3" || interface1_Option == "4" || interface1_Option == "5" || interface1_Option == "6" || interface1_Option == "7" || interface1_Option == "8" || interface1_Option == "9" || interface1_Option == "10" || interface1_Option == "11" || interface1_Option == "12")
                                            {
                                                if (interface1_Option == "1")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View VEHICLES");
                                                    CustomerViewVehiclesMenu(vehicleCount, vehicleMake, vehicleName, vehiclePrice);
                                                }
                                                else if (interface1_Option == "2")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("BUY VEHICLE");
                                                        interface2_Option = BuyProductMenu("Vehicle");
                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHOOSE VEHICLE");
                                                                PrintMessage(ChooseVehicleMenu(customerCount, customerUsername, temporaryUsername, customerName, customerPhoneNumber, vehicleCount, vehicleMake, vehicleName, vehiclePrice, buyVehicleCustomerCount, buyVehicleCustomerName, buyVehicleCustomerPhoneNumber, buyVehicleName, buyVehicleMake, buyVehiclePrice));
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                while (true)
                                                                {
                                                                    PrintHeader2();
                                                                    PrintMenu("PAYMENT METHOD");
                                                                    interface3_Option = PaymentMethodMenu1();
                                                                    if (interface3_Option == "1" || interface3_Option == "2" || interface3_Option == "3" || interface3_Option == "4")
                                                                    {
                                                                        if (interface3_Option == "1")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(vehicleCount, vehicleName, buyVehicleCustomerCount, buyVehicleName, buyVehiclePayment, "Immediate Cash Payment", "Vehicle"));
                                                                        }
                                                                        else if (interface3_Option == "2")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(vehicleCount, vehicleName, buyVehicleCustomerCount, buyVehicleName, buyVehiclePayment, "Payment by Credit Card", "Vehicle"));
                                                                        }
                                                                        else if (interface3_Option == "3")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(vehicleCount, vehicleName, buyVehicleCustomerCount, buyVehicleName, buyVehiclePayment, "Payment By Bank", "Vehicle"));
                                                                        }
                                                                        else if (interface3_Option == "4")
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        PrintMessage("Invalid Input. Try again!!");
                                                                        continue;
                                                                    }
                                                                }
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("PRINT BILL");
                                                                PrintMessage(VehicleBillMenu(vehicleCount, vehicleName, vehicleStock, ref buyVehicleCustomerCount, buyVehicleCustomerName, buyVehicleCustomerPhoneNumber, buyVehicleName, buyVehicleMake, buyVehiclePrice, buyVehiclePayment));
                                                                //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "3")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("View PRODUCTS");
                                                    CustomerViewProductsMenu(productCount, productName, productPrice);
                                                }
                                                else if (interface1_Option == "4")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("BUY PRODUCT");
                                                        interface2_Option = BuyProductMenu("Product");
                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHOOSE PRODUCT");
                                                                PrintMessage(ChooseProductMenu(customerCount, customerUsername, temporaryUsername, customerName, customerPhoneNumber, productCount, productName, productPrice, buyProductCustomerCount, buyProductCustomerName, buyProductCustomerPhoneNumber, buyProductName, buyProductPrice));
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                while (true)
                                                                {
                                                                    PrintHeader2();
                                                                    PrintMenu("PAYMENT METHOD");
                                                                    interface3_Option = PaymentMethodMenu1();
                                                                    if (interface3_Option == "1" || interface3_Option == "2" || interface3_Option == "3" || interface3_Option == "4")
                                                                    {
                                                                        if (interface3_Option == "1")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(productCount, productName, buyProductCustomerCount, buyProductName, buyProductPayment, "Immediate Cash Payment", "Product"));
                                                                        }
                                                                        else if (interface3_Option == "2")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(productCount, productName, buyProductCustomerCount, buyProductName, buyProductPayment, "Payment by Credit Card", "Product"));
                                                                        }
                                                                        else if (interface3_Option == "3")
                                                                        {
                                                                            PrintHeader2();
                                                                            PrintMenu("PAYMENT METHOD");
                                                                            PrintMessage(PaymentMethodMenu2(productCount, productName, buyProductCustomerCount, buyProductName, buyProductPayment, "Payment By Bank", "Product"));
                                                                        }
                                                                        else if (interface3_Option == "4")
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        PrintMessage("Invalid Input. Try again!!");
                                                                        continue;
                                                                    }
                                                                }
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("PRINT BILL");
                                                                ProductBillMenu(productCount, productName, productStock, ref buyProductCustomerCount, buyProductCustomerName, buyProductCustomerPhoneNumber, buyProductName, buyProductPrice, buyProductPayment);
                                                                //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "5")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("SERVICE REGISTRATION");
                                                    backOption = GoBackMessage();
                                                    if (backOption == '\b')
                                                    {
                                                        continue;
                                                    }
                                                    ServiceRegistrationMenu(customerCount, customerUsername, customerName, temporaryUsername, ref customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                    //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                }
                                                else if (interface1_Option == "6")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("TEST DRIVES REGISTRATION");
                                                    backOption = GoBackMessage();
                                                    if (backOption == '\b')
                                                    {
                                                        continue;
                                                    }
                                                    DriveRegistrationMenu(customerCount, customerUsername, customerName, temporaryUsername, ref customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle, vehicles4Drive);
                                                    //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                }
                                                else if (interface1_Option == "7")
                                                {
                                                    PrintHeader2();
                                                    PrintMenu("ADD COMMENTS");
                                                    backOption = GoBackMessage();
                                                    if (backOption == '\b')
                                                    {
                                                        continue;
                                                    }
                                                    PrintMessage(AddCommentsMenu(customerCount, customerUsername, customerName, temporaryUsername, ref customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments));
                                                    //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                }
                                                else if (interface1_Option == "8")
                                                {
                                                    while (true)
                                                    {
                                                        PrintHeader2();
                                                        PrintMenu("ACCOUNT SETTING");
                                                        interface2_Option = CustomerAccountSettingMenu(); ;

                                                        if (interface2_Option == "1" || interface2_Option == "2" || interface2_Option == "3" || interface2_Option == "4" || interface2_Option == "5")
                                                        {
                                                            if (interface2_Option == "1")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE NAME");
                                                                PrintMessage(ChangeProfile(customerCount, customerUsername, temporaryUsername, customerName, "Name"));
                                                                //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                            }
                                                            else if (interface2_Option == "2")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE USERNAME");
                                                                PrintMessage(ChangeUsername(customerCount, customerUsername, temporaryUsername, "Username"));
                                                                //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                            }
                                                            else if (interface2_Option == "3")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE PASSWORD");
                                                                PrintMessage(ChangeProfile(customerCount, customerUsername, temporaryUsername, customerPassword, "Password"));
                                                                //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                            }
                                                            else if (interface2_Option == "4")
                                                            {
                                                                PrintHeader2();
                                                                PrintMenu("CHANGE MOBILE NUMBER");
                                                                PrintMessage(ChangeProfile(customerCount, customerUsername, temporaryUsername, customerPhoneNumber, "Mobile Number"));
                                                                //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                            }
                                                            else if (interface2_Option == "5")
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            PrintMessage("Invalid Input. Try again!!");
                                                            continue;
                                                        }
                                                    }
                                                }
                                                else if (interface1_Option == "9")
                                                {
                                                    break;
                                                }
                                                else if (interface1_Option == "10")
                                                {
                                                    //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                                                    //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                                                    //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                                    //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                                                    //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                                                    //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                                                    //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                                                    //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                PrintMessage("Invalid Input. Try again!!");
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        PrintMessage("Wrong Credentials. Try again!!");
                                        continue;
                                    }
                                }
                                else if (login_Option2 == "2")
                                {
                                    eligible = false;
                                    PrintHeader2();
                                    PrintMenu("CUSTOMER SIGNUP");
                                    backOption = GoBackMessage();
                                    if (backOption == '\b')
                                    {
                                        continue;
                                    }

                                    eligible = CustomerSignupMenu(ref customerCount, customerUsername, customerPassword, customerName, customerPhoneNumber);
                                    if (eligible == true)
                                    {
                                        PrintMessage("You SignedUp Successfully...");
                                        customerCount++;
                                        //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                                        continue;
                                    }
                                    else if (eligible == false)
                                    {
                                        PrintMessage("Username already exists. Please try again using other Username...");
                                        continue;
                                    }
                                }
                                else if (login_Option2 == "3")
                                {
                                    break;
                                }
                            }
                            else
                            {
                                PrintMessage("Invalid Input. Try again!!");
                                continue;
                            }
                        }
                    }
                    else if (login_Option1 == "5")
                    {
                        //StoreUsersData("Managers_Data.txt", managerCount, managerName, managerUsername, managerPassword, managerPhoneNumber, managerCNIC, managerSalary);
                        //StoreUsersData("Employees_Data.txt", employeeCount, employeeName, employeeUsername, employeePassword, employeePhoneNumber, employeeCNIC, employeeSalary);
                        //StoreCustomerData("Customers_Data.txt", customerCount, customerName, customerUsername, customerPassword, customerPhoneNumber);
                        //StoreVehiclesData("Vehicles_Data.txt", vehicleCount, vehicleMake, vehicleName, vehicleStock, vehiclePrice);
                        //StoreProductsData("Products_Data.txt", productCount, productName, productStock, productPrice);
                        //StoreVehicleserviceData("VehicleService_Data.txt", customer4ServiceCount, customer4ServiceName, customer4ServiceUsername, serviceVehicleMake, serviceVehicleName);
                        //StoreTestDrivesData("TestDrives_Data.txt", customer4DriveCount, customer4DriveName, customer4DriveUsername, customer4DriveVehicle);
                        //StoreCommentsData("Comments_Data.txt", customerCommentsCount, commentingCustomerName, commentingCustomerUsername, customerComments);
                        return;
                    }
                }
                else
                {
                    PrintMessage("Invalid Input. Try again!!");
                    continue;
                }
            }
        }


        static void PrintHeader1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; // Set text color to red

            Console.WriteLine(@"
                                                                                         ((
                                                                   ((             )\ )      ))\ )  (
                                                                   )\))(   )\     (((() / (` )  / (() / (  )\                    
                                                          ((_)()((((_)(   )\ )\  / (_))( )(_))(_) | ((_)
                                                          (_()((_)\ _)\ ((_ | (_)(_))(_(_() | _)))\___
                                                          |  \/ (_)_\(_) | | __ / __ || _   _ | _ _((/ __ |
                                                          | |\/| |/ _ \| || | _ |\__ \  | |  | | | (__
                                                          | _ |  | _ / _ / )_\\__ /| ___ | _)_ / ( | _ | (| ___ | \___ |

                                           (( / (       )( / (  )\ ))\ )   ((     )\ ) )\ )     )\ ) ( / (
                                           )\))(  )\())` )  / ( )\())(() / ((() / (   )\ )    )\   (() / ((() / (((() / ( )\()) 
                                          ((_)()\((_)\  ( )(_) | (_)\  / (_))/ (_)) (() / (((((_)(  / (_)) / (_)))\  / (_) | (_)\  
                                          (_()((_)((_)(_(_())((_)(_))(_)) / (_))_)\ _ )\(_)) (_)) ((_)(_))__((_)
                                          |  \/  |/ _ \| _   _ | / _ \| _ \/ __ | (_)) __(_)_\(_) |  | |  | __ | _ \ \ / /
                                          | |\/| | (_) | | |  | (_) |   /\__ \    | (_ |/ _ \ | | __ | | __ | _ ||   /\ V /
                                          | _ |  | _ |\___ /  | _ |   \___ /| _ | _\| ___ /     \___ / _ / \_\| ____ | ____ | ___ | _ | _\ | _ |






                                      L O A D I N G
");

            Console.Write("\t\t\t\t\t\t\t");
            for (int i = 0; i < 25; i++)
            {
                char ch = '\u2588'; // Unicode character to print box
                Console.Write(ch + ch);
                Thread.Sleep(60);
            }
        }


        static void PrintHeader2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; // Set text color to red
            Console.WriteLine("\n");

            Console.WriteLine("              @@@     @@@  @@@@@@@      @@  @@@@@@  @@@@@@  @@@@@@@@  @@@@@@    @@@@@         @@@     @@@     @@@@@    @@@@@@@@    @@@@@     @@@@@@   @@@@@@      ");
            Console.WriteLine("              @@@@   @@@@  @@   @@      @@  @@   @  @@   @  @@ @@ @@    @@     @@   @         @@@@   @@@@    @@   @@   @@ @@ @@   @@   @@    @@   @   @@   @      ");
            Console.WriteLine("              @@@@@@@@@@@  @@   @@      @@  @@       @@     @  @@  @    @@    @@              @@@@@@@@@@@   @@     @@  @  @@  @  @@     @@   @@   @    @@         ");
            Console.WriteLine("              @@  @@@  @@  @@   @@      @@  @@@@      @@       @@       @@   @@               @@  @@@  @@  @@       @@    @@    @@       @@  @@@@@@     @@        ");
            Console.WriteLine("              @@  @@@  @@  @@@@@@@      @@  @@         @@      @@       @@    @@              @@  @@@  @@   @@     @@     @@     @@     @@   @@ @        @@       ");
            Console.WriteLine("              @@   @   @@  @@   @@  @   @@  @@   @  @   @@     @@       @@     @@   @         @@   @   @@    @@   @@      @@      @@   @@    @@  @    @   @@      ");
            Console.WriteLine("              @@       @@  @@   @@  @@@@@@  @@@@@@  @@@@@@     @@     @@@@@@    @@@@@         @@       @@     @@@@@       @@       @@@@@     @@   @@  @@@@@@      ");
            Console.WriteLine("\n");
            Console.WriteLine("                                                          @@@@       @@    @@     @@     @@@@@@@  @@@@@@   @@   @ ");
            Console.WriteLine("                                                         @@        @@@@@   @@     @@     @@    @  @@    @   @@ @  ");
            Console.WriteLine("                                                        @@  @@@   @@   @@  @@     @@     @@@@     @@@@@@     @@   ");
            Console.WriteLine("                                                        @@    @   @@@@@@@  @@  @  @@  @  @@    @  @@   @     @    ");
            Console.WriteLine("                                                         @@@@@@   @@   @@  @@@@@  @@@@@  @@@@@@@  @@    @   @     ");
            Console.WriteLine("\n\n");
        }


        static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Set text color to blue
            Console.WriteLine();
            Console.WriteLine($"\t\t\t{message}");
            Thread.Sleep(1100);
        }

        static void PrintMenu(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Set text color to Greem
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t---( {message} MENU )---\n");
        }

        static void CreateAccountMessage()
        {
            Console.ForegroundColor = ConsoleColor.White; // Set text color to white
            Console.WriteLine("\t\t If you don't have any account, Please go back and create your account...\n");
        }

        static char GoBackMessage()
        {
            char option;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t Enter Backspace Key to go back.");
            Console.Write("\t\t Enter any other key to proceed: ");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            return option;
        }


        static void CheckPasscode(ref string passcode, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t\t " + message);
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            passcode = PasswordValidation(10, 4);
            Console.WriteLine("\n");
        }

        static void InputCredentials(ref string username, ref string password)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            Console.Write("\t\t\t Enter User Name: ");
            username = UsernameValidation(10, 4);
            Console.Write("\n\t\t\t Enter Password: ");
            password = PasswordValidation(10, 4);
            Console.WriteLine("\n");
        }

        static string LoginMenu1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color to yellow
            Console.WriteLine("\t\t You want to Login as: \n");
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            Console.WriteLine("\t\t\t 1) OWNER\n");
            Console.WriteLine("\t\t\t 2) MANAGER\n");
            Console.WriteLine("\t\t\t 3) EMPLOYEE\n");
            Console.WriteLine("\t\t\t 4) CUSTOMER\n\n");
            Console.WriteLine("\t\t\t 5) Exit Application\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray; // Set text color to dark gray
            Console.Write("\t\t Enter Your Option (1-5): ");
            string option = Console.ReadLine();

            return option;
        }

        static string LoginMenu2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color to yellow
            Console.WriteLine("\t\t Select one of these: \n");
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            Console.WriteLine("\t\t\t 1) SignIn\n");
            Console.WriteLine("\t\t\t 2) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray; // Set text color to dark gray
            Console.Write("\t\t Enter Your Option (1-2): ");
            string option = Console.ReadLine();

            return option;
        }

        static string CustomerLoginMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color to yellow
            Console.WriteLine("\t\t Select one of these: \n");
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            Console.WriteLine("\t\t\t 1) SignIn\n");
            Console.WriteLine("\t\t\t 2) SignUp\n\n");
            Console.WriteLine("\t\t\t 3) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray; // Set text color to dark gray
            Console.Write("\t\t Enter Your Option (1-3): ");
            string option = Console.ReadLine();
            
            return option;
        }


        static string OwnerMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Communicate Managers \n");
            Console.WriteLine("\t\t\t 2) Veiw Managers Details \n");
            Console.WriteLine("\t\t\t 3) Manage Managers \n");
            Console.WriteLine("\t\t\t 4) Veiw Employees Details \n");
            Console.WriteLine("\t\t\t 5) Veiw Vehicles Details \n");
            Console.WriteLine("\t\t\t 6) Veiw Associated Products Details \n");
            Console.WriteLine("\t\t\t 7) View Expenses \n");
            Console.WriteLine("\t\t\t 8) View Feedbacks and Opinions \n");
            Console.WriteLine("\t\t\t 9) Sign out \n");
            Console.WriteLine("\t\t\t10) Exit Application \n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-10): ");
            string option = Console.ReadLine();

            return option;
        }


        static string CommunicateManagersMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Announce Important Message\n");
            Console.WriteLine("\t\t\t 2) Message received by Managers\n");
            Console.WriteLine("\t\t\t 3) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-3): ");
            string option = Console.ReadLine();

            return option;
        }


        static string OwnerAnnouncements(string[] ownerNotices, ref int ownerNoticesCount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Announce Important Message to Managers: \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Your Announcement: ");
            ownerNotices[ownerNoticesCount] = Console.ReadLine();
            ownerNoticesCount++;
            return "Your Message has been Delivered Successfully...";
        }

        static void ReceiveManagerMessagesMenu(string[] managerName2, string[] managerUsername2, string[] managerMessages, int managerMessagesCount)
        {
            if (managerMessagesCount == 0)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t No messages received by any Manager yet.\n");
            }
            else if (managerMessagesCount > 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("  " + $"{"SrNo.",-7}{"Name",-10}{"UserName",-15}{"Message",-10}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < managerMessagesCount; x++)
                {
                    Console.WriteLine("  " + $"{x + 1,-7}{managerName2[x],-10}{managerUsername2[x],-15}{managerMessages[x],-10}");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }


        static void ViewManagersMenu(int managerCount, string[] managerName, string[] managerUsername, string[] managerPhoneNumber, string[] managerCNIC, string[] managerSalary)
        {
            Console.WriteLine();
            if (managerCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Manager Added Yet!!\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" " + $" {"SrNo.",-15}{"Name",-30}{"Username",-30}{"Mobile Number",-30}{"CNIC",-30}{"Salary",-30}\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < managerCount; x++)
                {
                    Console.WriteLine($" {x + 1,-15}{managerName[x],-30}{managerUsername[x],-30}{managerPhoneNumber[x],-30}{managerCNIC[x],-30}{managerSalary[x],-30}\n");
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }


        static string ManageManagerMenu()
        {
            string option;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Add an Manager\n");
            Console.WriteLine("\t\t\t 2) Update Manager Details\n");
            Console.WriteLine("\t\t\t 3) Remove an Manager\n");
            Console.WriteLine("\t\t\t 4) Update Manager Salary\n");
            Console.WriteLine("\t\t\t 5) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-5): ");
            option = Console.ReadLine();

            return option;
        }


        static bool AddManagerMenu(int managerCount, string[] managerUsername, string[] managerPassword, string[] managerName, string[] managerPhoneNumber, string[] managerCNIC, string[] managerSalary)
        {
            bool eligible;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter the details of the Manager...\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\t\t\t Enter Manager Full Name: ");
            managerName[managerCount] = NameValidation(15, 1);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Manager User Name (4-10 characters): ");
            managerUsername[managerCount] = UsernameValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Manager Password (4-10 characters): ");
            managerPassword[managerCount] = PasswordValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Manager Mobile Number (11 digits): ");
            managerPhoneNumber[managerCount] = NumberValidation(11, 11);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Manager CNIC (13 digits): ");
            managerCNIC[managerCount] = NumberValidation(13, 13);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Manager Salary (4-7 digits): ");
            managerSalary[managerCount] = NumberValidation(7, 4);

            eligible = CheckAccountEligibility(managerUsername, managerCount);
            return eligible;
        }


        static string UpdateManagerDetailsMenu(int managerCount, string[] managerUsername, string[] managerPassword, string[] managerName, string[] managerPhoneNumber, string[] managerCNIC)
        {
            int index = -1;
            bool check = false;
            string name;

            if (managerCount == 0)
            {
                return "No Manager to Update...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter Username of the Manager you want to Update: ");
            name = Console.ReadLine();

            for (int x = 0; x < managerCount; x++)
            {
                if (name == managerUsername[x])
                {
                    index = x;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return "No Manager exists with this Username...";
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of the Manager before Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"Name",-30}{"Username",-30}{"Password",-30}{"Mobile Number",-30}{"CNIC",-30}\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {managerName[index],-30}{managerUsername[index],-30}{managerPassword[index],-30}{managerPhoneNumber[index],-30}{managerCNIC[index],-30}\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter new Details...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter new Full Name: ");
            managerName[index] = NameValidation(15, 3);
            Console.WriteLine();

            Console.Write("\t\t\t Enter new User Name: ");
            managerUsername[index] = UsernameValidation(10, 4);
            Console.WriteLine();

            Console.Write("\t\t\t Enter new Password: ");
            managerPassword[index] = PasswordValidation(10, 4);
            Console.WriteLine();

            Console.Write("\t\t\t Enter new Mobile Number (11 digits): ");
            managerPhoneNumber[index] = NumberValidation(11, 11);
            Console.WriteLine();

            Console.Write("\t\t\t Enter new CNIC (13 digits): ");
            managerCNIC[index] = NumberValidation(13, 13);
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of the Manager after Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"Name",-30}{"Username",-30}{"Password",-30}{"Mobile Number",-30}{"CNIC",-30}\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {managerName[index],-30}{managerUsername[index],-30}{managerPassword[index],-30}{managerPhoneNumber[index],-30}{managerCNIC[index],-30}\n");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();

            return "Manager updated Successfully...";
        }


        static string RemoveManagerMenu(ref int managerCount, string[] managerUsername, string[] managerPassword, string[] managerName, string[] managerPhoneNumber, string[] managerCNIC, string[] managerSalary)
        {
            int index = -1;
            bool check = false;
            string name;

            if (managerCount == 0)
            {
                return "No Manager to Remove...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter Username of the Manager you want to Remove: ");
            name = Console.ReadLine();

            for (int x = 0; x < managerCount; x++)
            {
                if (name == managerUsername[x])
                {
                    index = x;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return "No Manager exists with this Username...";
            }

            for (int y = index; y < managerCount - 1; y++)
            {
                managerUsername[y] = managerUsername[y + 1];
                managerPassword[y] = managerPassword[y + 1];
                managerName[y] = managerName[y + 1];
                managerPhoneNumber[y] = managerPhoneNumber[y + 1];
                managerCNIC[y] = managerCNIC[y + 1];
                managerSalary[y] = managerSalary[y + 1];
            }
            managerCount--;

            return "Manager removed Successfully...";
        }


        //string Update_managerSalaryMenu(int managerCount, string[] managerUsername, string[] managerPassword, string[] managerName, string[] managerSalary)
        //{
        //    int index;
        //    bool check = false;
        //    string name;

        //    if (managerCount == 0)
        //    {
        //        return "No Manager to Update...";
        //    }

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("\t\t\t Enter Username of the manager you want to Update: ";
        //    getline(cin, name);

        //    for (int x = 0; x < managerCount; x++)
        //    {
        //        if (name == managerUsername[x])
        //        {
        //            index = x;
        //            check = true;
        //        }
        //    }

        //    if (check == false)
        //    {
        //        return "No Manager exists with this Username or Password...";
        //    }

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("\t Salary of Manager before Update: \n");
        //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //    Console.WriteLine("  " << setw(30) << left << "Name" << setw(30) << left << "Username" << setw(30) << left << "Salary\n");

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("  " << setw(30) << left << managerName[index] << setw(30) << left << managerUsername[index] << setw(30) << left << managerSalary[index] << endl << endl;

        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("\t\t Enter the details of the Manager...\n") << endl;

        //    Console.WriteLine("\t\t\t Enter new Salary (4-7 digits): ");
        //    managerSalary[index] = numberValidation(7, 4);

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("\t Salary of Manager after Update: \n");
        //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //    Console.WriteLine("  " << setw(30) << left << "Name" << setw(30) << left << "Username" << setw(30) << left << "Salary\n");

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("  " << setw(30) << left << managerName[index] << setw(30) << left << managerUsername[index] << setw(30) << left << managerSalary[index] << endl << endl;

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.WriteLine("\t\t Press any key to Continue...";
        //    Console.ReadKey();

        //    return "Manager updated Successfully...";
        //}


        static void ViewExpensesMenu(int managerCount, string[] managerSalary, int employeeCount, string[] employeeSalary)
        {
            double employeeSalaries = 0;
            double managerSalaries = 0;
            double serviceCenter = 600000;
            double showroom = 700000;
            double other = 200000;
            double total;

            for (int x = 0; x < managerCount; x++)
            {
                managerSalaries += double.Parse(managerSalary[x]);
            }

            for (int y = 0; y < employeeCount; y++)
            {
                employeeSalaries += double.Parse(employeeSalary[y]);
            }

            total = managerSalaries + employeeSalaries + serviceCenter + showroom + other;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Details of Expenses are given below... :\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("      " + string.Format("{0,-30}{1,-30}{2,-30}{3,-30}{4,-30}", "Total Manager Salaries", "Total Employees Salaries", "Service Center Expenses", "Showroom Expenses", "Other Expenses"));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      " + string.Format("{0,-30}{1,-30}{2,-30}{3,-30}{4,-30}", managerSalaries, employeeSalaries, serviceCenter, showroom, other));
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t " + string.Format("{0,-30}{1,-50}", "Grand Total", total));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n");
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();
        }
        

        static void ViewCommentsMenu(int customerCommentsCount, string[] commentingCustomerName, string[] commentingCustomerUsername, string[] customerComments)
        {
            if (customerCommentsCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No comments given by Customers yet...");
            }
            else if (customerCommentsCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("  " + string.Format("{0,-10}{1,-10}{2,-15}{3,-10}{4}", "SrNo.", "Name", "UserName", "|", "Comments"));
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < customerCommentsCount; x++)
                {
                    Console.WriteLine("  " + string.Format("{0,-10}{1,-10}{2,-15}{3,-10}{4}", x + 1, commentingCustomerName[x], commentingCustomerUsername[x], "|", customerComments[x]));
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string ManagerMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t  1) Important Announcements\n");
            Console.WriteLine("\t\t\t  2) Contact to Owner\n");
            Console.WriteLine("\t\t\t  3) Veiw Vehicles Details\n");
            Console.WriteLine("\t\t\t  4) Modify Vehicles Details\n");
            Console.WriteLine("\t\t\t  5) Veiw Associated Products Details\n");
            Console.WriteLine("\t\t\t  6) Modify Associated Products Details\n");
            Console.WriteLine("\t\t\t  7) Sold Vehicles and Products\n");
            Console.WriteLine("\t\t\t  8) Veiw Employees Details\n");
            Console.WriteLine("\t\t\t  9) Manage Employees\n");
            Console.WriteLine("\t\t\t 10) Scheduled Registrations for Service\n");
            Console.WriteLine("\t\t\t 11) Scheduled Registrations for Test Drives\n");
            Console.WriteLine("\t\t\t 12) Communicate Employees\n");
            Console.WriteLine("\t\t\t 13) View Feedbacks and Opinions\n");
            Console.WriteLine("\t\t\t 14) Account Settings\n");
            Console.WriteLine("\t\t\t 15) Sign out\n");
            Console.WriteLine("\t\t\t 16) Exit Application\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-16): ");
            option = Console.ReadLine();

            return option;
        }


        static void ShowOwnerAnnouncements(string[] ownerNotices, int ownerNoticesCount)
        {
            if (ownerNoticesCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Announcements by Owner yet.");
            }
            else if (ownerNoticesCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t Important Announcements by Owner are: \n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < ownerNoticesCount; x++)
                {
                    Console.WriteLine("  " + string.Format("{0,-15}{1}", x + 1, ownerNotices[x]));
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string ContactOwnerMenu(int managerCount, string[] managerName, string[] managerUsername, string temporaryUsername, string[] managerName2, string[] managerUsername2, string[] managerMessages, ref int managerMessagesCount)
        {
            int index = -1;
            for (int x = 0; x < managerCount; x++)
            {
                if (temporaryUsername == managerUsername[x])
                {
                    index = x;
                    break;
                }
            }

            managerName2[managerMessagesCount] = managerName[index];
            managerUsername2[managerMessagesCount] = managerUsername[index];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Deliver your message to Owner... \n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tEnter your Message: ");
            managerMessages[managerMessagesCount] = Console.ReadLine();

            managerMessagesCount++;
            return "Your message has been delivered to the Owner Successfully...";
        }

        static void ViewVehicleDetailsMenu(int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehicleStock, string[] vehiclePrice)
        {
            Console.WriteLine();
            if (vehicleCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Vehicles Available..." + Environment.NewLine);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" " + new string(' ', 15) + "SrNo." + new string(' ', 20) + "Make" + new string(' ', 20) + "Name" + new string(' ', 20) + "Stock" + new string(' ', 20) + "Price\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < vehicleCount; x++)
                {
                    Console.WriteLine(" " + new string(' ', 15) + (x + 1) + new string(' ', 20) + vehicleMake[x] + new string(' ', 20) + vehicleName[x] + new string(' ', 20) + vehicleStock[x] + new string(' ', 20) + vehiclePrice[x] + Environment.NewLine + Environment.NewLine);
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string ModifyVehiclesMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Add Vehicle\n");
            Console.WriteLine("\t\t\t 2) Update Vehicle\n");
            Console.WriteLine("\t\t\t 3) Remove Vehicle\n");
            Console.WriteLine("\t\t\t 4) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-4): ");
            option = Console.ReadLine();

            return option;
        }

        static string AddVehicleMenu(ref int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehicleStock, string[] vehiclePrice)
        {
            string temp1, temp2;
            bool eligible = true;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter the details of the Vehicle...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t Enter the Make of Vehicle: ");
            temp1 = Console.ReadLine();
            Console.Write("\t\t Enter the Name of Vehicle: ");
            temp2 = Console.ReadLine();

            eligible = CheckEligibility(vehicleName, temp2, vehicleCount);
            if (!eligible)
            {
                return "Error!! Vehicle already exists...";
            }

            vehicleMake[vehicleCount] = temp1;
            vehicleName[vehicleCount] = temp2;

            Console.Write("\t\t Enter the Stock of Vehicle: ");
            vehicleStock[vehicleCount] = NumberValidation(4, 1);
            Console.WriteLine();
            Console.Write("\t\t Enter the Price of Vehicle: ");
            vehiclePrice[vehicleCount] = NumberValidation(9, 5);
            Console.WriteLine();

            vehicleCount++;
            return "New Vehicle has been added successfully...";
        }
        
        static string UpdateVehicleMenu(int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehicleStock, string[] vehiclePrice)
        {
            int index = -1;
            bool check = false;
            string make, name;

            if (vehicleCount == 0)
            {
                return "No vehicle to Update...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t Enter the Make of the Vehicle you Want to Update: ");
            make = Console.ReadLine();
            Console.Write("\t\t Enter the Name of the Vehicle you Want to Update: ");
            name = Console.ReadLine();

            for (int x = 0; x < vehicleCount; x++)
            {
                if (make == vehicleMake[x] && name == vehicleName[x])
                {
                    index = x;
                    check = true;
                }
            }

            if (!check)
            {
                return "No vehicle exists with this Name or Make...";
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of Vehicle before Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("  " + PadLeft("Make") + PadLeft("Name") + PadLeft("Stock") + PadLeft("Price") + "\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  " + PadLeft(vehicleMake[index]) + PadLeft(vehicleName[index]) + PadLeft(vehicleStock[index]) + PadLeft(vehiclePrice[index]) + "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter new Details...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter new Stock: ");
            vehicleStock[index] = NumberValidation(4, 1);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new Price: ");
            vehiclePrice[index] = NumberValidation(9, 5);

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of Vehicle after Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("  " + PadLeft("Make") + PadLeft("Name") + PadLeft("Stock") + PadLeft("Price") + "\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  " + PadLeft(vehicleMake[index]) + PadLeft(vehicleName[index]) + PadLeft(vehicleStock[index]) + PadLeft(vehiclePrice[index]) + "\n");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();

            return "Vehicle updated Successfully...";
        }

        static string PadLeft(string input)
        {
            return input.PadLeft(30);
        }
        
        static string RemoveVehicleMenu(ref int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehicleStock, string[] vehiclePrice)
        {
            int index = -1;
            bool check = false;
            string make, name;

            if (vehicleCount == 0)
            {
                return "No vehicle to Remove...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t Enter the Make of the Vehicle you Want to Remove: ");
            make = Console.ReadLine();
            Console.Write("\t\t Enter the Name of the Vehicle you Want to Remove: ");
            name = Console.ReadLine();

            for (int x = 0; x < vehicleCount; x++)
            {
                if (make == vehicleMake[x] && name == vehicleName[x])
                {
                    index = x;
                    check = true;
                }
            }

            if (!check)
            {
                return "No vehicle exists with this Name or Make...";
            }

            for (int y = index; y < vehicleCount; y++)
            {
                vehicleMake[y] = vehicleMake[y + 1];
                vehicleName[y] = vehicleName[y + 1];
                vehicleStock[y] = vehicleStock[y + 1];
                vehiclePrice[y] = vehiclePrice[y + 1];
            }
            vehicleCount--;

            return "Vehicle removed Successfully...";
        }


        static void ViewProductDetailsMenu(int productCount, string[] productName, string[] productStock, string[] productPrice)
        {
            if (productCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Products Available..." + Environment.NewLine);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"SrNo.",-15}{"Name",-30}{"Stock",-30}{"Price",-30}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < productCount; x++)
                {
                    Console.WriteLine($"  {x + 1,-15}{productName[x],-30}{productStock[x],-30}{productPrice[x],-30}" + Environment.NewLine);
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }


        static string ModifyProductMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Add Product\n");
            Console.WriteLine("\t\t\t 2) Update Product\n");
            Console.WriteLine("\t\t\t 3) Remove Product\n");
            Console.WriteLine("\t\t\t 4) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-4): ");
            option = Console.ReadLine();

            return option;
        }

        static string AddProductMenu(ref int productCount, string[] productName, string[] productStock, string[] productPrice)
        {
            int index = productCount;
            string temp;
            bool eligible = true;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter the Details of the Product...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t Enter the Name of Product: ");
            temp = Console.ReadLine();

            eligible = CheckEligibility(productName, temp, productCount);
            if (!eligible)
            {
                return "Error!! Product already exists...";
            }

            productName[index] = temp;
            Console.Write("\t\t Enter the Stock of Product: ");
            productStock[index] = NumberValidation(4, 1);
            Console.WriteLine();
            Console.Write("\t\t Enter the Price of Product: ");
            productPrice[index] = NumberValidation(9, 2);
            Console.WriteLine();
            productCount++;
            return "New Product has been added successfully...";
        }

        static string UpdateProductMenu(int productCount, string[] productName, string[] productStock, string[] productPrice)
        {
            int index = -1;
            bool check = false;
            string name;

            if (productCount == 0)
            {
                return "No product to Update...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t Enter the Name of the Product you Want to Update: ");
            name = Console.ReadLine();

            for (int x = 0; x < productCount; x++)
            {
                if (name == productName[x])
                {
                    index = x;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return "No product exists with this Name...";
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of Product before Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"   {"Name",-30}{"Stock",-30}{"Price",-30}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   {productName[index],-30}{productStock[index],-30}{productPrice[index],-30}" + Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Enter new Details...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter new Stock: ");
            productStock[index] = NumberValidation(4, 1);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new Price: ");
            productPrice[index] = NumberValidation(9, 2);

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of Product after Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"   {"Name",-30}{"Stock",-30}{"Price",-30}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   {productName[index],-30}{productStock[index],-30}{productPrice[index],-30}" + Environment.NewLine);

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t Press any key to Continue...");
            Console.ReadKey();

            return "Product updated Successfully...";
        }

        static string RemoveProductMenu(ref int productCount, string[] productName, string[] productStock, string[] productPrice)
        {
            int index = -1;
            bool check = false;
            string name;

            if (productCount == 0)
            {
                return "No product to Remove...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t Enter the Name of the Product you Want to Remove: ");
            name = Console.ReadLine();

            for (int x = 0; x < productCount; x++)
            {
                if (name == productName[x])
                {
                    index = x;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return "No product exists with this Name...";
            }

            for (int y = index; y < productCount - 1; y++)
            {
                productName[y] = productName[y + 1];
                productStock[y] = productStock[y + 1];
                productPrice[y] = productPrice[y + 1];
            }

            productCount--;

            return "Product removed Successfully...";
        }


        static string SoldItemsMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Select From the Following... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Sold Vehicles\n");
            Console.WriteLine("\t\t\t 2) Sold Products\n");
            Console.WriteLine("\t\t\t 3) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-3): ");
            option = Console.ReadLine();

            return option;
        }

        static void SoldVehiclesMenu(int buyVehicleCustomerCount, string[] buyVehicleCustomerName, string[] buyVehicleCustomerPhoneNumber, string[] buyVehicleName, string[] buyVehicleMake, string[] buyVehiclePrice, string[] buyVehiclePayment)
        {
            if (buyVehicleCustomerCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t No Vehicle has been purchased till now...");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t\t Vehicles Purchased: {buyVehicleCustomerCount}\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"SrNo.",-10} {"Name",-20} {"Phone Number",-20} {"Vehicle Make",-20} {"Vehicle Name",-20} {"Vehicle Price",-20} {"Payment Method",-20}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 0; x < buyVehicleCustomerCount; x++)
            {
                Console.WriteLine($" {x + 1,-10} {buyVehicleCustomerName[x],-20} {buyVehicleCustomerPhoneNumber[x],-20} {buyVehicleMake[x],-20} {buyVehicleName[x],-20} {buyVehiclePrice[x],-20} {buyVehiclePayment[x],-20}\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n");
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();
        }

        static void SoldProductsMenu(int buyProductCustomerCount, string[] buyProductCustomerName, string[] buyProductCustomerPhoneNumber, string[] buyProductName, string[] buyProductPrice, string[] buyProductPayment)
        {
            if (buyProductCustomerCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t No Product has been purchased till now...");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t\t Products Purchased: {buyProductCustomerCount}\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"SrNo.",-10} {"Name",-20} {"Phone Number",-20} {"Product Name",-20} {"Product Price",-20} {"Payment Method",-20}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 0; x < buyProductCustomerCount; x++)
            {
                Console.WriteLine($" {x + 1,-10} {buyProductCustomerName[x],-20} {buyProductCustomerPhoneNumber[x],-20} {buyProductName[x],-20} {buyProductPrice[x],-20} {buyProductPayment[x],-20}\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n");
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();
        }

        static void ViewEmployeesMenu(int employeeCount, string[] employeeName, string[] employeeUsername, string[] employeePhoneNumber, string[] employeeCNIC, string[] employeeSalary)
        {
            if (employeeCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Employees Added Yet.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($" {"SrNo.",-15} {"Name",-30} {"Username",-30} {"Mobile Number",-30} {"CNIC",-30} {"Salary",-30}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < employeeCount; x++)
                {
                    Console.WriteLine($" {x + 1,-15} {employeeName[x],-30} {employeeUsername[x],-30} {employeePhoneNumber[x],-30} {employeeCNIC[x],-30} {employeeSalary[x],-30}\n");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }


        static string ManageEmployeeMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Add an Employee\n");
            Console.WriteLine("\t\t\t 2) Update Employee Details\n");
            Console.WriteLine("\t\t\t 3) Remove an Employee\n");
            Console.WriteLine("\t\t\t 4) Update Employee Salary\n");
            Console.WriteLine("\t\t\t 5) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-5): ");
            option = Console.ReadLine();

            return option;
        }

        static bool AddEmployeeMenu(ref int employeeCount, string[] employeeUsername, string[] employeePassword, string[] employeeName, string[] employeePhoneNumber, string[] employeeCNIC, string[] employeeSalary)
        {
            bool eligible;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter the Details of the Employee...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter Employee Full Name: ");
            employeeName[employeeCount] = NameValidation(15, 3);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Employee User Name: ");
            employeeUsername[employeeCount] = UsernameValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Employee Password: ");
            employeePassword[employeeCount] = PasswordValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Employee Mobile Number (11 digits): ");
            employeePhoneNumber[employeeCount] = NumberValidation(11, 11);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Employee CNIC: ");
            employeeCNIC[employeeCount] = NumberValidation(13, 13);
            Console.WriteLine();
            Console.Write("\t\t\t Enter Employee Salary: ");
            employeeSalary[employeeCount] = NumberValidation(7, 4);

            eligible = CheckAccountEligibility(employeeUsername, employeeCount);
            employeeCount++;
            return eligible;
        }

        static string UpdateEmployeeDetailsMenu(int employeeCount, string[] employeeUsername, string[] employeePassword, string[] employeeName, string[] employeePhoneNumber, string[] employeeCNIC)
        {
            int index = -1;
            bool check = false;
            string name;

            if (employeeCount == 0)
            {
                return "No Employee to Update...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter Username of the Employee you want to Update: ");
            name = Console.ReadLine();

            for (int x = 0; x < employeeCount; x++)
            {
                if (name == employeeUsername[x])
                {
                    index = x;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return "No Employee exists with this Username or Password...";
            }

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of the Employee before Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"Name",-30} {"Username",-30} {"Password",-30} {"Mobile Number",-30} {"CNIC",-30}\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {employeeName[index],-30} {employeeUsername[index],-30} {employeePassword[index],-30} {employeePhoneNumber[index],-30} {employeeCNIC[index],-30}\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Enter new Details...\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter new Full Name: ");
            employeeName[index] = NameValidation(15, 3);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new User Name: ");
            employeeUsername[index] = UsernameValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new Password: ");
            employeePassword[index] = PasswordValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new Mobile Number: ");
            employeePhoneNumber[index] = NumberValidation(11, 11);
            Console.WriteLine();
            Console.Write("\t\t\t Enter new CNIC: ");
            employeeCNIC[index] = NumberValidation(13, 13);

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Details of the Employee after Update: \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" {"Name",-30} {"Username",-30} {"Password",-30} {"Mobile Number",-30} {"CNIC",-30}\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {employeeName[index],-30} {employeeUsername[index],-30} {employeePassword[index],-30} {employeePhoneNumber[index],-30} {employeeCNIC[index],-30}\n");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();

            return "Employee updated Successfully...";
        }

        static string RemoveEmployeeMenu(ref int employeeCount, string[] employeeUsername, string[] employeePassword, string[] employeeName, string[] employeePhoneNumber, string[] employeeCNIC, string[] employeeSalary)
        {
            int index = -1;
            string name;

            if (employeeCount == 0)
            {
                return "No Employee to Remove...";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter Username of the Employee you want to Remove: ");
            name = Console.ReadLine();

            for (int x = 0; x < employeeCount; x++)
            {
                if (name == employeeUsername[x])
                {
                    index = x;
                    break;
                }
            }

            if (index == -1)
            {
                return "No Employee exists with this Username or Password...";
            }

            for (int y = index; y < employeeCount - 1; y++)
            {
                employeeUsername[y] = employeeUsername[y + 1];
                employeePassword[y] = employeePassword[y + 1];
                employeeName[y] = employeeName[y + 1];
                employeePhoneNumber[y] = employeePhoneNumber[y + 1];
                employeeCNIC[y] = employeeCNIC[y + 1];
                employeeSalary[y] = employeeSalary[y + 1];
            }

            employeeCount--;

            return "Employee removed Successfully...";
        }


        //string UpdateEmployeeSalaryMenu(int employeeCount, string employeeUsername[], string employeePassword[], string employeeName[], string employeeSalary[])
        //{
        //    int index;
        //    bool check = false;
        //    string name;

        //    if (employeeCount == 0)
        //    {
        //        return "No Employee to Update...";
        //    }

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("\t\t\t Enter Username of the Employee you want to Update: ";
        //    getline(cin, name);

        //    for (int x = 0; x < employeeCount; x++)
        //    {
        //        if (name == employeeUsername[x])
        //        {
        //            index = x;
        //            check = true;
        //        }
        //    }

        //    if (check == false)
        //    {
        //        return "No Employee exists with this Username or Password...";
        //    }

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("\t Salary of the Employee before Update: \n");
        //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //    Console.WriteLine("  " << setw(30) << left << "Name" << setw(30) << left << "Username" << setw(30) << left << "Salary\n");

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("  " << setw(30) << left << employeeName[index] << setw(30) << left << employeeUsername[index] << setw(30) << left << employeeSalary[index] << endl << endl;

        //    Console.WriteLine("\t\t\t Enter new Salary: ";
        //    employeeSalary[index] = numberValidation(7, 4);

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("\t Salary of the Employee after Update: \n");
        //    Console.WriteLine("  " << setw(30) << left << "Name" << setw(30) << left << "Username" << setw(30) << left << "Salary\n");

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("  " << setw(30) << left << employeeName[index] << setw(30) << left << employeeUsername[index] << setw(30) << left << employeeSalary[index] << endl << endl;

        //    Console.WriteLine("\n");
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.WriteLine("\t\t Press any key to Continue...";
        //    Console.ReadKey();

        //    return "Employee updated Successfully...";
        //}

        static void ServiceDetailsMenu(int customer4ServiceCount, string[] customer4ServiceName, string[] customer4ServiceUsername, string[] serviceVehicleMake, string[] serviceVehicleName)
        {
            if (customer4ServiceCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t No Registrations Yet...\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t Details of the Customer Registered for Vehicle Service: \n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($" {"SrNo.",-15} {"Customer Name",-30} {"Customer Username",-30} {"Vehicle Make",-30} {"Vehicle Name",-30}\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < customer4ServiceCount; x++)
                {
                    Console.WriteLine($" {x + 1,-15} {customer4ServiceName[x],-30} {customer4ServiceUsername[x],-30} {serviceVehicleMake[x],-30} {serviceVehicleName[x],-30}");
                }
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static void TestDriveDetailsMenu(int customer4DriveCount, string[] customer4DriveName, string[] customer4DriveUsername, string[] customer4DriveVehicle)
        {
            if (customer4DriveCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t No Registrations Yet...\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("\t Details of the Customer Registered for Testing Drive: \n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($" {"SrNo.",-15} {"Customer Name",-30} {"Customer Username",-30} {"Vehicle Chosen",-40}\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < customer4DriveCount; x++)
                {
                    Console.WriteLine($" {x + 1,-15} {customer4DriveName[x],-30} {customer4DriveUsername[x],-30} {customer4DriveVehicle[x],-40}");
                }
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string CommunicateEmployeesMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Announce Important Message\n");
            Console.WriteLine("\t\t\t 2) Message received by Employees\n");
            Console.WriteLine("\t\t\t 3) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-3): ");
            option = Console.ReadLine();

            return option;
        }

        static string ManagerAnnouncements(string[] managerNotices, ref int managerNoticesCount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Announce Important Message to Employees: \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Your Announcement: ");
            managerNotices[managerNoticesCount] = Console.ReadLine();
            managerNoticesCount++;

            return "Your Message has been Delivered Successfully...";
        }

        static void ReceiveEmployeeMessagesMenu(string[] employeeName2, string[] employeeUsername2, string[] employeeMessages, int employeeMessagesCount)
        {
            if (employeeMessagesCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No messages received by any Employee yet.");
            }
            else if (employeeMessagesCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("  " + $"{"SrNo.",-7}{"Name",-10}{"UserName",-15}{"Message",-10}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < employeeMessagesCount; x++)
                {
                    Console.WriteLine($"  {x + 1,-7}{employeeName2[x],-10}{employeeUsername2[x],-15}{employeeMessages[x],-10}");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string EmployeeMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Important Announcements\n");
            Console.WriteLine("\t\t\t 2) Contact to Manager\n");
            Console.WriteLine("\t\t\t 3) View Vehicle Details\n");
            Console.WriteLine("\t\t\t 4) View Accociated Products Details\n");
            Console.WriteLine("\t\t\t 5) Sold Vehicles and Products\n");
            Console.WriteLine("\t\t\t 6) Scheduled Registrations for Service\n");
            Console.WriteLine("\t\t\t 7) Scheduled Registrations for Test Drives\n");
            Console.WriteLine("\t\t\t 8) Account Settings\n");
            Console.WriteLine("\t\t\t 9) Sign out\n");
            Console.WriteLine("\t\t\t10) Exit Application\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-10): ");
            option = Console.ReadLine();

            return option;
        }

        static void ShowManagerAnnouncements(string[] managerNotices, int managerNoticesCount)
        {
            if (managerNoticesCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Announcements by Manager yet.");
            }
            else if (managerNoticesCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t Important Announcements by Manager are: \n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < managerNoticesCount; x++)
                {
                    Console.WriteLine($"  {x + 1,-15}{managerNotices[x]}");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string ContactManagerMenu(int employeeCount, string[] employeeName, string[] employeeUsername, string temporaryUsername, string[] employeeName2, string[] employeeUsername2, string[] employeeMessages, ref int employeeMessagesCount)
        {
            int index = 0;
            for (int x = 0; x < employeeCount; x++)
            {
                if (temporaryUsername == employeeUsername[x])
                {
                    index = x;
                }
            }

            employeeName2[employeeMessagesCount] = employeeName[index];
            employeeUsername2[employeeMessagesCount] = employeeUsername[index];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Deliver your message to Manager... \n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write("\t\t\tEnter your Message: ");
            employeeMessages[employeeMessagesCount] = Console.ReadLine();

            employeeMessagesCount++;
            return "Your message has been delivered to the Manager Successfully...";
        }

        static string AccountSettingMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to change.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Name\n");
            Console.WriteLine("\t\t\t 2) Username\n");
            Console.WriteLine("\t\t\t 3) Password\n");
            Console.WriteLine("\t\t\t 4) Mobile Number\n");
            Console.WriteLine("\t\t\t 5) CNIC\n");
            Console.WriteLine("\t\t\t 6) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-6): ");
            option = Console.ReadLine();

            return option;
        }

        static string ChangeProfile(int count, string[] username, string temporaryUsername, string[] data, string message)
        {
            int index = 0;
            for (int x = 0; x < count; x++)
            {
                if (temporaryUsername == username[x])
                {
                    index = x;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"\t\t Your old {message}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(data[index] + "\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t\t  Enter Your new {message}: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t ************************************************************************\n\t\t  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            data[index] = UsernameValidation(10, 3);
            Console.WriteLine("\n\t\t ************************************************************************\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"\t\t Your New {message}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(data[index] + "\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();

            return $"Your {message} updated Successfully...";
        }

        static string ChangeUsername(int count, string[] username, string temporaryUsername, string message)
        {
            int index = 0;
            string temp;
            bool check = true;
            for (int x = 0; x < count; x++)
            {
                if (temporaryUsername == username[x])
                {
                    index = x;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"\t\t Your old {message}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(username[index] + "\n\n");
            username[index] = "-";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t\t  Enter Your new {message}: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t ************************************************************************\n\t\t  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            temp = UsernameValidation(10, 4);
            Console.WriteLine("\n\t\t ************************************************************************\n");

            for (int x = 0; x < count; x++)
            {
                if (temp == username[x])
                {
                    check = false;
                }
            }

            if (!check)
            {
                username[index] = temporaryUsername;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Username already exists!!\n");

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t Press any key to Continue...");
                Console.ReadKey();
                return "Please try again!!";
            }

            username[index] = temp;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"\t\t Your New {message}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(username[index] + "\n\n");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to Continue...");
            Console.ReadKey();

            return $"Your {message} updated Successfully...";
        }

        static string CustomerMenu()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to do.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) View Vehicles\n");
            Console.WriteLine("\t\t\t 2) Buy Vehicle\n");
            Console.WriteLine("\t\t\t 3) Veiw Accessories and Products\n");
            Console.WriteLine("\t\t\t 4) Buy Associated Products\n");
            Console.WriteLine("\t\t\t 5) Register your Car for Service\n");
            Console.WriteLine("\t\t\t 6) Register for Test Drive\n");
            Console.WriteLine("\t\t\t 7) Add comments or Suggestions\n");
            Console.WriteLine("\t\t\t 8) Account Settings\n");
            Console.WriteLine("\t\t\t 9) Sign out\n");
            Console.WriteLine("\t\t\t10) Exit Application\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-10): ");
            option = Console.ReadLine();

            return option;
        }

        static void CustomerViewVehiclesMenu(int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehiclePrice)
        {
            if (vehicleCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Vehicles Available...\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($" {"SrNo.",-15}{"Make",-35}{"Name",-35}{"Price",-35}\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < vehicleCount; x++)
                {
                    Console.WriteLine($" {x + 1,-15}{vehicleMake[x],-35}{vehicleName[x],-35}{vehiclePrice[x],-35}\n\n");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string BuyProductMenu(string message)
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Follow Step by Step Procedure to Buy Your Desired {message}... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t\t\t 1) Choose { message }\n");
            Console.WriteLine("\t\t\t 2) Choose Payment Method\n");
            Console.WriteLine("\t\t\t 3) Print Bill\n");
            Console.WriteLine("\t\t\t 4) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-4): ");
            option = Console.ReadLine();

            return option;
        }

        static string ChooseVehicleMenu(int customerCount, string[] customerUsername, string temporaryUsername, string[] customerName, string[] customerPhoneNumber, int vehicleCount, string[] vehicleMake, string[] vehicleName, string[] vehiclePrice, int buyVehicleCustomerCount, string[] buyVehicleCustomerName, string[] buyVehicleCustomerPhoneNumber, string[] buyVehicleName, string[] buyVehicleMake, string[] buyVehiclePrice)
        {
            int index1 = -1, index2 = -1;
            bool checkVehicle = false;
            bool checkCustomer = false;
            char ch;
            string name;

            if (vehicleCount == 0)
            {
                return "No vehicle to buy...";
            }

            for (int i = 0; i < vehicleCount; i++)
            {
                if (buyVehicleName[buyVehicleCustomerCount] == vehicleName[i])
                {
                    index2 = i;
                    checkCustomer = true;
                }
            }

            if (checkCustomer)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t You have already selected this Vehicle: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"Make",-30}{"Name",-30}{"Price",-30}\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {vehicleMake[index2],-30}{vehicleName[index2],-30}{vehiclePrice[index2],-30}\n\n\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you are satisfied with this Vehicle, press ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Backspace");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" to return,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you want to change the Vehicle, press ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter or Space");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" to change: ");

                while ((ch = Console.ReadKey(true).KeyChar) != '\b')
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        Console.WriteLine();
                        goto loop;
                    }
                    else
                    {
                        return "Choose the Payment Method Now...";
                    }
                }
            }

            loop:
            for (int x = 0; x < customerCount; x++)
            {
                if (temporaryUsername == customerUsername[x])
                {
                    index1 = x;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Enter the Name of the Vehicle you want to Buy: ");
            name = Console.ReadLine();

            for (int x = 0; x < vehicleCount; x++)
            {
                if (name == vehicleName[x])
                {
                    index2 = x;
                    checkVehicle = true;
                }
            }

            if (!checkVehicle)
            {
                return "No vehicle exists with this Name...";
            }
            else if (checkVehicle)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t The Vehicle available with this Name is: \n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"Make",-30}{"Name",-30}{"Price",-30}\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {vehicleMake[index2],-30}{vehicleName[index2],-30}{vehiclePrice[index2],-30}\n\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you want to buy above Vehicle, press ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter or Space");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" to proceed,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t Press ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Backspace key");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" to go back: ");

                while ((ch = Console.ReadKey(true).KeyChar) != '\b')
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        buyVehicleCustomerName[buyVehicleCustomerCount] = customerName[index1];
                        buyVehicleCustomerPhoneNumber[buyVehicleCustomerCount] = customerPhoneNumber[index1];
                        buyVehicleMake[buyVehicleCustomerCount] = vehicleMake[index2];
                        buyVehicleName[buyVehicleCustomerCount] = vehicleName[index2];
                        buyVehiclePrice[buyVehicleCustomerCount] = vehiclePrice[index2];
                        Console.WriteLine();
                        return "Vehicle selected successfully. Please select the payment method now!!";
                    }
                }
            }
            return "";
        }

        static string PaymentMethodMenu1()
        {
            string option = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Select Payment method... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Immediate Cash Payment\n");
            Console.WriteLine("\t\t\t 2) Payment by Credit Card\n");
            Console.WriteLine("\t\t\t 3) Transfer Amount by Bank\n");
            Console.WriteLine("\t\t\t 4) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-4): ");
            option = Console.ReadLine();

            return option;
        }

        static string PaymentMethodMenu2(int count, string[] productName, int buyCustomerCount, string[] buyProductName, string[] buyProductPayment, string message1, string message2)
        {
            bool checkCustomer = false;

            for (int i = 0; i < count; i++)
            {
                if (buyProductName[buyCustomerCount] == productName[i])
                {
                    checkCustomer = true;
                }
            }

            if (checkCustomer)
            {
                buyProductPayment[buyCustomerCount] = message1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t Payment Method has been set to {message1} Successfully!\n");

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t Press any key to Continue...");
                Console.ReadKey();
                return "Submit the Bill to Proceed!";
            }
            else
            {
                return $"Please Choose the {message2} First...";
            }
        }

        static string VehicleBillMenu(int vehicleCount, string[] vehicleName, string[] vehicleStock, ref int buyVehicleCustomerCount, string[] buyVehicleCustomerName, string[] buyVehicleCustomerPhoneNumber, string[] buyVehicleName, string[] buyVehicleMake, string[] buyVehiclePrice, string[] buyVehiclePayment)
        {
            int index = -1, temp;
            bool checkCustomer = false;
            bool checkPayment = false;
            char wall = (char)219, ch;
            int i = 33, j = 18;

            for (int x = 0; x < vehicleCount; x++)
            {
                if (buyVehicleName[buyVehicleCustomerCount] == vehicleName[x])
                {
                    index = x;
                    checkCustomer = true;
                }
            }

            if (buyVehiclePayment[buyVehicleCustomerCount] == "Immediate Cash Payment" || buyVehiclePayment[buyVehicleCustomerCount] == "Payment by Credit Card" || buyVehiclePayment[buyVehicleCustomerCount] == "Payment By Bank")
            {
                checkPayment = true;
            }

            if (!checkCustomer)
            {
                return "Please Choose the Vehicle First...";
            }

            if (!checkPayment)
            {
                return "Please Choose the Payment Method First...";
            }

            string[] bill = new string[] 
            {
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
                "ww                                M A J E S T I C     M O T O R S                                ww",
                "ww                                         G A L L E R Y                                         ww",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww NAME :                                                                                        ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww MOBILE NUMBER :                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww VEHICLE MAKE  :                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww VEHICLE NAME :                                                                                ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww PAYMENT METHOD :                                                                              ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                             RUPEES :                          ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww"
            };

            if (checkCustomer && checkPayment)
            {
                for (int x = 0; x < 26; x++)
                {
                    Console.SetCursorPosition(i, j);
                    for (int y = 0; y < 100; y++)
                    {
                        if (bill[x][y] == 'w')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(wall);
                        }
                        else if (bill[x][y] == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(bill[x][y]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(bill[x][y]);
                        }
                    }
                    Console.WriteLine();
                    j++;
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(44, 24);
                Console.Write(buyVehicleCustomerName[buyVehicleCustomerCount]);
                Console.SetCursorPosition(53, 26);
                Console.Write(buyVehicleCustomerPhoneNumber[buyVehicleCustomerCount]);
                Console.SetCursorPosition(53, 31);
                Console.Write(buyVehicleName[buyVehicleCustomerCount]);
                Console.SetCursorPosition(52, 33);
                Console.Write(buyVehicleMake[buyVehicleCustomerCount]);
                Console.SetCursorPosition(54, 35);
                Console.Write(buyVehiclePayment[buyVehicleCustomerCount]);
                Console.SetCursorPosition(106, 40);
                Console.Write(buyVehiclePrice[buyVehicleCustomerCount]);

                Console.WriteLine("\n\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t If you want to buy above Vehicle Press ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter or Space to Proceed,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t Press ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Backspace key to Go Back: ");

                while ((ch = Console.ReadKey().KeyChar) != '\b')
                {
                    if (char.IsWhiteSpace(ch))
                    {
                        buyVehicleCustomerCount++;
                        temp = int.Parse(vehicleStock[index]);
                        temp--;
                        vehicleStock[index] = temp.ToString();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t Vehicle has been purchased. Please pay the price according to your payment" +
                                          "\n\t\t method and get your Vehicle from the Showroom...\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\t Press any key to Continue...");
                        Console.ReadKey();
                        return "Thanks for Purchasing!! Get your Vehicle and Enjoy";
                    }
                }
            }

            return "";
        }

        static void CustomerViewProductsMenu(int productCount, string[] productName, string[] productPrice)
        {
            if (productCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("\t\t No Vehicles Available...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"SrNo.",-6} {"Name",-30} {"Price",-30}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int x = 0; x < productCount; x++)
                {
                    Console.WriteLine($"  {x + 1,-6} {productName[x],-30} {productPrice[x],-30}\n");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string ChooseProductMenu(int customerCount, string[] customerUsername, string temporaryUsername, string[] customerName, string[] customerPhoneNumber, int productCount, string[] productName, string[] productPrice, int buyProductCustomerCount, string[] buyProductCustomerName, string[] buyProductCustomerPhoneNumber, string[] buyProductName, string[] buyProductPrice)
        {
            int index1 = -1, index2 = -1;
            bool checkProduct = false;
            bool checkCustomer = false;
            char ch;
            string name;

            if (productCount == 0)
            {
                return "No Product to buy...";
            }

            for (int i = 0; i < productCount; i++)
            {
                if (buyProductName[buyProductCustomerCount] == productName[i])
                {
                    index2 = i;
                    checkCustomer = true;
                }
            }

            if (checkCustomer)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t You have already Selected this Product: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"Name",-40} {"Price",-40}\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {productName[index2],-40} {productPrice[index2],-40}\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you are satisfied with this Product Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Backspace to Return,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you want to change the Product Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter or Space to Change: ");

                while ((ch = Console.ReadKey(true).KeyChar) != '\b' && !char.IsWhiteSpace(ch))
                {
                    if (ch == '\b')
                    {
                        Console.WriteLine();
                        return "Choose the Payment Method Now...";
                    }
                    else if (char.IsWhiteSpace(ch))
                    {
                        Console.WriteLine("\n");
                        goto loop;
                    }
                }
            }

        loop:
            for (int x = 0; x < customerCount; x++)
            {
                if (temporaryUsername == customerUsername[x])
                {
                    index1 = x;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Enter the Name of the Product you want to Buy: ");
            name = Console.ReadLine();

            for (int x = 0; x < productCount; x++)
            {
                if (name == productName[x])
                {
                    index2 = x;
                    checkProduct = true;
                }
            }

            if (!checkProduct)
            {
                return "No Product exists with this Name...";
            }
            else if (checkProduct)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t The Product available with this Name is: \n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"  {"Name",-40} {"Price",-40}\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {productName[index2],-40} {productPrice[index2],-40}\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you want to buy above Product Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter or Space to Proceed,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Backspace key to Go Back: ");

                while ((ch = Console.ReadKey(true).KeyChar) != '\b' && !char.IsWhiteSpace(ch))
                {
                    if (ch == '\b')
                    {
                        break;
                    }
                    else if (char.IsWhiteSpace(ch))
                    {
                        buyProductCustomerName[buyProductCustomerCount] = customerName[index1];
                        buyProductCustomerPhoneNumber[buyProductCustomerCount] = customerPhoneNumber[index1];
                        buyProductName[buyProductCustomerCount] = productName[index2];
                        buyProductPrice[buyProductCustomerCount] = productPrice[index2];
                        Console.WriteLine();
                        return "Product Selected Successfully. Please Select the payment method now!!";
                    }
                }
            }

            return "";
        }


        static string ProductBillMenu(int productCount, string[] productName, string[] productStock, ref int buyProductCustomerCount, string[] buyProductCustomerName, string[] buyProductCustomerPhoneNumber, string[] buyProductName, string[] buyProductPrice, string[] buyProductPayment)
        {
            int index = -1, temp;
            bool checkCustomer = false;
            bool checkPayment = false;
            char wall = '█', ch;
            int i = 33, j = 18;

            for (int x = 0; x < productCount; x++)
            {
                if (buyProductName[buyProductCustomerCount] == productName[x])
                {
                    index = x;
                    checkCustomer = true;
                }
            }

            if (buyProductPayment[buyProductCustomerCount] == "Immediate Cash Payment" || buyProductPayment[buyProductCustomerCount] == "Payment by Credit Card" || buyProductPayment[buyProductCustomerCount] == "Payment By Bank")
            {
                checkPayment = true;
            }

            if (!checkCustomer)
            {
                return "Please Choose the Product First...";
            }

            if (!checkPayment)
            {
                return "Please Choose the Payment Method First...";
            }

            string[] bill = new string[]
            {
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
                "ww                                M A J E S T I C     M O T O R S                                ww",
                "ww                                         G A L L E R Y                                         ww",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww NAME :                                                                                        ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww MOBILE NUMBER :                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww PRODUCT NAME :                                                                                ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww PAYMENT METHOD :                                                                              ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "ww                                                                                               ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                             RUPEES :                          ww",
                "ww --------------------------------------------------------------------------------------------- ww",
                "ww                                                                                               ww",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
            };

            if (checkCustomer && checkPayment)
            {
                for (int x = 0; x < 26; x++)
                {
                    Console.SetCursorPosition(i, j);
                    for (int y = 0; y < 100; y++)
                    {
                        if (bill[x][y] == 'w')
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(wall);
                        }
                        else if (bill[x][y] == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(bill[x][y]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(bill[x][y]);
                        }
                    }
                    Console.WriteLine();
                    j++;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(44, 24);
                Console.Write(buyProductCustomerName[buyProductCustomerCount]);
                Console.SetCursorPosition(53, 26);
                Console.Write(buyProductCustomerPhoneNumber[buyProductCustomerCount]);
                Console.SetCursorPosition(53, 31);
                Console.Write(buyProductName[buyProductCustomerCount]);
                Console.SetCursorPosition(54, 33);
                Console.Write(buyProductPayment[buyProductCustomerCount]);
                Console.SetCursorPosition(106, 38);
                Console.Write(buyProductPrice[buyProductCustomerCount]);

                Console.WriteLine("\n\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t If you want to buy above Product Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter or Space to Proceed,");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t Press ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Backspace key to Go Back: ");

                while (true)
                {
                    ch = Console.ReadKey(true).KeyChar;

                    if (ch == '\b')
                    {
                        break;
                    }
                    else if (char.IsWhiteSpace(ch))
                    {
                        buyProductCustomerCount++;
                        temp = int.Parse(productStock[index]);
                        temp--;
                        productStock[index] = temp.ToString();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t Product has been purchased. Please pay the price according to your payment");
                        Console.WriteLine("\t\t method and Get your Product from the Showroom...\n");

                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t Press any key to Continue...");
                        Console.ReadKey();
                        return "Thanks for Purchasing!! Get your Product and Enjoy";
                    }
                }
            }

            return "";
        }

        static string AddCommentsMenu(int customerCount, string[] customerUsername, string[] customerName, string temporaryUsername, ref int customerCommentsCount, string[] commentingCustomerName, string[] commentingCustomerUsername, string[] customerComments)
        {
            int index = 0;
            for (int x = 0; x < customerCount; x++)
            {
                if (temporaryUsername == customerUsername[x])
                {
                    index = x;
                }
            }

            commentingCustomerName[customerCommentsCount] = customerName[index];
            commentingCustomerUsername[customerCommentsCount] = customerUsername[index];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Add Feedbacks or comments... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tEnter: ");
            customerComments[customerCommentsCount] = Console.ReadLine();
            customerCommentsCount++;

            return "Your message has been delivered, Successfully...";
        }

        static void ServiceRegistrationMenu(int customerCount, string[] customerUsername, string[] customerName, string temporaryUsername, ref int customer4ServiceCount, string[] customer4ServiceName, string[] customer4ServiceUsername, string[] serviceVehicleMake, string[] serviceVehicleName)
        {
            int index = 0;
            for (int x = 0; x < customerCount; x++)
            {
                if (temporaryUsername == customerUsername[x])
                {
                    index = x;
                }
            }

            customer4ServiceName[customer4ServiceCount] = customerName[index];
            customer4ServiceUsername[customer4ServiceCount] = customerUsername[index];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Add the following details for Registration... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter your Vehicle Make: ");
            serviceVehicleMake[customer4ServiceCount] = Console.ReadLine();
            Console.Write("\t\t\t Enter your Vehicle Name: ");
            serviceVehicleName[customer4ServiceCount] = Console.ReadLine();
            Console.WriteLine("\n");

            customer4ServiceCount++;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t Registration Completed Successfully!!\n");
            Console.WriteLine("\t Note: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t The timings of Service Centre are from ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("8:00 AM to 4:00 PM.");
            Console.WriteLine(" Please assure your presence");
            Console.WriteLine("\t\t in the service centre between the mentioned time. Also, we provide various service ");
            Console.WriteLine("\t\t packages to our customers. For regular customers, discounts are also available. To ");
            Console.WriteLine("\t\t avail these packages, Contact us in the Service Centre.");
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static void DriveRegistrationMenu(int customerCount, string[] customerUsername, string[] customerName, string temporaryUsername, ref int customer4DriveCount, string[] customer4DriveName, string[] customer4DriveUsername, string[] customer4DriveVehicle, string[] vehicles4Drive)
        {
            int index1 = customerCount, temp;
            string index2;
            for (int x = 0; x < customerCount; x++)
            {
                if (temporaryUsername == customerUsername[x])
                {
                    index1 = x;
                }
            }

            customer4DriveName[customer4DriveCount] = customerName[index1];
            customer4DriveUsername[customer4DriveCount] = customerUsername[index1];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Select Vehicles from the following for Testing the Drive... \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine($"\t{x + 1})   {vehicles4Drive[x]}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\t Enter your Choice: ");
            index2 = Console.ReadLine();

            Console.WriteLine("\n");
            if (index2 == "1" || index2 == "2" || index2 == "3" || index2 == "4" || index2 == "5" || index2 == "6" || index2 == "7")
            {
                temp = int.Parse(index2);
                customer4DriveVehicle[customer4DriveCount] = vehicles4Drive[temp - 1];
                customer4DriveCount++;

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t Registration Completed Successfully!!\n");
                Console.WriteLine("\t Note: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t The timings For testing Drive are from ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("8:00 AM to 4:00 PM.");
                Console.WriteLine(" Please assure your presence");
                Console.WriteLine("\t\t between the mentioned time. Charges for testing the drive, you have to deposit are ");
                Console.WriteLine("\t\t \"Rs 2000\"");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t Invalid input. Please try again!!");
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t Press any key to continue...");
            Console.ReadKey();
        }

        static string CustomerAccountSettingMenu()
        {
            string option;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t Choose you want to change.... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t 1) Name\n");
            Console.WriteLine("\t\t\t 2) Username\n");
            Console.WriteLine("\t\t\t 3) Password\n");
            Console.WriteLine("\t\t\t 4) Mobile Number\n");
            Console.WriteLine("\t\t\t 5) Go Back\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t Enter Your Option (1-5): ");
            option = Console.ReadLine();

            return option;
        }


        static bool CustomerSignupMenu(ref int customerCount, string[] customerUsername, string[] customerPassword, string[] customerName, string[] customerPhoneNumber)
        {
            bool eligible;
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color to yellow
            Console.WriteLine("\t\t Enter your Details...\n\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan
            Console.Write("\t\t\t Enter your Full Name (3-10 characters): ");
            customerName[customerCount] = NameValidation(15, 3);
            Console.WriteLine();
            Console.Write("\t\t\t Enter your User Name (4-10 characters): ");
            customerUsername[customerCount] = UsernameValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter your Password (4-10 characters): ");
            customerPassword[customerCount] = PasswordValidation(10, 4);
            Console.WriteLine();
            Console.Write("\t\t\t Enter your Mobile Number (11 digits): ");
            customerPhoneNumber[customerCount] = NumberValidation(11, 11);
            Console.WriteLine();

            eligible = CheckAccountEligibility(customerUsername, customerCount);
            return eligible;
        }



        static bool CheckUser(string username, string password, string[] usernameArr, string[] passwordArr, int count)
        {
            for (int x = 0; x <= count; x++)
            {
                if (usernameArr[x] == username && passwordArr[x] == password)
                {
                    return true;
                }
            }
            return false;
        }


        static bool CheckAccountEligibility(string[] username, int count)
        {
            for (int x = 0; x < count; x++)
            {
                if (username[x] == username[count])
                {
                    return false;
                }
            }
            return true;
        }


        static bool CheckEligibility(string[] array, string value, int count)
        {
            for (int x = 0; x <= count; x++)
            {
                if (array[x] == value)
                {
                    return false;
                }
            }
            return true;
        }





        static string NumberValidation(int maximum, int minimum)
        {
            string item = "";
            int count = 0;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                char ch = keyInfo.KeyChar;

                if (char.IsDigit(ch) && count < maximum)
                {
                    Console.Write(ch);
                    item += ch;
                    count++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter && count >= minimum)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        Console.Write("\b \b");
                        item = item.Substring(0, item.Length - 1);
                        count--;
                    }
                }
            }

            Console.WriteLine();
            return item;
        }

        static string UsernameValidation(int maximum, int minimum)
        {
            string item = "";
            int count = 0;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                char ch = keyInfo.KeyChar;

                if (char.IsLetterOrDigit(ch) && count <= maximum)
                {
                    Console.Write(ch);
                    item += ch;
                    count++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter && count >= minimum)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        Console.Write("\b \b");
                        item = item.Substring(0, item.Length - 1);
                        count--;
                    }
                }
            }

            Console.WriteLine();
            return item;
        }

        static string PasswordValidation(int maximum, int minimum)
        {
            string item = "";
            int count = 0;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                char ch = keyInfo.KeyChar;

                if (char.IsLetterOrDigit(ch) && count <= maximum)
                {
                    Console.Write("*");
                    item += ch;
                    count++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter && count >= minimum)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        Console.Write("\b \b");
                        item = item.Substring(0, item.Length - 1);
                        count--;
                    }
                }
            }
            Console.WriteLine();
            return item;
        }

        static string NameValidation(int maximum, int minimum)
        {
            string item = "";
            int count = 0;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                char ch = keyInfo.KeyChar;

                if (char.IsLetter(ch) && count <= maximum)
                {
                    Console.Write(ch);
                    item += ch;
                    count++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter && count >= minimum)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        Console.Write("\b \b");
                        item = item.Substring(0, item.Length - 1);
                        count--;
                    }
                }
            }

            Console.WriteLine(); // Move to the next line after input
            return item;
        }

        /*
        void getUsersData(string filename, int &userCount, string name[], string username[], string password[], string phoneNumber[], string CNIC[], string salary[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        name[userCount] = getField(line, 1);
                        username[userCount] = getField(line, 2);
                        password[userCount] = getField(line, 3);
                        phoneNumber[userCount] = getField(line, 4);
                        CNIC[userCount] = getField(line, 5);
                        salary[userCount] = getField(line, 6);
                        userCount++;
                    }
                }
            }
            file.close();
        }


        void getCustomerData(string filename, int &userCount, string name[], string username[], string password[], string phoneNumber[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        name[userCount] = getField(line, 1);
                        username[userCount] = getField(line, 2);
                        password[userCount] = getField(line, 3);
                        phoneNumber[userCount] = getField(line, 4);
                        userCount++;
                    }
                }
            }
            file.close();
        }


        void getVehiclesData(string filename, int &vehicleCount, string make[], string name[], string stock[], string price[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        make[vehicleCount] = getField(line, 1);
                        name[vehicleCount] = getField(line, 2);
                        stock[vehicleCount] = getField(line, 3);
                        price[vehicleCount] = getField(line, 4);
                        vehicleCount++;
                    }
                }
            }
            file.close();
        }


        void getProductsData(string filename, int &productCount, string name[], string stock[], string price[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        name[productCount] = getField(line, 1);
                        stock[productCount] = getField(line, 2);
                        price[productCount] = getField(line, 3);
                        productCount++;
                    }
                }
            }
            file.close();
        }


        void getVehicleServiceData(string filename, int &customer4ServiceCount, string customerName[], string customerUsername[], string vehicleMake[], string vehicleName[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        customerName[customer4ServiceCount] = getField(line, 1);
                        customerUsername[customer4ServiceCount] = getField(line, 2);
                        vehicleMake[customer4ServiceCount] = getField(line, 3);
                        vehicleName[customer4ServiceCount] = getField(line, 4);
                        customer4ServiceCount++;
                    }
                }
            }
            file.close();
        }


        void getTestDerivesData(string filename, int &customer4TestDriveCount, string customerName[], string customerUsername[], string vehicleName[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        customerName[customer4TestDriveCount] = getField(line, 1);
                        customerUsername[customer4TestDriveCount] = getField(line, 2);
                        vehicleName[customer4TestDriveCount] = getField(line, 3);
                        customer4TestDriveCount++;
                    }
                }
            }
            file.close();
        }


        void getCommentsData(string filename, int &customerCommentsCount, string customerName[], string customerUsername[], string comments[])
        {
            fstream file;
            file.open(filename, ios::in);
            string line;

            if (file.is_open())
            {
                while (!(file.eof()))
                {
                    getline(file, line);
                    if (line != "")
                    {
                        customerName[customerCommentsCount] = getField(line, 1);
                        customerUsername[customerCommentsCount] = getField(line, 2);
                        comments[customerCommentsCount] = getField(line, 3);
                        customerCommentsCount++;
                    }
                }
            }
            file.close();
        }


        string getField(string data, int field)
        {
            int commaCount = 1;
            string word;
            for (int x = 0; x < data.length(); x++)
            {
                if (data[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    word = word + data[x];
                }
            }
            return word;
        }


        void StoreUsersData(string filename, int userCount, string name[], string username[], string password[], string phoneNumber[], string CNIC[], string salary[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < userCount; x++)
            {
                file << name[x] << "," << username[x] << "," << password[x] << "," << phoneNumber[x] << "," << CNIC[x] << "," << salary[x] << endl;
            }
            file.close();
        }


        void StoreCustomerData(string filename, int userCount, string name[], string username[], string password[], string phoneNumber[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < userCount; x++)
            {
                file << name[x] << "," << username[x] << "," << password[x] << "," << phoneNumber[x] << endl;
            }
            file.close();
        }


        void StoreVehiclesData(string filename, int vehicleCount, string make[], string name[], string stock[], string price[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < vehicleCount; x++)
            {
                file << make[x] << "," << name[x] << "," << stock[x] << "," << price[x] << endl;
            }
            file.close();
        }


        void StoreProductsData(string filename, int productCount, string name[], string stock[], string price[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < productCount; x++)
            {
                file << name[x] << "," << stock[x] << "," << price[x] << endl;
            }
            file.close();
        }


        void StoreVehicleserviceData(string filename, int customer4ServiceCount, string customerName[], string customerUsername[], string vehicleMake[], string vehicleName[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < customer4ServiceCount; x++)
            {
                file << customerName[x] << "," << customerUsername[x] << "," << vehicleMake[x] << "," << vehicleName[x] << endl;
            }
            file.close();
        }


        void StoreTestDrivesData(string filename, int customer4TestDriveCount, string customerName[], string customerUsername[], string vehicleName[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < customer4TestDriveCount; x++)
            {
                file << customerName[x] << "," << customerUsername[x] << "," << vehicleName[x] << endl;
            }
            file.close();
        }


        void StoreCommentsData(string filename, int customerCommentsCount, string customerName[], string customerUsername[], string comments[])
        {
            fstream file;
            file.open(filename, ios::out);
            for (int x = 0; x < customerCommentsCount; x++)
            {
                file << customerName[x] << "," << customerUsername[x] << "," << comments[x] << endl;
            }
            file.close();
        }
        */


    }
}
