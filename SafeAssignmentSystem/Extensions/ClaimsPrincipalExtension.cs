namespace Microsoft.Extensions.DependencyInjection
{
    using System.Security.Claims;
    /// <summary>
    /// Екстенжън клас 
    /// </summary>
    public static class ClaimsPrincipalExtension
    {
        /// <summary>
        /// Идентификатор на текущо логнат потребител
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string Id(this ClaimsPrincipal user) => user.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
