using UnityEngine;

namespace Xyz.Vasd.FakeSystems
{
    public class DefaultFakeSystem : MonoBehaviour, IFakeSystem
    {
        public virtual bool IsSystemActive()
        {
            return isActiveAndEnabled;
        }

        public virtual void OnSystemStart()
        {
        }

        public virtual void OnSystemStop()
        {
        }
    }
}
