using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class BaseModel : INotifyPropertyChanged, IChangeTracking, IRevertibleChangeTracking
    {
        public Dictionary<string, object> OriginalValues { get; private set; } = new Dictionary<string, object>();

        public Dictionary<string, object> ModifiedValues { get; private set; } = new Dictionary<string, object>();

        public bool IsChanged { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool isRejectingChanges = false;

        public void AcceptChanges()
        {
            foreach (var value in ModifiedValues)
            {
                OriginalValues[value.Key] = value.Value;
            }

            var classProps = this.GetType()
                                 .GetProperties()
                                 .Where(x => x.PropertyType.IsClass && x.PropertyType.BaseType == typeof(BaseModel))
                                 .Select(x => x);

            foreach (var prop in classProps)
            {

                prop.PropertyType.GetMethod("AcceptChanges")?.Invoke(OriginalValues[prop.Name], null);
            }

            ModifiedValues.Clear();

            IsChanged = false;
        }

        public void RejectChanges()
        {
            isRejectingChanges = true;

            foreach (var value in OriginalValues)
            {
                var prop = this.GetType().GetProperty(value.Key);

                prop.SetValue(this, value.Value);

                if(prop.PropertyType.IsClass && prop.PropertyType.BaseType == typeof(BaseModel))
                {
                    prop.PropertyType.GetMethod("RejectChanges")?.Invoke(OriginalValues[prop.Name], null);
                }
            }

            IsChanged = false;

            isRejectingChanges = false;
        }

        public void ResetChangeTracking()
        {
            IsChanged = false;

            var classProps = this.GetType()
                                 .GetProperties()
                                 .Where(x => x.PropertyType.IsClass && x.PropertyType.BaseType == typeof(BaseModel))
                                 .Select(x => x);

            foreach (var prop in classProps)
            {

                prop.PropertyType.GetMethod("ResetChangeTracking")?.Invoke(OriginalValues[prop.Name], null);
            }
        }

        protected void OnPropertyChange(object value, [CallerMemberName] string name = null)
        {
            if (!isRejectingChanges)
            {
                if (!OriginalValues.ContainsKey(name))
                {
                    OriginalValues.Add(name, value);
                }

                if (OriginalValues[name] != value)
                {
                    ModifiedValues[name] = value;
                }

                IsChanged = true;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
