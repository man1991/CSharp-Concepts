using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class AccessModifier
    {
        //Available only to the container Class 
        private string privateVariable;

        // Available in entire assembly across the classes 
        internal string internalVariable;

        //Available in the container class and the derived class   
        protected string protectedVariable;

        //Available to the container class, entire assembly and to outside    
        public string publicVariable;

        //Available to the derived class and entire assembly as well 
        protected internal string protectedInternalVariable;

        private string PrivateFunction()
        {
            return privateVariable;
        }

        internal string InternalFunction()
        {
            return internalVariable;
        }

        protected string ProtectedFunction()
        {
            return protectedVariable;
        }

        public string PublicFunction()
        {
            return publicVariable;
        }

        protected internal string ProtectedInternalFunction()
        {
            return protectedInternalVariable;
        }
        static void Main(string[] args)
        {
            AccessModifier obj = new AccessModifier();
            obj.PublicFunction();
            obj.publicVariable = "";
            obj.PrivateFunction();
            obj.privateVariable = "";
            obj.ProtectedFunction();
            obj.protectedVariable = "";
            obj.InternalFunction();
            obj.internalVariable = "";
            obj.ProtectedInternalFunction();
            obj.protectedInternalVariable = "";
        }
    }
    class CallAccessModifier : AccessModifier
    {
        static void Main(string[] args)
        {
            CallAccessModifier obj = new CallAccessModifier();
            obj.PublicFunction();
            obj.publicVariable = "";
            obj.InternalFunction();
            obj.internalVariable = "";
            obj.ProtectedFunction();
            obj.protectedVariable = "";
            obj.ProtectedInternalFunction();
            obj.protectedInternalVariable = "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifier obj = new AccessModifier();
            obj.InternalFunction();
            obj.internalVariable = "";
            obj.ProtectedInternalFunction();
            obj.protectedInternalVariable = "";
            obj.PublicFunction();
            obj.publicVariable = "";
        }
    }
}
