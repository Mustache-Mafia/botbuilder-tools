// <auto-generated>
// Code generated by LUISGen ..\..\..\..\tests\LUISGenTest\Contoso app.json -cs Microsoft.Bot.Builder.Ai.LUIS.Tests.Contoso_App -o ..\..\..\..\tests\LUISGenTest\
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Microsoft.Bot.Builder.Ai.LUIS.Tests
{
    public partial class Contoso_App: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Cancel, 
            Delivery, 
            EntityTests, 
            Greeting, 
            Help, 
            None, 
            search, 
            SpecifyName, 
            Travel, 
            Weather_GetForecast
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Name;
            public string[] State;
            public string[] Weather_Location;
            public string[] City;
            public string[] To;
            public string[] From;

            // Built-in entities
            public Age[] age;
            public DateTimeSpec[] datetime;
            public Dimension[] dimension;
            public string[] email;
            public Money[] money;
            public double[] number;
            public double[] ordinal;
            public double[] percentage;
            public string[] phonenumber;
            public Temperature[] temperature;
            public string[] url;

            // Lists
            public string[][] Airline;

            // Regex entities
            public string[] Part;

            // Pattern.any
            public string[] person;
            public string[] subject;
            public string[] extra;

            // Composites
            public class _InstanceAddress
            {
                public InstanceData[] number;
                public InstanceData[] State;
            }
            public class AddressClass
            {
                public double[] number;
                public string[] State;
                [JsonProperty("$instance")]
                public _InstanceAddress _instance;
            }
            public AddressClass[] Address;

            public class _InstanceComposite1
            {
                public InstanceData[] age;
                public InstanceData[] datetime;
                public InstanceData[] dimension;
                public InstanceData[] email;
                public InstanceData[] money;
                public InstanceData[] number;
                public InstanceData[] ordinal;
                public InstanceData[] percentage;
                public InstanceData[] phonenumber;
                public InstanceData[] temperature;
            }
            public class Composite1Class
            {
                public Age[] age;
                public DateTimeSpec[] datetime;
                public Dimension[] dimension;
                public string[] email;
                public Money[] money;
                public double[] number;
                public double[] ordinal;
                public double[] percentage;
                public string[] phonenumber;
                public Temperature[] temperature;
                [JsonProperty("$instance")]
                public _InstanceComposite1 _instance;
            }
            public Composite1Class[] Composite1;

            public class _InstanceComposite2
            {
                public InstanceData[] Airline;
                public InstanceData[] City;
                public InstanceData[] url;
                public InstanceData[] From;
                public InstanceData[] To;
                public InstanceData[] Weather_Location;
            }
            public class Composite2Class
            {
                public string[][] Airline;
                public string[] City;
                public string[] url;
                public string[] From;
                public string[] To;
                public string[] Weather_Location;
                [JsonProperty("$instance")]
                public _InstanceComposite2 _instance;
            }
            public Composite2Class[] Composite2;

            // Instance
            public class _Instance
            {
                public InstanceData[] Name;
                public InstanceData[] State;
                public InstanceData[] Weather_Location;
                public InstanceData[] City;
                public InstanceData[] To;
                public InstanceData[] From;
                public InstanceData[] age;
                public InstanceData[] datetime;
                public InstanceData[] dimension;
                public InstanceData[] email;
                public InstanceData[] money;
                public InstanceData[] number;
                public InstanceData[] ordinal;
                public InstanceData[] percentage;
                public InstanceData[] phonenumber;
                public InstanceData[] temperature;
                public InstanceData[] url;
                public InstanceData[] Airline;
                public InstanceData[] Part;
                public InstanceData[] person;
                public InstanceData[] subject;
                public InstanceData[] extra;
                public InstanceData[] Address;
                public InstanceData[] Composite1;
                public InstanceData[] Composite2;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Contoso_App>(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
