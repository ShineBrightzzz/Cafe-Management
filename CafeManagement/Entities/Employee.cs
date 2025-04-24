using System;


public class Employee
{
    private string id;
    private string name;
    private string address;
    private string gender;
    private DateTime dateOfBirth;
    private string phoneNumber;

    public Employee(string id, string name, string address, string gender, DateTime dateOfBirth, string phoneNumber)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.gender = gender;
        this.dateOfBirth = dateOfBirth;
        this.phoneNumber = phoneNumber;
    }

    public string getId()
    {
        return employeeId;
    }
    public void setId(string value)
    {
        employeeId = value;
    }

    public string getName()
    {
        return employeeName;
    }
    public void setName(string value)
    {
        employeeName = value;
    }

    public string getAddress()
    {
        return address;
    }
    public void setAddress(string value)
    {
        address = value;
    }

    public DateTime getDateOfBirth()
    {
        return dateOfBirth;
    }
    public void setDateOfBirth(DateTime value)
    {
        dateOfBirth = value;
    }

    public string getPhoneNumber()
    {
        return phoneNumber;
    }
    public void setPhoneNumber(string value)
    {
        phoneNumber = value;
    }
}
