using System.Net;
using FluentAssertions;
using System.Threading.Tasks;
using Medgrupo.Contacts.IntegrationTests.Fixtures;
using Xunit;

namespace Medgrupo.Contacts.IntegrationTests.Scenarios
{
    public class ContactTest
    {
        private readonly TestContext _testContext;
        public ContactTest()
        {
            _testContext = new TestContext();
        }


        [Fact]
        public async Task Contacts_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/v1/contacts");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Contacts_GetById_ContactsReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/v1/contacts/v1/contacts");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Contacts_GetById_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/v1/contacts/XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Contacts_GetById_CorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("/v1/contacts/v1/contactss");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}
