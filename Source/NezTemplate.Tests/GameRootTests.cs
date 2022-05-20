using NUnit.Framework;

namespace NezTemplate.Tests;

public class GameRootTests
{
    private GameRoot? _gameRoot;

    [SetUp]
    public void Setup()
    {
        _gameRoot = new GameRoot();
    }

    [TearDown]
    public void Cleanup()
    {
        _gameRoot!.Dispose();
    }

    [Test]
    public void RunTest()
    {
        Assert.DoesNotThrow(() => _gameRoot!.Run());
    }
}