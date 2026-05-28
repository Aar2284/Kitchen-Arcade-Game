using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjScriptableObj kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, GetKitchenObjectFollowTransform());
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }
        else
        {
            // There is a KitchenObject here
            GetKitchenObject().SetKitchenObjectParent(player);
        }
    }
}