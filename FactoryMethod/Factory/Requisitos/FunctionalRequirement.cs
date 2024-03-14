namespace FactoryMethod.Requisitos
{
    public class FunctionalRequirement : IRequirement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } = "Funcional";
        public int Priority { get; set; }

        public void Edit(string title, string description, int priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
        }

        public void Delete()
        {
            Console.WriteLine("Requisito Eliminado");
        }
    }
}
