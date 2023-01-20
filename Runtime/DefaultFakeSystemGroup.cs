namespace Xyz.Vasd.FakeSystems
{
    public class DefaultFakeSystemGroup : FakeSystemGroup
    {
        public DefaultFakeSystem[] Systems;

        public override void InitSystemGroup()
        {
            foreach (var system in Systems)
            {
                AddSystem(system);
            }
        }
    }
}
