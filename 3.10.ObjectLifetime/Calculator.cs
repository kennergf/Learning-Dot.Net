using System;

namespace ObjectLifetime
{
    public class Calculator : IDisposable
    {
        static double pi = Math.PI;
        double startAngle = 0;
        public DateTime DateCreated { get; } = DateTime.Now;

        static Calculator()
        {
            Console.WriteLine("static Calculator()");
        }
        public Calculator()
        {
            Console.WriteLine("public Calculator()");
        }
        public Calculator(int val)
        {
            Console.WriteLine("public Calculator(int)");
        }

        #region Dispose
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool dispose)
        {
            if(!disposed)
            {
                if(dispose)
                {
                    // TODO
                    // Close log files and unmanaged resources
                }
                disposed = true;
            }
        }
        #endregion
    }
}