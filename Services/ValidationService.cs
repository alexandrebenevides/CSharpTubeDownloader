using CSharpTubeDownloader.Models;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpTubeDownloader.Services
{
    internal class ValidationService
    {
        static public ValidationResponse checkNullOrEmptyValue(string fieldName, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                string errorMessage = $"The field \"{fieldName}\" is required.";
                MessageBox.Show(errorMessage, "Alert Message");
                return new ValidationResponse(false, errorMessage);
            }

            return new ValidationResponse(true);
        }

        static public ValidationResponse checkYoutubeLink(string fieldName, string value)
        {
            if (!value.Contains("https://www.youtube.com/"))
            {
                string errorMessage = $"The field \"{fieldName}\" must contain a YouTube link.";
                MessageBox.Show(errorMessage, "Alert Message");
                return new ValidationResponse(false, errorMessage);
            }

            return new ValidationResponse(true);
        }
    }
}
