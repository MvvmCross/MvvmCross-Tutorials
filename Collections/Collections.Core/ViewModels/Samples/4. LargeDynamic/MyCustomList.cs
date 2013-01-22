using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Collections.Core.ViewModels.Samples.ListItems;

namespace Collections.Core.ViewModels.Samples.LargeDynamic
{
    public class MyCustomList : IList<Kitten>, IList, INotifyCollectionChanged
    {
        private MockDataRepository _dataRepository = new MockDataRepository();

        public int Count { get { return _dataRepository.GetCount(); } }

        public Kitten this[int index]
        {
            get { return _dataRepository.GetKitten(index); }
            set { throw new System.NotImplementedException(); }
        }

        object IList.this[int index]
        {
            get { return this[index]; }
            set { throw new NotImplementedException(); }
        }

        public void Add(Kitten item)
        {
            _dataRepository.Append(item);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, _dataRepository.GetCount() - 1));   
        }

        public void RemoveAt(int index)
        {
            var toRemove = this[index];
            _dataRepository.DeleteAt(index);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            //RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, null, toRemove, index));
        }

        public bool IsFixedSize { get { return false; } }

        private void RaiseCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            var handler = CollectionChanged;
            if (handler == null)
                return;

            handler(this, args);
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #region Not implemented

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Kitten> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Kitten item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(Kitten[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Kitten item)
        {
            throw new System.NotImplementedException();
        }

        public bool IsReadOnly { get; private set; }

        public int IndexOf(Kitten item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, Kitten item)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSynchronized { get; private set; }
        public object SyncRoot { get; private set; }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}