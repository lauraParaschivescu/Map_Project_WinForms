using System.ComponentModel;
using System.Runtime.CompilerServices;
using PostsAndTasksApp.Annotations;

namespace PostsAndTasksApp
{
    public class TestVm : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;

                _name = value;
                OnPropertyChanged();
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age == value) return;

                _age = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}