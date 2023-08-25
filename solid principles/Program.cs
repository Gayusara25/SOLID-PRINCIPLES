using solid_principles.DIP;
using solid_principles.ISP;
using solid_principles.LSP;
using solid_principles.OCP;
using solid_principles.SRP;
using solid_principles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SOLID Principles:");

        var principles = new List<Iprinciple>()
            {
                new Srp(),
                new Ocp(),
                new Lsp(),
                new Isp(),
                new Dip()
            };
        principles.ForEach(type =>
        {
            Console.WriteLine($"- {type.Principle()}");
        });
        Console.Read();
    }
}