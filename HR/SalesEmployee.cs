namespace HR;
public class SalesEmployee : Employee
{
    public float TargetDone{get;set;}
    public float incentive{get;set;}
    public float salesDone{get;set;}

    public SalesEmployee():base{
        this.TargetDone=95;
        this.incentive=50;
        this.salesDone=70;
    }

    public SalesEmployee(int ID,string firstName,string LastName,string Email,string contactNumber,string Location,
    DateTime birthdate,float DA,float HRA,float BasicSalary, float TargetDone, float incentive, float salesDone) : base(ID,firstName,LastName,Location,BasicSalary,Email,contactNumber,HRA,DA,BirthDate)){
        this.TargetDone=TargetDone;
        this.incentive=incentive;
        this.salesDone=salesDone;
    }

    public override float ComputePay(){
        float  pay=(DA * 25) + BasicSalary + HRA + incentive;
    return pay;
    }

    public string ToString(){
       // String str1=String.Format("{0},{1},{2}",TargetDone,incentive,salesDone);
        return base.ToString()  + "Incentive =" +incentive + ", Tartget="+ TargetDone +"Sales="+salesDone;
    }

    public float DoWork(){
        if(salesDone>=TargetDone){
            this.incentive=6000;
        }
        else{
            this.incentive=0;
        }
    }



}