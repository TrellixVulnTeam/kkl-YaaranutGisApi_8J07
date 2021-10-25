﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeydaTichnunyGisWcf
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MeydaTichnunyGisWcf.IMeydaTichnunyService")]
    public interface IMeydaTichnunyService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getGushHelkaIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getGushHelkaIntersectResponse")]
        string getGushHelkaIntersect(long from_gush, long from_helka, long to_gush, long to_helka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getGushHelkaIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getGushHelkaIntersectResponse")]
        System.Threading.Tasks.Task<string> getGushHelkaIntersectAsync(long from_gush, long from_helka, long to_gush, long to_helka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/loadTasritToSde", ReplyAction="http://tempuri.org/IMeydaTichnunyService/loadTasritToSdeResponse")]
        string loadTasritToSde(string fileName, long planId, string planNum, System.DateTime tasritDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/loadTasritToSde", ReplyAction="http://tempuri.org/IMeydaTichnunyService/loadTasritToSdeResponse")]
        System.Threading.Tasks.Task<string> loadTasritToSdeAsync(string fileName, long planId, string planNum, System.DateTime tasritDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getPlanIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getPlanIntersectResponse")]
        string getPlanIntersect(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getPlanIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getPlanIntersectResponse")]
        System.Threading.Tasks.Task<string> getPlanIntersectAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanIdResponse")]
        string getAreasByPlanId(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanIdResponse")]
        System.Threading.Tasks.Task<string> getAreasByPlanIdAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId8Groups", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId8GroupsResponse")]
        string getAreasByPlanId8Groups(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId8Groups", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getAreasByPlanId8GroupsResponse")]
        System.Threading.Tasks.Task<string> getAreasByPlanId8GroupsAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getGushIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getGushIntersectResponse")]
        string getGushIntersect(long from_gush, long to_gush);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getGushIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getGushIntersectResponse")]
        System.Threading.Tasks.Task<string> getGushIntersectAsync(long from_gush, long to_gush);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getHelkaIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getHelkaIntersectResponse")]
        string getHelkaIntersect(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getHelkaIntersect", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getHelkaIntersectResponse")]
        System.Threading.Tasks.Task<string> getHelkaIntersectAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumAreaDesignationByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumAreaDesignationByPlanIdResponse")]
        string getSumAreaDesignationByPlanId(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumAreaDesignationByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumAreaDesignationByPlanIdResponse")]
        System.Threading.Tasks.Task<string> getSumAreaDesignationByPlanIdAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumForestReserveByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumForestReserveByPlanIdResponse")]
        string getSumForestReserveByPlanId(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumForestReserveByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumForestReserveByPlanIdResponse")]
        System.Threading.Tasks.Task<string> getSumForestReserveByPlanIdAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumPlantedForestByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumPlantedForestByPlanIdResponse")]
        string getSumPlantedForestByPlanId(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/getSumPlantedForestByPlanId", ReplyAction="http://tempuri.org/IMeydaTichnunyService/getSumPlantedForestByPlanIdResponse")]
        System.Threading.Tasks.Task<string> getSumPlantedForestByPlanIdAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/isPlanIsExist", ReplyAction="http://tempuri.org/IMeydaTichnunyService/isPlanIsExistResponse")]
        string isPlanIsExist(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/isPlanIsExist", ReplyAction="http://tempuri.org/IMeydaTichnunyService/isPlanIsExistResponse")]
        System.Threading.Tasks.Task<string> isPlanIsExistAsync(long planId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/GetMapViewerUrl", ReplyAction="http://tempuri.org/IMeydaTichnunyService/GetMapViewerUrlResponse")]
        string GetMapViewerUrl();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeydaTichnunyService/GetMapViewerUrl", ReplyAction="http://tempuri.org/IMeydaTichnunyService/GetMapViewerUrlResponse")]
        System.Threading.Tasks.Task<string> GetMapViewerUrlAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMeydaTichnunyServiceChannel : MeydaTichnunyGisWcf.IMeydaTichnunyService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MeydaTichnunyServiceClient : System.ServiceModel.ClientBase<MeydaTichnunyGisWcf.IMeydaTichnunyService>, MeydaTichnunyGisWcf.IMeydaTichnunyService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MeydaTichnunyServiceClient() : 
                base(MeydaTichnunyServiceClient.GetDefaultBinding(), MeydaTichnunyServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMeydaTichnunyService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MeydaTichnunyServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MeydaTichnunyServiceClient.GetBindingForEndpoint(endpointConfiguration), MeydaTichnunyServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MeydaTichnunyServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MeydaTichnunyServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MeydaTichnunyServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MeydaTichnunyServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MeydaTichnunyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string getGushHelkaIntersect(long from_gush, long from_helka, long to_gush, long to_helka)
        {
            return base.Channel.getGushHelkaIntersect(from_gush, from_helka, to_gush, to_helka);
        }
        
        public System.Threading.Tasks.Task<string> getGushHelkaIntersectAsync(long from_gush, long from_helka, long to_gush, long to_helka)
        {
            return base.Channel.getGushHelkaIntersectAsync(from_gush, from_helka, to_gush, to_helka);
        }
        
        public string loadTasritToSde(string fileName, long planId, string planNum, System.DateTime tasritDate)
        {
            return base.Channel.loadTasritToSde(fileName, planId, planNum, tasritDate);
        }
        
        public System.Threading.Tasks.Task<string> loadTasritToSdeAsync(string fileName, long planId, string planNum, System.DateTime tasritDate)
        {
            return base.Channel.loadTasritToSdeAsync(fileName, planId, planNum, tasritDate);
        }
        
        public string getPlanIntersect(long planId)
        {
            return base.Channel.getPlanIntersect(planId);
        }
        
        public System.Threading.Tasks.Task<string> getPlanIntersectAsync(long planId)
        {
            return base.Channel.getPlanIntersectAsync(planId);
        }
        
        public string getAreasByPlanId(long planId)
        {
            return base.Channel.getAreasByPlanId(planId);
        }
        
        public System.Threading.Tasks.Task<string> getAreasByPlanIdAsync(long planId)
        {
            return base.Channel.getAreasByPlanIdAsync(planId);
        }
        
        public string getAreasByPlanId8Groups(long planId)
        {
            return base.Channel.getAreasByPlanId8Groups(planId);
        }
        
        public System.Threading.Tasks.Task<string> getAreasByPlanId8GroupsAsync(long planId)
        {
            return base.Channel.getAreasByPlanId8GroupsAsync(planId);
        }
        
        public string getGushIntersect(long from_gush, long to_gush)
        {
            return base.Channel.getGushIntersect(from_gush, to_gush);
        }
        
        public System.Threading.Tasks.Task<string> getGushIntersectAsync(long from_gush, long to_gush)
        {
            return base.Channel.getGushIntersectAsync(from_gush, to_gush);
        }
        
        public string getHelkaIntersect(string xml)
        {
            return base.Channel.getHelkaIntersect(xml);
        }
        
        public System.Threading.Tasks.Task<string> getHelkaIntersectAsync(string xml)
        {
            return base.Channel.getHelkaIntersectAsync(xml);
        }
        
        public string getSumAreaDesignationByPlanId(long planId)
        {
            return base.Channel.getSumAreaDesignationByPlanId(planId);
        }
        
        public System.Threading.Tasks.Task<string> getSumAreaDesignationByPlanIdAsync(long planId)
        {
            return base.Channel.getSumAreaDesignationByPlanIdAsync(planId);
        }
        
        public string getSumForestReserveByPlanId(long planId)
        {
            return base.Channel.getSumForestReserveByPlanId(planId);
        }
        
        public System.Threading.Tasks.Task<string> getSumForestReserveByPlanIdAsync(long planId)
        {
            return base.Channel.getSumForestReserveByPlanIdAsync(planId);
        }
        
        public string getSumPlantedForestByPlanId(long planId)
        {
            return base.Channel.getSumPlantedForestByPlanId(planId);
        }
        
        public System.Threading.Tasks.Task<string> getSumPlantedForestByPlanIdAsync(long planId)
        {
            return base.Channel.getSumPlantedForestByPlanIdAsync(planId);
        }
        
        public string isPlanIsExist(long planId)
        {
            return base.Channel.isPlanIsExist(planId);
        }
        
        public System.Threading.Tasks.Task<string> isPlanIsExistAsync(long planId)
        {
            return base.Channel.isPlanIsExistAsync(planId);
        }
        
        public string GetMapViewerUrl()
        {
            return base.Channel.GetMapViewerUrl();
        }
        
        public System.Threading.Tasks.Task<string> GetMapViewerUrlAsync()
        {
            return base.Channel.GetMapViewerUrlAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMeydaTichnunyService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMeydaTichnunyService))
            {
                return new System.ServiceModel.EndpointAddress("http://kkl-arcsrv2tst/WcfGisServicesTest/MeydaTichnunyService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MeydaTichnunyServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMeydaTichnunyService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MeydaTichnunyServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMeydaTichnunyService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMeydaTichnunyService,
        }
    }
}
