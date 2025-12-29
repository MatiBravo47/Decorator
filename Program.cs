using System;

namespace DecoratorCafe 
{
    public abstract class Cafe 
    {
        public abstract string Descripcion();
        public abstract decimal Precio();
    }

    class CafeSimple : Cafe
    {
        public override string Descripcion()
        {
            return "Cafe ";
        }

        public override decimal Precio()
        {
            return 500;
        }
    }

    abstract class CafeDecorator : Cafe
    {
        protected Cafe cafe;
        public CafeDecorator(Cafe cafe)
        {
            this.cafe = cafe;
        }
    }


    class ConLeche : CafeDecorator 
    {
        public ConLeche(Cafe cafe) : base(cafe) 
        {
        }

        public override string Descripcion()
        {
            return cafe.Descripcion() + "con leche ";
        }

        public override decimal Precio() 
        {
            return cafe.Precio() + 150;
        }
    }

    class ConAzucar : CafeDecorator
    {
        public ConAzucar(Cafe cafe) : base(cafe) 
        {
        }

        public override string Descripcion()
        {
            return cafe.Descripcion() + "con azucar ";
        }

        public override decimal Precio() 
        {
            return cafe.Precio() + 50;
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Cafe pedido = new CafeSimple();

            pedido = new ConLeche(pedido);
            pedido = new ConAzucar(pedido);

            Console.WriteLine("Pedido: ");
            Console.WriteLine(pedido.Descripcion());
            Console.WriteLine("Precio total: $" + pedido.Precio());

            Console.ReadKey();

        }
    }
}
