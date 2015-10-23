namespace KillMe
{
    using System;
    using Nancy;

    public class B
    {
        public C C { get; set; }
    }

    public class C
    {
        public B B { get; set; }
    }

    public class Oops : NancyModule
    {
        private Random random = new Random();

        public Oops()
        {
            var bytes = new byte[200000];
            random.NextBytes(bytes);

            Get["/"] = x => Negotiate.WithModel(bytes);

            Get["/circular"] = x =>
            {
                var b = new B()
                {
                    C = new C()
                };

                b.C.B = b;

                return b;
            };
        }
    }
}
