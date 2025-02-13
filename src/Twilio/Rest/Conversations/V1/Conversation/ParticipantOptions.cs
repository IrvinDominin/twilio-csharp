/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1.Conversation
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateParticipantOptions
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this participant.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A unique string identifier for the conversation participant as Chat User.
        /// </summary>
        public string Identity { get; set; }
        /// <summary>
        /// The address of the participant's device.
        /// </summary>
        public string MessagingBindingAddress { get; set; }
        /// <summary>
        /// The address of the Twilio phone number that the participant is in contact with.
        /// </summary>
        public string MessagingBindingProxyAddress { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this participant. </param>
        public CreateParticipantOptions(string pathConversationSid)
        {
            PathConversationSid = pathConversationSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (MessagingBindingAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingBinding.Address", MessagingBindingAddress));
            }

            if (MessagingBindingProxyAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingBinding.ProxyAddress", MessagingBindingProxyAddress));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateParticipantOptions
    /// </summary>
    public class UpdateParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this participant.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new UpdateParticipantOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this participant. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateParticipantOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteParticipantOptions
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this participant.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this participant. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteParticipantOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchParticipantOptions
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this participant.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this participant. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchParticipantOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadParticipantOptions
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource>
    {
        /// <summary>
        /// The unique id of the Conversation for participants.
        /// </summary>
        public string PathConversationSid { get; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for participants. </param>
        public ReadParticipantOptions(string pathConversationSid)
        {
            PathConversationSid = pathConversationSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}