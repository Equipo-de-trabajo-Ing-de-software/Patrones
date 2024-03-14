namespace FactoryMethod.Fabrica
{
    public abstract class RequirementHandler
    {
        public abstract IRequirement CreateRequirement();

        public void ManagementRequirement()
        {
            IRequirement requirement = CreateRequirement();

            requirement.Delete();
        }
    }
}
