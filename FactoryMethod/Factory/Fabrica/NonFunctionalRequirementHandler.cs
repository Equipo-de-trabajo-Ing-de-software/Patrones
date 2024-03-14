using FactoryMethod.Requisitos;


namespace FactoryMethod.Fabrica
{
    public class NonFunctionalRequirementHandler : RequirementHandler
    {

        public override IRequirement CreateRequirement()
        {
            return new NonFunctionalRequirement();
        }
    }
}