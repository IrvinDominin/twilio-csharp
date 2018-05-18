/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Returns a single Composition Instance resource identified by a CompositionSid.
    /// </summary>
    public class FetchCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The Composition Sid that uniquely identifies the Composition to fetch.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCompositionOptions
        /// </summary>
        /// <param name="pathSid"> The Composition Sid that uniquely identifies the Composition to fetch. </param>
        public FetchCompositionOptions(string pathSid)
        {
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// List of all Recording Compositions.
    /// </summary>
    public class ReadCompositionOptions : ReadOptions<CompositionResource> 
    {
        /// <summary>
        /// Only show Compositions with the given status.
        /// </summary>
        public CompositionResource.StatusEnum Status { get; set; }
        /// <summary>
        /// Only show Compositions that started on or after this ISO8601 date-time.
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// Only show Compositions that started before this this ISO8601 date-time.
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// The room_sid
        /// </summary>
        public string RoomSid { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (RoomSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoomSid", RoomSid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Delete a Recording Composition Instance resource identified by a `CompositionSid`.
    /// </summary>
    public class DeleteCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The Recording Composition Sid that uniquely identifies the Recording Composition to delete.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCompositionOptions
        /// </summary>
        /// <param name="pathSid"> The Recording Composition Sid that uniquely identifies the Recording Composition to delete.
        ///               </param>
        public DeleteCompositionOptions(string pathSid)
        {
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateCompositionOptions
    /// </summary>
    public class CreateCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string RoomSid { get; set; }
        /// <summary>
        /// The video_layout
        /// </summary>
        public object VideoLayout { get; set; }
        /// <summary>
        /// The audio_sources
        /// </summary>
        public List<string> AudioSources { get; set; }
        /// <summary>
        /// The audio_sources_excluded
        /// </summary>
        public List<string> AudioSourcesExcluded { get; set; }
        /// <summary>
        /// The resolution
        /// </summary>
        public string Resolution { get; set; }
        /// <summary>
        /// The format
        /// </summary>
        public CompositionResource.FormatEnum Format { get; set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The trim
        /// </summary>
        public bool? Trim { get; set; }

        /// <summary>
        /// Construct a new CreateCompositionOptions
        /// </summary>
        public CreateCompositionOptions()
        {
            AudioSources = new List<string>();
            AudioSourcesExcluded = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (RoomSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoomSid", RoomSid.ToString()));
            }

            if (VideoLayout != null)
            {
                p.Add(new KeyValuePair<string, string>("VideoLayout", Serializers.JsonObject(VideoLayout)));
            }

            if (AudioSources != null)
            {
                p.AddRange(AudioSources.Select(prop => new KeyValuePair<string, string>("AudioSources", prop.ToString())));
            }

            if (AudioSourcesExcluded != null)
            {
                p.AddRange(AudioSourcesExcluded.Select(prop => new KeyValuePair<string, string>("AudioSourcesExcluded", prop)));
            }

            if (Resolution != null)
            {
                p.Add(new KeyValuePair<string, string>("Resolution", Resolution));
            }

            if (Format != null)
            {
                p.Add(new KeyValuePair<string, string>("Format", Format.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}