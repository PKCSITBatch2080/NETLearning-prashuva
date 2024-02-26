class Student
{   
    //Default Constructor
    public Student(){

    }

//Parameteized Constructor
    public Student(string n , byte rn){
        name = n;
        RollNumber = rn;
    }
    //Field
    string name;
    byte rollNumber;
    //Properties
    public byte rollNumber{
        get
        {
            return rollNumber;
        }
        set{
            if (value <= 100)
            {
                rollNumber = value;
            }
        }


    }
    string address;

    DateTime dob;



}