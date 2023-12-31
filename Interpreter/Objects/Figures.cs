using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Interpreter
{
	public abstract class Figure 
	{
        public Equation Equation { get; }

        public abstract Color FigureColor { get; set; }

        public abstract string? Text { get; set; }
		
	}
}