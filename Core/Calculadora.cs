namespace Calculadora.Core {
    public class Calculadora {
        /// <summary>
        /// Aportar los operandos (op1 y op2), y la operación.
        /// El operador es un char que acepta:
        /// +: Suma
        /// -: Resta
        /// x: Producto,
        /// /: División
        /// </summary>
        /// <param name="op1">El primer operando.</param>
        /// <param name="op2">El segundo operando.</param>
        /// <param name="opr">Un char conteniendo: +, -, x, o /.</param>
        public Calculadora(double op1, double op2, char opr)
        {
            this.Op1 = op1;
            this.Op2 = op2;
            this.Opr = opr;
        }

        public double Opera()
        {
            double toret = 0;

            switch ( this.Opr ) {
                case '+':
                    toret = this.Op1 + this.Op2;
                    break;
                case '-':
                    toret = this.Op1 - this.Op2;
                    break;
                case 'x':
                    toret = this.Op1 * this.Op2;
                    break;
                case '/':
                    toret = this.Op1 / this.Op2;
                    break;
                default:
                    throw new System.ArgumentException( "operador no soportado: " + this.Opr );
            }

            return toret;
        }

        public double Op1 {
            get; set;
        }

        public double Op2 {
            get; set;
        }

        public char Opr {
            get; set;
        }
    }
}
