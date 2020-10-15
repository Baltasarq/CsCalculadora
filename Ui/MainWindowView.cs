namespace Calculadora {
    using Draw = System.Drawing;
    using WForms = System.Windows.Forms;


    public class MainWindowView : WForms.Form {
        public MainWindowView()
        {
            this.Build();
        }

        void Build()
        {
            var pnlMain = new WForms.TableLayoutPanel {
                Dock = WForms.DockStyle.Fill
            };
            
            pnlMain.Controls.Add( this.BuildOp1() );
            pnlMain.Controls.Add( this.BuildOp2() );
            pnlMain.Controls.Add( this.BuildOperacion() );
            pnlMain.Controls.Add( this.BuildBtOpera() );
            pnlMain.Controls.Add( this.BuildRes() );
            
            this.Controls.Add( pnlMain );
            this.Text = "Calculadora";
            this.MinimumSize = new Draw.Size( 300, 350 );
        }

        WForms.Panel BuildOp1()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            toret.Controls.Add( new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Op1"
            } );

            this.EdOp1 = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add( this.EdOp1 );

            return toret;
        }
        
        WForms.Panel BuildOp2()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            toret.Controls.Add( new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Op2"
            } );

            this.EdOp2 = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add( this.EdOp2 );

            return toret;
        }
        
        WForms.Panel BuildRes()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            toret.Controls.Add( new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Resultado"
            } );

            this.EdRes = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right,
                ReadOnly = true
            };

            toret.Controls.Add( this.EdRes );

            return toret;
        }

        WForms.Button BuildBtOpera()
        {
            this.BtOpera = new WForms.Button {
                Dock = WForms.DockStyle.Top,
                Text = "Opera"
            };

            return this.BtOpera;
        }

        WForms.Panel BuildOperacion()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };

            this.CbOperacion = new WForms.ComboBox {
                Dock = WForms.DockStyle.Fill,
                DropDownStyle = WForms.ComboBoxStyle.DropDownList
            };
            
            this.CbOperacion.Items.AddRange( new [] {
                "+", "-", "x", "/"
            } );
            this.CbOperacion.Text = (string) this.CbOperacion.Items[ 0 ];
            
            toret.Controls.Add( this.CbOperacion );
            toret.MaximumSize = new Draw.Size( int.MaxValue, this.CbOperacion.Height );

            return toret;
        }

        public WForms.TextBox EdOp1 {
            get; private set;
        }
        
        public WForms.TextBox EdOp2 {
            get; private set;
        }
        
        public WForms.TextBox EdRes {
            get; private set;
        }

        public WForms.Button BtOpera {
            get; private set;
        }

        public WForms.ComboBox CbOperacion {
            get; private set;
        }
    }
}
