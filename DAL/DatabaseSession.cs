using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class DatabaseSession
    {
        private static string? _connectionString;
        private static Timer? _scheduler;
        private static int _isRunning = 0;

        public static QLGPLXContext? Context { get; private set; }

        public static void Initialize(string username, string password)
        {
            _connectionString = $"Data Source=DESKTOP-39G03JV\\SQLEXPRESS;" +
                                $"Initial Catalog=QLGPLX;" +
                                $"User ID={username};" +
                                $"Password={password};" +
                                $"TrustServerCertificate=True;";

            Context = new QLGPLXContext(_connectionString);

            // Start background scheduler to run stored procedure every 10 minutes
            StartScheduler();
        }

        private static void StartScheduler()
        {
            // avoid starting multiple timers
            if (string.IsNullOrEmpty(_connectionString)) return;
            if (_scheduler != null) return;

            // run immediately then every 10 minutes
            _scheduler = new Timer(state =>
            {
                // prevent overlapping executions
                if (Interlocked.Exchange(ref _isRunning, 1) == 1) return;

                try
                {
                    using var ctx = new QLGPLXContext(_connectionString);
                    // Execute stored procedure - adjust if your SP name or syntax differs
                    ctx.Database.ExecuteSqlRaw("EXEC sp_CapNhatTrangThaiKyThi");
                    ctx.Database.ExecuteSqlRaw("EXEC sp_ResetDiemGPLX");
                    Debug.WriteLine($"sp_CapNhatTrangThaiKyThi executed at {DateTime.Now}");
                    Debug.WriteLine($"sp_ResetDiemGPLX executed at {DateTime.Now}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error executing sp_CapNhatTrangThaiKyThi: {ex}");
                }
                finally
                {
                    Interlocked.Exchange(ref _isRunning, 0);
                }
            }, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));
        }

        public static void StopScheduler()
        {
            try
            {
                _scheduler?.Change(Timeout.Infinite, Timeout.Infinite);
                _scheduler?.Dispose();
            }
            catch { }
            finally
            {
                _scheduler = null;
                _isRunning = 0;
            }
        }

        public static void Close()
        {
            StopScheduler();
            Context?.Dispose();
            Context = null;
            _connectionString = null;
        }
    }
}
