﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Text;

using static YaaranutGisApi.Controllers.GisWorkUnitModel;
using Microsoft.AspNetCore.Cors;

namespace YaaranutGisApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("CorsAll")]
    public class WorkUnitController : BaseController
    {
        public WorkUnitController(YaaranutGisApi.IAppSettings appSettings, IGisApiHelper GisApiHelper) : base(appSettings, GisApiHelper) { }

        [HttpGet]
        [Route("GetWorkUnitTipul")]
        public string GetWorkUnitTipul()
        {
            //IList<WorkUnitModel> WorkUnits = new List<WorkUnitModel>();
            //string queryWhare = "FOR_NO=3303";

            //var reqparmForest = new System.Collections.Specialized.NameValueCollection
            //    {
            //        {"where", queryWhare },
            //        {"outFields", "OBJECTID,FOR_Name,WorkYear,TRTUnit,WPFSRequestStatus,DistrictName,RegionName,FOR_NO,AgeGr,ForAgeComposition,CurForestType,CurDensity,CurCover,ForStatusMain,AreaDesignation,ReqForestType,VegDesignPrinc,ThinningPurpose,OtherThinningPurpose,ThinFreq,ReqDensity,ReqCover,ThinIntensity,ThinType,PruningType,BurnPermission,WPFSWorkEssence"},
            //        {"returnGeometry", "true"},
            //        {"returnExceededLimitFeatures", "true"},
            //        //{"orderByFields", "objectid"},
            //        {"token", this.GisApiHelper.GetToken()},
            //        {"f", "json"},
            //        {"geometryType","esriGeometryPoint"},
            //        {"spatialRel","esriSpatialRelIntersects"}
            //    };

            //var rrr = this.GisApiHelper.GetFeatures("KKLForestManagementUnits", 0, reqparmForest);
            //var Gisfeatures = System.Text.Json.JsonSerializer.Deserialize<GisWorkUnitModel>(rrr);

            //return rrr;
            string responsebodyForest;
            using (WebClient clientForest = new WebClient())
            {
                byte[] responsebytesForest = clientForest.UploadValues("https://services2.arcgis.com/utNNrmXb4IZOLXXs/arcgis/rest/services/JNFFieldCenterBuildingsPublicView/FeatureServer/0", "POST", null);
                responsebodyForest = Encoding.UTF8.GetString(responsebytesForest);
            }
            return responsebodyForest;
        }
        [HttpGet]
        [Route("CheckTest")]
        public IEnumerable<string> CheckTest()
        {
            string ApiParm;
            ApiParm = @" { ""DistrictName"": ""מרכז"", ""FOR_NO"": null, ""OBJECTID"": null , ""RegionName"": null, ""TRTUnit"": """", ""WorkYear"": """", ""WPFSRequestStatus"": """"}";
            ApiParm = @"{ ""DistrictName"": """" , ""FOR_NO"":  """" , ""OBJECTID"":null, ""RegionName"":""גליל עליון - רמת הגולן"" , ""TRTUnit"": """" , ""WorkYear"":""2020"" , ""WPFSRequestStatus"": ""אושר על ידי מחלקת יער""}";
            var QueryParmeters = System.Text.Json.JsonSerializer.Deserialize<WorkUnitModelQueryParameter>(ApiParm);
            using (var stringContent = new StringContent(ApiParm, System.Text.Encoding.UTF8, "application/json"))
            using (var client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:27552/WorkUnit/GetWorkUnits", stringContent).Result;
                var listOfWorkUnit = response.Content.ReadAsStringAsync().Result;

            }

            return new string[] { "aaa", "bbb" };
        }
        [HttpPost]
        [Route("GetWorkUnits")]
        public async Task<ActionResult<IEnumerable<WorkUnitModel>>> GetWorkUnits(  WorkUnitModelQueryParameter QueryParmeters)
        {
            //var az = @" { ""DistrictName"": null, ""FOR_NO"": null, ""OBJECTID"": null , ""RegionName"": null, ""TRTUnit"": ""T12551"", ""WorkYear"": ""2020"", ""WPFSRequestStatus"": ""אושר על ידי מחלקת יער""} ";
            //QueryParmeters = System.Text.Json.JsonSerializer.Deserialize<WorkUnitModelQueryParameter>(az);
            IList<WorkUnitModel> WorkUnits = new List<WorkUnitModel>();
            string queryWhare = "1=1";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.OBJECTID.ToString()) ? " and OBJECTID=" + QueryParmeters.OBJECTID : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.WorkYear) ? " and WorkYear='" + QueryParmeters.WorkYear + "'" : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.WPFSRequestStatus) ? " and WPFSRequestStatus='" + QueryParmeters.WPFSRequestStatus + "'" : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.DistrictName) ? " and DistrictName='" + QueryParmeters.DistrictName + "'" : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.RegionName) ? " and RegionName='" + QueryParmeters.RegionName + "'" : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.FOR_NO) ? " and FOR_NO='" + QueryParmeters.FOR_NO + "'" : "";
            queryWhare += !String.IsNullOrEmpty(QueryParmeters.TRTUNIT) ? " and TRTUNIT='" + QueryParmeters.TRTUNIT + "'" : "";
             
            var reqparmForest = new System.Collections.Specialized.NameValueCollection
                {
                    {"where", queryWhare },
                    //{"where", "ObjectId=7099"},
                    //{"where", "ObjectID>=6133"},
                    //{ "where",@"FOR_Name='עמק יזרעאל'"},
                    
                    {"outFields", "OBJECTID,FOR_Name,WorkYear,TRTUnit,WPFSRequestStatus,DistrictName,RegionName,FOR_NO,AgeGr,ForAgeComposition,CurForestType,CurDensity,CurCover,ForStatusMain,AreaDesignation,ReqForestType,VegDesignPrinc,ThinningPurpose,OtherThinningPurpose,ThinFreq,ReqDensity,ReqCover,ThinIntensity,ThinType,PruningType,BurnPermission,WPFSWorkEssence"},
                    {"returnGeometry", "false"},
                    {"returnExceededLimitFeatures", "true"},
                    //{"orderByFields", "objectid"},
                    {"token", this.GisApiHelper.GetToken()},
                    {"f", "json"},
                    {"geometryType","esriGeometryPoint"},
                    //{"geometry",11+","+22},
                    //{"inSR","4326"}
                    //{"spatialRel","esriSpatialRelIntersects"}
                };

            
            var Gisfeatures = System.Text.Json.JsonSerializer.Deserialize<GisWorkUnitModel>(this.GisApiHelper.GetFeatures("KKLForestManagementUnits",0, reqparmForest));
            if (Gisfeatures.error == null)
            {
                foreach (var item in Gisfeatures.features)
                {
                    WorkUnits.Add(item.attributes);
                }
                return Ok(WorkUnits);
            }
            else
            {
                return StatusCode(500, Gisfeatures.error.message + " " + Gisfeatures.error.details[0] + " where:" + reqparmForest.GetValues("where")[0] + " Fields:" + reqparmForest.GetValues("outFields")[0]);
            }
        }
    }

    public class GisWorkUnitModel : GisModel
    {      
        public Features[] features { get; set; }
        public class Features
        {
            public Attributes attributes { get; set; }
        }
        public class Attributes:WorkUnitModel
        {            
        }
        public class WorkUnitModel
        {
            public int? OBJECTID { get; set; }
            public string FOR_Name { get; set; }       
            public int WorkYear { get; set; }
            public string TRTUnit { get; set; }
            public string WPFSRequestStatus { get; set; }
            public string DistrictName { get; set; }
            public string RegionName { get; set; }
            public string FOR_NO { get; set; }
            public string ForAgeComposition { get; set; }
            public string CurForestType { get; set; }
            public string CurDensity { get; set; }
            public string CurCover { get; set; }
            public string ForStatusMain { get; set; }
            public string AreaDesignation { get; set; }
            public string ReqForestType { get; set; }
            public string VegDesignPrinc { get; set; }
            public string ThinningPurpose { get; set; }
            public string OtherThinningPurpose { get; set; }
            public string ThinFreq { get; set; }
            public string ReqDensity { get; set; }
            public string ReqCover { get; set; }
            public string ThinIntensity { get; set; }
            public string ThinType { get; set; }
            public string PruningType { get; set; }
            public string BurnPermission { get; set; }
            public string WPFSWorkEssence { get; set; }
            public string Date { get; set; }
            public string ReporterName { get; set; }
            public string TRTPriority { get; set; }
            public string OtherCurForestType { get; set; }
            public string Stands { get; set; }
        }
    }
    public class WorkUnitModelQueryParameter 
    {
        public int? OBJECTID { get; set; }
        public string WorkYear { get; set; }
        public string WPFSRequestStatus { get; set; }
        public string DistrictName { get; set; }
        public string RegionName { get; set; }
        public string FOR_NO { get; set; }
        public string TRTUNIT { get; set; }

    }
}
