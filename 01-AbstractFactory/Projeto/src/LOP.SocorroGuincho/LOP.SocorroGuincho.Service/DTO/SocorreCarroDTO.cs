using LOP.GuinchoSocorro.Domain.Type;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOP.SocorroGuincho.Service.DTO
{
    public class SocorreCarroDTO
    {
        public string Modelo { get; set; }

        public string Motivo { get; set; }

        //[EnumDataType(typeof(Porte))]
        [JsonConverter(typeof(StringEnumConverter))]
        public Porte Porte { get; set; }
    }
}
