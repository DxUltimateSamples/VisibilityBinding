namespace VisibilityBindingDemo.Data
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class TestRecord : INotifyPropertyChanged
    {
        private string assistant;

        private bool assistantVisible;

        private string @event;

        private bool eventVisible;

        private int id;

        private string weekday;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.id == value) return;
                this.id = value;
                this.OnPropertyChanged();
            }
        }

        public string Weekday
        {
            get
            {
                return this.weekday;
            }

            set
            {
                if (this.weekday == value) return;
                this.weekday = value;
                this.OnPropertyChanged();
            }
        }

        public string Event
        {
            get
            {
                return this.@event;
            }
            set
            {
                if (this.@event == value) return;
                this.@event = value;
                this.OnPropertyChanged();
            }
        }

        public string Assistant
        {
            get
            {
                return this.assistant;
            }

            set
            {
                if (this.assistant == value) return;
                this.assistant = value;
                this.OnPropertyChanged();
            }
        }

        public bool EventVisible
        {
            get
            {
                return this.eventVisible;
            }

            set
            {
                if (this.eventVisible == value) return;
                this.eventVisible = value;
                this.OnPropertyChanged();
            }
        }

        public bool AssistantVisible
        {
            get
            {
                return this.assistantVisible;
            }

            set
            {
                if (this.assistantVisible == value) return;
                this.assistantVisible = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}