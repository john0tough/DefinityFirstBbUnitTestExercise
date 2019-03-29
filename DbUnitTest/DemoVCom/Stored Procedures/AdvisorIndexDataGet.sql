CREATE PROCEDURE [DemoVCom].[AdvisorIndexDataGet]
        @DateFrom                       DATETIME    =   NULL
,       @AdvisorMasterEntityID          INT         =   NULL
,       @CompanyMasterEntityID          INT         =   NULL
,       @GetOnlyActive                  BIT         =   0
,       @GetOnlyInactive                BIT         =   0
AS
BEGIN

if @GetOnlyActive = 1 
	SELECT 
		*
	FROM [DemoVCom].[AdvisorIndexData] AS A
	WHERE 
		active = 1 
		AND
			((@DateFrom IS NULL) OR ([DateFrom] >= @DateFrom))
		AND
			((@AdvisorMasterEntityID IS NULL) OR ([AdvisorMasterEntityID] = @AdvisorMasterEntityID))
		AND
			((@CompanyMasterEntityID IS NULL) OR ([CompanyMasterEntityID] = @CompanyMasterEntityID));

if @GetOnlyInactive = 1
		SELECT 
		*
		FROM [DemoVCom].[AdvisorIndexData] AS A
		WHERE 
			active = 0 
		AND
			((@DateFrom IS NULL) OR ([DateFrom] >= @DateFrom))
		AND
			((@AdvisorMasterEntityID IS NULL) OR ([AdvisorMasterEntityID] = @AdvisorMasterEntityID))
		AND
			((@CompanyMasterEntityID IS NULL) OR ([CompanyMasterEntityID] = @CompanyMasterEntityID));

END