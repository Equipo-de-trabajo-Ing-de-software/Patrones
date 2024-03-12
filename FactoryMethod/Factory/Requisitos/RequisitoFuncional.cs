using Factory.Factory;


namespace Factory.Requisitos
{
    public class RequisitoFuncional : RequisitoFactory
    {
        public override void TipoRequisito()
        {
            Console.WriteLine("Este es un Requisito Funcional");
        }
    }
}
