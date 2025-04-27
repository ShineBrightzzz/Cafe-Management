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

    public string getId(){
        return id;
    }
    public void setId(string value){ 
        id = value; 
    }

    public string getName(){
        return name;
    }
    public void setName(string value){
        name = value; 
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
