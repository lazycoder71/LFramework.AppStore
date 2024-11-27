using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace LFramework.AppStore.Demo
{
    public class Demo : MonoBehaviour
    {
        [Title("Config")]
        [SerializeField] private string _iOSAppStoreID = "6737477778";

        [Title("Reference")]
        [SerializeField] private Button _btnOpenStore;
        [SerializeField] private Button _btnReview;

        private void Start()
        {
            _btnOpenStore.onClick.AddListener(BtnOpenStore_OnClick);
            _btnReview.onClick.AddListener(BtnReview_OnClick);
        }

        private void BtnOpenStore_OnClick()
        {
            AppStore.OpenStore();
        }

        private void BtnReview_OnClick()
        {
#if UNITY_IOS
            AppStore.Review(_iOSAppStoreID);
#else
            AppStore.Review();
#endif
        }
    }
}
