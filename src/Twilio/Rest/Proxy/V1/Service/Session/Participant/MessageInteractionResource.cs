/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// MessageInteractionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Proxy.V1.Service.Session.Participant 
{

    public class MessageInteractionResource : Resource 
    {
        public sealed class TypeEnum : StringEnum 
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }

            public static readonly TypeEnum Message = new TypeEnum("message");
            public static readonly TypeEnum Voice = new TypeEnum("voice");
            public static readonly TypeEnum Unknown = new TypeEnum("unknown");
        }

        public sealed class ResourceStatusEnum : StringEnum 
        {
            private ResourceStatusEnum(string value) : base(value) {}
            public ResourceStatusEnum() {}
            public static implicit operator ResourceStatusEnum(string value)
            {
                return new ResourceStatusEnum(value);
            }

            public static readonly ResourceStatusEnum Accepted = new ResourceStatusEnum("accepted");
            public static readonly ResourceStatusEnum Answered = new ResourceStatusEnum("answered");
            public static readonly ResourceStatusEnum Busy = new ResourceStatusEnum("busy");
            public static readonly ResourceStatusEnum Canceled = new ResourceStatusEnum("canceled");
            public static readonly ResourceStatusEnum Completed = new ResourceStatusEnum("completed");
            public static readonly ResourceStatusEnum Deleted = new ResourceStatusEnum("deleted");
            public static readonly ResourceStatusEnum Delivered = new ResourceStatusEnum("delivered");
            public static readonly ResourceStatusEnum DeliveryUnknown = new ResourceStatusEnum("delivery-unknown");
            public static readonly ResourceStatusEnum Failed = new ResourceStatusEnum("failed");
            public static readonly ResourceStatusEnum InProgress = new ResourceStatusEnum("in-progress");
            public static readonly ResourceStatusEnum Initiated = new ResourceStatusEnum("initiated");
            public static readonly ResourceStatusEnum NoAnswer = new ResourceStatusEnum("no-answer");
            public static readonly ResourceStatusEnum Queued = new ResourceStatusEnum("queued");
            public static readonly ResourceStatusEnum Received = new ResourceStatusEnum("received");
            public static readonly ResourceStatusEnum Receiving = new ResourceStatusEnum("receiving");
            public static readonly ResourceStatusEnum Ringing = new ResourceStatusEnum("ringing");
            public static readonly ResourceStatusEnum Scheduled = new ResourceStatusEnum("scheduled");
            public static readonly ResourceStatusEnum Sending = new ResourceStatusEnum("sending");
            public static readonly ResourceStatusEnum Sent = new ResourceStatusEnum("sent");
            public static readonly ResourceStatusEnum Undelivered = new ResourceStatusEnum("undelivered");
            public static readonly ResourceStatusEnum Unknown = new ResourceStatusEnum("unknown");
        }

        private static Request BuildCreateRequest(CreateMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new message Interaction to send directly from your system to one
        /// [Participant](https://www.twilio.com/docs/proxy/api/participants).  The `inbound` properties for this Interaction
        /// will always be empty.
        /// </summary>
        /// <param name="options"> Create MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Create(CreateMessageInteractionOptions options, 
                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new message Interaction to send directly from your system to one
        /// [Participant](https://www.twilio.com/docs/proxy/api/participants).  The `inbound` properties for this Interaction
        /// will always be empty.
        /// </summary>
        /// <param name="options"> Create MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> CreateAsync(CreateMessageInteractionOptions options, 
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new message Interaction to send directly from your system to one
        /// [Participant](https://www.twilio.com/docs/proxy/api/participants).  The `inbound` properties for this Interaction
        /// will always be empty.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid </param>
        /// <param name="pathSessionSid"> Session Sid </param>
        /// <param name="pathParticipantSid"> Participant Sid </param>
        /// <param name="body"> Message body </param>
        /// <param name="mediaUrl"> The media_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Create(string pathServiceSid, 
                                                        string pathSessionSid, 
                                                        string pathParticipantSid, 
                                                        string body = null, 
                                                        List<Uri> mediaUrl = null, 
                                                        ITwilioRestClient client = null)
        {
            var options = new CreateMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){Body = body, MediaUrl = mediaUrl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new message Interaction to send directly from your system to one
        /// [Participant](https://www.twilio.com/docs/proxy/api/participants).  The `inbound` properties for this Interaction
        /// will always be empty.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid </param>
        /// <param name="pathSessionSid"> Session Sid </param>
        /// <param name="pathParticipantSid"> Participant Sid </param>
        /// <param name="body"> Message body </param>
        /// <param name="mediaUrl"> The media_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> CreateAsync(string pathServiceSid, 
                                                                                                string pathSessionSid, 
                                                                                                string pathParticipantSid, 
                                                                                                string body = null, 
                                                                                                List<Uri> mediaUrl = null, 
                                                                                                ITwilioRestClient client = null)
        {
            var options = new CreateMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){Body = body, MediaUrl = mediaUrl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Fetch(FetchMessageInteractionOptions options, 
                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> FetchAsync(FetchMessageInteractionOptions options, 
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static MessageInteractionResource Fetch(string pathServiceSid, 
                                                       string pathSessionSid, 
                                                       string pathParticipantSid, 
                                                       string pathSid, 
                                                       ITwilioRestClient client = null)
        {
            var options = new FetchMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<MessageInteractionResource> FetchAsync(string pathServiceSid, 
                                                                                               string pathSessionSid, 
                                                                                               string pathParticipantSid, 
                                                                                               string pathSid, 
                                                                                               ITwilioRestClient client = null)
        {
            var options = new FetchMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMessageInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathParticipantSid + "/MessageInteractions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static ResourceSet<MessageInteractionResource> Read(ReadMessageInteractionOptions options, 
                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MessageInteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<MessageInteractionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read MessageInteraction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageInteractionResource>> ReadAsync(ReadMessageInteractionOptions options, 
                                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageInteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<MessageInteractionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessageInteraction </returns> 
        public static ResourceSet<MessageInteractionResource> Read(string pathServiceSid, 
                                                                   string pathSessionSid, 
                                                                   string pathParticipantSid, 
                                                                   int? pageSize = null, 
                                                                   long? limit = null, 
                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessageInteraction </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageInteractionResource>> ReadAsync(string pathServiceSid, 
                                                                                                           string pathSessionSid, 
                                                                                                           string pathParticipantSid, 
                                                                                                           int? pageSize = null, 
                                                                                                           long? limit = null, 
                                                                                                           ITwilioRestClient client = null)
        {
            var options = new ReadMessageInteractionOptions(pathServiceSid, pathSessionSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<MessageInteractionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessageInteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<MessageInteractionResource> NextPage(Page<MessageInteractionResource> page, 
                                                                ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Proxy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessageInteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<MessageInteractionResource> PreviousPage(Page<MessageInteractionResource> page, 
                                                                    ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Proxy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessageInteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a MessageInteractionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageInteractionResource object represented by the provided JSON </returns> 
        public static MessageInteractionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessageInteractionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Message Interaction.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        [JsonProperty("session_sid")]
        public string SessionSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Message body
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; private set; }
        /// <summary>
        /// The Type of this Message Interaction
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.TypeEnum Type { get; private set; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// Always empty for Message Interactions.
        /// </summary>
        [JsonProperty("inbound_participant_sid")]
        public string InboundParticipantSid { get; private set; }
        /// <summary>
        /// Always empty for Message Interactions.
        /// </summary>
        [JsonProperty("inbound_resource_sid")]
        public string InboundResourceSid { get; private set; }
        /// <summary>
        /// Always empty for Message Interactions.
        /// </summary>
        [JsonProperty("inbound_resource_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.ResourceStatusEnum InboundResourceStatus { get; private set; }
        /// <summary>
        /// Always empty for Message Interactions.
        /// </summary>
        [JsonProperty("inbound_resource_type")]
        public string InboundResourceType { get; private set; }
        /// <summary>
        /// Always empty for Message Interactions.
        /// </summary>
        [JsonProperty("inbound_resource_url")]
        public Uri InboundResourceUrl { get; private set; }
        /// <summary>
        /// Outbound Participant Sid.
        /// </summary>
        [JsonProperty("outbound_participant_sid")]
        public string OutboundParticipantSid { get; private set; }
        /// <summary>
        /// Outbound message resource Sid.
        /// </summary>
        [JsonProperty("outbound_resource_sid")]
        public string OutboundResourceSid { get; private set; }
        /// <summary>
        /// The Outbound Resource Status of this Message Interaction
        /// </summary>
        [JsonProperty("outbound_resource_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageInteractionResource.ResourceStatusEnum OutboundResourceStatus { get; private set; }
        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty("outbound_resource_type")]
        public string OutboundResourceType { get; private set; }
        /// <summary>
        /// The URL of the Twilio message resource.
        /// </summary>
        [JsonProperty("outbound_resource_url")]
        public Uri OutboundResourceUrl { get; private set; }
        /// <summary>
        /// The date this Message Interaction was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Message Interaction was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MessageInteractionResource()
        {

        }
    }

}