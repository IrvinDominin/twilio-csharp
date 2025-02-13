/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// FlexFlowResource
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

namespace Twilio.Rest.FlexApi.V1
{

    public class FlexFlowResource : Resource
    {
        public sealed class ChannelTypeEnum : StringEnum
        {
            private ChannelTypeEnum(string value) : base(value) {}
            public ChannelTypeEnum() {}
            public static implicit operator ChannelTypeEnum(string value)
            {
                return new ChannelTypeEnum(value);
            }

            public static readonly ChannelTypeEnum Web = new ChannelTypeEnum("web");
            public static readonly ChannelTypeEnum Sms = new ChannelTypeEnum("sms");
            public static readonly ChannelTypeEnum Facebook = new ChannelTypeEnum("facebook");
            public static readonly ChannelTypeEnum Whatsapp = new ChannelTypeEnum("whatsapp");
            public static readonly ChannelTypeEnum Line = new ChannelTypeEnum("line");
            public static readonly ChannelTypeEnum Custom = new ChannelTypeEnum("custom");
        }

        public sealed class IntegrationTypeEnum : StringEnum
        {
            private IntegrationTypeEnum(string value) : base(value) {}
            public IntegrationTypeEnum() {}
            public static implicit operator IntegrationTypeEnum(string value)
            {
                return new IntegrationTypeEnum(value);
            }

            public static readonly IntegrationTypeEnum Studio = new IntegrationTypeEnum("studio");
            public static readonly IntegrationTypeEnum External = new IntegrationTypeEnum("external");
            public static readonly IntegrationTypeEnum Task = new IntegrationTypeEnum("task");
        }

        private static Request BuildReadRequest(ReadFlexFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/FlexFlows",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static ResourceSet<FlexFlowResource> Read(ReadFlexFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FlexFlowResource>.FromJson("flex_flows", response.Content);
            return new ResourceSet<FlexFlowResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FlexFlowResource>> ReadAsync(ReadFlexFlowOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FlexFlowResource>.FromJson("flex_flows", response.Content);
            return new ResourceSet<FlexFlowResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="friendlyName"> The `friendly_name` of the FlexFlow resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static ResourceSet<FlexFlowResource> Read(string friendlyName = null,
                                                         int? pageSize = null,
                                                         long? limit = null,
                                                         ITwilioRestClient client = null)
        {
            var options = new ReadFlexFlowOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="friendlyName"> The `friendly_name` of the FlexFlow resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FlexFlowResource>> ReadAsync(string friendlyName = null,
                                                                                                 int? pageSize = null,
                                                                                                 long? limit = null,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadFlexFlowOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FlexFlowResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FlexFlowResource>.FromJson("flex_flows", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FlexFlowResource> NextPage(Page<FlexFlowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.FlexApi,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FlexFlowResource>.FromJson("flex_flows", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FlexFlowResource> PreviousPage(Page<FlexFlowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.FlexApi,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FlexFlowResource>.FromJson("flex_flows", response.Content);
        }

        private static Request BuildFetchRequest(FetchFlexFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/FlexFlows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Fetch(FetchFlexFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> FetchAsync(FetchFlexFlowOptions options,
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
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFlexFlowOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> FetchAsync(string pathSid,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new FetchFlexFlowOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateFlexFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/FlexFlows",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Create(CreateFlexFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> CreateAsync(CreateFlexFlowOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="chatServiceSid"> The SID of the chat service </param>
        /// <param name="channelType"> The channel type </param>
        /// <param name="contactIdentity"> The channel contact's Identity </param>
        /// <param name="enabled"> Whether the new FlexFlow is enabled </param>
        /// <param name="integrationType"> The integration type </param>
        /// <param name="integrationFlowSid"> The SID of the Flow </param>
        /// <param name="integrationUrl"> The External Webhook URL </param>
        /// <param name="integrationWorkspaceSid"> The Workspace SID for a new task </param>
        /// <param name="integrationWorkflowSid"> The Workflow SID for a new task </param>
        /// <param name="integrationChannel"> The task channel for a new task </param>
        /// <param name="integrationTimeout"> The task timeout in seconds for a new task </param>
        /// <param name="integrationPriority"> The task priority of a new task </param>
        /// <param name="integrationCreationOnMessage"> Whether to create a task when the first message arrives </param>
        /// <param name="longLived"> Whether new channels are long-lived </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Create(string friendlyName,
                                              string chatServiceSid,
                                              FlexFlowResource.ChannelTypeEnum channelType,
                                              string contactIdentity = null,
                                              bool? enabled = null,
                                              FlexFlowResource.IntegrationTypeEnum integrationType = null,
                                              string integrationFlowSid = null,
                                              Uri integrationUrl = null,
                                              string integrationWorkspaceSid = null,
                                              string integrationWorkflowSid = null,
                                              string integrationChannel = null,
                                              int? integrationTimeout = null,
                                              int? integrationPriority = null,
                                              bool? integrationCreationOnMessage = null,
                                              bool? longLived = null,
                                              ITwilioRestClient client = null)
        {
            var options = new CreateFlexFlowOptions(friendlyName, chatServiceSid, channelType){ContactIdentity = contactIdentity, Enabled = enabled, IntegrationType = integrationType, IntegrationFlowSid = integrationFlowSid, IntegrationUrl = integrationUrl, IntegrationWorkspaceSid = integrationWorkspaceSid, IntegrationWorkflowSid = integrationWorkflowSid, IntegrationChannel = integrationChannel, IntegrationTimeout = integrationTimeout, IntegrationPriority = integrationPriority, IntegrationCreationOnMessage = integrationCreationOnMessage, LongLived = longLived};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="chatServiceSid"> The SID of the chat service </param>
        /// <param name="channelType"> The channel type </param>
        /// <param name="contactIdentity"> The channel contact's Identity </param>
        /// <param name="enabled"> Whether the new FlexFlow is enabled </param>
        /// <param name="integrationType"> The integration type </param>
        /// <param name="integrationFlowSid"> The SID of the Flow </param>
        /// <param name="integrationUrl"> The External Webhook URL </param>
        /// <param name="integrationWorkspaceSid"> The Workspace SID for a new task </param>
        /// <param name="integrationWorkflowSid"> The Workflow SID for a new task </param>
        /// <param name="integrationChannel"> The task channel for a new task </param>
        /// <param name="integrationTimeout"> The task timeout in seconds for a new task </param>
        /// <param name="integrationPriority"> The task priority of a new task </param>
        /// <param name="integrationCreationOnMessage"> Whether to create a task when the first message arrives </param>
        /// <param name="longLived"> Whether new channels are long-lived </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> CreateAsync(string friendlyName,
                                                                                      string chatServiceSid,
                                                                                      FlexFlowResource.ChannelTypeEnum channelType,
                                                                                      string contactIdentity = null,
                                                                                      bool? enabled = null,
                                                                                      FlexFlowResource.IntegrationTypeEnum integrationType = null,
                                                                                      string integrationFlowSid = null,
                                                                                      Uri integrationUrl = null,
                                                                                      string integrationWorkspaceSid = null,
                                                                                      string integrationWorkflowSid = null,
                                                                                      string integrationChannel = null,
                                                                                      int? integrationTimeout = null,
                                                                                      int? integrationPriority = null,
                                                                                      bool? integrationCreationOnMessage = null,
                                                                                      bool? longLived = null,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new CreateFlexFlowOptions(friendlyName, chatServiceSid, channelType){ContactIdentity = contactIdentity, Enabled = enabled, IntegrationType = integrationType, IntegrationFlowSid = integrationFlowSid, IntegrationUrl = integrationUrl, IntegrationWorkspaceSid = integrationWorkspaceSid, IntegrationWorkflowSid = integrationWorkflowSid, IntegrationChannel = integrationChannel, IntegrationTimeout = integrationTimeout, IntegrationPriority = integrationPriority, IntegrationCreationOnMessage = integrationCreationOnMessage, LongLived = longLived};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateFlexFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/FlexFlows/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Update(UpdateFlexFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> UpdateAsync(UpdateFlexFlowOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="chatServiceSid"> The SID of the chat service </param>
        /// <param name="channelType"> The channel type </param>
        /// <param name="contactIdentity"> The channel contact's Identity </param>
        /// <param name="enabled"> Whether the FlexFlow is enabled </param>
        /// <param name="integrationType"> The integration type </param>
        /// <param name="integrationFlowSid"> The SID of the Flow </param>
        /// <param name="integrationUrl"> The External Webhook URL </param>
        /// <param name="integrationWorkspaceSid"> The Workspace SID for a new task </param>
        /// <param name="integrationWorkflowSid"> The Workflow SID for a new task </param>
        /// <param name="integrationChannel"> task channel for a new task </param>
        /// <param name="integrationTimeout"> The task timeout in seconds for a new task </param>
        /// <param name="integrationPriority"> The task priority of a new task </param>
        /// <param name="integrationCreationOnMessage"> Whether to create a task when the first message arrives </param>
        /// <param name="longLived"> Whether new channels created are long-lived </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static FlexFlowResource Update(string pathSid,
                                              string friendlyName = null,
                                              string chatServiceSid = null,
                                              FlexFlowResource.ChannelTypeEnum channelType = null,
                                              string contactIdentity = null,
                                              bool? enabled = null,
                                              FlexFlowResource.IntegrationTypeEnum integrationType = null,
                                              string integrationFlowSid = null,
                                              Uri integrationUrl = null,
                                              string integrationWorkspaceSid = null,
                                              string integrationWorkflowSid = null,
                                              string integrationChannel = null,
                                              int? integrationTimeout = null,
                                              int? integrationPriority = null,
                                              bool? integrationCreationOnMessage = null,
                                              bool? longLived = null,
                                              ITwilioRestClient client = null)
        {
            var options = new UpdateFlexFlowOptions(pathSid){FriendlyName = friendlyName, ChatServiceSid = chatServiceSid, ChannelType = channelType, ContactIdentity = contactIdentity, Enabled = enabled, IntegrationType = integrationType, IntegrationFlowSid = integrationFlowSid, IntegrationUrl = integrationUrl, IntegrationWorkspaceSid = integrationWorkspaceSid, IntegrationWorkflowSid = integrationWorkflowSid, IntegrationChannel = integrationChannel, IntegrationTimeout = integrationTimeout, IntegrationPriority = integrationPriority, IntegrationCreationOnMessage = integrationCreationOnMessage, LongLived = longLived};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="chatServiceSid"> The SID of the chat service </param>
        /// <param name="channelType"> The channel type </param>
        /// <param name="contactIdentity"> The channel contact's Identity </param>
        /// <param name="enabled"> Whether the FlexFlow is enabled </param>
        /// <param name="integrationType"> The integration type </param>
        /// <param name="integrationFlowSid"> The SID of the Flow </param>
        /// <param name="integrationUrl"> The External Webhook URL </param>
        /// <param name="integrationWorkspaceSid"> The Workspace SID for a new task </param>
        /// <param name="integrationWorkflowSid"> The Workflow SID for a new task </param>
        /// <param name="integrationChannel"> task channel for a new task </param>
        /// <param name="integrationTimeout"> The task timeout in seconds for a new task </param>
        /// <param name="integrationPriority"> The task priority of a new task </param>
        /// <param name="integrationCreationOnMessage"> Whether to create a task when the first message arrives </param>
        /// <param name="longLived"> Whether new channels created are long-lived </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<FlexFlowResource> UpdateAsync(string pathSid,
                                                                                      string friendlyName = null,
                                                                                      string chatServiceSid = null,
                                                                                      FlexFlowResource.ChannelTypeEnum channelType = null,
                                                                                      string contactIdentity = null,
                                                                                      bool? enabled = null,
                                                                                      FlexFlowResource.IntegrationTypeEnum integrationType = null,
                                                                                      string integrationFlowSid = null,
                                                                                      Uri integrationUrl = null,
                                                                                      string integrationWorkspaceSid = null,
                                                                                      string integrationWorkflowSid = null,
                                                                                      string integrationChannel = null,
                                                                                      int? integrationTimeout = null,
                                                                                      int? integrationPriority = null,
                                                                                      bool? integrationCreationOnMessage = null,
                                                                                      bool? longLived = null,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateFlexFlowOptions(pathSid){FriendlyName = friendlyName, ChatServiceSid = chatServiceSid, ChannelType = channelType, ContactIdentity = contactIdentity, Enabled = enabled, IntegrationType = integrationType, IntegrationFlowSid = integrationFlowSid, IntegrationUrl = integrationUrl, IntegrationWorkspaceSid = integrationWorkspaceSid, IntegrationWorkflowSid = integrationWorkflowSid, IntegrationChannel = integrationChannel, IntegrationTimeout = integrationTimeout, IntegrationPriority = integrationPriority, IntegrationCreationOnMessage = integrationCreationOnMessage, LongLived = longLived};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteFlexFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                "/v1/FlexFlows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static bool Delete(DeleteFlexFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete FlexFlow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFlexFlowOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlexFlow </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFlexFlowOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlexFlow </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFlexFlowOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FlexFlowResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FlexFlowResource object represented by the provided JSON </returns>
        public static FlexFlowResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FlexFlowResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The SID of the chat service
        /// </summary>
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }
        /// <summary>
        /// The channel type
        /// </summary>
        [JsonProperty("channel_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FlexFlowResource.ChannelTypeEnum ChannelType { get; private set; }
        /// <summary>
        /// The channel contact's Identity
        /// </summary>
        [JsonProperty("contact_identity")]
        public string ContactIdentity { get; private set; }
        /// <summary>
        /// Whether the FlexFlow is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The integration type
        /// </summary>
        [JsonProperty("integration_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FlexFlowResource.IntegrationTypeEnum IntegrationType { get; private set; }
        /// <summary>
        /// An object that contains specific parameters for the integration
        /// </summary>
        [JsonProperty("integration")]
        public object Integration { get; private set; }
        /// <summary>
        /// Whether new channels are long-lived
        /// </summary>
        [JsonProperty("long_lived")]
        public bool? LongLived { get; private set; }
        /// <summary>
        /// The absolute URL of the FlexFlow resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FlexFlowResource()
        {

        }
    }

}