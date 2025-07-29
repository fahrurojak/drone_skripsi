using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public class GenericObjectPool<T> : MonoBehaviour
    {
        public List<PooledItem> pooledItems = new List<PooledItem>();

        public virtual T GetItem()
        {
            if (pooledItems.Count > 0)
            {
                PooledItem item = pooledItems.Find(i => !i.isUsed);
                if (item != null)
                {
                    item.isUsed = true;
                    return item.Item;
                }
            }
            return CreateNewPooledItem();
        }

        private T CreateNewPooledItem()
        {
            PooledItem newItem = new PooledItem();
            newItem.Item = CreateItem();
            newItem.isUsed = true;
            pooledItems.Add(newItem);
            return newItem.Item;
        }

        protected virtual T CreateItem()
        {
            throw new NotImplementedException("CreateItem() method not implemented in derived class");
        }

        public virtual void ReturnItem(T item)
        {
            PooledItem pooledItem = pooledItems.Find(i => EqualityComparer<T>.Default.Equals(i.Item, item));
            if (pooledItem != null)
            {
                pooledItem.isUsed = false;
            }
        }

        public class PooledItem
        {
            public T Item;
            public bool isUsed;
        }
    }
}
