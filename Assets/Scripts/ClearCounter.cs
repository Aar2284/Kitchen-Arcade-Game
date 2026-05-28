using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjScriptableObj kitchenObjectSO;
    [SerializeField] private Transform CounterTopPoint;

    private KitchenObject kitchenObject;
    
    public void Interact(Player player)
    {
        if(kitchenObject == null)
        {
            Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, CounterTopPoint);
            KitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }

        else
        {
            //Give object to the PLayer
            kitchenObject.SetKitchenObjectParent(player);
        }  
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return CounterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    
    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
