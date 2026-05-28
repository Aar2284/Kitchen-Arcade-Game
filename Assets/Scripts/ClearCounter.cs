using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjScriptableObj kitchenObjectSO;
    [SerializeField] private Transform CounterTopPoint;

    public void Interact()
    {
        Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, CounterTopPoint);
        KitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(KitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
