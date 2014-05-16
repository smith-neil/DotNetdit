using DotNetdit.Utilities;
using Newtonsoft.Json.Linq;

namespace DotNetdit.Factories
{
    // this is so fucking pointless. i mean wtf.
    // youre returning JToken so whatever use this is still dependent on JSON.NET.
    // this abstracts nothing and introduces code smell in my service constructor.
    // stop being a dick. the GoF isnt god. not everything has to be from a design pattern book.
    // so go fuck yourself and just call json.parse in your god damn services
    public class JTokenFactory : IJTokenFactory
    {
        public JToken MakeJToken(string val) {
            val.ThrowIfNull("val");

            return JToken.Parse(val);
        }
    }
}
