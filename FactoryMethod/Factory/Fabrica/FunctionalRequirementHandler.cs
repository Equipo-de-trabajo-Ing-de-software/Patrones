using FactoryMethod.Requisitos;



namespace FactoryMethod.Fabrica
{
    public class FunctionalRequirementHandler : RequirementHandler
    {

        public override IRequirement CreateRequirement()
        {
            return new FunctionalRequirement();
        }
    }
}
