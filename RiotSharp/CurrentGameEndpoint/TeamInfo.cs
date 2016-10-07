using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RiotSharp.CurrentGameEndpoint
{
    public class TeamInfo
    {
        internal TeamInfo() { }

        [JsonProperty("tag")]
        public string tag { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("memberStatus")]
        public string memberStatus { get; set; }

        [JsonProperty("secondsUntilEligibleForDeletion")]
        public double secondsUntilEligibleForDeletion { get; set; }

        [JsonProperty("teamId")]
        public Dictionary<String, String> teamId { get; set; }
    }
}
