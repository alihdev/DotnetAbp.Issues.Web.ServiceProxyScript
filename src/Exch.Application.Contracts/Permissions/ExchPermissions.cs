namespace Exch.Permissions;

public static class ExchPermissions
{
    public const string GroupName = "Exch";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class Transfer
    {
        public const string Default = GroupName + ".Transfer";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
