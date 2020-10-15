namespace Calculadora {
    using WForms = System.Windows.Forms;
    
    
    public class MainWindowCtrl {
        public MainWindowCtrl()
        {
            this.View = new MainWindowView();

            this.View.BtOpera.Click += (sender,  args) => this.OnBtOperaClick();
            this.View.CbOperacion.SelectedIndexChanged += (sender,  args) => this.OnBtOperaClick();
            this.View.EdOp1.TextChanged += (sender,  args) => this.OnBtOperaClick();
            this.View.EdOp2.TextChanged += (sender, args) => this.OnBtOperaClick();
        }

        void OnBtOperaClick()
        {
            double op1;
            double op2;
            string strOp1 = this.View.EdOp1.Text;
            string strOp2 = this.View.EdOp2.Text;
            
            if ( !double.TryParse( strOp1, out op1 ) ) {
                WForms.MessageBox.Show( "Error convirtiendo op1: " + strOp1 );
            }
            
            if ( !double.TryParse( strOp2, out op2 ) ) {
                WForms.MessageBox.Show( "Error convirtiendo op2: " + strOp2 );
            }
            
            var calc = new Core.Calculadora( op1, op2, this.View.CbOperacion.Text[ 0 ] );

            try {
                this.View.EdRes.Text = calc.Opera().ToString();
            }
            catch (System.Exception exc) {
                WForms.MessageBox.Show( exc.Message );
            }
        }
        
        public MainWindowView View {
            get;
        }
    }
}
