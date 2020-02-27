﻿namespace CompaniesHouse.Core
{
    public interface ICompaniesHouseClient :
        ICompaniesHouseSearchCompanyClient,
        ICompaniesHouseSearchOfficerClient,
        ICompaniesHouseSearchDisqualifiedOfficerClient,
        ICompaniesHouseSearchAllClient,
        ICompaniesHouseCompanyProfileClient,
        ICompaniesHouseCompanyFilingHistoryClient,
        ICompaniesHouseOfficersClient,
        ICompaniesHouseCompanyInsolvencyInformationClient,
        ICompaniesHouseAppointmentsClient,
        ICompaniesHouseDocumentMetadataClient,
        ICompaniesHousePersonsWithSignificantControlClient
    {

    }
}