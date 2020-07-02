using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class EvaluateConstants
    {
        public void Evaluate(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;

            for(int i = 0; i < sLenght; i++)
            {
                switch (inputSequence[i])
                {
                    case "e":
                        inputSequence[i] = Convert.ToString(Math.E);
                        break;
                    case "pi":
                        inputSequence[i] = Convert.ToString(Math.PI);
                        break;
                }
            }
        }
    }
}
