using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQL.Client.Internal.HttpHandlers {

	internal class GraphQLHttpHandler : DelegatingHandler {

		public GraphQLHttpHandler(HttpMessageHandler innerHandler) : base(innerHandler) {}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => base.SendAsync(request, cancellationToken);

	}

}
