/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry 
{

    /// <summary>
    /// ReadMobileOptions
    /// </summary>
    public class ReadMobileOptions : ReadOptions<MobileResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The country_code
        /// </summary>
        public string PathCountryCode { get; }
        /// <summary>
        /// Find phone numbers in the specified area code.
        /// </summary>
        public int? AreaCode { get; set; }
        /// <summary>
        /// A pattern on which to match phone numbers.
        /// </summary>
        public string Contains { get; set; }
        /// <summary>
        /// This indicates whether the phone numbers can receive text messages.
        /// </summary>
        public bool? SmsEnabled { get; set; }
        /// <summary>
        /// This indicates whether the phone numbers can receive MMS messages.
        /// </summary>
        public bool? MmsEnabled { get; set; }
        /// <summary>
        /// This indicates whether the phone numbers can receive calls.
        /// </summary>
        public bool? VoiceEnabled { get; set; }
        /// <summary>
        /// Indicates whether the response includes phone numbers which require any Address.
        /// </summary>
        public bool? ExcludeAllAddressRequired { get; set; }
        /// <summary>
        /// Indicates whether the response includes phone numbers which require a local Address.
        /// </summary>
        public bool? ExcludeLocalAddressRequired { get; set; }
        /// <summary>
        /// Indicates whether the response includes phone numbers which require a foreign Address.
        /// </summary>
        public bool? ExcludeForeignAddressRequired { get; set; }
        /// <summary>
        /// Include phone numbers new to the Twilio platform.
        /// </summary>
        public bool? Beta { get; set; }
        /// <summary>
        /// Given a phone number, find a geographically close number within Distance miles. (US/Canada only)
        /// </summary>
        public Types.PhoneNumber NearNumber { get; set; }
        /// <summary>
        /// Given a latitude/longitude pair lat,long find geographically close numbers within Distance miles. (US/Canada only)
        /// </summary>
        public string NearLatLong { get; set; }
        /// <summary>
        /// Specifies the search radius for a Near- query in miles. (US/Canada only)
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// Limit results to a particular postal code. (US/Canada only)
        /// </summary>
        public string InPostalCode { get; set; }
        /// <summary>
        /// Limit results to a particular region. (US/Canada only)
        /// </summary>
        public string InRegion { get; set; }
        /// <summary>
        /// Limit results to a specific rate center, or given a phone number search within the same rate center as that number. (US/Canada only)
        /// </summary>
        public string InRateCenter { get; set; }
        /// <summary>
        /// Limit results to a specific Local access and transport area. (US/Canada only)
        /// </summary>
        public string InLata { get; set; }
        /// <summary>
        /// Limit results to a particular locality.
        /// </summary>
        public string InLocality { get; set; }
        /// <summary>
        /// This indicates whether the phone numbers can receive faxes.
        /// </summary>
        public bool? FaxEnabled { get; set; }

        /// <summary>
        /// Construct a new ReadMobileOptions
        /// </summary>
        /// <param name="pathCountryCode"> The country_code </param>
        public ReadMobileOptions(string pathCountryCode)
        {
            PathCountryCode = pathCountryCode;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AreaCode != null)
            {
                p.Add(new KeyValuePair<string, string>("AreaCode", AreaCode.Value.ToString()));
            }

            if (Contains != null)
            {
                p.Add(new KeyValuePair<string, string>("Contains", Contains));
            }

            if (SmsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsEnabled", SmsEnabled.Value.ToString().ToLower()));
            }

            if (MmsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MmsEnabled", MmsEnabled.Value.ToString().ToLower()));
            }

            if (VoiceEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceEnabled", VoiceEnabled.Value.ToString().ToLower()));
            }

            if (ExcludeAllAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeAllAddressRequired", ExcludeAllAddressRequired.Value.ToString().ToLower()));
            }

            if (ExcludeLocalAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeLocalAddressRequired", ExcludeLocalAddressRequired.Value.ToString().ToLower()));
            }

            if (ExcludeForeignAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeForeignAddressRequired", ExcludeForeignAddressRequired.Value.ToString().ToLower()));
            }

            if (Beta != null)
            {
                p.Add(new KeyValuePair<string, string>("Beta", Beta.Value.ToString().ToLower()));
            }

            if (NearNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("NearNumber", NearNumber.ToString()));
            }

            if (NearLatLong != null)
            {
                p.Add(new KeyValuePair<string, string>("NearLatLong", NearLatLong));
            }

            if (Distance != null)
            {
                p.Add(new KeyValuePair<string, string>("Distance", Distance.Value.ToString()));
            }

            if (InPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("InPostalCode", InPostalCode));
            }

            if (InRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("InRegion", InRegion));
            }

            if (InRateCenter != null)
            {
                p.Add(new KeyValuePair<string, string>("InRateCenter", InRateCenter));
            }

            if (InLata != null)
            {
                p.Add(new KeyValuePair<string, string>("InLata", InLata));
            }

            if (InLocality != null)
            {
                p.Add(new KeyValuePair<string, string>("InLocality", InLocality));
            }

            if (FaxEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("FaxEnabled", FaxEnabled.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}