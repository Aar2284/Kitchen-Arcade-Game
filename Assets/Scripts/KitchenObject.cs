using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjScriptableObj kitchenObjectSO;

    public KitchenObjScriptableObj GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }
}
