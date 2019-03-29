PRINT N'Creating Objects...';
GO
CREATE SCHEMA [DemoVCom]
    AUTHORIZATION [dbo];
GO
PRINT N'Creating DemoVCom.AdvisorIndexData...';
GO
CREATE TABLE [DemoVCom].[AdvisorIndexData] (
    [AdvisorIndex]			INT           IDENTITY (1, 1) NOT NULL,
    [DateFrom]				DATETIME NULL,
    [AdvisorMasterEntityID] INT NULL,
    [CompanyMasterEntityID] INT NULL,
    [Active]			BIT NOT NULL DEFAULT 0
);
GO
PRINT N'Creating DemoVCom.AdvisorIndexDataGet...';

GO
CREATE PROCEDURE [DemoVCom].[AdvisorIndexDataGet]
        @DateFrom                       DATETIME    =   NULL
,       @AdvisorMasterEntityID          INT         =   NULL
,       @CompanyMasterEntityID          INT         =   NULL
,       @GetOnlyActive                  BIT         =   0
,       @GetOnlyInactive                BIT         =   0
AS
BEGIN
	SELECT 
		[A].[AdvisorIndex], CONVERT(date, [A].[DateFrom]), [A].[AdvisorMasterEntityID], [A].[CompanyMasterEntityID] 
	FROM [DemoVCom].[AdvisorIndexData] AS A
	WHERE 
		(Active = @GetOnlyActive OR Active = @GetOnlyInactive)
		AND
			((@DateFrom IS NULL) OR ([DateFrom] = @DateFrom))
		AND
			((@AdvisorMasterEntityID IS NULL) OR ([AdvisorMasterEntityID] = @AdvisorMasterEntityID))
		AND
			((@CompanyMasterEntityID IS NULL) OR ([CompanyMasterEntityID] = @CompanyMasterEntityID))
END
GO
GO