using solid_principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.OCP

{
    class Ocp : Iprinciple
    {
        public string Principle()
    {
        return "Open for Extension, Closed for Modification";
    }
}


internal class Customer
{
    public int Type;

    public virtual void Add(Database db)
    {
        if (Type == 0)
        {
            db.Add();
        }
        else
        {
            db.AddExistingCustomer();
        }
    }
}

internal class CustomerBetter
{
    public virtual void Add(Database db)
    {
        db.Add();
    }
}

internal class ExistingCustomer : CustomerBetter
{
    public override void Add(Database db)
    {
        db.AddExistingCustomer();
    }
}

internal class AnotherCustomer : CustomerBetter
{
    public override void Add(Database db)
    {
        db.AnotherExtension();
    }
}
}
