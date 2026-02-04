namespace FactoryRobotHazardAnalyzer;
class Program
{
    public static void Main()
    {
        RobotHazardAuditor auditorObj=new RobotHazardAuditor();
        try
        {
            System.Console.Write("Enter Arm Precision (0.0 - 1.0): ");
            double armPrecisionPrecision=double.Parse(Console.ReadLine());

            System.Console.Write("Enter Worker Density (1 - 20): ");
            int workerDensity=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter Machinery State (Worn/Faulty/Critical): ");
            string machineryState=Console.ReadLine();

            double riskCalculation=auditorObj.CalculateHazardRisk(armPrecisionPrecision,workerDensity,machineryState);
            System.Console.WriteLine($"\nRobot Hazard Risk Score: {riskCalculation}\n");
            
        }catch(RobotSafetyException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }  

    }
}