using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace AppCoreModels
{
    [DataContract]
    public class UserModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("is_debt")]
        public bool IsDebt { get; set; }

        [JsonProperty("chat_id")]
        public string ChatId { get; set; }

    }
}
