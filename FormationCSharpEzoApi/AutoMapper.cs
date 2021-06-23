using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCSharpEzoApi
{
    public static class AutoMapper<T,TRetour>
        where T : class
        where TRetour : class
    {
        public static TRetour Map(T toMap)
        {            
            
            var toReturn = Activator.CreateInstance(typeof(TRetour));
            foreach (var item in toMap.GetType().GetProperties())
            {
                if (toReturn.GetType().GetProperty(item.Name) != null)
                {
                    if(toReturn.GetType().GetProperty(item.Name).GetType() == item.GetType())
                    {
                        toReturn.GetType().GetProperty(item.Name).SetValue(toReturn.GetType().GetProperty(item.Name),
                            item.GetType().GetProperty(item.Name).GetValue(item.GetType().GetProperty(item.Name)));
                    }
                }
            }
            return (TRetour)toReturn;
        }
    }
}
