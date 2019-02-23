using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFarimetica
{

    [ServiceContract]
    public interface IsrvSuma
    {

        [OperationContract]
        clsSuma suma(int numero1, int numero 2);
    }

    [DataContract]
    public class clsSuma
    {
        [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numeroB { get; set; }
        [DataMember]
        public int resultado { get; set; }
    }


    
}
