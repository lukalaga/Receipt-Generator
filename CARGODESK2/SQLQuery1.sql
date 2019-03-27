CREATE TABLE Maintenance
(
    Recepient varchar(25),Address varchar(25),Phone varchar(25),Date1 varchar(25),
    Time1 varchar(25),OriginatorNo varchar(25),Project varchar(25),Title varchar(25),Site1 varchar(25),Equipment varchar(25),Originator varchar(25),
    ProblemValidated varchar(MAX),Activity varchar(MAX) ,ProbDescription varchar(MAX),OSCondition varchar(MAX),SystemStatus varchar(25),
    SysNomenclature varchar(25),SysSerialNo varchar(25),MeterTime varchar(25),TechnicalAnalyzer varchar(25),ProblemStatus varchar(MAX),
    ProbRecomendation varchar(MAX),ProgNomenclature varchar(MAX),VersionNumber INT ,SoftwareConfig varchar(MAX),Recommendation varchar(MAX),
    SubsysSerialNo varchar(MAX),SubsysNomenclature varchar(MAX)
);


CReate TABLE Repairs(RepairDate varchar(25),RepairCompany varchar(25),Timein varchar(25),ReceiptNo varchar(25),Item varchar(25),
Model varchar(25),Quantity INT,Remarks varchar(MAX),AuthorizingOfficer varchar(25),Designation varchar(25),ReceivedBy varchar(25),
IDNumber varchar(25),RepairerRemarks varchar(MAX),Diagnosis varchar(MAX))