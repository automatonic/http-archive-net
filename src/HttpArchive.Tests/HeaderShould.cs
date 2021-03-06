using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Header"/> object
    /// </summary>
    public class HeaderShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
    ""name"": ""Accept-Encoding"",
    ""value"": ""gzip,deflate"",
    ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Header>(json);
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("Accept-Encoding");
            deserialized.Value.Should().Be("gzip,deflate");
            deserialized.Comment.Should().Be("");
        }


        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Header>(
                JsonSerializer.Serialize(new Header()));
            deserialized.Name.Should().Be("");
            deserialized.Value.Should().Be("");
            deserialized.Comment.Should().BeNull();
        }
    }
}
