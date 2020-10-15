namespace Calculadora {
    using WForms = System.Windows.Forms;
    
    
    internal class Program {
        public static void Main(string[] args)
        {
            WForms.Application.Run( new MainWindowCtrl().View );
        }
    }
}
