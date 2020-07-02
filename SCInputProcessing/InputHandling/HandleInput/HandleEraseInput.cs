using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleEraseInput
    {
        public void HandleInput(List<string> inputSequence, List<string> postUnaryOperators, List<string> preUnaryOperators, List<string> constants)
        {
            int sLenght = inputSequence.Count;

            if (sLenght > 1 && inputSequence[sLenght-1] == "" &&
                (postUnaryOperators.Contains(inputSequence[sLenght - 2]) || preUnaryOperators.Contains(inputSequence[sLenght - 2])))
            {
                if (sLenght == 2)
                {
                    inputSequence.RemoveAt(1);
                    inputSequence[0] = "";
                }
                else
                {
                    inputSequence.RemoveAt(sLenght - 1);
                    inputSequence.RemoveAt(sLenght - 2);
                }
            }
            else if (constants.Contains(inputSequence[sLenght - 1]))
            {
                inputSequence[sLenght - 1] = "";
            }
            else if(sLenght > 1 && inputSequence[sLenght-1] == "" && constants.Contains(inputSequence[sLenght - 2]))
            {
                inputSequence.RemoveAt(sLenght - 1);
                inputSequence[sLenght - 2] = "";
            }
            else if (sLenght == 1)
            {
                int iLength = inputSequence[0].Length;
                inputSequence[0] = inputSequence[0].Remove(iLength - 1);
            }
            else if (inputSequence[sLenght - 1] == "")
            {
                int iLength = inputSequence[sLenght - 2].Length;
                inputSequence.RemoveAt(sLenght - 1);
                inputSequence[sLenght - 2] = inputSequence[sLenght - 2].Remove(iLength - 1);
            }
            else if (inputSequence[sLenght - 1] != "")
            {
                int iLength = inputSequence[sLenght - 1].Length;
                inputSequence[sLenght - 1] = inputSequence[sLenght - 1].Remove(iLength - 1);
            }

        }

        public void HandleEraseAllInput(List<string> inputSequance)
        {
            inputSequance.Clear();
            inputSequance.Add("");
        }

        public bool CanHandle(List<string> inputSequence)
        {
            if (inputSequence[0] == "")
                return false;
            return true;
        }
    }
}
