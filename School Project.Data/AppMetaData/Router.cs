namespace School_Project.Data.AppMetaData
{

    public static class Router
    {
        public const string root = "Api";
        public const string Version = "V1";
        public const string Rule = root + "/" + Version + "/"; // "Api/V1"
        public const string SingleRoute = "/{id}";
        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";  // "Api/V1"
            public const string List = Prefix + "/List";  // "Api/V1/List"
            public const string GetById = Prefix + SingleRoute;  // "Api/V1/{id}"
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";
        }

    }

}
