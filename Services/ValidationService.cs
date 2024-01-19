using CSharpTubeDownloader.Exceptions;

namespace CSharpTubeDownloader.Services
{
    internal class ValidationService
    {
        static public void checkNullOrEmptyValue(string fieldName, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ValidationException($"The field \"{fieldName}\" is required.");
            }
        }

        static public void checkYoutubeLink(string fieldName, string value)
        {
            if (!value.Contains("https://www.youtube.com/"))
            {
                throw new ValidationException($"The field \"{fieldName}\" must contain a YouTube link.");
            }
        }
    }
}
