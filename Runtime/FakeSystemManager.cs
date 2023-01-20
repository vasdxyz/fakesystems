using UnityEngine;

namespace Xyz.Vasd.FakeSystems
{
    public class FakeSystemManager : MonoBehaviour
    {
        public FakeSystemGroup[] Groups;

        private void Awake()
        {
            foreach (var group in Groups)
            {
                group.InitSystemGroup();
            }
        }

        private void OnEnable()
        {
            foreach (var group in Groups)
            {
                group.StartAllSystems();
                group.Stage_Start();
            }
        }

        private void Update()
        {
            foreach (var group in Groups)
            {
                group.Stage_Update();
            }
        }

        private void LateUpdate()
        {
            foreach (var group in Groups)
            {
                group.Stage_LateUpdate();
            }
        }

        private void FixedUpdate()
        {
            foreach (var group in Groups)
            {
                group.Stage_Start();
                group.Stage_FixedUpdate();
                group.Stage_Stop();
            }
        }

        private void OnDisable()
        {
            foreach (var group in Groups)
            {
                group.StopAllSystems();
                group.Stage_Stop();
            }
        }
    }
}
