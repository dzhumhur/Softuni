namespace NinjectIoCContainer
{
    using System;
    using System.Reflection;
    using Contracts;
    using Ninject;

    public class NinjectIoCExmaple
    {
        internal static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var data = kernel.Get<ICourseData>();
            Console.WriteLine(string.Join(", ", data.GetCourseNames()));
        }
    }
}
