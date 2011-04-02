using System;
using System.Reflection;
using System.Text;
using System.Threading;

namespace SpecSalad
{
    public class SaladDirector: Director
    {
        public TaskRole How_Do_I_Perform(string role_description)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Assembly[] assemblies = domain.GetAssemblies();
            
            string roleName = get_role_name(role_description);

            foreach (var assembly in assemblies)
            {
                Type[] types = assembly.GetTypes();

                foreach (var type in types)
                {
                    if (type.Name == roleName)
                        if (typeof(ApplicationTask).IsAssignableFrom(type) || typeof(ApplicationRole).IsAssignableFrom(type))
                            return (TaskRole) Activator.CreateInstance(type);
                }
            }

            throw new SaladException(string.Format("You need to define the role or task '{0}'", roleName));
        }

        static string get_role_name(string roleDescription)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < roleDescription.Length; i++)
            {
                char toAdd = roleDescription[i];

                if (builder.Length == 0)
                    toAdd = char.ToUpper(toAdd);

                if(toAdd == ' ')
                {
                    i++;
                    toAdd = char.ToUpper(roleDescription[i]);                    
                }

                builder.Append(toAdd);
            }

            return builder.ToString();
        }
    }
}