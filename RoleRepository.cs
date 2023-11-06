using PPM.Model;

namespace PPM.Domain
{
    public class RoleRepository
    {
        public static List<Role> roles = new List<Role>();

        //add role
        public bool AddRole(Role role)
        {
            roles.Add(role);
            return true;
        }

        //view Roles
        public List<Role> GetRoles()
        {
            return roles;
        }

        //Delete Roles
        public static bool DeleteRole(string roleId)
        {
            Role roleToDelete = roles.Find(r => r.Id == roleId);
            if (roleToDelete != null)
            {
                roles.Remove(roleToDelete);
                return true;
            }
            return false; // role not found or deletion failed
        }

        //Get role by ID
        public static Role GetRoleById(string roleId)
        {
            // Find the Role with the given ID
            Role role = roles.Find(r => r.Id == roleId);
            return role; // Return the Role (or null if not found)
        }

        //VALIDATION PART
        //RoleExists
        public bool RoleExists(string roleId)
        {
            return roles.Exists(role => role.Id == roleId);
        }

        // Check if the role ID already exists
        public bool IsRoleIdUnique(string roleId)
        {
            return !roles.Exists(r => r.Id == roleId);
        }

        // Role ID validation for null value
        public static bool ValidateRoleId(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return false;
            }
            return true;
        }

        // Role Name validation for null value
        public static bool ValidateRoleName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }
            return true;
        }
        public bool IsRoleNameUnique(string roleName)
        {
            return !roles.Exists(r => r.Name == roleName);
        }
    }
}
