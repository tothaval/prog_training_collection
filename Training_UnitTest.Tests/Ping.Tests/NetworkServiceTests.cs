using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Training_UnitTest.DNS;
using Training_UnitTest.Ping;

namespace Training_UnitTest.Tests.Ping.Tests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dNS;


        public NetworkServiceTests()
        {
            // Dependencies
            _dNS = A.Fake<IDNS>();

            //SUT
            _pingService = new NetworkService(_dNS);
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange - variables, classes, mocks
            A.CallTo(() => _dNS.SendDNS()).Returns(true);

            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange

            //Act
            var result = _pingService.PingTimeout(a, b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDateTime()
        {
            //Arrange - variables, classes, mocks

            //Act
            var result = _pingService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act
            var result = _pingService.GetPingOptions();

            //Assert WARNING: "Be" careful
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.DontFragment.Should().Be(expected.DontFragment);
            result.Ttl.Should().Be(expected.Ttl);
        }

        [Fact]
        public void NetworkService_GetPingOptionsList_ReturnsObject()
        {
            //Arrange

            //Act
            var result = _pingService.GetPingOptionsList();

            //Assert
            result.Should().BeOfType<PingOptions[]>();
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
