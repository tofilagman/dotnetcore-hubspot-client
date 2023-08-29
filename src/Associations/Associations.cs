using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Associations
{
    public enum Associations : int
    {
        Contact_to_company = 279,
        Contact_to_company_primary = 1,
        Contact_to_deal = 4,
        Contact_to_ticket = 15,
        Contact_to_call = 193,
        Contact_to_email = 197,
        Contact_to_meeting = 199,
        Contact_to_note = 201,
        Contact_to_task = 203,
        /// <summary>
        /// SMS, WhatsApp, or LinkedIn message
        /// </summary>
        Contact_to_communication = 82,
        Contact_to_postal_mail = 454,
        Company_to_contact = 280,
        Company_to_contact_primary = 2,
        Company_to_deal = 342,
        Company_to_deal_primary = 6,
        Company_to_ticket = 340,
        Company_to_ticket_primary = 25,
        Company_to_call = 181,
        Company_to_email = 185,
        Company_to_meeting = 187,
        Company_to_note = 189,
        Note_to_company = 190,
        Company_to_task = 191,
        /// <summary>
        /// SMS, WhatsApp, or LinkedIn message
        /// </summary>
        Company_to_communication = 88,
        Company_to_postal_mail = 460,
       
    }
}
