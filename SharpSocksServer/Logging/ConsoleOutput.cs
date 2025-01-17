﻿using System;

namespace SharpSocksServer.Logging
{
    public class ConsoleOutput : ILogOutput
    {
        private bool _verbose;

        public void LogError(string errorMessage)
        {
            Console.WriteLine($"[{DateTime.Now}][X] {errorMessage}");
        }

        public void LogMessage(string message)
        {
            if (_verbose)
            {
                Console.WriteLine($"[{DateTime.Now}][*] {message}");
            }
        }

        public void LogImportantMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}][!] {message}");
        }

        public bool FailError(string message, Guid errorCode)
        {
            Console.WriteLine($"[{DateTime.Now}][-] Error Code: {errorCode} Message: {message}");
            throw new Exception(message ?? "");
        }

        public void BannerMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void SetVerboseOn()
        {
            _verbose = true;
        }

        public void SetVerboseOff()
        {
            _verbose = false;
        }

        public bool IsVerboseOn()
        {
            return _verbose;
        }
    }
}