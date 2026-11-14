using DataJuggler.Excelerate.Office.SS.Formula.Eval;
using DataJuggler.Excelerate.Office.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataJuggler.Excelerate.Office.SS.Formula.Atp
{
    public class IfNa : FreeRefFunction
    {
        public static FreeRefFunction instance = new IfNa();

        private IfNa()
        {
            // Enforce singleton
        }

        public ValueEval Evaluate(ValueEval[] args, OperationEvaluationContext ec)
        {
            if (args.Length != 2)
            {
                return ErrorEval.VALUE_INVALID;
            }

            try
            {
                return OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex);
            }
            catch (EvaluationException e)
            {
                ValueEval error = e.GetErrorEval();
                if (error != ErrorEval.NA)
                {
                    return error;
                }
            }
            try
            {
                return OperandResolver.GetSingleValue(args[1], ec.RowIndex, ec.ColumnIndex);
            }
            catch (EvaluationException e)
            {
                return e.GetErrorEval();
            }
        }
    }
}
