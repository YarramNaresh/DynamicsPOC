//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\jkrishnan\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\DLaB.EarlyBoundGenerator\crmsvcutil.exe" /url:"https://winpilot.api.crm8.dynamics.com/XRMServices/2011/Organization.svc" /namespace:"SolutionConstants" /out:"C:\Users\jkrishnan\AppData\Roaming\MscrmTools\XrmToolBox\Settings\EBG\OptionSets.cs" /codecustomization:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.OptionSet.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.NamingService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.BaseMetadataProviderService,DLaB.CrmSvcUtilExtensions" /username:"Pilot@WinPilot.onmicrosoft.com" /password:"********" 
//------------------------------------------------------------------------------

namespace SolutionConstants
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum Solution_SolutionType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Internal = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Snapshot = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_deploymentinstance_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_mastersolutions_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_mergesolutions_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_solutiondetail_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_solutiondetail_syed_IsMaster
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		No = 433710000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Yes = 433710001,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_sourcecontrolqueue_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum syed_sourcecontrolqueue_syed_overwritesolutionstxt
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		No = 433710001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Yes = 433710000,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum msdyn_msdyn_requirementrelationship_msdyn_resourcegroupings
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		OrganizationalUnit = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		RelatedResourcePools = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Location = 192350002,
	}
}
