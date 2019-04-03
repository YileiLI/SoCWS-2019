using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MathLibrary
{
    [ServiceContract] //c'est un attribut -> IMathsOperations devient un contract de service WCF
    public interface IMathsOperations
    {
        //rendre visible pour le client
        [OperationContract]
        int Add(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);
    }
}
