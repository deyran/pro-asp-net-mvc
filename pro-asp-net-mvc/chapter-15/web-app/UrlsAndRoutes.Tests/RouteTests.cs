using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web;

namespace UrlsAndRoutes.Tests
{
    [TestClass]
    public class RouteTests
    {
        /*
        # Chapter 15: URL Routing
        ## Creating and registering a simple route
        ### Using the simple route
        #### UNIT TEST: TESTING INCOMING URLS    
        ##### UNIT TEST CreateHttpContext
         */
        private HttpContextBase CreateHttpContext(string targetUrl = null, string httpMethod = "GET")
        {
            // create the mock request
            Mock<HttpRequestBase> mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(m => m.AppRelativeCurrentExecutionFilePath).Returns(targetUrl);
            mockRequest.Setup(m => m.HttpMethod).Returns(httpMethod);

            // create the mock response
            Mock<HttpResponseBase> mockResponse = new Mock<HttpResponseBase>();
            mockResponse.Setup(m => m.ApplyAppPathModifier(It.IsAny<string>())).Returns<string>(s => s);

            // create the mock context, using the request and response
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(m => m.Request).Returns(mockRequest.Object);
            mockContext.Setup(m => m.Response).Returns(mockResponse.Object);

            // return the mocked context
            return mockContext.Object;
        }
    }
}


