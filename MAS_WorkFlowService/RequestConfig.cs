using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MAS_WorkFlowService
{
    public class RequestConfig : ConfigurationSection
    {
        // Create a "remoteOnly" attribute.
        [ConfigurationProperty("remoteOnly", DefaultValue = "false", IsRequired = false)]
        public Boolean RemoteOnly
        {
            get
            {
                return (Boolean)this["remoteOnly"];
            }
            set
            {
                this["remoteOnly"] = value;
            }
        }
        // Create a "Status" element.
        [ConfigurationProperty("Status", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RequestConfigElementCollection),
        AddItemName = "add",
        ClearItemsName = "clear",
        RemoveItemName = "remove")]
        public RequestConfigElementCollection Status
        {

            get
            {
                RequestConfigElementCollection statusCollection =
               (RequestConfigElementCollection)base["Status"];

                return statusCollection;
            }
            set
            { RequestConfigElementCollection statusCollection = (RequestConfigElementCollection)value; }
        }


        [ConfigurationProperty("RequestType", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RequestConfigElementCollection),
        AddItemName = "add",
        ClearItemsName = "clear",
        RemoveItemName = "remove")]
        public RequestConfigElementCollection RequestType
        {

            get
            {
                RequestConfigElementCollection statusCollection =
               (RequestConfigElementCollection)base["RequestType"];

                return statusCollection;
            }
            set
            { RequestConfigElementCollection statusCollection = (RequestConfigElementCollection)value; }
        }

        [ConfigurationProperty("POSStatus", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RequestConfigElementCollection),
        AddItemName = "add",
        ClearItemsName = "clear",
        RemoveItemName = "remove")]
        public RequestConfigElementCollection POSStatus
        {

            get
            {
                RequestConfigElementCollection posCollection =
               (RequestConfigElementCollection)base["POSStatus"];

                return posCollection;
            }
            set
            { RequestConfigElementCollection posCollection = (RequestConfigElementCollection)value; }
        }
        public RequestConfig()
        {
            RequestConfigElement requestConfigElement = new RequestConfigElement();
            Status.Add(requestConfigElement);

        }
    }
    //Status Element
    public class RequestConfigElementCollection : ConfigurationElementCollection
    {

        public RequestConfigElementCollection()
        {

        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new RequestConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((RequestConfigElement)element).Name;
        }

        public RequestConfigElement this[int index]
        {
            get
            {
                return (RequestConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public RequestConfigElement this[string Name]
        {
            get
            {
                return (RequestConfigElement)BaseGet(Name);
            }
        }
        public int IndexOf(RequestConfigElement status)
        {
            return BaseIndexOf(status);
        }
        public void Add(RequestConfigElement status)
        {
            BaseAdd(status);

            // Your custom code goes here.

        }
        public void Remove(RequestConfigElement status)
        {
            if (BaseIndexOf(status) >= 0)
            {
                BaseRemove(status.Name);
                // Your custom code goes here.
                Console.WriteLine("UrlsCollection: {0}", "Removed collection element!");
            }
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);

            // Your custom code goes here.

        }
        public void Remove(string name)
        {
            BaseRemove(name);

            // Your custom code goes here.

        }

        public void Clear()
        {
            BaseClear();

            // Your custom code goes here.
            Console.WriteLine("UrlsCollection: {0}", "Removed entire collection!");
        }


    }
    //Status Element


    // Define the UrlsConfigElement elements that are contained 
    // by the UrlsCollection.
    public class RequestConfigElement : ConfigurationElement
    {
        public RequestConfigElement(String name, String displayName, int value)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Value = value;
        }

        public RequestConfigElement()
        {

        }

        [ConfigurationProperty("name", DefaultValue = "DRAFT",
            IsRequired = true, IsKey = true)]
       // [RegexStringValidator(@"\w+:\/\/[\w.]+\S*")]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("displayName", DefaultValue = "DRAFT",
            IsRequired = true)]
       // [RegexStringValidator(@"\w+:\/\/[\w.]+\S*")]
        public string DisplayName
        {
            get
            {
                return (string)this["displayName"];
            }
            set
            {
                this["displayName"] = value;
            }
        }

        [ConfigurationProperty("value", DefaultValue = 1, IsRequired = false, IsKey = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 8080, ExcludeRange = false)]
        public int Value
        {
            get
            {
                return (int)this["value"];
            }
            set
            {
                this["value"] = value;
            }
        }
        [ConfigurationProperty("view", DefaultValue = "", IsRequired = false)]
      // [RegexStringValidator(@"\w+:\/\/[\w.]+\S*")]
        public string view
        {
            get
            {
                return (string)this["view"];
            }
            set
            {
                this["view"] = value;
            }
        }

    }

    public static class RequestConfigHelper
    {


        public static RequestConfigElement GetStatus(string key)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                   ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            var result = config.Status[key];
            return result;
        }
     
        public static String GetStatusDisplayName(Int32 value)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            //var result = config.Status[value].DisplayName;
            var result = (from MAS_WorkFlowService.RequestConfigElement s in config.Status
                         where s.Value == value
                         select s).FirstOrDefault();
            return result.DisplayName;
        }
        public static String GetRequestDisplayName(Int32 value)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestType");
            // config.Status
            //var result = config.Status[value].DisplayName;
            var result = (from MAS_WorkFlowService.RequestConfigElement s in config.Status
                          where s.Value == value
                          select s).FirstOrDefault();
            return result.DisplayName;
        }
        public static MAS_WorkFlowService.RequestConfigElement GetStatusConfig(Int32 value)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            //var result = config.Status[value].DisplayName;
            var result = (from MAS_WorkFlowService.RequestConfigElement s in config.Status
                          where s.Value == value
                          select s).FirstOrDefault();
            return result;
        }

        public static List<RequestStatusViewModel> GetAllRequestType()
        {
            List<RequestStatusViewModel> result = new List<RequestStatusViewModel>();

            RequestConfig config = (RequestConfig)
                        System.Configuration.ConfigurationManager.GetSection("RequestConfig");


            foreach (var item in config.RequestType)
            {
                result.Add(new RequestStatusViewModel
                {
                    DisplayName = (item as RequestConfigElement).DisplayName,
                    Name = (item as RequestConfigElement).Name,
                    Value = (item as RequestConfigElement).Value
                });

            }

            return result;
        }
        public static RequestConfigElement GetRequestType(string key)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            var result = config.RequestType[key];
            return result;
        }
        public static String GetRequestTypeDisplayName(Int32 value)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");

            var result = (from MAS_WorkFlowService.RequestConfigElement s in config.RequestType
                          where s.Value == value
                          select s).FirstOrDefault();

            // config.Status
            
            return result.DisplayName;
        }


        public static RequestConfigElement GetPOSType(string key)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            var result = config.POSStatus[key];
            return result;
        }
        public static String GetPOSTypeDisplayName(Int32 value)
        {

            MAS_WorkFlowService.RequestConfig config = (MAS_WorkFlowService.RequestConfig)
                    System.Configuration.ConfigurationManager.GetSection("RequestConfig");
            // config.Status
            var result = config.POSStatus[value].DisplayName;
            return result;
        }

    }
    public class RequestStatusViewModel
    {
        public String Name { get; set; }
        public String DisplayName { get; set; }
        public Int32 Value { get; set; }

    }
}