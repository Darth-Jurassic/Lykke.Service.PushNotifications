// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.PushNotifications.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AssetsCreditedModel
    {
        /// <summary>
        /// Initializes a new instance of the AssetsCreditedModel class.
        /// </summary>
        public AssetsCreditedModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetsCreditedModel class.
        /// </summary>
        public AssetsCreditedModel(double amount, IList<string> notificationIds = default(IList<string>), string assetId = default(string), string message = default(string))
        {
            NotificationIds = notificationIds;
            Amount = amount;
            AssetId = assetId;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NotificationIds")]
        public IList<string> NotificationIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}