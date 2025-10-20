using UnityEngine;
using UnityEngine.UI;

public class InventoryViewItem : MonoBehaviour
{
//     [SerializeField] private Image itemImage;
//     [SerializeField] private Image durabilityImage;
//     [SerializeField] private Color availableColor =  Color.grey;
//
//     public bool IsAvailable = true;
//
//     private void Awake()
//     {
//         if (IsAvailable)
//         {
//             ResetView();
//         }
//     }
//
//     public void InitView(Item item)
//     {
//         IsAvailable = false;
//         itemImage.sprite = item.Definition.Sprite;
//         itemImage.color = Color.white;
//         durabilityImage.transform.parent.gameObject.SetActive(true);
//         durabilityImage.fillAmount = item.Durability/item.Definition.BaseDurability;
//     }
//     
//     public void UpdateView(Item item)
//     {
//         durabilityImage.fillAmount = item.Durability/item.Definition.BaseDurability;
//     }
//
//     public void ResetView()
//     {
//         itemImage.sprite = null;
//         itemImage.color = availableColor;
//         durabilityImage.transform.parent.gameObject.SetActive(false);
//         IsAvailable = true;
//     }
}
