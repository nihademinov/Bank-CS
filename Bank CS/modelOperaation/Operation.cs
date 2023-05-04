using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelOperaation
{
    internal class Operation
    {
        private Guid _Id;
        private string _OperationName;
        private DateTime _CreateTime;

        public Operation(string operationName)
        {
            _OperationName = operationName;
            _CreateTime = DateTime.Now;
            _Id = Guid.NewGuid();
        }



        public string Property_operationName
        {
            get { return _OperationName; }
            set { _OperationName = value; }
        }

        public DateTime Property_CreatTime
        {
            get { return _CreateTime; }
        }

        public Guid Property_Id
        {
            get { return _Id; }
        }

    }
}
