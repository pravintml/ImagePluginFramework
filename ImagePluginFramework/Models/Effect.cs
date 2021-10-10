using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Models
{
    public class Effect
    {
        public int Id { get; set; }
        public Plugin Plugin { get; set; }
        public int Value { get; set; }
    }
}
