using ServiceStack;
using CustomBatchedRequestsMetadata.ServiceModel;

namespace CustomBatchedRequestsMetadata.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        public object Any(Hello[] requests)
        {
            return requests.Map(request => new HelloResponse { Result = $"Hello, {request.Name}!" });
        }
    }
}