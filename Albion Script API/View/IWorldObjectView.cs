namespace Ennui.Api.View
{
    public interface IWorldObjectView : ISimulationObjectView
    {
        bool Click(string collider);

        bool Click();
    }
}
