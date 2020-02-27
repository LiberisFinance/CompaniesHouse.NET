﻿using System.Runtime.Serialization;

namespace CompaniesHouse.Core.Response.PersonsWithSignificantControl
{
    public enum PersonWithSignificantControlKind
    {
        [EnumMember(Value = "corporate-entity-person-with-significant-control")]
        CorporateEntityPersonWithSignificantControl,

        [EnumMember(Value = "individual-person-with-significant-control")]
        IndividualPersonWithSignificantControl
    }
}
