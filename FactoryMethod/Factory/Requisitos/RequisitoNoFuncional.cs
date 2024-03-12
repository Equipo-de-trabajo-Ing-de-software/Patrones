using Factory.Factory;


namespace Factory.Requisitos
{
    public class RequisitoNoFuncional : RequisitoFactory
    {
        public override void TipoRequisito()
        {
            Console.WriteLine("Este es un Requisito no Funcional");
        }
    }
}
