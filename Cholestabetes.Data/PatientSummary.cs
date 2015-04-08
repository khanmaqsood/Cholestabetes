//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cholestabetes.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientSummary
    {
        public int ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> HighRisk_10Year { get; set; }
        public Nullable<int> HighRisk_CAD { get; set; }
        public Nullable<int> HighRisk_CeVD { get; set; }
        public Nullable<int> HighRisk_AAAS { get; set; }
        public Nullable<int> HighRisk_PAD { get; set; }
        public Nullable<System.DateTime> DateOfConsent { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Visit1Date { get; set; }
        public string Gender { get; set; }
        public string Ethinicity { get; set; }
        public string MedicationCoverage { get; set; }
        public Nullable<int> Systolic { get; set; }
        public Nullable<int> Diastolic { get; set; }
        public Nullable<decimal> Weight_KG { get; set; }
        public Nullable<decimal> Weight_LB { get; set; }
        public Nullable<decimal> Height_CM { get; set; }
        public Nullable<decimal> Height_IN { get; set; }
        public Nullable<int> SmokingHistory { get; set; }
        public Nullable<int> Diabetes_Despression { get; set; }
        public Nullable<int> Diabetes_ErectileDysfunction { get; set; }
        public Nullable<int> Diabetes_Hypoglycemia { get; set; }
        public Nullable<int> Diabetes_Macroalbuminuria { get; set; }
        public Nullable<int> Diabetes_Microalbuminuria { get; set; }
        public Nullable<int> Diabetes_Retinopathy { get; set; }
        public Nullable<int> CurrentMedication_ASA { get; set; }
        public Nullable<int> CurrentMedication_OtherAntiplateletAgent { get; set; }
        public Nullable<int> CurrentMedication_ACEInhibitor { get; set; }
        public Nullable<int> CurrentMedication_ARB { get; set; }
        public Nullable<int> CurrentMedication_BetaBlocker { get; set; }
        public Nullable<int> CurrentMedication_CalciumChannelBlocker { get; set; }
        public Nullable<int> CurrentMedication_Diuretic { get; set; }
        public string AdherePatient { get; set; }
        public Nullable<int> MedicationAdherence_Caregiver { get; set; }
        public Nullable<int> MedicationAdherence_PharmacyRenewalRecords { get; set; }
        public Nullable<int> MedicationAdherence_MedicationCount { get; set; }
        public Nullable<int> MedicationAdherence_Guessed { get; set; }
        public Nullable<int> MedicationAdherence_NotEvaluated { get; set; }
        public Nullable<System.DateTime> MostRecentLabDate { get; set; }
        public Nullable<int> ALT { get; set; }
        public Nullable<int> ALKPHOS { get; set; }
        public Nullable<int> Creatinine { get; set; }
        public Nullable<decimal> eGFR { get; set; }
        public Nullable<decimal> ACR { get; set; }
        public string LDLCTarget { get; set; }
        public Nullable<System.DateTime> MostRecentLipidLabDate { get; set; }
        public Nullable<decimal> Cholesterol { get; set; }
        public Nullable<decimal> LDLC { get; set; }
        public Nullable<decimal> LDLC_Care_Gap { get; set; }
        public Nullable<decimal> HDLC { get; set; }
        public Nullable<decimal> NonHDLC { get; set; }
        public Nullable<decimal> Triglycerides { get; set; }
        public string StatinTherapy { get; set; }
        public Nullable<int> LipidLowering_BileAcid { get; set; }
        public Nullable<int> LipidLowering_Ezetimibe { get; set; }
        public Nullable<int> LipidLowering_Fibrate { get; set; }
        public Nullable<int> LipidLowering_Niacin { get; set; }
        public Nullable<int> LipidLowering_FattyAcids { get; set; }
        public string LipidLowering_BileAcid_Medication { get; set; }
        public string DurationDiabetes { get; set; }
        public string A1CTarget { get; set; }
        public Nullable<System.DateTime> MostRecentA1CLabDate { get; set; }
        public Nullable<decimal> A1C { get; set; }
        public Nullable<decimal> FastingPlasmaGlucose { get; set; }
        public string MetTherMetforminDailyDose { get; set; }
        public string MetTherMetforminDailyFrequency { get; set; }
        public string MetTherGlumetzaDailyDose { get; set; }
        public string MetTherLinagliptinDailyDose { get; set; }
        public string MetTherSaxagliptinDailyDose { get; set; }
        public string MetTherSitagliptinDailyDose { get; set; }
        public string MetTherSitagliptinExDailyDose { get; set; }
        public Nullable<int> AntihyperglycemicGlucosidase { get; set; }
        public Nullable<int> AntihyperglycemicDPP4 { get; set; }
        public Nullable<int> AntihyperglycemicGLP { get; set; }
        public Nullable<int> AntihyperglycemicInsulin { get; set; }
        public Nullable<int> AntihyperglycemicMeglitinide { get; set; }
        public Nullable<int> AntihyperglycemicSGLT2 { get; set; }
        public Nullable<int> AntihyperglycemicSulfonylurea { get; set; }
        public Nullable<int> AntihyperglycemicThiazolidinedione { get; set; }
        public Nullable<int> AntihyperglycemicNumInjects { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> A1CTarget_LimitedLife { get; set; }
        public Nullable<int> A1CTarget_FunctionalDep { get; set; }
        public Nullable<int> A1CTarget_IschemicEvents { get; set; }
        public Nullable<int> A1CTarget_MultipleMorbidities { get; set; }
        public Nullable<int> A1CTarget_SevereHypoglycemia { get; set; }
        public Nullable<int> A1CTarget_HypoglycemiaUnawareness { get; set; }
        public Nullable<int> A1CTarget_Longstanding { get; set; }
        public Nullable<int> A1CTarget_ClinicalJudge { get; set; }
        public Nullable<int> A1CTarget_None { get; set; }
        public Nullable<int> AddColesevelam { get; set; }
        public Nullable<int> AddEzetimibe { get; set; }
        public Nullable<int> AddFibrate { get; set; }
        public Nullable<int> AddNiacin { get; set; }
        public Nullable<int> AddNoChange { get; set; }
        public Nullable<int> AddColesevelamYes { get; set; }
        public Nullable<int> AddColesevelamNo { get; set; }
        public Nullable<int> AddColesevelamDosage { get; set; }
        public Nullable<int> AddColesevelamNoPatientRefusal { get; set; }
        public Nullable<int> AddColesevelamNoPatientAfford { get; set; }
        public Nullable<int> AddColesevelamNoDrugAdminister { get; set; }
        public Nullable<int> AddColesevelamNoRX { get; set; }
        public Nullable<int> AddEzetimibeYes { get; set; }
        public Nullable<int> AddEzetimibeNo { get; set; }
        public Nullable<int> AddEzetimibeNoPatientRefusal { get; set; }
        public Nullable<int> AddEzetimibeNoPatientAfford { get; set; }
        public Nullable<int> AddEzetimibeNoDrugAdminister { get; set; }
        public Nullable<int> AddEzetimibeNoRX { get; set; }
        public Nullable<int> AddFibrateYes { get; set; }
        public Nullable<int> AddFibrateNo { get; set; }
        public Nullable<int> AddFibrateNotApprop { get; set; }
        public Nullable<int> AddFibrateTG { get; set; }
        public Nullable<int> AddFibrateRecommendations { get; set; }
        public Nullable<int> AddFibrateMedicalConstraints { get; set; }
        public Nullable<int> AddFibrateReimbursement { get; set; }
        public Nullable<int> AddNiacinYes { get; set; }
        public Nullable<int> AddNiacinNo { get; set; }
        public Nullable<int> AddNiacinNotApprop { get; set; }
        public Nullable<int> AddNiacinRecommendations { get; set; }
        public Nullable<int> AddNiacinMedicalConstraints { get; set; }
        public Nullable<int> AddNiacinReimbursement { get; set; }
        public Nullable<int> NoChangeLCLCReduction { get; set; }
        public Nullable<int> NoChangeReinforce { get; set; }
        public Nullable<int> NoChangeEfficacy { get; set; }
        public Nullable<int> NoChangeStatinDose { get; set; }
        public Nullable<int> NoChangeNewTherapy { get; set; }
        public Nullable<int> NoChangeApprop { get; set; }
        public Nullable<int> NoChangeRiskAssesment { get; set; }
        public Nullable<int> NoChangeDisagree { get; set; }
        public Nullable<int> NoChangePatientRefusal { get; set; }
        public Nullable<int> NoChangeMedicalConstraints { get; set; }
        public Nullable<int> NoChangeAge { get; set; }
        public Nullable<int> NoChangeReimbursement { get; set; }
        public Nullable<int> AddaGlucosidaseInhibitor { get; set; }
        public Nullable<int> AddDPP4Inhibitor { get; set; }
        public Nullable<int> AddGLP1ReceptorAgonist { get; set; }
        public Nullable<int> AddInsulin { get; set; }
        public Nullable<int> AddMeglitinide { get; set; }
        public Nullable<int> AddSGLT2Inhibitor { get; set; }
        public Nullable<int> AddSulfonylurear { get; set; }
        public Nullable<int> AddThiazolidinedione { get; set; }
        public Nullable<int> NochangeCurrentManagement { get; set; }
        public Nullable<int> AddTherapyYes { get; set; }
        public Nullable<int> AddTherapyNo { get; set; }
        public Nullable<int> NoPatientRefusal { get; set; }
        public Nullable<int> NoPatientCantAfford { get; set; }
        public Nullable<int> NoDrugCanBeAdministered { get; set; }
        public Nullable<int> NoPatientRX { get; set; }
        public Nullable<int> NoChangeReinforcingLifeStyle { get; set; }
        public Nullable<int> NoChangeEvaluateEfficacy { get; set; }
        public Nullable<int> NoChangeTitratedMetformin { get; set; }
        public Nullable<int> NoChangeColesevelamOnGlycemia { get; set; }
        public Nullable<int> NoChangeDoNotInitiate { get; set; }
        public Nullable<int> NoChangePatientApprop { get; set; }
        public Nullable<int> NoChangePatientRiskAssesment { get; set; }
        public Nullable<int> NoChangeDisagreeRecommendation { get; set; }
        public Nullable<int> NoChangePatientRefusal2 { get; set; }
        public Nullable<int> NoChangeMedicalConstraints2 { get; set; }
        public Nullable<int> NoChangePatientAge2 { get; set; }
        public Nullable<int> NoChangeReimbursementDifficulties2 { get; set; }
        public string BaseLineLDLC { get; set; }
    }
}