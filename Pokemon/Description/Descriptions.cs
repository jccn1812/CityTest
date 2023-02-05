using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Descriptions
    {
        [JsonProperty("Descriptions")]
        public List<DescLanguage> descriptions { get; set; }
    }
}
