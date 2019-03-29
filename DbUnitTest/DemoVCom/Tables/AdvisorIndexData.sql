CREATE TABLE [DemoVCom].[AdvisorIndexData] (
    [AdvisorIndex]			INT           IDENTITY (1, 1) NOT NULL,
    [DateFrom]				DATETIME NULL,
    [AdvisorMasterEntityID] INT NULL,
    [CompanyMasterEntityID] INT NULL,
    [Active]			BIT NOT NULL DEFAULT 0
);