using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class InventoryViewManager : MonoBehaviour
{
//     private object _inventoryInstance;
//     private FieldInfo _itemsField;
//
//     private readonly List<object> _previousItems = new();
//     private readonly Dictionary<object, ItemInventoryView> _activeViews = new();
//     private List<ItemInventoryView> _availableSlots;
//
//     private void Awake()
//     {
//         _availableSlots = GetComponentsInChildren<ItemInventoryView>().ToList();
//         _availableSlots = _availableSlots.OrderBy(x => x.transform.position.x).ToList();
//     }
//
//     private void Start()
//     {
//         // Locate BasicInventory instance and private field 'items'
//         var inventoryType = typeof(BasicInventory);
//         _inventoryInstance = FindFirstObjectByType(inventoryType);
//
//         if (_inventoryInstance == null)
//         {
//             Debug.LogError("BasicInventory instance not found.");
//             enabled = false;
//             return;
//         }
//
//         _itemsField = inventoryType.GetField("items", BindingFlags.NonPublic | BindingFlags.Instance);
//         if (_itemsField == null)
//         {
//             Debug.LogError("Private field 'items' not found in BasicInventory.");
//             enabled = false;
//             return;
//         }
//     }
//
//     private void Update()
//     {
//         if (_inventoryInstance == null || _itemsField == null) return;
//
//         var currentEnumerable = _itemsField.GetValue(_inventoryInstance) as IEnumerable;
//         if (currentEnumerable == null) return;
//
//         var currentItems = currentEnumerable.Cast<object>().ToList();
//         DetectChanges(_previousItems, currentItems);
//
//         _previousItems.Clear();
//         _previousItems.AddRange(currentItems);
//     }
//
//     private void DetectChanges(List<object> oldList, List<object> newList)
//     {
//         // Removed items
//         foreach (var removed in oldList.Except(newList))
//             RemoveItemView(removed);
//
//         // Added items
//         foreach (var added in newList.Except(oldList))
//             AddItemView(added);
//
//         // Updated items (same references)
//         foreach (var item in newList.Intersect(oldList))
//             UpdateItemView(item);
//     }
//
//     private void AddItemView(object item)
//     {
//         if (_availableSlots.Count == 0) return;
//
//         var slot = _availableSlots[0];
//         _availableSlots.RemoveAt(0);
//         slot.InitView((Item)item);
//         _activeViews[item] = slot;
//     }
//
//     private void UpdateItemView(object item)
//     {
//         if (_activeViews.TryGetValue(item, out var view))
//             view.UpdateView((Item)item);
//     }
//
//     private void RemoveItemView(object item)
//     {
//         if (!_activeViews.TryGetValue(item, out var view)) return;
//
//         view.ResetView();
//         _availableSlots.Add(view);
//         _availableSlots = _availableSlots.OrderBy(x => x.transform.position.x).ToList();
//         _activeViews.Remove(item);
//     }
}