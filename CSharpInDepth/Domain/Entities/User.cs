using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class User : IdentityUser<Guid>, ISoftDeletable, IBaseEntity, IAuditableEntity
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Department { get; init; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }

        public static bool ValidatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(password)
                && hasUpperChar.IsMatch(password)
                && hasMinimum8Chars.IsMatch(password);

            return isValidated;
        }
    }
}
