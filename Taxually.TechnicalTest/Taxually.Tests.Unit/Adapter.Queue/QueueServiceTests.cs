using FluentAssertions;
using Taxually.Adapter.Queue;

namespace Taxually.Tests.Unit.Adapter.Queue
{
    public class QueueServiceTests
    {
        private QueueService _queueService;

        [SetUp]
        public void Init()
        {
            _queueService = new QueueService();
        }

        [Test]
        public async Task EnqueueAsync_WhenCalled_ShouldNotThrowException()
        {
            var act = () => _queueService.EnqueueAsync("test", string.Empty);

            await act.Should().NotThrowAsync();
        }
    }
}
