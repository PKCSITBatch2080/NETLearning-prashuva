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

    public Student(string n , byte rn, DateTime date){
        name = n;
        RollNumber = rn;
        dob= date
    }
    //Field
    public string name;
    byte rollNumber;
    //Properties
    public byte RollNumber{
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
    //Auto implemented properties
    public string Address{get; set;}

    public DateTime dob;

    public virtual void DisplayInfo(){
        Console.WriteLine($"Student Name:{name}");
        Console.WriteLine($"Student Rollnumber:{rollNumber}");
        Console.WriteLine($"Student Address:{Address}");
    }



}