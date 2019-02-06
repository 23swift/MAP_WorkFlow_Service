﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAP_FrontEnd.MAS_MainFlow {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MAS_MainFlow.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadRequest", ReplyAction="http://tempuri.org/IService/LoadRequestResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string LoadRequest(int inRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadRequest", ReplyAction="http://tempuri.org/IService/LoadRequestResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> LoadRequestAsync(int inRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AOChecking", ReplyAction="http://tempuri.org/IService/AOCheckingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string AOChecking(int inRequestId, bool inIsComplete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AOChecking", ReplyAction="http://tempuri.org/IService/AOCheckingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> AOCheckingAsync(int inRequestId, bool inIsComplete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToAOChecker", ReplyAction="http://tempuri.org/IService/SubmitToAOCheckerResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string SubmitToAOChecker(int inRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToAOChecker", ReplyAction="http://tempuri.org/IService/SubmitToAOCheckerResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> SubmitToAOCheckerAsync(int inRequestId);
        
        // CODEGEN: Generating message contract since the operation SubmitToMAUChecker is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToMAUChecker", ReplyAction="http://tempuri.org/IService/SubmitToMAUCheckerResponse")]
        MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse SubmitToMAUChecker(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToMAUChecker", ReplyAction="http://tempuri.org/IService/SubmitToMAUCheckerResponse")]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse> SubmitToMAUCheckerAsync(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest request);
        
        // CODEGEN: Generating message contract since the operation SubmitToMAUScreening is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToMAUScreening", ReplyAction="http://tempuri.org/IService/SubmitToMAUScreeningResponse")]
        MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse SubmitToMAUScreening(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitToMAUScreening", ReplyAction="http://tempuri.org/IService/SubmitToMAUScreeningResponse")]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse> SubmitToMAUScreeningAsync(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PreScreenDecission", ReplyAction="http://tempuri.org/IService/PreScreenDecissionResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string PreScreenDecission(int paramRequestId, bool paramIsPassedScreening);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PreScreenDecission", ReplyAction="http://tempuri.org/IService/PreScreenDecissionResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> PreScreenDecissionAsync(int paramRequestId, bool paramIsPassedScreening);
        
        // CODEGEN: Generating message contract since the operation CheckPOSRequest is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPOSRequest", ReplyAction="http://tempuri.org/IService/CheckPOSRequestResponse")]
        MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse CheckPOSRequest(MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPOSRequest", ReplyAction="http://tempuri.org/IService/CheckPOSRequestResponse")]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse> CheckPOSRequestAsync(MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CompleteRequest", ReplyAction="http://tempuri.org/IService/CompleteRequestResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string CompleteRequest(int paramRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CompleteRequest", ReplyAction="http://tempuri.org/IService/CompleteRequestResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> CompleteRequestAsync(int paramRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/QualityApproval", ReplyAction="http://tempuri.org/IService/QualityApprovalResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string QualityApproval(int inRequestId, bool _isApproved);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/QualityApproval", ReplyAction="http://tempuri.org/IService/QualityApprovalResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> QualityApprovalAsync(int inRequestId, bool _isApproved);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FinalApproval", ReplyAction="http://tempuri.org/IService/FinalApprovalResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string FinalApproval(int inRequestId, bool inApproved, string inApprover, string inApproverRank);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FinalApproval", ReplyAction="http://tempuri.org/IService/FinalApprovalResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> FinalApprovalAsync(int inRequestId, bool inApproved, string inApprover, string inApproverRank);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PickRequestForMDCSProcessing", ReplyAction="http://tempuri.org/IService/PickRequestForMDCSProcessingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string PickRequestForMDCSProcessing(int inRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PickRequestForMDCSProcessing", ReplyAction="http://tempuri.org/IService/PickRequestForMDCSProcessingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> PickRequestForMDCSProcessingAsync(int inRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitForPOSProcessing", ReplyAction="http://tempuri.org/IService/SubmitForPOSProcessingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string SubmitForPOSProcessing(int paramRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SubmitForPOSProcessing", ReplyAction="http://tempuri.org/IService/SubmitForPOSProcessingResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> SubmitForPOSProcessingAsync(int paramRequestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestApproval", ReplyAction="RequestApproval")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        string RequestApproval(int inRequestId, bool inApproved, string inApprover, string inApproverRank);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestApproval", ReplyAction="RequestApproval")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outMsg")]
        System.Threading.Tasks.Task<string> RequestApprovalAsync(int inRequestId, bool inApproved, string inApprover, string inApproverRank);
        
        // CODEGEN: Generating message contract since the operation ReturnToMakerFormApproval is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnToMakerFormApproval", ReplyAction="http://tempuri.org/IService/ReturnToMakerFormApprovalResponse")]
        MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse ReturnToMakerFormApproval(MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnToMakerFormApproval", ReplyAction="http://tempuri.org/IService/ReturnToMakerFormApprovalResponse")]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse> ReturnToMakerFormApprovalAsync(MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SubmitToMAUChecker", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SubmitToMAUCheckerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int inRequestId;
        
        public SubmitToMAUCheckerRequest() {
        }
        
        public SubmitToMAUCheckerRequest(int inRequestId) {
            this.inRequestId = inRequestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitToMAUCheckerResponse {
        
        public SubmitToMAUCheckerResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SubmitToMAUScreening", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SubmitToMAUScreeningRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int inRequestId;
        
        public SubmitToMAUScreeningRequest() {
        }
        
        public SubmitToMAUScreeningRequest(int inRequestId) {
            this.inRequestId = inRequestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitToMAUScreeningResponse {
        
        public SubmitToMAUScreeningResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckPOSRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckPOSRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int paramRequestId;
        
        public CheckPOSRequestRequest() {
        }
        
        public CheckPOSRequestRequest(int paramRequestId) {
            this.paramRequestId = paramRequestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckPOSRequestResponse {
        
        public CheckPOSRequestResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReturnToMakerFormApproval", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ReturnToMakerFormApprovalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int inRequestId;
        
        public ReturnToMakerFormApprovalRequest() {
        }
        
        public ReturnToMakerFormApprovalRequest(int inRequestId) {
            this.inRequestId = inRequestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReturnToMakerFormApprovalResponse {
        
        public ReturnToMakerFormApprovalResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MAP_FrontEnd.MAS_MainFlow.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MAP_FrontEnd.MAS_MainFlow.IService>, MAP_FrontEnd.MAS_MainFlow.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string LoadRequest(int inRequestId) {
            return base.Channel.LoadRequest(inRequestId);
        }
        
        public System.Threading.Tasks.Task<string> LoadRequestAsync(int inRequestId) {
            return base.Channel.LoadRequestAsync(inRequestId);
        }
        
        public string AOChecking(int inRequestId, bool inIsComplete) {
            return base.Channel.AOChecking(inRequestId, inIsComplete);
        }
        
        public System.Threading.Tasks.Task<string> AOCheckingAsync(int inRequestId, bool inIsComplete) {
            return base.Channel.AOCheckingAsync(inRequestId, inIsComplete);
        }
        
        public string SubmitToAOChecker(int inRequestId) {
            return base.Channel.SubmitToAOChecker(inRequestId);
        }
        
        public System.Threading.Tasks.Task<string> SubmitToAOCheckerAsync(int inRequestId) {
            return base.Channel.SubmitToAOCheckerAsync(inRequestId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse MAP_FrontEnd.MAS_MainFlow.IService.SubmitToMAUChecker(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest request) {
            return base.Channel.SubmitToMAUChecker(request);
        }
        
        public void SubmitToMAUChecker(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest inValue = new MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest();
            inValue.inRequestId = inRequestId;
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse retVal = ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).SubmitToMAUChecker(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse> MAP_FrontEnd.MAS_MainFlow.IService.SubmitToMAUCheckerAsync(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest request) {
            return base.Channel.SubmitToMAUCheckerAsync(request);
        }
        
        public System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerResponse> SubmitToMAUCheckerAsync(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest inValue = new MAP_FrontEnd.MAS_MainFlow.SubmitToMAUCheckerRequest();
            inValue.inRequestId = inRequestId;
            return ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).SubmitToMAUCheckerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse MAP_FrontEnd.MAS_MainFlow.IService.SubmitToMAUScreening(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest request) {
            return base.Channel.SubmitToMAUScreening(request);
        }
        
        public void SubmitToMAUScreening(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest inValue = new MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest();
            inValue.inRequestId = inRequestId;
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse retVal = ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).SubmitToMAUScreening(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse> MAP_FrontEnd.MAS_MainFlow.IService.SubmitToMAUScreeningAsync(MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest request) {
            return base.Channel.SubmitToMAUScreeningAsync(request);
        }
        
        public System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningResponse> SubmitToMAUScreeningAsync(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest inValue = new MAP_FrontEnd.MAS_MainFlow.SubmitToMAUScreeningRequest();
            inValue.inRequestId = inRequestId;
            return ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).SubmitToMAUScreeningAsync(inValue);
        }
        
        public string PreScreenDecission(int paramRequestId, bool paramIsPassedScreening) {
            return base.Channel.PreScreenDecission(paramRequestId, paramIsPassedScreening);
        }
        
        public System.Threading.Tasks.Task<string> PreScreenDecissionAsync(int paramRequestId, bool paramIsPassedScreening) {
            return base.Channel.PreScreenDecissionAsync(paramRequestId, paramIsPassedScreening);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse MAP_FrontEnd.MAS_MainFlow.IService.CheckPOSRequest(MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest request) {
            return base.Channel.CheckPOSRequest(request);
        }
        
        public void CheckPOSRequest(int paramRequestId) {
            MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest inValue = new MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest();
            inValue.paramRequestId = paramRequestId;
            MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse retVal = ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).CheckPOSRequest(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse> MAP_FrontEnd.MAS_MainFlow.IService.CheckPOSRequestAsync(MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest request) {
            return base.Channel.CheckPOSRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestResponse> CheckPOSRequestAsync(int paramRequestId) {
            MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest inValue = new MAP_FrontEnd.MAS_MainFlow.CheckPOSRequestRequest();
            inValue.paramRequestId = paramRequestId;
            return ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).CheckPOSRequestAsync(inValue);
        }
        
        public string CompleteRequest(int paramRequestId) {
            return base.Channel.CompleteRequest(paramRequestId);
        }
        
        public System.Threading.Tasks.Task<string> CompleteRequestAsync(int paramRequestId) {
            return base.Channel.CompleteRequestAsync(paramRequestId);
        }
        
        public string QualityApproval(int inRequestId, bool _isApproved) {
            return base.Channel.QualityApproval(inRequestId, _isApproved);
        }
        
        public System.Threading.Tasks.Task<string> QualityApprovalAsync(int inRequestId, bool _isApproved) {
            return base.Channel.QualityApprovalAsync(inRequestId, _isApproved);
        }
        
        public string FinalApproval(int inRequestId, bool inApproved, string inApprover, string inApproverRank) {
            return base.Channel.FinalApproval(inRequestId, inApproved, inApprover, inApproverRank);
        }
        
        public System.Threading.Tasks.Task<string> FinalApprovalAsync(int inRequestId, bool inApproved, string inApprover, string inApproverRank) {
            return base.Channel.FinalApprovalAsync(inRequestId, inApproved, inApprover, inApproverRank);
        }
        
        public string PickRequestForMDCSProcessing(int inRequestId) {
            return base.Channel.PickRequestForMDCSProcessing(inRequestId);
        }
        
        public System.Threading.Tasks.Task<string> PickRequestForMDCSProcessingAsync(int inRequestId) {
            return base.Channel.PickRequestForMDCSProcessingAsync(inRequestId);
        }
        
        public string SubmitForPOSProcessing(int paramRequestId) {
            return base.Channel.SubmitForPOSProcessing(paramRequestId);
        }
        
        public System.Threading.Tasks.Task<string> SubmitForPOSProcessingAsync(int paramRequestId) {
            return base.Channel.SubmitForPOSProcessingAsync(paramRequestId);
        }
        
        public string RequestApproval(int inRequestId, bool inApproved, string inApprover, string inApproverRank) {
            return base.Channel.RequestApproval(inRequestId, inApproved, inApprover, inApproverRank);
        }
        
        public System.Threading.Tasks.Task<string> RequestApprovalAsync(int inRequestId, bool inApproved, string inApprover, string inApproverRank) {
            return base.Channel.RequestApprovalAsync(inRequestId, inApproved, inApprover, inApproverRank);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse MAP_FrontEnd.MAS_MainFlow.IService.ReturnToMakerFormApproval(MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest request) {
            return base.Channel.ReturnToMakerFormApproval(request);
        }
        
        public void ReturnToMakerFormApproval(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest inValue = new MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest();
            inValue.inRequestId = inRequestId;
            MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse retVal = ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).ReturnToMakerFormApproval(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse> MAP_FrontEnd.MAS_MainFlow.IService.ReturnToMakerFormApprovalAsync(MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest request) {
            return base.Channel.ReturnToMakerFormApprovalAsync(request);
        }
        
        public System.Threading.Tasks.Task<MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalResponse> ReturnToMakerFormApprovalAsync(int inRequestId) {
            MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest inValue = new MAP_FrontEnd.MAS_MainFlow.ReturnToMakerFormApprovalRequest();
            inValue.inRequestId = inRequestId;
            return ((MAP_FrontEnd.MAS_MainFlow.IService)(this)).ReturnToMakerFormApprovalAsync(inValue);
        }
    }
}
