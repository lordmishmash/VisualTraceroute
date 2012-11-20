using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualTraceroute {
    /// <summary>
    /// Code taken from StackOverflow http://stackoverflow.com/a/1351877
    /// Original author: MaLio (http://stackoverflow.com/users/128334/malio)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SyncList<T> : System.ComponentModel.BindingList<T> {
        private System.ComponentModel.ISynchronizeInvoke _SyncObject;
        private System.Action<System.ComponentModel.ListChangedEventArgs> _FireEventAction;

        public SyncList()
            : base(null) {
        }

        public SyncList(System.ComponentModel.ISynchronizeInvoke syncObject) {
            _SyncObject = syncObject;
            _FireEventAction = FireEvent;
        }

        protected override void OnListChanged(System.ComponentModel.ListChangedEventArgs e) {
            if (_SyncObject == null) {
                FireEvent(e);
            } else {
                _SyncObject.Invoke(_FireEventAction, new object[] { e });
            }
        }

        private void FireEvent(System.ComponentModel.ListChangedEventArgs e) {
            base.OnListChanged(e);
        }

    }
}
