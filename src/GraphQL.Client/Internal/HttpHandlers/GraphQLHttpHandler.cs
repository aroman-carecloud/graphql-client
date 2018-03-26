using System.Net.Http;
using System.Threading;

namespace GraphQL.Client.Internal.HttpHandlers {

	internal class GraphQLHttpHandler : MessageProcessingHandler {

		public GraphQLHttpHandler(HttpMessageHandler innerHandler) : base(innerHandler) {}

		protected override HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken) {
			return request;
		}
		protected override HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken) {
			return response;
		}

	}

}
