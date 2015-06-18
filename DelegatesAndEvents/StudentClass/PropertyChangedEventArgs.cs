namespace StudentClass
{
    using System;

    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propertyName, string oldValue, string newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Property changed: {0} (from {1} to {2})", 
                this.PropertyName, 
                this.OldValue, 
                this.NewValue);
        }
    }
}