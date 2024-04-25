namespace Abril24.ITD.PERROSPERDIDOS.API.CONTROLLERS
{
    public static class IActionResultExtensions
    {
        public static bool IsSuccessStatusCode(this IActionResult result)
        {
            var objectResult = result as ObjectResult;
            if (objectResult != null)
            {
                return objectResult.StatusCode >= 200 && objectResult.StatusCode < 300;
            }

            // Si no es un ObjectResult, asumimos que es exitoso.
            return true;
        }
    }
}