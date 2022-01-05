using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclulator_Testing
{
    public class BaseTestEntity<T> where T : class, new()
    {
        protected T memberToTest;

        public virtual void Initialize()
        {
            memberToTest = new T();
        }

        public virtual void Clean()
        {
            memberToTest = null;
        }

    }
}
