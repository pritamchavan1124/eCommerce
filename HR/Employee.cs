namespace HR;

public abstract class Employee
{
    //decalre all the getter and setter method by this syntax
    //there is no need to declare seprate data variables bez THIS GETTER SETTER PROPERTY decalre internally.
    public int ID{get;set;}
    public string firstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string contactNumber{get;set;}
    public string Location{get;set;}
    public DateTime BirthDate{get;set;}
    public float DA{get;set;}
    public float HRA{get;set;}
    public float BasicSalary{get;set;}

    public Employee(){
        this.ID=100;
        this.firstName="Pritam";
        this.LastName="chavan";
        this.Email="pritam@gmail.com";
        this.contactNumber="+9568956943";
        this.Location="pune";
        this.BirthDate=new DateTime(1975, 8,18);
        this.DA=1450;
        this.HRA=2547;
        this.BasicSalary=25780;
    }
    public Employee(int ID,string firstName,string LastName,string Email,string contactNumber,string Location,
    DateTime birthdate,float DA,float HRA,float BasicSalary){

        this.ID=ID;
        this.firstName=firstName;
        this.LastName=LastName;
        this.Email=Email;
        this.contactNumber=contactNumber;
        this.Location=Location;
        this.BirthDate=birthdate;
        this.DA=DA;
        this.HRA=HRA;
        this.BasicSalary=BasicSalary;
    }

    public abstract void DoWork();

     public virtual float ComputePay(){ 
    float  pay=(DA * 25) + BasicSalary + HRA;
    return pay;
   }

   public override string ToString()
    {
       String str=string.Format("{0}, {1}, {2}, {3}, {4}, {5}", ID, firstName, LastName, 
       Email, contactNumber); 
    }


}
