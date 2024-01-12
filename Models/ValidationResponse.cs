﻿namespace CSharpTubeDownloader.Models
{
    internal class ValidationResponse
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResponse(bool isValid, string errorMessage = null)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
    }
}
