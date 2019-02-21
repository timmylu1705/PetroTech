using System.ComponentModel;

namespace PetroTech.Common.Resource
{
    public static class Helper
    {
        public class Enum
        {
            public enum Status
            {
                [Description("Active")]
                A = 1,

                [Description("Inactive")]
                I = 2
            }

            public enum HomePage
            {
            }
        }
    }
}