using System.Net.Http;
using System.Threading;

namespace GraphQL.Client.Internal.HttpHandlers {

	internal class GraphQLHttpHandler : MessageProcessingHandler {

		public HttpClient HttpClient { get; }

		public GraphQLClientOptions Options { get; set; }

		public GraphQLHttpHandler(GraphQLClientOptions options) : base(options.HttpMessageHandler) {
			this.HttpClient = new HttpClient(this.InnerHandler);
			this.Options = options;
		}

		protected override HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken) {
			return request;
		}
		protected override HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken) {
			return response;
		}

	}

}
