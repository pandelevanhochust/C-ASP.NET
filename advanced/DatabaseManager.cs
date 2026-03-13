using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace advanced
{
    public class DatabaseManager : IDisposable
    {
        private bool _disposed = false;
        private string _connectionString;
        private bool _isOpen;

        private StreamWriter stream;

        public DatabaseManager(string conn)
        {
            _connectionString = conn;
            _isOpen = true;
            Console.WriteLine("Database Connection Opened.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent the Finalizer from running since the Dispose ve done 
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Clean up logic in here 
                    // All the object that needs to call Dispose()
                    stream.Dispose();
                }

                //Clean up unmanaged resources here
                _isOpen = false;

                _disposed = true;
            }
        }

        // If the programmer forgets to call Dispose(), the GC will eventually call this, which calls Dispose(false)
        ~DatabaseManager()
        {
            Console.WriteLine("Finalizer called by GC!");
            Dispose(false);
        }
    }
}