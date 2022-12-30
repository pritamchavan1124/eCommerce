namespace HR;


public class SalesManager:SalesEmployee{
    public float bonous{get;set;}

    public SalesManager():base{
        this.bonous=1200;
    }

    public SalesManager(int ID,string firstName,string LastName,string Email,string contactNumber,string Location,
    DateTime birthdate,float DA,float HRA,float BasicSalary, float TargetDone, float incentive, float salesDone,
    float bonous):base(ID,firstName,LastName,Location,BasicSalary,Email,contactNumber,HRA,DA,BirthDate,TargetDone,incentive,salesDone){

        this.bonous=bonous;
    }

      public override float ComputePay()
    {
        return base.ComputePay()+ Bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override string ToString()
    {
        return base.ToString() + " Bonus="+ Bonus;
    }







}
