using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace zd5_Shaidullin.store
{
    public class Store
    {
        public async Task SaveApplicationProperty<T>(string key, T value)
        {
            Xamarin.Forms.Application.Current.Properties[key] = value;
            await Xamarin.Forms.Application.Current.SavePropertiesAsync();
        }

       public T LoadApplicationProperty<T>(string key)
        {
            return (T)Xamarin.Forms.Application.Current.Properties[key];
        }
    }
}
