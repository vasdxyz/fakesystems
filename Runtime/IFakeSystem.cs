namespace Xyz.Vasd.FakeSystems
{
    public interface IFakeSystem
    {
        bool IsSystemActive();
        void OnSystemStart();
        void OnSystemStop();
    }

    public interface IUpdateFakeSystem : IFakeSystem
    {
        void OnSystemUpdate();
    }

    public interface ILateUpdateFakeSystem : IFakeSystem
    {
        void OnSystemLateUpdate();
    }

    public interface IFixedUpdateFakeSystem : IFakeSystem
    {
        void OnSystemFixedUpdate();
    }
}
