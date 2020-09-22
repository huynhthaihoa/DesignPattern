namespace Strategy
{
    public class FormulaOne : Vehicle
    {
        public FormulaOne()
        {
            setGoAlgorithm(new GoByDrivingAlgorithm());
        }
    }
}
